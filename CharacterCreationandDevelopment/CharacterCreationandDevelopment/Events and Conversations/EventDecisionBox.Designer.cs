namespace CharacterCreationandDevelopment.Events_and_Conversations
{
    partial class EventDecisionBox
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
            this.lblDecisionInfo = new System.Windows.Forms.Label();
            this.btnChoice1 = new System.Windows.Forms.Button();
            this.btnChoice3 = new System.Windows.Forms.Button();
            this.btnChoice2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDecisionInfo
            // 
            this.lblDecisionInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDecisionInfo.Location = new System.Drawing.Point(2, -2);
            this.lblDecisionInfo.Name = "lblDecisionInfo";
            this.lblDecisionInfo.Size = new System.Drawing.Size(472, 85);
            this.lblDecisionInfo.TabIndex = 0;
            this.lblDecisionInfo.Text = "label1";
            this.lblDecisionInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChoice1
            // 
            this.btnChoice1.Location = new System.Drawing.Point(12, 86);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Size = new System.Drawing.Size(126, 59);
            this.btnChoice1.TabIndex = 1;
            this.btnChoice1.Text = "Choice 1";
            this.btnChoice1.UseVisualStyleBackColor = true;
            this.btnChoice1.Click += new System.EventHandler(this.btnChoice1_Click);
            // 
            // btnChoice3
            // 
            this.btnChoice3.Location = new System.Drawing.Point(167, 86);
            this.btnChoice3.Name = "btnChoice3";
            this.btnChoice3.Size = new System.Drawing.Size(126, 59);
            this.btnChoice3.TabIndex = 2;
            this.btnChoice3.Text = "Choice 3";
            this.btnChoice3.UseVisualStyleBackColor = true;
            this.btnChoice3.Visible = false;
            this.btnChoice3.Click += new System.EventHandler(this.btnChoice3_Click);
            // 
            // btnChoice2
            // 
            this.btnChoice2.Location = new System.Drawing.Point(332, 86);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.Size = new System.Drawing.Size(126, 59);
            this.btnChoice2.TabIndex = 3;
            this.btnChoice2.Text = "Choice 2";
            this.btnChoice2.UseVisualStyleBackColor = true;
            this.btnChoice2.Click += new System.EventHandler(this.btnChoice2_Click);
            // 
            // EventDecisionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 157);
            this.Controls.Add(this.btnChoice2);
            this.Controls.Add(this.btnChoice3);
            this.Controls.Add(this.btnChoice1);
            this.Controls.Add(this.lblDecisionInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventDecisionBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Decide...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDecisionInfo;
        private System.Windows.Forms.Button btnChoice1;
        private System.Windows.Forms.Button btnChoice3;
        private System.Windows.Forms.Button btnChoice2;
    }
}