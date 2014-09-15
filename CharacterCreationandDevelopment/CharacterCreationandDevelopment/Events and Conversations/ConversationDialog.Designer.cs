namespace CharacterCreationandDevelopment.Events_and_Conversations
{
	partial class ConversationDialog
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
			this.btnNext = new System.Windows.Forms.Button();
			this.txtConversation = new System.Windows.Forms.TextBox();
			this.pBoxCharacter = new System.Windows.Forms.PictureBox();
			this.pBoxNPC = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pBoxCharacter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxNPC)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(400, 168);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(81, 30);
			this.btnNext.TabIndex = 0;
			this.btnNext.Text = "Next...";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// txtConversation
			// 
			this.txtConversation.Enabled = false;
			this.txtConversation.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConversation.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtConversation.Location = new System.Drawing.Point(116, 12);
			this.txtConversation.Multiline = true;
			this.txtConversation.Name = "txtConversation";
			this.txtConversation.ReadOnly = true;
			this.txtConversation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtConversation.Size = new System.Drawing.Size(365, 150);
			this.txtConversation.TabIndex = 1;
			// 
			// pBoxCharacter
			// 
			this.pBoxCharacter.Location = new System.Drawing.Point(10, 12);
			this.pBoxCharacter.Name = "pBoxCharacter";
			this.pBoxCharacter.Size = new System.Drawing.Size(100, 150);
			this.pBoxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pBoxCharacter.TabIndex = 2;
			this.pBoxCharacter.TabStop = false;
			// 
			// pBoxNPC
			// 
			this.pBoxNPC.Location = new System.Drawing.Point(487, 12);
			this.pBoxNPC.Name = "pBoxNPC";
			this.pBoxNPC.Size = new System.Drawing.Size(100, 149);
			this.pBoxNPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pBoxNPC.TabIndex = 3;
			this.pBoxNPC.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(512, 167);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(81, 30);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Location = new System.Drawing.Point(116, 167);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(81, 30);
			this.btnPrevious.TabIndex = 5;
			this.btnPrevious.Text = "Previous...";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// ConversationDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(605, 209);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pBoxNPC);
			this.Controls.Add(this.pBoxCharacter);
			this.Controls.Add(this.txtConversation);
			this.Controls.Add(this.btnNext);
			this.Name = "ConversationDialog";
			this.Text = "ConversationDialog";
			((System.ComponentModel.ISupportInitialize)(this.pBoxCharacter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxNPC)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.TextBox txtConversation;
		private System.Windows.Forms.PictureBox pBoxCharacter;
		private System.Windows.Forms.PictureBox pBoxNPC;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnPrevious;
	}
}