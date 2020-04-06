namespace Game_Shooter_vol7
{
    partial class Game_Screen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelScore = new System.Windows.Forms.Label();
            this.timerSpawn = new System.Windows.Forms.Timer(this.components);
            this.Given_Commands = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(193)))), ((int)(((byte)(2)))));
            this.labelScore.Location = new System.Drawing.Point(0, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(101, 23);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Score:0";
            // 
            // timerSpawn
            // 
            this.timerSpawn.Tick += new System.EventHandler(this.timerSpawn_Tick);
            // 
            // Given_Commands
            // 
            this.Given_Commands.Location = new System.Drawing.Point(161, 60);
            this.Given_Commands.Name = "Given_Commands";
            this.Given_Commands.Size = new System.Drawing.Size(155, 22);
            this.Given_Commands.TabIndex = 1;
            this.Given_Commands.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Given_Commands_KeyDown);
            // 
            // Game_Screen
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Given_Commands);
            this.Controls.Add(this.labelScore);
            this.Name = "Game_Screen";
            this.Size = new System.Drawing.Size(1100, 800);
            this.Load += new System.EventHandler(this.Game_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timerSpawn;
        private System.Windows.Forms.TextBox Given_Commands;
    }
}
