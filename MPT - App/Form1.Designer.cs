namespace MPT___App
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
            this.Profielen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Speel = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.Spelen = new System.Windows.Forms.Button();
            this.Profiel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Profielen
            // 
            this.Profielen.Location = new System.Drawing.Point(345, 251);
            this.Profielen.Name = "Profielen";
            this.Profielen.Size = new System.Drawing.Size(167, 69);
            this.Profielen.TabIndex = 0;
            this.Profielen.Text = "Profielen";
            this.Profielen.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "FAQ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Speel
            // 
            this.Speel.Location = new System.Drawing.Point(345, 153);
            this.Speel.Name = "Speel";
            this.Speel.Size = new System.Drawing.Size(167, 69);
            this.Speel.TabIndex = 2;
            this.Speel.Text = "Speel";
            this.Speel.UseVisualStyleBackColor = true;
            this.Speel.Click += new System.EventHandler(this.button3_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(321, 48);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(219, 61);
            this.WelcomeLabel.TabIndex = 3;
            this.WelcomeLabel.Text = "Welkom!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Spelen
            // 
            this.Spelen.Location = new System.Drawing.Point(345, 153);
            this.Spelen.Name = "Spelen";
            this.Spelen.Size = new System.Drawing.Size(167, 69);
            this.Spelen.TabIndex = 2;
            this.Spelen.Text = "Speel";
            this.Spelen.UseVisualStyleBackColor = true;
            this.Spelen.Click += new System.EventHandler(this.button3_Click);
            // 
            // Profiel
            // 
            this.Profiel.Location = new System.Drawing.Point(345, 251);
            this.Profiel.Name = "Profiel";
            this.Profiel.Size = new System.Drawing.Size(167, 69);
            this.Profiel.TabIndex = 0;
            this.Profiel.Text = "Profielen";
            this.Profiel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 532);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.Speel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Profielen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Speel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Profielen;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button Profiel;
    }
}

