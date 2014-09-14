namespace CharacterCreationandDevelopment
{
    partial class SelectGame
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listOfSaves = new System.Windows.Forms.ListBox();
            this.pBoxChar = new System.Windows.Forms.PictureBox();
            this.pBarAnimalEmpathy = new System.Windows.Forms.ProgressBar();
            this.pBarAthletics = new System.Windows.Forms.ProgressBar();
            this.pBarCrafting = new System.Windows.Forms.ProgressBar();
            this.pBarDiplomacy = new System.Windows.Forms.ProgressBar();
            this.pBarFaith = new System.Windows.Forms.ProgressBar();
            this.pBarLockpicking = new System.Windows.Forms.ProgressBar();
            this.pBarMedicine = new System.Windows.Forms.ProgressBar();
            this.pBarPickPocketing = new System.Windows.Forms.ProgressBar();
            this.pBarScience = new System.Windows.Forms.ProgressBar();
            this.pBarSurvival = new System.Windows.Forms.ProgressBar();
            this.pBarSwimming = new System.Windows.Forms.ProgressBar();
            this.pBarUnarmed = new System.Windows.Forms.ProgressBar();
            this.pBarWeapons = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxChar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(188, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listOfSaves
            // 
            this.listOfSaves.FormattingEnabled = true;
            this.listOfSaves.Location = new System.Drawing.Point(118, 39);
            this.listOfSaves.Name = "listOfSaves";
            this.listOfSaves.Size = new System.Drawing.Size(235, 134);
            this.listOfSaves.TabIndex = 2;
            this.listOfSaves.SelectedValueChanged += new System.EventHandler(this.listOfSaves_SelectedValueChanged);
            // 
            // pBoxChar
            // 
            this.pBoxChar.Location = new System.Drawing.Point(12, 12);
            this.pBoxChar.Name = "pBoxChar";
            this.pBoxChar.Size = new System.Drawing.Size(100, 101);
            this.pBoxChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxChar.TabIndex = 3;
            this.pBoxChar.TabStop = false;
            // 
            // pBarAnimalEmpathy
            // 
            this.pBarAnimalEmpathy.Location = new System.Drawing.Point(12, 119);
            this.pBarAnimalEmpathy.Name = "pBarAnimalEmpathy";
            this.pBarAnimalEmpathy.Size = new System.Drawing.Size(48, 10);
            this.pBarAnimalEmpathy.TabIndex = 4;
            this.toolTip1.SetToolTip(this.pBarAnimalEmpathy, "Animal Empathy");
            // 
            // pBarAthletics
            // 
            this.pBarAthletics.Location = new System.Drawing.Point(12, 135);
            this.pBarAthletics.Name = "pBarAthletics";
            this.pBarAthletics.Size = new System.Drawing.Size(48, 10);
            this.pBarAthletics.TabIndex = 5;
            this.toolTip1.SetToolTip(this.pBarAthletics, "Athletics");
            // 
            // pBarCrafting
            // 
            this.pBarCrafting.Location = new System.Drawing.Point(12, 151);
            this.pBarCrafting.Name = "pBarCrafting";
            this.pBarCrafting.Size = new System.Drawing.Size(48, 10);
            this.pBarCrafting.TabIndex = 6;
            this.toolTip1.SetToolTip(this.pBarCrafting, "Crafting");
            // 
            // pBarDiplomacy
            // 
            this.pBarDiplomacy.Location = new System.Drawing.Point(12, 167);
            this.pBarDiplomacy.Name = "pBarDiplomacy";
            this.pBarDiplomacy.Size = new System.Drawing.Size(48, 10);
            this.pBarDiplomacy.TabIndex = 7;
            this.toolTip1.SetToolTip(this.pBarDiplomacy, "Diplomacy");
            // 
            // pBarFaith
            // 
            this.pBarFaith.Location = new System.Drawing.Point(12, 183);
            this.pBarFaith.Name = "pBarFaith";
            this.pBarFaith.Size = new System.Drawing.Size(48, 10);
            this.pBarFaith.TabIndex = 8;
            this.toolTip1.SetToolTip(this.pBarFaith, "Faith");
            // 
            // pBarLockpicking
            // 
            this.pBarLockpicking.Location = new System.Drawing.Point(12, 199);
            this.pBarLockpicking.Name = "pBarLockpicking";
            this.pBarLockpicking.Size = new System.Drawing.Size(48, 10);
            this.pBarLockpicking.TabIndex = 9;
            this.toolTip1.SetToolTip(this.pBarLockpicking, "Lockpicking");
            // 
            // pBarMedicine
            // 
            this.pBarMedicine.Location = new System.Drawing.Point(12, 215);
            this.pBarMedicine.Name = "pBarMedicine";
            this.pBarMedicine.Size = new System.Drawing.Size(48, 10);
            this.pBarMedicine.TabIndex = 10;
            this.toolTip1.SetToolTip(this.pBarMedicine, "Medicine");
            // 
            // pBarPickPocketing
            // 
            this.pBarPickPocketing.Location = new System.Drawing.Point(66, 119);
            this.pBarPickPocketing.Name = "pBarPickPocketing";
            this.pBarPickPocketing.Size = new System.Drawing.Size(48, 10);
            this.pBarPickPocketing.TabIndex = 11;
            this.toolTip1.SetToolTip(this.pBarPickPocketing, "Pickpocketing");
            // 
            // pBarScience
            // 
            this.pBarScience.Location = new System.Drawing.Point(66, 135);
            this.pBarScience.Name = "pBarScience";
            this.pBarScience.Size = new System.Drawing.Size(48, 10);
            this.pBarScience.TabIndex = 12;
            this.toolTip1.SetToolTip(this.pBarScience, "Science");
            // 
            // pBarSurvival
            // 
            this.pBarSurvival.Location = new System.Drawing.Point(66, 151);
            this.pBarSurvival.Name = "pBarSurvival";
            this.pBarSurvival.Size = new System.Drawing.Size(48, 10);
            this.pBarSurvival.TabIndex = 13;
            this.toolTip1.SetToolTip(this.pBarSurvival, "Survival");
            // 
            // pBarSwimming
            // 
            this.pBarSwimming.Location = new System.Drawing.Point(66, 167);
            this.pBarSwimming.Name = "pBarSwimming";
            this.pBarSwimming.Size = new System.Drawing.Size(48, 10);
            this.pBarSwimming.TabIndex = 14;
            this.toolTip1.SetToolTip(this.pBarSwimming, "Swimming");
            // 
            // pBarUnarmed
            // 
            this.pBarUnarmed.Location = new System.Drawing.Point(66, 183);
            this.pBarUnarmed.Name = "pBarUnarmed";
            this.pBarUnarmed.Size = new System.Drawing.Size(48, 10);
            this.pBarUnarmed.TabIndex = 15;
            this.toolTip1.SetToolTip(this.pBarUnarmed, "Unarmed");
            // 
            // pBarWeapons
            // 
            this.pBarWeapons.Location = new System.Drawing.Point(66, 199);
            this.pBarWeapons.Name = "pBarWeapons";
            this.pBarWeapons.Size = new System.Drawing.Size(48, 10);
            this.pBarWeapons.TabIndex = 16;
            this.toolTip1.SetToolTip(this.pBarWeapons, "Weapons");
            // 
            // SelectGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(395, 233);
            this.Controls.Add(this.pBarWeapons);
            this.Controls.Add(this.pBarUnarmed);
            this.Controls.Add(this.pBarSwimming);
            this.Controls.Add(this.pBarSurvival);
            this.Controls.Add(this.pBarScience);
            this.Controls.Add(this.pBarPickPocketing);
            this.Controls.Add(this.pBarMedicine);
            this.Controls.Add(this.pBarLockpicking);
            this.Controls.Add(this.pBarFaith);
            this.Controls.Add(this.pBarDiplomacy);
            this.Controls.Add(this.pBarCrafting);
            this.Controls.Add(this.pBarAthletics);
            this.Controls.Add(this.pBarAnimalEmpathy);
            this.Controls.Add(this.pBoxChar);
            this.Controls.Add(this.listOfSaves);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelectGame";
            this.Text = "Select Game";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxChar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listOfSaves;
        private System.Windows.Forms.PictureBox pBoxChar;
        private System.Windows.Forms.ProgressBar pBarAnimalEmpathy;
        private System.Windows.Forms.ProgressBar pBarAthletics;
        private System.Windows.Forms.ProgressBar pBarCrafting;
        private System.Windows.Forms.ProgressBar pBarDiplomacy;
        private System.Windows.Forms.ProgressBar pBarFaith;
        private System.Windows.Forms.ProgressBar pBarLockpicking;
        private System.Windows.Forms.ProgressBar pBarMedicine;
        private System.Windows.Forms.ProgressBar pBarPickPocketing;
        private System.Windows.Forms.ProgressBar pBarScience;
        private System.Windows.Forms.ProgressBar pBarSurvival;
        private System.Windows.Forms.ProgressBar pBarSwimming;
        private System.Windows.Forms.ProgressBar pBarUnarmed;
        private System.Windows.Forms.ProgressBar pBarWeapons;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}