namespace CharacterCreationandDevelopment
{
    partial class WorldUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldUI));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblDate = new System.Windows.Forms.Label();
			this.pBoxNPC = new System.Windows.Forms.PictureBox();
			this.txtConversation = new System.Windows.Forms.TextBox();
			this.lblSkills = new System.Windows.Forms.Label();
			this.pBoxSchool = new System.Windows.Forms.PictureBox();
			this.pBoxFarm = new System.Windows.Forms.PictureBox();
			this.pBoxChurch = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxNPC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxSchool)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxFarm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxChurch)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(17, 377);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 101);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.BackColor = System.Drawing.Color.Transparent;
			this.lblDate.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.Location = new System.Drawing.Point(12, 9);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(63, 33);
			this.lblDate.TabIndex = 3;
			this.lblDate.Text = "Date";
			// 
			// pBoxNPC
			// 
			this.pBoxNPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pBoxNPC.Location = new System.Drawing.Point(610, 377);
			this.pBoxNPC.Name = "pBoxNPC";
			this.pBoxNPC.Size = new System.Drawing.Size(100, 101);
			this.pBoxNPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pBoxNPC.TabIndex = 5;
			this.pBoxNPC.TabStop = false;
			// 
			// txtConversation
			// 
			this.txtConversation.Location = new System.Drawing.Point(133, 379);
			this.txtConversation.Multiline = true;
			this.txtConversation.Name = "txtConversation";
			this.txtConversation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtConversation.Size = new System.Drawing.Size(459, 99);
			this.txtConversation.TabIndex = 6;
			// 
			// lblSkills
			// 
			this.lblSkills.AutoSize = true;
			this.lblSkills.BackColor = System.Drawing.SystemColors.Control;
			this.lblSkills.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSkills.Location = new System.Drawing.Point(11, 194);
			this.lblSkills.Name = "lblSkills";
			this.lblSkills.Size = new System.Drawing.Size(73, 33);
			this.lblSkills.TabIndex = 10;
			this.lblSkills.Text = "Skills";
			this.lblSkills.Click += new System.EventHandler(this.lblSkills_Click);
			this.lblSkills.MouseEnter += new System.EventHandler(this.lblSkills_MouseEnter);
			this.lblSkills.MouseLeave += new System.EventHandler(this.lblSkills_MouseLeave);
			// 
			// pBoxSchool
			// 
			this.pBoxSchool.Image = ((System.Drawing.Image)(resources.GetObject("pBoxSchool.Image")));
			this.pBoxSchool.Location = new System.Drawing.Point(367, 167);
			this.pBoxSchool.Name = "pBoxSchool";
			this.pBoxSchool.Size = new System.Drawing.Size(75, 75);
			this.pBoxSchool.TabIndex = 11;
			this.pBoxSchool.TabStop = false;
			// 
			// pBoxFarm
			// 
			this.pBoxFarm.BackColor = System.Drawing.Color.Transparent;
			this.pBoxFarm.Image = ((System.Drawing.Image)(resources.GetObject("pBoxFarm.Image")));
			this.pBoxFarm.Location = new System.Drawing.Point(581, 240);
			this.pBoxFarm.Name = "pBoxFarm";
			this.pBoxFarm.Size = new System.Drawing.Size(75, 75);
			this.pBoxFarm.TabIndex = 12;
			this.pBoxFarm.TabStop = false;
			this.pBoxFarm.Click += new System.EventHandler(this.pictureBox3_Click);
			this.pBoxFarm.MouseEnter += new System.EventHandler(this.pBoxFarm_MouseEnter);
			// 
			// pBoxChurch
			// 
			this.pBoxChurch.BackColor = System.Drawing.Color.Transparent;
			this.pBoxChurch.Image = ((System.Drawing.Image)(resources.GetObject("pBoxChurch.Image")));
			this.pBoxChurch.Location = new System.Drawing.Point(193, 240);
			this.pBoxChurch.Name = "pBoxChurch";
			this.pBoxChurch.Size = new System.Drawing.Size(75, 75);
			this.pBoxChurch.TabIndex = 13;
			this.pBoxChurch.TabStop = false;
			this.pBoxChurch.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 236);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 33);
			this.label1.TabIndex = 14;
			this.label1.Text = "Journal";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 282);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 33);
			this.label2.TabIndex = 15;
			this.label2.Text = "Inventory";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 329);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 33);
			this.label3.TabIndex = 16;
			this.label3.Text = "Mood";
			// 
			// WorldUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(737, 490);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pBoxChurch);
			this.Controls.Add(this.pBoxFarm);
			this.Controls.Add(this.pBoxSchool);
			this.Controls.Add(this.lblSkills);
			this.Controls.Add(this.txtConversation);
			this.Controls.Add(this.pBoxNPC);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.pictureBox1);
			this.Name = "WorldUI";
			this.Text = "WorldUI";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorldUI_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxNPC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxSchool)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxFarm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxChurch)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pBoxNPC;
        private System.Windows.Forms.TextBox txtConversation;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.PictureBox pBoxSchool;
        private System.Windows.Forms.PictureBox pBoxFarm;
        private System.Windows.Forms.PictureBox pBoxChurch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
    }
}