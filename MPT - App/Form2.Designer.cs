namespace MPT___App
{
    partial class ProfielenForm
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
            this.SoftwareProfiel = new System.Windows.Forms.Button();
            this.TechnologyProfiel = new System.Windows.Forms.Button();
            this.BusinessProfiel = new System.Windows.Forms.Button();
            this.InfrastructureProfiel = new System.Windows.Forms.Button();
            this.MediaProfiel = new System.Windows.Forms.Button();
            this.ProfielLabel = new System.Windows.Forms.Label();
            this.Terug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoftwareProfiel
            // 
            this.SoftwareProfiel.Location = new System.Drawing.Point(25, 69);
            this.SoftwareProfiel.Name = "SoftwareProfiel";
            this.SoftwareProfiel.Size = new System.Drawing.Size(190, 52);
            this.SoftwareProfiel.TabIndex = 0;
            this.SoftwareProfiel.Text = "SoftwareProfiel";
            this.SoftwareProfiel.UseVisualStyleBackColor = true;
            this.SoftwareProfiel.Click += new System.EventHandler(this.SoftwareProfiel_Click);
            // 
            // TechnologyProfiel
            // 
            this.TechnologyProfiel.Location = new System.Drawing.Point(25, 127);
            this.TechnologyProfiel.Name = "TechnologyProfiel";
            this.TechnologyProfiel.Size = new System.Drawing.Size(190, 52);
            this.TechnologyProfiel.TabIndex = 1;
            this.TechnologyProfiel.Text = "TechnologyProfiel";
            this.TechnologyProfiel.UseVisualStyleBackColor = true;
            this.TechnologyProfiel.Click += new System.EventHandler(this.TechnologyProfiel_Click);
            // 
            // BusinessProfiel
            // 
            this.BusinessProfiel.Location = new System.Drawing.Point(25, 185);
            this.BusinessProfiel.Name = "BusinessProfiel";
            this.BusinessProfiel.Size = new System.Drawing.Size(190, 52);
            this.BusinessProfiel.TabIndex = 2;
            this.BusinessProfiel.Text = "BusinessProfiel";
            this.BusinessProfiel.UseVisualStyleBackColor = true;
            // 
            // InfrastructureProfiel
            // 
            this.InfrastructureProfiel.Location = new System.Drawing.Point(25, 243);
            this.InfrastructureProfiel.Name = "InfrastructureProfiel";
            this.InfrastructureProfiel.Size = new System.Drawing.Size(190, 52);
            this.InfrastructureProfiel.TabIndex = 3;
            this.InfrastructureProfiel.Text = "InfrastructureProfiel";
            this.InfrastructureProfiel.UseVisualStyleBackColor = true;
            // 
            // MediaProfiel
            // 
            this.MediaProfiel.Location = new System.Drawing.Point(25, 301);
            this.MediaProfiel.Name = "MediaProfiel";
            this.MediaProfiel.Size = new System.Drawing.Size(190, 52);
            this.MediaProfiel.TabIndex = 4;
            this.MediaProfiel.Text = "MediaProfiel";
            this.MediaProfiel.UseVisualStyleBackColor = true;
            // 
            // ProfielLabel
            // 
            this.ProfielLabel.AutoSize = true;
            this.ProfielLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ProfielLabel.Location = new System.Drawing.Point(278, 13);
            this.ProfielLabel.Name = "ProfielLabel";
            this.ProfielLabel.Size = new System.Drawing.Size(185, 37);
            this.ProfielLabel.TabIndex = 5;
            this.ProfielLabel.Text = "Placeholder";
            // 
            // Terug
            // 
            this.Terug.Location = new System.Drawing.Point(25, 384);
            this.Terug.Name = "Terug";
            this.Terug.Size = new System.Drawing.Size(190, 68);
            this.Terug.TabIndex = 6;
            this.Terug.Text = "Terug";
            this.Terug.UseVisualStyleBackColor = true;
            this.Terug.Click += new System.EventHandler(this.Terug_Click);
            // 
            // ProfielenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 488);
            this.Controls.Add(this.Terug);
            this.Controls.Add(this.ProfielLabel);
            this.Controls.Add(this.MediaProfiel);
            this.Controls.Add(this.InfrastructureProfiel);
            this.Controls.Add(this.BusinessProfiel);
            this.Controls.Add(this.TechnologyProfiel);
            this.Controls.Add(this.SoftwareProfiel);
            this.Name = "Profielen";
            this.Text = "Profielen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button SoftwareProfiel;
        private System.Windows.Forms.Button TechnologyProfiel;
        private System.Windows.Forms.Button BusinessProfiel;
        private System.Windows.Forms.Button InfrastructureProfiel;
        private System.Windows.Forms.Button MediaProfiel;
        private System.Windows.Forms.Label ProfielLabel;
        private System.Windows.Forms.Button Terug;
    }
}