
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.groupMisc = new System.Windows.Forms.GroupBox();
            this.checkBoxCrash = new System.Windows.Forms.CheckBox();
            this.checkBoxFPS = new System.Windows.Forms.CheckBox();
            this.buttonMin = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.groupMovement = new System.Windows.Forms.GroupBox();
            this.checkBoxNoclip = new System.Windows.Forms.CheckBox();
            this.checkBoxFly = new System.Windows.Forms.CheckBox();
            this.groupPlayer = new System.Windows.Forms.GroupBox();
            this.checkBoxReach = new System.Windows.Forms.CheckBox();
            this.timerOpac = new System.Windows.Forms.Timer(this.components);
            this.checkBoxFakelag = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupMisc.SuspendLayout();
            this.groupMovement.SuspendLayout();
            this.groupPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.groupMisc);
            this.panel1.Controls.Add(this.buttonMin);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.groupMovement);
            this.panel1.Controls.Add(this.groupPlayer);
            this.panel1.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 260);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EMouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EMouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label.Location = new System.Drawing.Point(396, 55);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(210, 12);
            this.label.TabIndex = 12;
            this.label.Text = "Early alpha build (2021- 2022)";
            // 
            // groupMisc
            // 
            this.groupMisc.Controls.Add(this.checkBoxFakelag);
            this.groupMisc.Controls.Add(this.checkBoxCrash);
            this.groupMisc.Controls.Add(this.checkBoxFPS);
            this.groupMisc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupMisc.Location = new System.Drawing.Point(398, 70);
            this.groupMisc.Name = "groupMisc";
            this.groupMisc.Size = new System.Drawing.Size(209, 185);
            this.groupMisc.TabIndex = 10;
            this.groupMisc.TabStop = false;
            this.groupMisc.Text = "Misc";
            // 
            // checkBoxCrash
            // 
            this.checkBoxCrash.AutoSize = true;
            this.checkBoxCrash.Location = new System.Drawing.Point(6, 45);
            this.checkBoxCrash.Name = "checkBoxCrash";
            this.checkBoxCrash.Size = new System.Drawing.Size(142, 16);
            this.checkBoxCrash.TabIndex = 4;
            this.checkBoxCrash.Text = "Packet spammer";
            this.checkBoxCrash.UseVisualStyleBackColor = true;
            this.checkBoxCrash.CheckedChanged += new System.EventHandler(this.checkBoxCrash_CheckedChanged);
            // 
            // checkBoxFPS
            // 
            this.checkBoxFPS.AutoSize = true;
            this.checkBoxFPS.Location = new System.Drawing.Point(6, 21);
            this.checkBoxFPS.Name = "checkBoxFPS";
            this.checkBoxFPS.Size = new System.Drawing.Size(167, 16);
            this.checkBoxFPS.TabIndex = 3;
            this.checkBoxFPS.Text = "Max fps (FPS Boost)";
            this.checkBoxFPS.UseVisualStyleBackColor = true;
            this.checkBoxFPS.CheckedChanged += new System.EventHandler(this.checkBoxFPS_CheckedChanged);
            // 
            // buttonMin
            // 
            this.buttonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Location = new System.Drawing.Point(561, 3);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(20, 21);
            this.buttonMin.TabIndex = 7;
            this.buttonMin.Text = "-";
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // exit
            // 
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(587, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 21);
            this.exit.TabIndex = 7;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // groupMovement
            // 
            this.groupMovement.Controls.Add(this.checkBoxNoclip);
            this.groupMovement.Controls.Add(this.checkBoxFly);
            this.groupMovement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupMovement.Location = new System.Drawing.Point(206, 70);
            this.groupMovement.Name = "groupMovement";
            this.groupMovement.Size = new System.Drawing.Size(186, 185);
            this.groupMovement.TabIndex = 9;
            this.groupMovement.TabStop = false;
            this.groupMovement.Text = "Movement";
            // 
            // checkBoxNoclip
            // 
            this.checkBoxNoclip.AutoSize = true;
            this.checkBoxNoclip.Location = new System.Drawing.Point(6, 45);
            this.checkBoxNoclip.Name = "checkBoxNoclip";
            this.checkBoxNoclip.Size = new System.Drawing.Size(124, 16);
            this.checkBoxNoclip.TabIndex = 1;
            this.checkBoxNoclip.Text = "No clip access";
            this.checkBoxNoclip.UseVisualStyleBackColor = true;
            this.checkBoxNoclip.CheckedChanged += new System.EventHandler(this.checkBoxNoclip_CheckedChanged);
            // 
            // checkBoxFly
            // 
            this.checkBoxFly.AutoSize = true;
            this.checkBoxFly.Location = new System.Drawing.Point(6, 21);
            this.checkBoxFly.Name = "checkBoxFly";
            this.checkBoxFly.Size = new System.Drawing.Size(98, 16);
            this.checkBoxFly.TabIndex = 0;
            this.checkBoxFly.Text = "Fly access";
            this.checkBoxFly.UseVisualStyleBackColor = true;
            this.checkBoxFly.CheckedChanged += new System.EventHandler(this.checkBoxFly_CheckedChanged);
            // 
            // groupPlayer
            // 
            this.groupPlayer.Controls.Add(this.checkBoxReach);
            this.groupPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupPlayer.Location = new System.Drawing.Point(3, 70);
            this.groupPlayer.Name = "groupPlayer";
            this.groupPlayer.Size = new System.Drawing.Size(197, 185);
            this.groupPlayer.TabIndex = 8;
            this.groupPlayer.TabStop = false;
            this.groupPlayer.Text = "Player";
            // 
            // checkBoxReach
            // 
            this.checkBoxReach.AutoSize = true;
            this.checkBoxReach.Location = new System.Drawing.Point(6, 21);
            this.checkBoxReach.Name = "checkBoxReach";
            this.checkBoxReach.Size = new System.Drawing.Size(69, 16);
            this.checkBoxReach.TabIndex = 2;
            this.checkBoxReach.Text = "Reach";
            this.checkBoxReach.UseVisualStyleBackColor = true;
            this.checkBoxReach.CheckedChanged += new System.EventHandler(this.checkBoxReach_CheckedChanged);
            // 
            // timerOpac
            // 
            this.timerOpac.Interval = 5;
            this.timerOpac.Tick += new System.EventHandler(this.timerOpac_Tick);
            // 
            // checkBoxFakelag
            // 
            this.checkBoxFakelag.AutoSize = true;
            this.checkBoxFakelag.Location = new System.Drawing.Point(6, 67);
            this.checkBoxFakelag.Name = "checkBoxFakelag";
            this.checkBoxFakelag.Size = new System.Drawing.Size(83, 16);
            this.checkBoxFakelag.TabIndex = 5;
            this.checkBoxFakelag.Text = "Fake lag";
            this.checkBoxFakelag.UseVisualStyleBackColor = true;
            this.checkBoxFakelag.CheckedChanged += new System.EventHandler(this.checkBoxFakelag_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(633, 280);
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
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupMisc.ResumeLayout(false);
            this.groupMisc.PerformLayout();
            this.groupMovement.ResumeLayout(false);
            this.groupMovement.PerformLayout();
            this.groupPlayer.ResumeLayout(false);
            this.groupPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox groupMisc;
        private System.Windows.Forms.GroupBox groupMovement;
        private System.Windows.Forms.GroupBox groupPlayer;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timerOpac;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.CheckBox checkBoxCrash;
        public System.Windows.Forms.CheckBox checkBoxFPS;
        public System.Windows.Forms.CheckBox checkBoxNoclip;
        public System.Windows.Forms.CheckBox checkBoxFly;
        public System.Windows.Forms.CheckBox checkBoxReach;
        public System.Windows.Forms.CheckBox checkBoxFakelag;
    }
}