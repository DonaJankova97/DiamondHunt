namespace proekt
{
    partial class HardLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardLevel));
            this.pinkpanther = new System.Windows.Forms.PictureBox();
            this.diamond1 = new System.Windows.Forms.PictureBox();
            this.diamond2 = new System.Windows.Forms.PictureBox();
            this.diamond3 = new System.Windows.Forms.PictureBox();
            this.spike1 = new System.Windows.Forms.PictureBox();
            this.spike2 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Diamond = new System.Windows.Forms.PictureBox();
            this.score1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.bottomwall = new System.Windows.Forms.PictureBox();
            this.middlewall = new System.Windows.Forms.PictureBox();
            this.topwall = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pinkpanther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamond1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamond2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamond3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spike1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spike2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diamond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomwall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlewall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topwall)).BeginInit();
            this.SuspendLayout();
            // 
            // pinkpanther
            // 
            this.pinkpanther.Image = ((System.Drawing.Image)(resources.GetObject("pinkpanther.Image")));
            this.pinkpanther.Location = new System.Drawing.Point(9, 248);
            this.pinkpanther.Margin = new System.Windows.Forms.Padding(2);
            this.pinkpanther.Name = "pinkpanther";
            this.pinkpanther.Size = new System.Drawing.Size(42, 35);
            this.pinkpanther.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinkpanther.TabIndex = 1;
            this.pinkpanther.TabStop = false;
            // 
            // diamond1
            // 
            this.diamond1.BackColor = System.Drawing.Color.Transparent;
            this.diamond1.Image = ((System.Drawing.Image)(resources.GetObject("diamond1.Image")));
            this.diamond1.Location = new System.Drawing.Point(382, 105);
            this.diamond1.Margin = new System.Windows.Forms.Padding(2);
            this.diamond1.Name = "diamond1";
            this.diamond1.Size = new System.Drawing.Size(32, 32);
            this.diamond1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diamond1.TabIndex = 13;
            this.diamond1.TabStop = false;
            // 
            // diamond2
            // 
            this.diamond2.BackColor = System.Drawing.Color.Transparent;
            this.diamond2.Image = ((System.Drawing.Image)(resources.GetObject("diamond2.Image")));
            this.diamond2.Location = new System.Drawing.Point(536, 368);
            this.diamond2.Margin = new System.Windows.Forms.Padding(2);
            this.diamond2.Name = "diamond2";
            this.diamond2.Size = new System.Drawing.Size(31, 32);
            this.diamond2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diamond2.TabIndex = 14;
            this.diamond2.TabStop = false;
            // 
            // diamond3
            // 
            this.diamond3.BackColor = System.Drawing.Color.Transparent;
            this.diamond3.Image = ((System.Drawing.Image)(resources.GetObject("diamond3.Image")));
            this.diamond3.Location = new System.Drawing.Point(127, 310);
            this.diamond3.Margin = new System.Windows.Forms.Padding(2);
            this.diamond3.Name = "diamond3";
            this.diamond3.Size = new System.Drawing.Size(33, 36);
            this.diamond3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diamond3.TabIndex = 15;
            this.diamond3.TabStop = false;
            // 
            // spike1
            // 
            this.spike1.Image = ((System.Drawing.Image)(resources.GetObject("spike1.Image")));
            this.spike1.Location = new System.Drawing.Point(573, 25);
            this.spike1.Margin = new System.Windows.Forms.Padding(2);
            this.spike1.Name = "spike1";
            this.spike1.Size = new System.Drawing.Size(52, 66);
            this.spike1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spike1.TabIndex = 16;
            this.spike1.TabStop = false;
            // 
            // spike2
            // 
            this.spike2.Image = ((System.Drawing.Image)(resources.GetObject("spike2.Image")));
            this.spike2.Location = new System.Drawing.Point(610, 417);
            this.spike2.Margin = new System.Windows.Forms.Padding(2);
            this.spike2.Name = "spike2";
            this.spike2.Size = new System.Drawing.Size(53, 71);
            this.spike2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spike2.TabIndex = 17;
            this.spike2.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Diamond
            // 
            this.Diamond.BackColor = System.Drawing.Color.Transparent;
            this.Diamond.Image = ((System.Drawing.Image)(resources.GetObject("Diamond.Image")));
            this.Diamond.Location = new System.Drawing.Point(350, 191);
            this.Diamond.Margin = new System.Windows.Forms.Padding(2);
            this.Diamond.Name = "Diamond";
            this.Diamond.Size = new System.Drawing.Size(65, 66);
            this.Diamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Diamond.TabIndex = 21;
            this.Diamond.TabStop = false;
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.Color.SeaGreen;
            this.score1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.score1.Location = new System.Drawing.Point(317, -1);
            this.score1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(85, 30);
            this.score1.TabIndex = 23;
            this.score1.Text = "Score";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // floor
            // 
            this.floor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.floor.Image = ((System.Drawing.Image)(resources.GetObject("floor.Image")));
            this.floor.Location = new System.Drawing.Point(0, 485);
            this.floor.Margin = new System.Windows.Forms.Padding(2);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(738, 32);
            this.floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor.TabIndex = 18;
            this.floor.TabStop = false;
            // 
            // bottomwall
            // 
            this.bottomwall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomwall.Image = ((System.Drawing.Image)(resources.GetObject("bottomwall.Image")));
            this.bottomwall.Location = new System.Drawing.Point(308, 333);
            this.bottomwall.Margin = new System.Windows.Forms.Padding(2);
            this.bottomwall.Name = "bottomwall";
            this.bottomwall.Size = new System.Drawing.Size(43, 155);
            this.bottomwall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomwall.TabIndex = 7;
            this.bottomwall.TabStop = false;
            // 
            // middlewall
            // 
            this.middlewall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middlewall.Image = ((System.Drawing.Image)(resources.GetObject("middlewall.Image")));
            this.middlewall.Location = new System.Drawing.Point(435, 156);
            this.middlewall.Margin = new System.Windows.Forms.Padding(2);
            this.middlewall.Name = "middlewall";
            this.middlewall.Size = new System.Drawing.Size(41, 153);
            this.middlewall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.middlewall.TabIndex = 12;
            this.middlewall.TabStop = false;
            // 
            // topwall
            // 
            this.topwall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topwall.Image = ((System.Drawing.Image)(resources.GetObject("topwall.Image")));
            this.topwall.Location = new System.Drawing.Point(218, 25);
            this.topwall.Margin = new System.Windows.Forms.Padding(2);
            this.topwall.Name = "topwall";
            this.topwall.Size = new System.Drawing.Size(43, 158);
            this.topwall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topwall.TabIndex = 6;
            this.topwall.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(-5, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Username";
            // 
            // HardLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(673, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Diamond);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.spike2);
            this.Controls.Add(this.spike1);
            this.Controls.Add(this.diamond3);
            this.Controls.Add(this.diamond2);
            this.Controls.Add(this.diamond1);
            this.Controls.Add(this.middlewall);
            this.Controls.Add(this.bottomwall);
            this.Controls.Add(this.topwall);
            this.Controls.Add(this.pinkpanther);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HardLevel";
            this.Text = "Diamond Hunt - Hard Level";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HardLevel_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inGameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pinkpanther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamond1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamond2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamond3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spike1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spike2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diamond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomwall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlewall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topwall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pinkpanther;
        private System.Windows.Forms.PictureBox diamond1;
        private System.Windows.Forms.PictureBox diamond2;
        private System.Windows.Forms.PictureBox diamond3;
        private System.Windows.Forms.PictureBox spike1;
        private System.Windows.Forms.PictureBox spike2;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox Diamond;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox bottomwall;
        private System.Windows.Forms.PictureBox middlewall;
        private System.Windows.Forms.PictureBox topwall;
        private System.Windows.Forms.Label label1;
    }
}