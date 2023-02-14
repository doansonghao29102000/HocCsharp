namespace BaiTap3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCloudy = new System.Windows.Forms.RadioButton();
            this.rdRainy = new System.Windows.Forms.RadioButton();
            this.rdSnowy = new System.Windows.Forms.RadioButton();
            this.rdSunny = new System.Windows.Forms.RadioButton();
            this.picSunny = new System.Windows.Forms.PictureBox();
            this.picSnowy = new System.Windows.Forms.PictureBox();
            this.picRainy = new System.Windows.Forms.PictureBox();
            this.picCloudy = new System.Windows.Forms.PictureBox();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name here";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(315, 36);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(416, 40);
            this.txtHoTen.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdSunny);
            this.groupBox1.Controls.Add(this.rdSnowy);
            this.groupBox1.Controls.Add(this.rdRainy);
            this.groupBox1.Controls.Add(this.rdCloudy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 295);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // rdCloudy
            // 
            this.rdCloudy.AutoSize = true;
            this.rdCloudy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdCloudy.Location = new System.Drawing.Point(25, 56);
            this.rdCloudy.Name = "rdCloudy";
            this.rdCloudy.Size = new System.Drawing.Size(117, 35);
            this.rdCloudy.TabIndex = 0;
            this.rdCloudy.TabStop = true;
            this.rdCloudy.Text = "&Cloudy";
            this.rdCloudy.UseVisualStyleBackColor = true;
            this.rdCloudy.CheckedChanged += new System.EventHandler(this.rdCloudy_CheckedChanged);
            // 
            // rdRainy
            // 
            this.rdRainy.AutoSize = true;
            this.rdRainy.ForeColor = System.Drawing.Color.Fuchsia;
            this.rdRainy.Location = new System.Drawing.Point(25, 107);
            this.rdRainy.Name = "rdRainy";
            this.rdRainy.Size = new System.Drawing.Size(102, 35);
            this.rdRainy.TabIndex = 1;
            this.rdRainy.TabStop = true;
            this.rdRainy.Text = "&Rainy";
            this.rdRainy.UseVisualStyleBackColor = true;
            this.rdRainy.CheckedChanged += new System.EventHandler(this.rdRainy_CheckedChanged);
            // 
            // rdSnowy
            // 
            this.rdSnowy.AutoSize = true;
            this.rdSnowy.ForeColor = System.Drawing.Color.Pink;
            this.rdSnowy.Location = new System.Drawing.Point(25, 163);
            this.rdSnowy.Name = "rdSnowy";
            this.rdSnowy.Size = new System.Drawing.Size(114, 35);
            this.rdSnowy.TabIndex = 2;
            this.rdSnowy.TabStop = true;
            this.rdSnowy.Text = "&Snowy";
            this.rdSnowy.UseVisualStyleBackColor = true;
            this.rdSnowy.CheckedChanged += new System.EventHandler(this.rdSnowy_CheckedChanged);
            // 
            // rdSunny
            // 
            this.rdSunny.AutoSize = true;
            this.rdSunny.ForeColor = System.Drawing.Color.Red;
            this.rdSunny.Location = new System.Drawing.Point(25, 215);
            this.rdSunny.Name = "rdSunny";
            this.rdSunny.Size = new System.Drawing.Size(109, 35);
            this.rdSunny.TabIndex = 3;
            this.rdSunny.TabStop = true;
            this.rdSunny.Text = "&Sunny";
            this.rdSunny.UseVisualStyleBackColor = true;
            this.rdSunny.CheckedChanged += new System.EventHandler(this.rdSunny_CheckedChanged);
            // 
            // picSunny
            // 
            this.picSunny.Image = global::BaiTap3.Properties.Resources.Sunny;
            this.picSunny.Location = new System.Drawing.Point(524, 278);
            this.picSunny.Name = "picSunny";
            this.picSunny.Size = new System.Drawing.Size(169, 132);
            this.picSunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSunny.TabIndex = 6;
            this.picSunny.TabStop = false;
            // 
            // picSnowy
            // 
            this.picSnowy.Image = global::BaiTap3.Properties.Resources.Snowy;
            this.picSnowy.Location = new System.Drawing.Point(349, 278);
            this.picSnowy.Name = "picSnowy";
            this.picSnowy.Size = new System.Drawing.Size(169, 132);
            this.picSnowy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSnowy.TabIndex = 5;
            this.picSnowy.TabStop = false;
            // 
            // picRainy
            // 
            this.picRainy.Image = global::BaiTap3.Properties.Resources.Rainy;
            this.picRainy.Location = new System.Drawing.Point(524, 135);
            this.picRainy.Name = "picRainy";
            this.picRainy.Size = new System.Drawing.Size(169, 132);
            this.picRainy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRainy.TabIndex = 4;
            this.picRainy.TabStop = false;
            // 
            // picCloudy
            // 
            this.picCloudy.Image = global::BaiTap3.Properties.Resources.loundy;
            this.picCloudy.Location = new System.Drawing.Point(349, 135);
            this.picCloudy.Name = "picCloudy";
            this.picCloudy.Size = new System.Drawing.Size(169, 132);
            this.picCloudy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCloudy.TabIndex = 3;
            this.picCloudy.TabStop = false;
            // 
            // lbDisplay
            // 
            this.lbDisplay.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.Location = new System.Drawing.Point(7, 427);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(461, 158);
            this.lbDisplay.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(524, 427);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(169, 62);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(524, 520);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 62);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 594);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.picSunny);
            this.Controls.Add(this.picSnowy);
            this.Controls.Add(this.picRainy);
            this.Controls.Add(this.picCloudy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdSunny;
        private System.Windows.Forms.RadioButton rdSnowy;
        private System.Windows.Forms.RadioButton rdRainy;
        private System.Windows.Forms.RadioButton rdCloudy;
        private System.Windows.Forms.PictureBox picCloudy;
        private System.Windows.Forms.PictureBox picRainy;
        private System.Windows.Forms.PictureBox picSunny;
        private System.Windows.Forms.PictureBox picSnowy;
        private System.Windows.Forms.Label lbDisplay;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
    }
}

