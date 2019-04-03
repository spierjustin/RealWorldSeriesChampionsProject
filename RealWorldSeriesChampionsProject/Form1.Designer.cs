namespace RealWorldSeriesChampionsProject
{
    partial class indicatorWorldSeriesChamps
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
            this.lstbxTeams = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstbxTeams
            // 
            this.lstbxTeams.FormattingEnabled = true;
            this.lstbxTeams.Location = new System.Drawing.Point(64, 12);
            this.lstbxTeams.Name = "lstbxTeams";
            this.lstbxTeams.Size = new System.Drawing.Size(247, 407);
            this.lstbxTeams.TabIndex = 0;
            // 
            // indicatorWorldSeriesChamps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 447);
            this.Controls.Add(this.lstbxTeams);
            this.Name = "indicatorWorldSeriesChamps";
            this.Text = "World Series Indicator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxTeams;
    }
}

