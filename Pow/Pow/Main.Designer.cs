
namespace Pow
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMisc = new System.Windows.Forms.Panel();
            this.checkBoxFakelag = new System.Windows.Forms.CheckBox();
            this.checkBoxFPS = new System.Windows.Forms.CheckBox();
            this.checkBoxCrash = new System.Windows.Forms.CheckBox();
            this.panelMovement = new System.Windows.Forms.Panel();
            this.checkBoxNoclip = new System.Windows.Forms.CheckBox();
            this.checkBoxFly = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.checkBoxMiniHop = new System.Windows.Forms.CheckBox();
            this.checkBoxReach = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMisc = new System.Windows.Forms.Button();
            this.buttonMovement = new System.Windows.Forms.Button();
            this.buttonPlayer = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.timerOpac = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMisc.SuspendLayout();
            this.panelMovement.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 410);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EMouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EMouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.panelMisc);
            this.panel2.Controls.Add(this.panelMovement);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.panelPlayer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonMisc);
            this.panel2.Controls.Add(this.buttonMovement);
            this.panel2.Controls.Add(this.buttonPlayer);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.buttonMin);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 402);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EMouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EMouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EMouseUp);
            // 
            // panelMisc
            // 
            this.panelMisc.Controls.Add(this.checkBoxFakelag);
            this.panelMisc.Controls.Add(this.checkBoxFPS);
            this.panelMisc.Controls.Add(this.checkBoxCrash);
            this.panelMisc.Enabled = false;
            this.panelMisc.Location = new System.Drawing.Point(169, 132);
            this.panelMisc.Name = "panelMisc";
            this.panelMisc.Size = new System.Drawing.Size(494, 267);
            this.panelMisc.TabIndex = 19;
            this.panelMisc.Visible = false;
            // 
            // checkBoxFakelag
            // 
            this.checkBoxFakelag.AutoSize = true;
            this.checkBoxFakelag.Font = new System.Drawing.Font("Minecraft", 9F);
            this.checkBoxFakelag.Location = new System.Drawing.Point(3, 61);
            this.checkBoxFakelag.Name = "checkBoxFakelag";
            this.checkBoxFakelag.Size = new System.Drawing.Size(75, 16);
            this.checkBoxFakelag.TabIndex = 5;
            this.checkBoxFakelag.Text = "Fake lag";
            this.checkBoxFakelag.UseVisualStyleBackColor = true;
            this.checkBoxFakelag.CheckedChanged += new System.EventHandler(this.checkBoxFakelag_CheckedChanged);
            // 
            // checkBoxFPS
            // 
            this.checkBoxFPS.AutoSize = true;
            this.checkBoxFPS.Font = new System.Drawing.Font("Minecraft", 9F);
            this.checkBoxFPS.Location = new System.Drawing.Point(3, 15);
            this.checkBoxFPS.Name = "checkBoxFPS";
            this.checkBoxFPS.Size = new System.Drawing.Size(148, 16);
            this.checkBoxFPS.TabIndex = 3;
            this.checkBoxFPS.Text = "Max fps (FPS Boost)";
            this.checkBoxFPS.UseVisualStyleBackColor = true;
            this.checkBoxFPS.CheckedChanged += new System.EventHandler(this.checkBoxFPS_CheckedChanged);
            // 
            // checkBoxCrash
            // 
            this.checkBoxCrash.AutoSize = true;
            this.checkBoxCrash.Font = new System.Drawing.Font("Minecraft", 9F);
            this.checkBoxCrash.Location = new System.Drawing.Point(3, 39);
            this.checkBoxCrash.Name = "checkBoxCrash";
            this.checkBoxCrash.Size = new System.Drawing.Size(128, 16);
            this.checkBoxCrash.TabIndex = 4;
            this.checkBoxCrash.Text = "Packet spammer";
            this.checkBoxCrash.UseVisualStyleBackColor = true;
            this.checkBoxCrash.CheckedChanged += new System.EventHandler(this.checkBoxCrash_CheckedChanged);
            // 
            // panelMovement
            // 
            this.panelMovement.Controls.Add(this.checkBoxNoclip);
            this.panelMovement.Controls.Add(this.checkBoxFly);
            this.panelMovement.Enabled = false;
            this.panelMovement.Location = new System.Drawing.Point(169, 132);
            this.panelMovement.Name = "panelMovement";
            this.panelMovement.Size = new System.Drawing.Size(494, 267);
            this.panelMovement.TabIndex = 18;
            this.panelMovement.Visible = false;
            // 
            // checkBoxNoclip
            // 
            this.checkBoxNoclip.AutoSize = true;
            this.checkBoxNoclip.Font = new System.Drawing.Font("Minecraft", 9F);
            this.checkBoxNoclip.Location = new System.Drawing.Point(3, 39);
            this.checkBoxNoclip.Name = "checkBoxNoclip";
            this.checkBoxNoclip.Size = new System.Drawing.Size(63, 16);
            this.checkBoxNoclip.TabIndex = 1;
            this.checkBoxNoclip.Text = "No clip";
            this.checkBoxNoclip.UseVisualStyleBackColor = true;
            this.checkBoxNoclip.CheckedChanged += new System.EventHandler(this.checkBoxNoclip_CheckedChanged);
            // 
            // checkBoxFly
            // 
            this.checkBoxFly.AutoSize = true;
            this.checkBoxFly.Font = new System.Drawing.Font("Minecraft", 9F);
            this.checkBoxFly.Location = new System.Drawing.Point(3, 15);
            this.checkBoxFly.Name = "checkBoxFly";
            this.checkBoxFly.Size = new System.Drawing.Size(41, 16);
            this.checkBoxFly.TabIndex = 0;
            this.checkBoxFly.Text = "Fly";
            this.checkBoxFly.UseVisualStyleBackColor = true;
            this.checkBoxFly.CheckedChanged += new System.EventHandler(this.checkBoxFly_CheckedChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label.Location = new System.Drawing.Point(223, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(210, 12);
            this.label.TabIndex = 17;
            this.label.Text = "Early alpha build (2021- 2022)";
            // 
            // panelPlayer
            // 
            this.panelPlayer.Controls.Add(this.checkBoxMiniHop);
            this.panelPlayer.Controls.Add(this.checkBoxReach);
            this.panelPlayer.Location = new System.Drawing.Point(169, 132);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(494, 267);
            this.panelPlayer.TabIndex = 13;
            // 
            // checkBoxMiniHop
            // 
            this.checkBoxMiniHop.AutoSize = true;
            this.checkBoxMiniHop.Font = new System.Drawing.Font("Minecraft", 9F);
            this.checkBoxMiniHop.Location = new System.Drawing.Point(3, 37);
            this.checkBoxMiniHop.Name = "checkBoxMiniHop";
            this.checkBoxMiniHop.Size = new System.Drawing.Size(63, 16);
            this.checkBoxMiniHop.TabIndex = 2;
            this.checkBoxMiniHop.Text = "Vanish";
            this.checkBoxMiniHop.UseVisualStyleBackColor = true;
            this.checkBoxMiniHop.CheckedChanged += new System.EventHandler(this.checkBoxMiniHop_CheckedChanged);
            // 
            // checkBoxReach
            // 
            this.checkBoxReach.AutoSize = true;
            this.checkBoxReach.Font = new System.Drawing.Font("Minecraft", 9F);
            this.checkBoxReach.Location = new System.Drawing.Point(3, 15);
            this.checkBoxReach.Name = "checkBoxReach";
            this.checkBoxReach.Size = new System.Drawing.Size(64, 16);
            this.checkBoxReach.TabIndex = 2;
            this.checkBoxReach.Text = "Reach";
            this.checkBoxReach.UseVisualStyleBackColor = true;
            this.checkBoxReach.CheckedChanged += new System.EventHandler(this.checkBoxReach_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraft", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(269, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "p o w";
            // 
            // buttonMisc
            // 
            this.buttonMisc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMisc.FlatAppearance.BorderSize = 0;
            this.buttonMisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMisc.Font = new System.Drawing.Font("Minecraft", 15F);
            this.buttonMisc.Location = new System.Drawing.Point(18, 277);
            this.buttonMisc.Name = "buttonMisc";
            this.buttonMisc.Size = new System.Drawing.Size(145, 41);
            this.buttonMisc.TabIndex = 9;
            this.buttonMisc.Text = "Misc";
            this.buttonMisc.UseVisualStyleBackColor = false;
            this.buttonMisc.Click += new System.EventHandler(this.buttonMisc_Click);
            // 
            // buttonMovement
            // 
            this.buttonMovement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMovement.FlatAppearance.BorderSize = 0;
            this.buttonMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovement.Font = new System.Drawing.Font("Minecraft", 15F);
            this.buttonMovement.Location = new System.Drawing.Point(18, 205);
            this.buttonMovement.Name = "buttonMovement";
            this.buttonMovement.Size = new System.Drawing.Size(145, 41);
            this.buttonMovement.TabIndex = 10;
            this.buttonMovement.Text = "Movement";
            this.buttonMovement.UseVisualStyleBackColor = false;
            this.buttonMovement.Click += new System.EventHandler(this.buttonMovement_Click);
            // 
            // buttonPlayer
            // 
            this.buttonPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlayer.FlatAppearance.BorderSize = 0;
            this.buttonPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayer.Font = new System.Drawing.Font("Minecraft", 15F);
            this.buttonPlayer.Location = new System.Drawing.Point(18, 132);
            this.buttonPlayer.Name = "buttonPlayer";
            this.buttonPlayer.Size = new System.Drawing.Size(145, 41);
            this.buttonPlayer.TabIndex = 11;
            this.buttonPlayer.Text = "Players";
            this.buttonPlayer.UseVisualStyleBackColor = false;
            this.buttonPlayer.Click += new System.EventHandler(this.buttonPlayer_Click);
            // 
            // exit
            // 
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(643, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 21);
            this.exit.TabIndex = 7;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Location = new System.Drawing.Point(617, 3);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(20, 21);
            this.buttonMin.TabIndex = 7;
            this.buttonMin.Text = "-";
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // timerOpac
            // 
            this.timerOpac.Interval = 5;
            this.timerOpac.Tick += new System.EventHandler(this.timerOpac_Tick);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(681, 417);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pow";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMisc.ResumeLayout(false);
            this.panelMisc.PerformLayout();
            this.panelMovement.ResumeLayout(false);
            this.panelMovement.PerformLayout();
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Timer timerOpac;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.CheckBox checkBoxFakelag;
        public System.Windows.Forms.CheckBox checkBoxCrash;
        public System.Windows.Forms.CheckBox checkBoxFPS;
        public System.Windows.Forms.CheckBox checkBoxNoclip;
        public System.Windows.Forms.CheckBox checkBoxFly;
        public System.Windows.Forms.CheckBox checkBoxMiniHop;
        public System.Windows.Forms.CheckBox checkBoxReach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonMisc;
        private System.Windows.Forms.Button buttonMovement;
        private System.Windows.Forms.Button buttonPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Panel panelMovement;
        private System.Windows.Forms.Panel panelMisc;
    }
}