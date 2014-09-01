namespace CharacterCreationandDevelopment.Lessons
{
	partial class LessonLearningForm
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
			this.txtReport = new System.Windows.Forms.TextBox();
			this.pBarLessonProgress = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// txtReport
			// 
			this.txtReport.Location = new System.Drawing.Point(42, 40);
			this.txtReport.Multiline = true;
			this.txtReport.Name = "txtReport";
			this.txtReport.Size = new System.Drawing.Size(501, 191);
			this.txtReport.TabIndex = 0;
			// 
			// pBarLessonProgress
			// 
			this.pBarLessonProgress.Location = new System.Drawing.Point(42, 237);
			this.pBarLessonProgress.Name = "pBarLessonProgress";
			this.pBarLessonProgress.Size = new System.Drawing.Size(501, 38);
			this.pBarLessonProgress.TabIndex = 1;
			// 
			// LessonLearningForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 319);
			this.Controls.Add(this.pBarLessonProgress);
			this.Controls.Add(this.txtReport);
			this.Name = "LessonLearningForm";
			this.Text = "Learning...";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtReport;
		private System.Windows.Forms.ProgressBar pBarLessonProgress;
	}
}