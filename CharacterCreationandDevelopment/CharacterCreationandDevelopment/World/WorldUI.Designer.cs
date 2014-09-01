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
            this.lBoxActions = new System.Windows.Forms.ListBox();
            this.pBoxLake = new System.Windows.Forms.PictureBox();
            this.lblCurrentLocation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxChurch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(22, 45);
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
            this.pBoxNPC.Location = new System.Drawing.Point(630, 45);
            this.pBoxNPC.Name = "pBoxNPC";
            this.pBoxNPC.Size = new System.Drawing.Size(100, 101);
            this.pBoxNPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxNPC.TabIndex = 5;
            this.pBoxNPC.TabStop = false;
            // 
            // txtConversation
            // 
            this.txtConversation.Location = new System.Drawing.Point(138, 47);
            this.txtConversation.Multiline = true;
            this.txtConversation.Name = "txtConversation";
            this.txtConversation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConversation.Size = new System.Drawing.Size(474, 99);
            this.txtConversation.TabIndex = 6;
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.BackColor = System.Drawing.SystemColors.Control;
            this.lblSkills.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkills.Location = new System.Drawing.Point(12, 333);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(67, 33);
            this.lblSkills.TabIndex = 10;
            this.lblSkills.Text = "Skills";
            this.lblSkills.Click += new System.EventHandler(this.lblSkills_Click);
            this.lblSkills.MouseEnter += new System.EventHandler(this.lblSkills_MouseEnter);
            this.lblSkills.MouseLeave += new System.EventHandler(this.lblSkills_MouseLeave);
            // 
            // pBoxSchool
            // 
            this.pBoxSchool.Image = ((System.Drawing.Image)(resources.GetObject("pBoxSchool.Image")));
            this.pBoxSchool.Location = new System.Drawing.Point(410, 184);
            this.pBoxSchool.Name = "pBoxSchool";
            this.pBoxSchool.Size = new System.Drawing.Size(75, 75);
            this.pBoxSchool.TabIndex = 11;
            this.pBoxSchool.TabStop = false;
            this.pBoxSchool.Click += new System.EventHandler(this.pBoxSchool_Click);
            // 
            // pBoxFarm
            // 
            this.pBoxFarm.BackColor = System.Drawing.Color.Transparent;
            this.pBoxFarm.Image = ((System.Drawing.Image)(resources.GetObject("pBoxFarm.Image")));
            this.pBoxFarm.Location = new System.Drawing.Point(279, 266);
            this.pBoxFarm.Name = "pBoxFarm";
            this.pBoxFarm.Size = new System.Drawing.Size(75, 75);
            this.pBoxFarm.TabIndex = 12;
            this.pBoxFarm.TabStop = false;
            this.pBoxFarm.Click += new System.EventHandler(this.pBoxFarm_Click);
            // 
            // pBoxChurch
            // 
            this.pBoxChurch.BackColor = System.Drawing.Color.Transparent;
            this.pBoxChurch.Image = ((System.Drawing.Image)(resources.GetObject("pBoxChurch.Image")));
            this.pBoxChurch.Location = new System.Drawing.Point(149, 194);
            this.pBoxChurch.Name = "pBoxChurch";
            this.pBoxChurch.Size = new System.Drawing.Size(75, 75);
            this.pBoxChurch.TabIndex = 13;
            this.pBoxChurch.TabStop = false;
            this.pBoxChurch.Click += new System.EventHandler(this.pBoxChurch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Journal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mood";
            // 
            // lBoxActions
            // 
            this.lBoxActions.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxActions.FormattingEnabled = true;
            this.lBoxActions.ItemHeight = 18;
            this.lBoxActions.Location = new System.Drawing.Point(564, 301);
            this.lBoxActions.Name = "lBoxActions";
            this.lBoxActions.Size = new System.Drawing.Size(166, 94);
            this.lBoxActions.TabIndex = 17;
            // 
            // pBoxLake
            // 
            this.pBoxLake.Image = ((System.Drawing.Image)(resources.GetObject("pBoxLake.Image")));
            this.pBoxLake.Location = new System.Drawing.Point(410, 358);
            this.pBoxLake.Name = "pBoxLake";
            this.pBoxLake.Size = new System.Drawing.Size(75, 75);
            this.pBoxLake.TabIndex = 18;
            this.pBoxLake.TabStop = false;
            this.pBoxLake.Click += new System.EventHandler(this.pBoxLake_Click);
            // 
            // lblCurrentLocation
            // 
            this.lblCurrentLocation.AutoSize = true;
            this.lblCurrentLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentLocation.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentLocation.Location = new System.Drawing.Point(409, 9);
            this.lblCurrentLocation.Name = "lblCurrentLocation";
            this.lblCurrentLocation.Size = new System.Drawing.Size(0, 33);
            this.lblCurrentLocation.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 33);
            this.label5.TabIndex = 19;
            this.label5.Text = "Current Location:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(213, 383);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pBoxBarracks_Click);
            // 
            // WorldUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 510);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCurrentLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pBoxLake);
            this.Controls.Add(this.lBoxActions);
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
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.ListBox lBoxActions;
        private System.Windows.Forms.PictureBox pBoxLake;
        private System.Windows.Forms.Label lblCurrentLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}