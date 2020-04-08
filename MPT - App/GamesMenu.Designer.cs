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
            this.SoftGameBtn = new System.Windows.Forms.Button();
            this.TechGameBtn = new System.Windows.Forms.Button();
            this.BusnGameBtn = new System.Windows.Forms.Button();
            this.InfraGameBtn = new System.Windows.Forms.Button();
            this.MediaGameBtn = new System.Windows.Forms.Button();
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
            // SoftGameBtn
            // 
            this.SoftGameBtn.Location = new System.Drawing.Point(341, 99);
            this.SoftGameBtn.Name = "SoftGameBtn";
            this.SoftGameBtn.Size = new System.Drawing.Size(169, 51);
            this.SoftGameBtn.TabIndex = 1;
            this.SoftGameBtn.Text = "Software";
            this.SoftGameBtn.UseVisualStyleBackColor = true;
            this.SoftGameBtn.Click += new System.EventHandler(this.SoftwareGameButton_Click);
            // 
            // TechGameBtn
            // 
            this.TechGameBtn.Location = new System.Drawing.Point(341, 156);
            this.TechGameBtn.Name = "TechGameBtn";
            this.TechGameBtn.Size = new System.Drawing.Size(169, 51);
            this.TechGameBtn.TabIndex = 2;
            this.TechGameBtn.Text = "Technology - Coming Soon!";
            this.TechGameBtn.UseVisualStyleBackColor = true;
            this.TechGameBtn.Click += new System.EventHandler(this.TechGameBtn_Click);
            // 
            // BusnGameBtn
            // 
            this.BusnGameBtn.Location = new System.Drawing.Point(341, 212);
            this.BusnGameBtn.Name = "BusnGameBtn";
            this.BusnGameBtn.Size = new System.Drawing.Size(169, 51);
            this.BusnGameBtn.TabIndex = 3;
            this.BusnGameBtn.Text = "Business - Coming Soon!";
            this.BusnGameBtn.UseVisualStyleBackColor = true;
            this.BusnGameBtn.Click += new System.EventHandler(this.BusnGameBtn_Click);
            // 
            // InfraGameBtn
            // 
            this.InfraGameBtn.Location = new System.Drawing.Point(341, 269);
            this.InfraGameBtn.Name = "InfraGameBtn";
            this.InfraGameBtn.Size = new System.Drawing.Size(169, 51);
            this.InfraGameBtn.TabIndex = 4;
            this.InfraGameBtn.Text = "Infrastructure - Coming Soon!";
            this.InfraGameBtn.UseVisualStyleBackColor = true;
            // 
            // MediaGameBtn
            // 
            this.MediaGameBtn.Location = new System.Drawing.Point(341, 326);
            this.MediaGameBtn.Name = "MediaGameBtn";
            this.MediaGameBtn.Size = new System.Drawing.Size(169, 51);
            this.MediaGameBtn.TabIndex = 5;
            this.MediaGameBtn.Text = "Media - Coming Soon!";
            this.MediaGameBtn.UseVisualStyleBackColor = true;
            // 
            // GamesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.MediaGameBtn);
            this.Controls.Add(this.InfraGameBtn);
            this.Controls.Add(this.BusnGameBtn);
            this.Controls.Add(this.TechGameBtn);
            this.Controls.Add(this.SoftGameBtn);
            this.Controls.Add(this.TerugButton);
            this.Name = "GamesMenu";
            this.Text = "GamesMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TerugButton;
        private System.Windows.Forms.Button SoftGameBtn;
        private System.Windows.Forms.Button TechGameBtn;
        private System.Windows.Forms.Button BusnGameBtn;
        private System.Windows.Forms.Button InfraGameBtn;
        private System.Windows.Forms.Button MediaGameBtn;
    }
}