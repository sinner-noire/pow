using static Memory;
using static Pow.Main;

public class Spammer
{
    public static int fPosX = 0x25CDE0;
    public static int fPosY = 0x25CDE4;
    public static int fPosZ = 0x25CDE8;
    public static int fMatrixY = 0x25CDF0;
    public static int fMatrixX = 0x25CDEC;
    public static Vec3 pos;
    public static Vec2 pos2;
    public struct Vec3
    {
        public float x;
        public float y;
        public float z;
    }
    public struct Vec2
    {
        public float x;
        public float y;
    }

    public static Vec3 PlayerPos
    {
        get
        {
            Vec3 pos = new Vec3();
            pos.x = read<float>((int)ccAdd + fPosX);
            pos.y = read<float>((int)ccAdd + fPosY);
            pos.z = read<float>((int)ccAdd + fPosZ);

            return pos;
        }
    }
    public static Vec2 ViewPos
    {
        get
        {
            Vec2 pos = new Vec2();
            pos.x = read<float>((int)ccAdd + fMatrixX);
            pos.y = read<float>((int)ccAdd + fMatrixY);

            return pos;
        }
    }

    public static void SetPlayerPos(float x, float y, float z)
    {
        write<float>((int)ccAdd + fPosX, x);
        write<float>((int)ccAdd + fPosY, y);
        write<float>((int)ccAdd + fPosZ, z);
    }
    public static void SetViewPos(float x, float y)
    {
        write<float>((int)ccAdd + fMatrixX, x);
        write<float>((int)ccAdd + fMatrixY, y);
    }

    public static void svpacketspam()
    {
        SetViewPos(pos2.x++, pos.y++);
        SetViewPos(pos2.x--, pos.y--);
        SetPlayerPos(pos.x++, pos.y++, pos.z++);
        SetPlayerPos(pos.x--, pos.y--, pos.z--);
    }
}
