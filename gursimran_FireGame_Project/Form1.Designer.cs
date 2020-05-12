namespace gursimran_FireGame_Project
{
    partial class Form1
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
            this.Load_btn = new System.Windows.Forms.Button();
            this.spin_btn = new System.Windows.Forms.Button();
            this.shoot_btn = new System.Windows.Forms.Button();
            this.shoot_away_btn = new System.Windows.Forms.Button();
            this.Exit_reload = new System.Windows.Forms.Button();
            this.FireArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FireArea)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_btn
            // 
            this.Load_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Load_btn.BackgroundImage = global::gursimran_FireGame_Project.Properties.Resources.new_load_button;
            this.Load_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Load_btn.Location = new System.Drawing.Point(12, 21);
            this.Load_btn.Name = "Load_btn";
            this.Load_btn.Size = new System.Drawing.Size(177, 81);
            this.Load_btn.TabIndex = 0;
            this.Load_btn.UseVisualStyleBackColor = false;
            this.Load_btn.Click += new System.EventHandler(this.Load_btn_Click);
            // 
            // spin_btn
            // 
            this.spin_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.spin_btn.BackgroundImage = global::gursimran_FireGame_Project.Properties.Resources.new_spin;
            this.spin_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spin_btn.Location = new System.Drawing.Point(12, 108);
            this.spin_btn.Name = "spin_btn";
            this.spin_btn.Size = new System.Drawing.Size(177, 81);
            this.spin_btn.TabIndex = 1;
            this.spin_btn.UseVisualStyleBackColor = false;
            this.spin_btn.Click += new System.EventHandler(this.spin_btn_Click);
            // 
            // shoot_btn
            // 
            this.shoot_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shoot_btn.BackgroundImage = global::gursimran_FireGame_Project.Properties.Resources.new_shoot;
            this.shoot_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shoot_btn.Location = new System.Drawing.Point(12, 195);
            this.shoot_btn.Name = "shoot_btn";
            this.shoot_btn.Size = new System.Drawing.Size(177, 81);
            this.shoot_btn.TabIndex = 2;
            this.shoot_btn.UseVisualStyleBackColor = false;
            this.shoot_btn.Click += new System.EventHandler(this.shoot_btn_Click);
            // 
            // shoot_away_btn
            // 
            this.shoot_away_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shoot_away_btn.BackgroundImage = global::gursimran_FireGame_Project.Properties.Resources.new_shoot;
            this.shoot_away_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shoot_away_btn.Font = new System.Drawing.Font("Modern No. 20", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoot_away_btn.Location = new System.Drawing.Point(12, 282);
            this.shoot_away_btn.Name = "shoot_away_btn";
            this.shoot_away_btn.Size = new System.Drawing.Size(177, 81);
            this.shoot_away_btn.TabIndex = 3;
            this.shoot_away_btn.Text = "Away";
            this.shoot_away_btn.UseVisualStyleBackColor = false;
            this.shoot_away_btn.Click += new System.EventHandler(this.shoot_away_btn_Click);
            // 
            // Exit_reload
            // 
            this.Exit_reload.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit_reload.BackgroundImage = global::gursimran_FireGame_Project.Properties.Resources.new_exit;
            this.Exit_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_reload.Font = new System.Drawing.Font("Modern No. 20", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_reload.Location = new System.Drawing.Point(12, 369);
            this.Exit_reload.Name = "Exit_reload";
            this.Exit_reload.Size = new System.Drawing.Size(177, 81);
            this.Exit_reload.TabIndex = 4;
            this.Exit_reload.Text = "Away";
            this.Exit_reload.UseVisualStyleBackColor = false;
            this.Exit_reload.Click += new System.EventHandler(this.Exit_reload_Click);
            // 
            // FireArea
            // 
            this.FireArea.Location = new System.Drawing.Point(355, 51);
            this.FireArea.Name = "FireArea";
            this.FireArea.Size = new System.Drawing.Size(485, 350);
            this.FireArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireArea.TabIndex = 5;
            this.FireArea.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::gursimran_FireGame_Project.Properties.Resources.shooting_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 449);
            this.Controls.Add(this.FireArea);
            this.Controls.Add(this.Exit_reload);
            this.Controls.Add(this.shoot_away_btn);
            this.Controls.Add(this.shoot_btn);
            this.Controls.Add(this.spin_btn);
            this.Controls.Add(this.Load_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FireArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load_btn;
        private System.Windows.Forms.Button spin_btn;
        private System.Windows.Forms.Button shoot_btn;
        private System.Windows.Forms.Button shoot_away_btn;
        private System.Windows.Forms.Button Exit_reload;
        private System.Windows.Forms.PictureBox FireArea;
    }
}

