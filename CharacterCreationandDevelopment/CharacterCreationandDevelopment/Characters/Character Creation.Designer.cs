namespace CharacterCreationandDevelopment
{
    partial class Character_Creation
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
			this.numericStr = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numericDex = new System.Windows.Forms.NumericUpDown();
			this.numericCon = new System.Windows.Forms.NumericUpDown();
			this.numericInt = new System.Windows.Forms.NumericUpDown();
			this.numericWis = new System.Windows.Forms.NumericUpDown();
			this.numericCha = new System.Windows.Forms.NumericUpDown();
			this.txtName = new System.Windows.Forms.TextBox();
			this.buttonRandomName = new System.Windows.Forms.Button();
			this.txtRemainingPoints = new System.Windows.Forms.TextBox();
			this.btnCreateCharacter = new System.Windows.Forms.Button();
			this.pBoxImage = new System.Windows.Forms.PictureBox();
			this.btnPreviousPic = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.cBoxGender = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.numericStr)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericDex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericInt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericWis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCha)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).BeginInit();
			this.SuspendLayout();
			// 
			// numericStr
			// 
			this.numericStr.BackColor = System.Drawing.SystemColors.ControlText;
			this.numericStr.ForeColor = System.Drawing.SystemColors.Control;
			this.numericStr.Location = new System.Drawing.Point(95, 80);
			this.numericStr.Name = "numericStr";
			this.numericStr.Size = new System.Drawing.Size(44, 20);
			this.numericStr.TabIndex = 0;
			this.numericStr.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericStr.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ControlText;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(12, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Strength";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(11, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Dexterity";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(89, 344);
			this.panel1.TabIndex = 3;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.SystemColors.ControlText;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.ForeColor = System.Drawing.SystemColors.Control;
			this.label9.Location = new System.Drawing.Point(11, 53);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 15);
			this.label9.TabIndex = 9;
			this.label9.Text = "Gender";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.ForeColor = System.Drawing.SystemColors.Control;
			this.label8.Location = new System.Drawing.Point(13, 278);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 43);
			this.label8.TabIndex = 8;
			this.label8.Text = "Remaining Points";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.ControlText;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.ForeColor = System.Drawing.SystemColors.Control;
			this.label7.Location = new System.Drawing.Point(12, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 15);
			this.label7.TabIndex = 7;
			this.label7.Text = "Name";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.ForeColor = System.Drawing.SystemColors.Control;
			this.label6.Location = new System.Drawing.Point(12, 237);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 15);
			this.label6.TabIndex = 6;
			this.label6.Text = "Charisma";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.ForeColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(12, 205);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 15);
			this.label5.TabIndex = 5;
			this.label5.Text = "Wisdom";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(12, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Intelligence";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(11, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Constitution";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericDex
			// 
			this.numericDex.BackColor = System.Drawing.SystemColors.ControlText;
			this.numericDex.ForeColor = System.Drawing.SystemColors.Control;
			this.numericDex.Location = new System.Drawing.Point(95, 110);
			this.numericDex.Name = "numericDex";
			this.numericDex.Size = new System.Drawing.Size(44, 20);
			this.numericDex.TabIndex = 4;
			this.numericDex.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericDex.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
			// 
			// numericCon
			// 
			this.numericCon.BackColor = System.Drawing.SystemColors.ControlText;
			this.numericCon.ForeColor = System.Drawing.SystemColors.Control;
			this.numericCon.Location = new System.Drawing.Point(95, 141);
			this.numericCon.Name = "numericCon";
			this.numericCon.Size = new System.Drawing.Size(44, 20);
			this.numericCon.TabIndex = 5;
			this.numericCon.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericCon.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
			// 
			// numericInt
			// 
			this.numericInt.BackColor = System.Drawing.SystemColors.ControlText;
			this.numericInt.ForeColor = System.Drawing.SystemColors.Control;
			this.numericInt.Location = new System.Drawing.Point(95, 174);
			this.numericInt.Name = "numericInt";
			this.numericInt.Size = new System.Drawing.Size(44, 20);
			this.numericInt.TabIndex = 6;
			this.numericInt.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericInt.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
			// 
			// numericWis
			// 
			this.numericWis.BackColor = System.Drawing.SystemColors.ControlText;
			this.numericWis.ForeColor = System.Drawing.SystemColors.Control;
			this.numericWis.Location = new System.Drawing.Point(95, 205);
			this.numericWis.Name = "numericWis";
			this.numericWis.Size = new System.Drawing.Size(44, 20);
			this.numericWis.TabIndex = 7;
			this.numericWis.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericWis.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
			// 
			// numericCha
			// 
			this.numericCha.BackColor = System.Drawing.SystemColors.ControlText;
			this.numericCha.ForeColor = System.Drawing.SystemColors.Control;
			this.numericCha.Location = new System.Drawing.Point(95, 237);
			this.numericCha.Name = "numericCha";
			this.numericCha.ReadOnly = true;
			this.numericCha.Size = new System.Drawing.Size(44, 20);
			this.numericCha.TabIndex = 8;
			this.numericCha.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericCha.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(95, 18);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(173, 20);
			this.txtName.TabIndex = 9;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// buttonRandomName
			// 
			this.buttonRandomName.Location = new System.Drawing.Point(274, 16);
			this.buttonRandomName.Name = "buttonRandomName";
			this.buttonRandomName.Size = new System.Drawing.Size(61, 23);
			this.buttonRandomName.TabIndex = 10;
			this.buttonRandomName.Text = "Random";
			this.buttonRandomName.UseVisualStyleBackColor = true;
			this.buttonRandomName.Click += new System.EventHandler(this.buttonRandomName_Click);
			// 
			// txtRemainingPoints
			// 
			this.txtRemainingPoints.BackColor = System.Drawing.SystemColors.ControlText;
			this.txtRemainingPoints.ForeColor = System.Drawing.SystemColors.Control;
			this.txtRemainingPoints.Location = new System.Drawing.Point(95, 279);
			this.txtRemainingPoints.Name = "txtRemainingPoints";
			this.txtRemainingPoints.ReadOnly = true;
			this.txtRemainingPoints.Size = new System.Drawing.Size(44, 20);
			this.txtRemainingPoints.TabIndex = 11;
			this.txtRemainingPoints.TextChanged += new System.EventHandler(this.txtRemainingPoints_TextChanged);
			// 
			// btnCreateCharacter
			// 
			this.btnCreateCharacter.Location = new System.Drawing.Point(260, 256);
			this.btnCreateCharacter.Name = "btnCreateCharacter";
			this.btnCreateCharacter.Size = new System.Drawing.Size(75, 40);
			this.btnCreateCharacter.TabIndex = 12;
			this.btnCreateCharacter.Text = "Create Character";
			this.btnCreateCharacter.UseVisualStyleBackColor = true;
			this.btnCreateCharacter.Click += new System.EventHandler(this.btnCreateCharacter_Click);
			// 
			// pBoxImage
			// 
			this.pBoxImage.Location = new System.Drawing.Point(176, 53);
			this.pBoxImage.Name = "pBoxImage";
			this.pBoxImage.Size = new System.Drawing.Size(135, 140);
			this.pBoxImage.TabIndex = 13;
			this.pBoxImage.TabStop = false;
			// 
			// btnPreviousPic
			// 
			this.btnPreviousPic.Location = new System.Drawing.Point(176, 206);
			this.btnPreviousPic.Name = "btnPreviousPic";
			this.btnPreviousPic.Size = new System.Drawing.Size(56, 23);
			this.btnPreviousPic.TabIndex = 14;
			this.btnPreviousPic.Text = "<<";
			this.btnPreviousPic.UseVisualStyleBackColor = true;
			this.btnPreviousPic.Click += new System.EventHandler(this.btnPreviousPic_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(255, 206);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(56, 23);
			this.btnNext.TabIndex = 15;
			this.btnNext.Text = ">>";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(95, 305);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(44, 23);
			this.btnReset.TabIndex = 16;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// cBoxGender
			// 
			this.cBoxGender.BackColor = System.Drawing.SystemColors.ControlText;
			this.cBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBoxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cBoxGender.ForeColor = System.Drawing.SystemColors.Control;
			this.cBoxGender.FormattingEnabled = true;
			this.cBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.cBoxGender.Location = new System.Drawing.Point(95, 51);
			this.cBoxGender.Name = "cBoxGender";
			this.cBoxGender.Size = new System.Drawing.Size(75, 21);
			this.cBoxGender.TabIndex = 17;
			this.cBoxGender.SelectedValueChanged += new System.EventHandler(this.cBoxGender_SelectedValueChanged);
			// 
			// Character_Creation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlText;
			this.ClientSize = new System.Drawing.Size(347, 344);
			this.Controls.Add(this.cBoxGender);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPreviousPic);
			this.Controls.Add(this.pBoxImage);
			this.Controls.Add(this.btnCreateCharacter);
			this.Controls.Add(this.txtRemainingPoints);
			this.Controls.Add(this.buttonRandomName);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.numericCha);
			this.Controls.Add(this.numericWis);
			this.Controls.Add(this.numericInt);
			this.Controls.Add(this.numericCon);
			this.Controls.Add(this.numericDex);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.numericStr);
			this.Name = "Character_Creation";
			this.Text = "Create a Character";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Character_Creation_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.numericStr)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericDex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericInt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericWis)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCha)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericStr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericDex;
        private System.Windows.Forms.NumericUpDown numericCon;
        private System.Windows.Forms.NumericUpDown numericInt;
        private System.Windows.Forms.NumericUpDown numericWis;
        private System.Windows.Forms.NumericUpDown numericCha;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button buttonRandomName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRemainingPoints;
        private System.Windows.Forms.Button btnCreateCharacter;
        private System.Windows.Forms.PictureBox pBoxImage;
        private System.Windows.Forms.Button btnPreviousPic;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBoxGender;
    }
}