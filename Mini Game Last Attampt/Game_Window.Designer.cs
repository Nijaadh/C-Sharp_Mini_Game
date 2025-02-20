﻿namespace Mini_Game_Last_Attampt
{
    partial class Game_Window
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMissed = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn_go_menu = new System.Windows.Forms.PictureBox();
            this.btn_pause = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rabit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_go_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblScore.Location = new System.Drawing.Point(12, 11);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(97, 24);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score    :   ";
            // 
            // lblMissed
            // 
            this.lblMissed.AutoSize = true;
            this.lblMissed.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMissed.Location = new System.Drawing.Point(12, 49);
            this.lblMissed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(99, 24);
            this.lblMissed.TabIndex = 1;
            this.lblMissed.Text = "Missed  :   ";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.Main_Game_Timer);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTimer.Location = new System.Drawing.Point(460, 11);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(90, 24);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "Timer  :   ";
            // 
            // btn_go_menu
            // 
            this.btn_go_menu.Image = global::Mini_Game_Last_Attampt.Properties.Resources.back_button;
            this.btn_go_menu.Location = new System.Drawing.Point(925, 2);
            this.btn_go_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_go_menu.Name = "btn_go_menu";
            this.btn_go_menu.Size = new System.Drawing.Size(73, 57);
            this.btn_go_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_go_menu.TabIndex = 3;
            this.btn_go_menu.TabStop = false;
            this.btn_go_menu.Click += new System.EventHandler(this.btn_go_menu_Click);
            this.btn_go_menu.MouseLeave += new System.EventHandler(this.btn_go_menu_MouseLeave);
            this.btn_go_menu.MouseHover += new System.EventHandler(this.btn_go_menu_MouseHover);
            // 
            // btn_pause
            // 
            this.btn_pause.Image = global::Mini_Game_Last_Attampt.Properties.Resources.paus_button;
            this.btn_pause.Location = new System.Drawing.Point(855, -7);
            this.btn_pause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(77, 74);
            this.btn_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_pause.TabIndex = 3;
            this.btn_pause.TabStop = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Mini_Game_Last_Attampt.Properties.Resources.fridge_beetroot;
            this.pictureBox2.Location = new System.Drawing.Point(16, 106);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "veg";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Mini_Game_Last_Attampt.Properties.Resources.fridge_broccoli;
            this.pictureBox3.Location = new System.Drawing.Point(885, 106);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "veg";
            // 
            // rabit
            // 
            this.rabit.BackColor = System.Drawing.Color.Transparent;
            this.rabit.Image = global::Mini_Game_Last_Attampt.Properties.Resources.rabit_normal;
            this.rabit.Location = new System.Drawing.Point(783, 678);
            this.rabit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rabit.Name = "rabit";
            this.rabit.Size = new System.Drawing.Size(176, 178);
            this.rabit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rabit.TabIndex = 0;
            this.rabit.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Mini_Game_Last_Attampt.Properties.Resources.fridge_carrot;
            this.pictureBox1.Location = new System.Drawing.Point(451, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "veg";
            // 
            // Game_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(999, 852);
            this.Controls.Add(this.btn_go_menu);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblMissed);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.rabit);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Game_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Window";
            this.Load += new System.EventHandler(this.Game_Window_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Is_Down);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Is_Space);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Is_Up);
            ((System.ComponentModel.ISupportInitialize)(this.btn_go_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMissed;
        private System.Windows.Forms.PictureBox rabit;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox btn_pause;
        private System.Windows.Forms.PictureBox btn_go_menu;
        public System.Windows.Forms.Timer GameTimer;
    }
}