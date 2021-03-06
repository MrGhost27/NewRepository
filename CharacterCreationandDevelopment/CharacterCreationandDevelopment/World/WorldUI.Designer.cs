﻿namespace CharacterCreationandDevelopment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldUI));
            this.pBoxPortrait = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.pBoxNPC = new System.Windows.Forms.PictureBox();
            this.txtConversation = new System.Windows.Forms.TextBox();
            this.lblSkills = new System.Windows.Forms.Label();
            this.pBoxSchool = new System.Windows.Forms.PictureBox();
            this.pBoxFarm = new System.Windows.Forms.PictureBox();
            this.pBoxChurch = new System.Windows.Forms.PictureBox();
            this.lblJournal = new System.Windows.Forms.Label();
            this.lblRelationships = new System.Windows.Forms.Label();
            this.lblMood = new System.Windows.Forms.Label();
            this.lBoxActions = new System.Windows.Forms.ListBox();
            this.pBoxLake = new System.Windows.Forms.PictureBox();
            this.lblCurrentLocation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pBoxMarket = new System.Windows.Forms.PictureBox();
            this.pBoxBlacksmith = new System.Windows.Forms.PictureBox();
            this.btnTakeAction = new System.Windows.Forms.Button();
            this.pBoxMood = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pBoxForestPath = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPortrait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxChurch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMarket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBlacksmith)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMood)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxForestPath)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxPortrait
            // 
            this.pBoxPortrait.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxPortrait.Location = new System.Drawing.Point(18, 66);
            this.pBoxPortrait.Name = "pBoxPortrait";
            this.pBoxPortrait.Size = new System.Drawing.Size(100, 101);
            this.pBoxPortrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxPortrait.TabIndex = 2;
            this.pBoxPortrait.TabStop = false;
            this.pBoxPortrait.Click += new System.EventHandler(this.pBoxPortrait_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 33);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // pBoxNPC
            // 
            this.pBoxNPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxNPC.Location = new System.Drawing.Point(625, 64);
            this.pBoxNPC.Name = "pBoxNPC";
            this.pBoxNPC.Size = new System.Drawing.Size(100, 101);
            this.pBoxNPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxNPC.TabIndex = 5;
            this.pBoxNPC.TabStop = false;
            this.pBoxNPC.Visible = false;
            // 
            // txtConversation
            // 
            this.txtConversation.Location = new System.Drawing.Point(134, 66);
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
            this.lblSkills.Location = new System.Drawing.Point(12, 369);
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
            this.pBoxSchool.Location = new System.Drawing.Point(495, 445);
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
            this.pBoxFarm.Location = new System.Drawing.Point(348, 171);
            this.pBoxFarm.Name = "pBoxFarm";
            this.pBoxFarm.Size = new System.Drawing.Size(75, 75);
            this.pBoxFarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxFarm.TabIndex = 12;
            this.pBoxFarm.TabStop = false;
            this.pBoxFarm.Click += new System.EventHandler(this.pBoxFarm_Click);
            // 
            // pBoxChurch
            // 
            this.pBoxChurch.BackColor = System.Drawing.Color.Transparent;
            this.pBoxChurch.Image = ((System.Drawing.Image)(resources.GetObject("pBoxChurch.Image")));
            this.pBoxChurch.Location = new System.Drawing.Point(169, 197);
            this.pBoxChurch.Name = "pBoxChurch";
            this.pBoxChurch.Size = new System.Drawing.Size(75, 75);
            this.pBoxChurch.TabIndex = 13;
            this.pBoxChurch.TabStop = false;
            this.pBoxChurch.Click += new System.EventHandler(this.pBoxChurch_Click);
            // 
            // lblJournal
            // 
            this.lblJournal.AutoSize = true;
            this.lblJournal.BackColor = System.Drawing.SystemColors.Control;
            this.lblJournal.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJournal.Location = new System.Drawing.Point(12, 411);
            this.lblJournal.Name = "lblJournal";
            this.lblJournal.Size = new System.Drawing.Size(86, 33);
            this.lblJournal.TabIndex = 14;
            this.lblJournal.Text = "Journal";
            this.lblJournal.Click += new System.EventHandler(this.lblJournal_Click);
            this.lblJournal.MouseEnter += new System.EventHandler(this.lblJournal_MouseEnter);
            this.lblJournal.MouseLeave += new System.EventHandler(this.lblJournal_MouseLeave);
            // 
            // lblRelationships
            // 
            this.lblRelationships.AutoSize = true;
            this.lblRelationships.BackColor = System.Drawing.SystemColors.Control;
            this.lblRelationships.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelationships.Location = new System.Drawing.Point(12, 457);
            this.lblRelationships.Name = "lblRelationships";
            this.lblRelationships.Size = new System.Drawing.Size(145, 33);
            this.lblRelationships.TabIndex = 15;
            this.lblRelationships.Text = "Relationships";
            this.lblRelationships.Click += new System.EventHandler(this.lblRelationships_Click);
            this.lblRelationships.MouseEnter += new System.EventHandler(this.lblRelationships_MouseEnter);
            this.lblRelationships.MouseLeave += new System.EventHandler(this.lblRelationships_MouseLeave);
            // 
            // lblMood
            // 
            this.lblMood.AutoSize = true;
            this.lblMood.BackColor = System.Drawing.SystemColors.Control;
            this.lblMood.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMood.Location = new System.Drawing.Point(12, 504);
            this.lblMood.Name = "lblMood";
            this.lblMood.Size = new System.Drawing.Size(72, 33);
            this.lblMood.TabIndex = 16;
            this.lblMood.Text = "Mood";
            this.lblMood.Click += new System.EventHandler(this.lblMood_Click);
            this.lblMood.MouseEnter += new System.EventHandler(this.lblMood_MouseEnter);
            this.lblMood.MouseLeave += new System.EventHandler(this.lblMood_MouseLeave);
            // 
            // lBoxActions
            // 
            this.lBoxActions.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxActions.FormattingEnabled = true;
            this.lBoxActions.ItemHeight = 18;
            this.lBoxActions.Location = new System.Drawing.Point(275, 252);
            this.lBoxActions.Name = "lBoxActions";
            this.lBoxActions.Size = new System.Drawing.Size(218, 148);
            this.lBoxActions.TabIndex = 17;
            this.lBoxActions.SelectedValueChanged += new System.EventHandler(this.lBoxActions_SelectedValueChanged);
            // 
            // pBoxLake
            // 
            this.pBoxLake.Image = ((System.Drawing.Image)(resources.GetObject("pBoxLake.Image")));
            this.pBoxLake.Location = new System.Drawing.Point(533, 197);
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
            this.lblCurrentLocation.Location = new System.Drawing.Point(390, 30);
            this.lblCurrentLocation.Name = "lblCurrentLocation";
            this.lblCurrentLocation.Size = new System.Drawing.Size(33, 33);
            this.lblCurrentLocation.TabIndex = 20;
            this.lblCurrentLocation.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 33);
            this.label5.TabIndex = 19;
            this.label5.Text = "Current Location:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(213, 445);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pBoxBarracks_Click);
            // 
            // pBoxMarket
            // 
            this.pBoxMarket.Image = ((System.Drawing.Image)(resources.GetObject("pBoxMarket.Image")));
            this.pBoxMarket.Location = new System.Drawing.Point(591, 327);
            this.pBoxMarket.Name = "pBoxMarket";
            this.pBoxMarket.Size = new System.Drawing.Size(75, 75);
            this.pBoxMarket.TabIndex = 22;
            this.pBoxMarket.TabStop = false;
            this.pBoxMarket.Click += new System.EventHandler(this.pBoxMarket_Click);
            // 
            // pBoxBlacksmith
            // 
            this.pBoxBlacksmith.Image = ((System.Drawing.Image)(resources.GetObject("pBoxBlacksmith.Image")));
            this.pBoxBlacksmith.Location = new System.Drawing.Point(120, 314);
            this.pBoxBlacksmith.Name = "pBoxBlacksmith";
            this.pBoxBlacksmith.Size = new System.Drawing.Size(75, 75);
            this.pBoxBlacksmith.TabIndex = 23;
            this.pBoxBlacksmith.TabStop = false;
            this.pBoxBlacksmith.Click += new System.EventHandler(this.pBoxBlacksmith_Click);
            // 
            // btnTakeAction
            // 
            this.btnTakeAction.Location = new System.Drawing.Point(327, 406);
            this.btnTakeAction.Name = "btnTakeAction";
            this.btnTakeAction.Size = new System.Drawing.Size(112, 33);
            this.btnTakeAction.TabIndex = 24;
            this.btnTakeAction.Text = "Take Action";
            this.btnTakeAction.UseVisualStyleBackColor = true;
            this.btnTakeAction.Click += new System.EventHandler(this.btnTakeAction_Click);
            // 
            // pBoxMood
            // 
            this.pBoxMood.BackColor = System.Drawing.Color.Transparent;
            this.pBoxMood.Location = new System.Drawing.Point(21, 173);
            this.pBoxMood.Name = "pBoxMood";
            this.pBoxMood.Size = new System.Drawing.Size(54, 40);
            this.pBoxMood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxMood.TabIndex = 25;
            this.pBoxMood.TabStop = false;
            this.pBoxMood.MouseHover += new System.EventHandler(this.pBoxMood_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // pBoxForestPath
            // 
            this.pBoxForestPath.Image = ((System.Drawing.Image)(resources.GetObject("pBoxForestPath.Image")));
            this.pBoxForestPath.Location = new System.Drawing.Point(348, 504);
            this.pBoxForestPath.Name = "pBoxForestPath";
            this.pBoxForestPath.Size = new System.Drawing.Size(75, 75);
            this.pBoxForestPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxForestPath.TabIndex = 27;
            this.pBoxForestPath.TabStop = false;
            this.pBoxForestPath.Click += new System.EventHandler(this.pBoxForestPath_Click);
            // 
            // WorldUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 596);
            this.Controls.Add(this.pBoxForestPath);
            this.Controls.Add(this.pBoxMood);
            this.Controls.Add(this.btnTakeAction);
            this.Controls.Add(this.pBoxBlacksmith);
            this.Controls.Add(this.pBoxMarket);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCurrentLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pBoxLake);
            this.Controls.Add(this.lBoxActions);
            this.Controls.Add(this.lblMood);
            this.Controls.Add(this.lblRelationships);
            this.Controls.Add(this.lblJournal);
            this.Controls.Add(this.pBoxChurch);
            this.Controls.Add(this.pBoxFarm);
            this.Controls.Add(this.pBoxSchool);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.txtConversation);
            this.Controls.Add(this.pBoxNPC);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pBoxPortrait);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WorldUI";
            this.Text = "The World";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorldUI_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPortrait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxChurch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMarket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBlacksmith)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMood)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxForestPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxPortrait;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pBoxNPC;
        private System.Windows.Forms.TextBox txtConversation;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.PictureBox pBoxSchool;
        private System.Windows.Forms.PictureBox pBoxFarm;
        private System.Windows.Forms.PictureBox pBoxChurch;
		private System.Windows.Forms.Label lblJournal;
		private System.Windows.Forms.Label lblRelationships;
		private System.Windows.Forms.Label lblMood;
        private System.Windows.Forms.ListBox lBoxActions;
        private System.Windows.Forms.PictureBox pBoxLake;
        private System.Windows.Forms.Label lblCurrentLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pBoxMarket;
        private System.Windows.Forms.PictureBox pBoxBlacksmith;
        private System.Windows.Forms.Button btnTakeAction;
        private System.Windows.Forms.PictureBox pBoxMood;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pBoxForestPath;
    }
}