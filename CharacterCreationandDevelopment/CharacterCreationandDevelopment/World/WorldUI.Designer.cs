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
            this.btnNextTurn = new System.Windows.Forms.Button();
            this.pBoxNPC = new System.Windows.Forms.PictureBox();
            this.txtConversation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNPC)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(32, 24);
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
            this.lblDate.Location = new System.Drawing.Point(603, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label1";
            // 
            // btnNextTurn
            // 
            this.btnNextTurn.Location = new System.Drawing.Point(606, 59);
            this.btnNextTurn.Name = "btnNextTurn";
            this.btnNextTurn.Size = new System.Drawing.Size(75, 23);
            this.btnNextTurn.TabIndex = 4;
            this.btnNextTurn.Text = "button1";
            this.btnNextTurn.UseVisualStyleBackColor = true;
            this.btnNextTurn.Click += new System.EventHandler(this.btnNextTurn_Click);
            // 
            // pBoxNPC
            // 
            this.pBoxNPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxNPC.Location = new System.Drawing.Point(487, 24);
            this.pBoxNPC.Name = "pBoxNPC";
            this.pBoxNPC.Size = new System.Drawing.Size(100, 101);
            this.pBoxNPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxNPC.TabIndex = 5;
            this.pBoxNPC.TabStop = false;
            // 
            // txtConversation
            // 
            this.txtConversation.Location = new System.Drawing.Point(148, 26);
            this.txtConversation.Multiline = true;
            this.txtConversation.Name = "txtConversation";
            this.txtConversation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConversation.Size = new System.Drawing.Size(323, 99);
            this.txtConversation.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "TestSchool";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(396, 237);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Weapons";
            // 
            // WorldUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConversation);
            this.Controls.Add(this.pBoxNPC);
            this.Controls.Add(this.btnNextTurn);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WorldUI";
            this.Text = "WorldUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorldUI_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnNextTurn;
        private System.Windows.Forms.PictureBox pBoxNPC;
        private System.Windows.Forms.TextBox txtConversation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}