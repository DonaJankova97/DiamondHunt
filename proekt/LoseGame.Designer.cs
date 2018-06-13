namespace proekt
{
    partial class LoseGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoseGame));
            this.losetext1 = new System.Windows.Forms.Label();
            this.losetext2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // losetext1
            // 
            this.losetext1.AutoSize = true;
            this.losetext1.BackColor = System.Drawing.Color.Transparent;
            this.losetext1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losetext1.ForeColor = System.Drawing.Color.DarkRed;
            this.losetext1.Location = new System.Drawing.Point(177, 66);
            this.losetext1.Name = "losetext1";
            this.losetext1.Size = new System.Drawing.Size(194, 37);
            this.losetext1.TabIndex = 0;
            this.losetext1.Text = "GAME OVER!";
            // 
            // losetext2
            // 
            this.losetext2.AutoSize = true;
            this.losetext2.BackColor = System.Drawing.Color.Transparent;
            this.losetext2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losetext2.ForeColor = System.Drawing.Color.DarkRed;
            this.losetext2.Location = new System.Drawing.Point(179, 117);
            this.losetext2.Name = "losetext2";
            this.losetext2.Size = new System.Drawing.Size(69, 25);
            this.losetext2.TabIndex = 1;
            this.losetext2.Text = "Score";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(51, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Again";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(326, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(563, 374);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.losetext2);
            this.Controls.Add(this.losetext1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoseGame";
            this.Text = "Diamond Hunt ";
            this.Load += new System.EventHandler(this.LoseGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label losetext1;
        private System.Windows.Forms.Label losetext2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}