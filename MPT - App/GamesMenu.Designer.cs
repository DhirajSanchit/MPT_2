namespace MPT___App
{
    partial class GamesMenu
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
            this.TerugButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TechnologyGameButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TerugButton
            // 
            this.TerugButton.Location = new System.Drawing.Point(12, 392);
            this.TerugButton.Name = "TerugButton";
            this.TerugButton.Size = new System.Drawing.Size(110, 46);
            this.TerugButton.TabIndex = 0;
            this.TerugButton.Text = "Terug";
            this.TerugButton.UseVisualStyleBackColor = true;
            this.TerugButton.Click += new System.EventHandler(this.TerugButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Software";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TechnologyGameButton
            // 
            this.TechnologyGameButton.Location = new System.Drawing.Point(341, 156);
            this.TechnologyGameButton.Name = "TechnologyGameButton";
            this.TechnologyGameButton.Size = new System.Drawing.Size(169, 51);
            this.TechnologyGameButton.TabIndex = 2;
            this.TechnologyGameButton.Text = "Technology - Coming Soon!";
            this.TechnologyGameButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(341, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Business - Coming Soon!";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(341, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "Infrastructure - Coming Soon!";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(341, 326);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 51);
            this.button5.TabIndex = 5;
            this.button5.Text = "Media - Coming Soon!";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // GamesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TechnologyGameButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TerugButton);
            this.Name = "GamesMenu";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TerugButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TechnologyGameButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}