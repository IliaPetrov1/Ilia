namespace Game_Shooter_vol7
{
    partial class Game_Shooter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Shooter));
            this.home_Screen1 = new Game_Shooter_vol7.Home_Screen();
            this.game_Screen1 = new Game_Shooter_vol7.Game_Screen();
            this.SuspendLayout();
            // 
            // home_Screen1
            // 
            this.home_Screen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_Screen1.BackgroundImage")));
            this.home_Screen1.Location = new System.Drawing.Point(-2, -1);
            this.home_Screen1.Name = "home_Screen1";
            this.home_Screen1.Size = new System.Drawing.Size(1100, 800);
            this.home_Screen1.TabIndex = 0;
            // 
            // game_Screen1
            // 
            this.game_Screen1.AllowDrop = true;
            this.game_Screen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("game_Screen1.BackgroundImage")));
            this.game_Screen1.Location = new System.Drawing.Point(-2, -1);
            this.game_Screen1.Name = "game_Screen1";
            this.game_Screen1.Size = new System.Drawing.Size(576, 312);
            this.game_Screen1.TabIndex = 1;
            // 
            // Game_Shooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.game_Screen1);
            this.Controls.Add(this.home_Screen1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game_Shooter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game_Shooter";
            this.ResumeLayout(false);

        }

        #endregion

        private Home_Screen home_Screen1;
        private Game_Screen game_Screen1;
    }
}

