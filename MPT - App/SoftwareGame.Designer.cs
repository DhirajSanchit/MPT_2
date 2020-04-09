namespace MPT___App
{
    partial class SoftwareGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareGame));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Vraaglbl = new System.Windows.Forms.Label();
            this.HangmanImgBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HangmanImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 0;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkAntwoordEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 49);
            this.button2.TabIndex = 1;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkAntwoordEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 49);
            this.button3.TabIndex = 2;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkAntwoordEvent);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(554, 456);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 49);
            this.button4.TabIndex = 3;
            this.button4.Tag = "4";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checkAntwoordEvent);
            // 
            // Vraaglbl
            // 
            this.Vraaglbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Vraaglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vraaglbl.Location = new System.Drawing.Point(-12, 264);
            this.Vraaglbl.Name = "Vraaglbl";
            this.Vraaglbl.Size = new System.Drawing.Size(787, 94);
            this.Vraaglbl.TabIndex = 5;
            this.Vraaglbl.Text = "Vraag";
            this.Vraaglbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HangmanImgBox
            // 
            this.HangmanImgBox.Image = ((System.Drawing.Image)(resources.GetObject("HangmanImgBox.Image")));
            this.HangmanImgBox.Location = new System.Drawing.Point(156, 12);
            this.HangmanImgBox.Name = "HangmanImgBox";
            this.HangmanImgBox.Size = new System.Drawing.Size(501, 249);
            this.HangmanImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HangmanImgBox.TabIndex = 6;
            this.HangmanImgBox.TabStop = false;
            // 
            // SoftwareGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 517);
            this.Controls.Add(this.HangmanImgBox);
            this.Controls.Add(this.Vraaglbl);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SoftwareGame";
            this.Text = "Software ";
            ((System.ComponentModel.ISupportInitialize)(this.HangmanImgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Vraaglbl;
        private System.Windows.Forms.PictureBox HangmanImgBox;
    }
}