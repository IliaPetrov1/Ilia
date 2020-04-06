namespace Game_Shooter_vol7
{
    partial class Home_Screen
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonLeaderBoard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DimGray;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(193)))), ((int)(((byte)(2)))));
            this.buttonStart.Location = new System.Drawing.Point(200, 546);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(250, 80);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonLeaderBoard
            // 
            this.buttonLeaderBoard.BackColor = System.Drawing.Color.DimGray;
            this.buttonLeaderBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeaderBoard.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeaderBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(193)))), ((int)(((byte)(2)))));
            this.buttonLeaderBoard.Location = new System.Drawing.Point(650, 546);
            this.buttonLeaderBoard.Name = "buttonLeaderBoard";
            this.buttonLeaderBoard.Size = new System.Drawing.Size(250, 80);
            this.buttonLeaderBoard.TabIndex = 1;
            this.buttonLeaderBoard.Text = "Leader Board";
            this.buttonLeaderBoard.UseVisualStyleBackColor = false;
            this.buttonLeaderBoard.Click += new System.EventHandler(this.buttonLeaderBoard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(193)))), ((int)(((byte)(2)))));
            this.label1.Location = new System.Drawing.Point(54, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(928, 123);
            this.label1.TabIndex = 2;
            this.label1.Text = "SPACESHOOTER";
            // 
            // Home_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLeaderBoard);
            this.Controls.Add(this.buttonStart);
            this.Name = "Home_Screen";
            this.Size = new System.Drawing.Size(1100, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonLeaderBoard;
        private System.Windows.Forms.Label label1;
    }
}
