namespace MPT___App
{
    partial class MPT
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
            this.ProfielenButton = new System.Windows.Forms.Button();
            this.FaqButton = new System.Windows.Forms.Button();
            this.VerkenButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProfielenButton
            // 
            this.ProfielenButton.Location = new System.Drawing.Point(345, 251);
            this.ProfielenButton.Name = "ProfielenButton";
            this.ProfielenButton.Size = new System.Drawing.Size(167, 69);
            this.ProfielenButton.TabIndex = 0;
            this.ProfielenButton.Text = "Profielen";
            this.ProfielenButton.UseVisualStyleBackColor = true;
            this.ProfielenButton.Click += new System.EventHandler(this.ProfielenButton_Click);
            // 
            // FaqButton
            // 
            this.FaqButton.Location = new System.Drawing.Point(345, 354);
            this.FaqButton.Name = "FaqButton";
            this.FaqButton.Size = new System.Drawing.Size(167, 69);
            this.FaqButton.TabIndex = 1;
            this.FaqButton.Text = "FAQ";
            this.FaqButton.UseVisualStyleBackColor = true;
            this.FaqButton.Click += new System.EventHandler(this.FaqButton_Click);
            // 
            // VerkenButton
            // 
            this.VerkenButton.Location = new System.Drawing.Point(345, 153);
            this.VerkenButton.Name = "VerkenButton";
            this.VerkenButton.Size = new System.Drawing.Size(167, 69);
            this.VerkenButton.TabIndex = 2;
            this.VerkenButton.Text = "Verken";
            this.VerkenButton.UseVisualStyleBackColor = true;
            this.VerkenButton.Click += new System.EventHandler(this.VerkenButton_Click);
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
            // 
            // MPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 532);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.VerkenButton);
            this.Controls.Add(this.FaqButton);
            this.Controls.Add(this.ProfielenButton);
            this.Name = "MPT";
            this.Text = "MPT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VerkenButton;
        private System.Windows.Forms.Button FaqButton;
        private System.Windows.Forms.Button ProfielenButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button Profiel;
    }
}

