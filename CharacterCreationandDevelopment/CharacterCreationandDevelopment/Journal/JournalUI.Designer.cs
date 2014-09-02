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
			this.lblLeft = new System.Windows.Forms.Label();
			this.lblRight = new System.Windows.Forms.Label();
			this.btnPreviousPage = new System.Windows.Forms.Button();
			this.btnNextPage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblLeft
			// 
			this.lblLeft.BackColor = System.Drawing.Color.Transparent;
			this.lblLeft.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLeft.Location = new System.Drawing.Point(59, 26);
			this.lblLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLeft.MaximumSize = new System.Drawing.Size(293, 305);
			this.lblLeft.Name = "lblLeft";
			this.lblLeft.Size = new System.Drawing.Size(263, 305);
			this.lblLeft.TabIndex = 0;
			this.lblLeft.Text = "label1";
			// 
			// lblRight
			// 
			this.lblRight.BackColor = System.Drawing.Color.Transparent;
			this.lblRight.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRight.Location = new System.Drawing.Point(399, 26);
			this.lblRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRight.MaximumSize = new System.Drawing.Size(293, 305);
			this.lblRight.Name = "lblRight";
			this.lblRight.Size = new System.Drawing.Size(280, 305);
			this.lblRight.TabIndex = 1;
			this.lblRight.Text = "label1";
			// 
			// btnPreviousPage
			// 
			this.btnPreviousPage.Enabled = false;
			this.btnPreviousPage.Location = new System.Drawing.Point(12, 173);
			this.btnPreviousPage.Name = "btnPreviousPage";
			this.btnPreviousPage.Size = new System.Drawing.Size(40, 28);
			this.btnPreviousPage.TabIndex = 2;
			this.btnPreviousPage.Text = "<<";
			this.btnPreviousPage.UseVisualStyleBackColor = true;
			this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
			// 
			// btnNextPage
			// 
			this.btnNextPage.Location = new System.Drawing.Point(686, 173);
			this.btnNextPage.Name = "btnNextPage";
			this.btnNextPage.Size = new System.Drawing.Size(40, 28);
			this.btnNextPage.TabIndex = 3;
			this.btnNextPage.Text = ">>";
			this.btnNextPage.UseVisualStyleBackColor = true;
			this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
			// 
			// JournalUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(738, 389);
			this.Controls.Add(this.btnNextPage);
			this.Controls.Add(this.btnPreviousPage);
			this.Controls.Add(this.lblRight);
			this.Controls.Add(this.lblLeft);
			this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "JournalUI";
			this.Text = "Journal";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblLeft;
		private System.Windows.Forms.Label lblRight;
		private System.Windows.Forms.Button btnPreviousPage;
		private System.Windows.Forms.Button btnNextPage;
	}
}