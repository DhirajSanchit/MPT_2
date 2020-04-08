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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Vraaglbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SoftGameBtn
            // 
            this.button1.Location = new System.Drawing.Point(133, 370);
            this.button1.Name = "SoftGameBtn";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 0;
            this.button1.Tag = "1";
            this.button1.Text = "SoftGameBtn";
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
            // BusnGameBtn
            // 
            this.button3.Location = new System.Drawing.Point(133, 456);
            this.button3.Name = "BusnGameBtn";
            this.button3.Size = new System.Drawing.Size(131, 49);
            this.button3.TabIndex = 2;
            this.button3.Tag = "3";
            this.button3.Text = "BusnGameBtn";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MPT___App.Properties.Resources.software_engineer;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Vraaglbl
            // 
            this.Vraaglbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Vraaglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vraaglbl.Location = new System.Drawing.Point(12, 311);
            this.Vraaglbl.Name = "Vraaglbl";
            this.Vraaglbl.Size = new System.Drawing.Size(787, 47);
            this.Vraaglbl.TabIndex = 5;
            this.Vraaglbl.Text = "Vraag";
            this.Vraaglbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Vraaglbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // SoftwareGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 517);
            this.Controls.Add(this.Vraaglbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SoftwareGame";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Vraaglbl;
    }
}