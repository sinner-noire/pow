using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

public class Memory
{
    public static IntPtr prochandle = (IntPtr)0;
    public static IntPtr moduleaddy = (IntPtr)0;
    public static bool sethandle(string procname)
    {
        int PROCESS_VM_OPERATION = 0x0008;
        int PROCESS_VM_READ = 0x0010;
        int PROCESS_VM_WRITE = 0x0020;
        try
        {
            prochandle = Imports.OpenProcess(PROCESS_VM_OPERATION | PROCESS_VM_READ | PROCESS_VM_WRITE, false, Process.GetProcessesByName(procname)[0].Id);
            return true;
        }
        catch (Exception)
        {
            prochandle = (IntPtr)0;
            return false;
        }
    }

    public static void setmodule(string procname, string modulename, out IntPtr moduleaddy)
    {
        IntPtr moduleaddy_ = (IntPtr)0;
        Process proc = Process.GetProcessesByName(procname)[0];
        foreach (ProcessModule m in proc.Modules)
        {
            if (m.ModuleName == modulename)
            {
                moduleaddy_ = m.BaseAddress;
                break;
            }
            else
            {
                moduleaddy_ = (IntPtr)0;
            }
            moduleaddy_ = (IntPtr)0;
        }
        moduleaddy = moduleaddy_;
    }

    private static T bas<T>(byte[] bytes) where T : struct
    {
        GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);

        try
        {
            return (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
        }
        finally
        {
            handle.Free();
        }
    }

    private static byte[] sba(object obj)
    {
        int length = Marshal.SizeOf(obj);

        byte[] array = new byte[length];

        IntPtr pointer = Marshal.AllocHGlobal(length);

        Marshal.StructureToPtr(obj, pointer, true);
        Marshal.Copy(pointer, array, 0, length);
        Marshal.FreeHGlobal(pointer);

        return array;
    }

    public static T read<T>(int address) where T : struct
    {
        int dump = 0;
        int ByteSize = Marshal.SizeOf(typeof(T));

        byte[] buffer = new byte[ByteSize];

        Imports.ReadProcessMemory((int)prochandle, address, buffer, buffer.Length, ref dump);

        return bas<T>(buffer);
    }

    public static void write<T>(int address, object Value) where T : struct
    {
        byte[] buffer = sba(Value);
        int dump;

        Imports.WriteProcessMemory((int)prochandle, address, buffer, buffer.Length, out dump);
    }
    public static IntPtr FindDMAAddy(IntPtr ptr, int[] offsets)
    {
        int dump = 0;
        var buffer = new byte[IntPtr.Size];
        foreach (int i in offsets)
        {
            Imports.ReadProcessMemory((int)prochandle, (int)ptr, buffer, buffer.Length, ref dump);

            ptr = (IntPtr.Size == 4)
            ? IntPtr.Add(new IntPtr(BitConverter.ToInt32(buffer, 0)), i)
            : ptr = IntPtr.Add(new IntPtr(BitConverter.ToInt64(buffer, 0)), i);
        }
        return ptr;
    }

    private class Imports
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, out int lpNumberOfBytesWritten);

    }
}
