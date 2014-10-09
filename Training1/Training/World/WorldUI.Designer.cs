namespace Training
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnFastForward = new System.Windows.Forms.Button();
            this.lBoxUnits = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diplomatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soldiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swordsmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lBoxTargets = new System.Windows.Forms.ListBox();
            this.Targets = new System.Windows.Forms.Label();
            this.cBoxActions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblCityReport = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(6, 22);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(30, 30);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "||";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(42, 22);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(30, 30);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = ">";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnFastForward
            // 
            this.btnFastForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastForward.Location = new System.Drawing.Point(78, 22);
            this.btnFastForward.Name = "btnFastForward";
            this.btnFastForward.Size = new System.Drawing.Size(30, 30);
            this.btnFastForward.TabIndex = 4;
            this.btnFastForward.Text = ">>";
            this.btnFastForward.UseVisualStyleBackColor = true;
            this.btnFastForward.Click += new System.EventHandler(this.btnFastForward_Click);
            // 
            // lBoxUnits
            // 
            this.lBoxUnits.FormattingEnabled = true;
            this.lBoxUnits.Location = new System.Drawing.Point(15, 429);
            this.lBoxUnits.Name = "lBoxUnits";
            this.lBoxUnits.Size = new System.Drawing.Size(183, 95);
            this.lBoxUnits.TabIndex = 9;
            this.lBoxUnits.SelectedValueChanged += new System.EventHandler(this.lBoxUnits_SelectedValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.unitsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // unitsToolStripMenuItem
            // 
            this.unitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agentsToolStripMenuItem,
            this.soldiersToolStripMenuItem});
            this.unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
            this.unitsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unitsToolStripMenuItem.Text = "Units";
            // 
            // agentsToolStripMenuItem
            // 
            this.agentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diplomatToolStripMenuItem,
            this.spyToolStripMenuItem});
            this.agentsToolStripMenuItem.Name = "agentsToolStripMenuItem";
            this.agentsToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.agentsToolStripMenuItem.Text = "Agents";
            // 
            // diplomatToolStripMenuItem
            // 
            this.diplomatToolStripMenuItem.Name = "diplomatToolStripMenuItem";
            this.diplomatToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.diplomatToolStripMenuItem.Text = "Diplomat";
            this.diplomatToolStripMenuItem.Click += new System.EventHandler(this.diplomatToolStripMenuItem_Click);
            // 
            // spyToolStripMenuItem
            // 
            this.spyToolStripMenuItem.Name = "spyToolStripMenuItem";
            this.spyToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.spyToolStripMenuItem.Text = "Spy";
            this.spyToolStripMenuItem.Click += new System.EventHandler(this.spyToolStripMenuItem_Click);
            // 
            // soldiersToolStripMenuItem
            // 
            this.soldiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archerToolStripMenuItem,
            this.swordsmanToolStripMenuItem});
            this.soldiersToolStripMenuItem.Name = "soldiersToolStripMenuItem";
            this.soldiersToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.soldiersToolStripMenuItem.Text = "Soldiers";
            // 
            // archerToolStripMenuItem
            // 
            this.archerToolStripMenuItem.Name = "archerToolStripMenuItem";
            this.archerToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.archerToolStripMenuItem.Text = "Archer";
            this.archerToolStripMenuItem.Click += new System.EventHandler(this.archerToolStripMenuItem_Click);
            // 
            // swordsmanToolStripMenuItem
            // 
            this.swordsmanToolStripMenuItem.Name = "swordsmanToolStripMenuItem";
            this.swordsmanToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.swordsmanToolStripMenuItem.Text = "Swordsman";
            this.swordsmanToolStripMenuItem.Click += new System.EventHandler(this.swordsmanToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(15, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 357);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Units";
            // 
            // lBoxTargets
            // 
            this.lBoxTargets.FormattingEnabled = true;
            this.lBoxTargets.Location = new System.Drawing.Point(345, 429);
            this.lBoxTargets.Name = "lBoxTargets";
            this.lBoxTargets.Size = new System.Drawing.Size(157, 160);
            this.lBoxTargets.TabIndex = 16;
            this.lBoxTargets.Visible = false;
            // 
            // Targets
            // 
            this.Targets.AutoSize = true;
            this.Targets.Location = new System.Drawing.Point(342, 413);
            this.Targets.Name = "Targets";
            this.Targets.Size = new System.Drawing.Size(43, 13);
            this.Targets.TabIndex = 17;
            this.Targets.Text = "Targets";
            this.Targets.Visible = false;
            // 
            // cBoxActions
            // 
            this.cBoxActions.FormattingEnabled = true;
            this.cBoxActions.Location = new System.Drawing.Point(204, 429);
            this.cBoxActions.Name = "cBoxActions";
            this.cBoxActions.Size = new System.Drawing.Size(135, 21);
            this.cBoxActions.TabIndex = 18;
            this.cBoxActions.Visible = false;
            this.cBoxActions.SelectedValueChanged += new System.EventHandler(this.cBoxActions_SelectedValueChanged);
            this.cBoxActions.VisibleChanged += new System.EventHandler(this.cBoxActions_VisibleChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Actions";
            this.label3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 27);
            this.button2.TabIndex = 20;
            this.button2.Text = "Undo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 530);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 27);
            this.button3.TabIndex = 21;
            this.button3.Text = "Select";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblCityReport
            // 
            this.lblCityReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCityReport.Location = new System.Drawing.Point(513, 128);
            this.lblCityReport.Name = "lblCityReport";
            this.lblCityReport.Size = new System.Drawing.Size(126, 276);
            this.lblCityReport.TabIndex = 22;
            this.lblCityReport.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFastForward);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Location = new System.Drawing.Point(516, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 54);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // WorldUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCityReport);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxActions);
            this.Controls.Add(this.Targets);
            this.Controls.Add(this.lBoxTargets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lBoxUnits);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WorldUI";
            this.Text = "WorldUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorldUI_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnFastForward;
		private System.Windows.Forms.ListBox lBoxUnits;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diplomatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soldiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swordsmanToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lBoxTargets;
		private System.Windows.Forms.Label Targets;
		private System.Windows.Forms.ComboBox cBoxActions;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label lblCityReport;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}