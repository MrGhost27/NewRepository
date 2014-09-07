namespace CharacterCreationandDevelopment.Moods
{
    partial class MoodUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineWidth = 10;
            this.chart1.BorderSkin.BorderWidth = 10;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            customLabel1.ForeColor = System.Drawing.Color.Black;
            customLabel1.Text = "Label1";
            customLabel2.ForeColor = System.Drawing.Color.Black;
            customLabel2.RowIndex = 1;
            customLabel2.Text = "Label2";
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.CustomLabels.Add(customLabel2);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.Black;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = -100D;
            chartArea1.AxisY.ScrollBar.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Red,
        System.Drawing.Color.Green,
        System.Drawing.Color.Purple};
            this.chart1.Size = new System.Drawing.Size(438, 365);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Your Mood";
            title1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            this.chart1.Titles.Add(title1);
            // 
            // MoodUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(473, 389);
            this.Controls.Add(this.chart1);
            this.Name = "MoodUI";
            this.Text = "Mood";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}