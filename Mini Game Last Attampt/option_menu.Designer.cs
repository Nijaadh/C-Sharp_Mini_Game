namespace Mini_Game_Last_Attampt
{
    partial class option_menu
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
            this.optionMenu = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.optionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // optionMenu
            // 
            this.optionMenu.BackColor = System.Drawing.Color.Transparent;
            this.optionMenu.BackgroundImage = global::Mini_Game_Last_Attampt.Properties.Resources.ins_menu_n;
            this.optionMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionMenu.Controls.Add(this.label1);
            this.optionMenu.Controls.Add(this.btn_Exit);
            this.optionMenu.Location = new System.Drawing.Point(48, 24);
            this.optionMenu.Name = "optionMenu";
            this.optionMenu.Size = new System.Drawing.Size(287, 360);
            this.optionMenu.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = global::Mini_Game_Last_Attampt.Properties.Resources.exit_normal_n;
            this.btn_Exit.Location = new System.Drawing.Point(99, 291);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 43);
            this.btn_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.MouseLeave += new System.EventHandler(this.btn_Exit_MouseLeave);
            this.btn_Exit.MouseHover += new System.EventHandler(this.btn_Exit_MouseHover);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 178);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press the left arrow key and press the Right arrow keys to move the rabit\r\n\r\ncaut" +
    "ch the Dropping Vagetables.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.optionMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "option_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option Menu";
            this.optionMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel optionMenu;
        private System.Windows.Forms.PictureBox btn_Exit;
        private System.Windows.Forms.Label label1;
    }
}