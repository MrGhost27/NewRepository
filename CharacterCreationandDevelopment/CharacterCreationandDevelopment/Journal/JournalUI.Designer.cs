namespace CharacterCreationandDevelopment
{
	partial class JournalUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalUI));
			this.lblLeftPage = new System.Windows.Forms.Label();
			this.lblRightPage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblLeftPage
			// 
			this.lblLeftPage.AutoSize = true;
			this.lblLeftPage.BackColor = System.Drawing.Color.Transparent;
			this.lblLeftPage.Location = new System.Drawing.Point(53, 26);
			this.lblLeftPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLeftPage.MaximumSize = new System.Drawing.Size(293, 305);
			this.lblLeftPage.Name = "lblLeftPage";
			this.lblLeftPage.Size = new System.Drawing.Size(42, 18);
			this.lblLeftPage.TabIndex = 0;
			this.lblLeftPage.Text = "label1";
			// 
			// lblRightPage
			// 
			this.lblRightPage.AutoSize = true;
			this.lblRightPage.BackColor = System.Drawing.Color.Transparent;
			this.lblRightPage.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRightPage.Location = new System.Drawing.Point(317, 26);
			this.lblRightPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRightPage.MaximumSize = new System.Drawing.Size(293, 305);
			this.lblRightPage.Name = "lblRightPage";
			this.lblRightPage.Size = new System.Drawing.Size(42, 18);
			this.lblRightPage.TabIndex = 1;
			this.lblRightPage.Text = "label1";
			// 
			// JournalUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(579, 570);
			this.Controls.Add(this.lblRightPage);
			this.Controls.Add(this.lblLeftPage);
			this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "JournalUI";
			this.Text = "Journal";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblLeftPage;
		private System.Windows.Forms.Label lblRightPage;
	}
}