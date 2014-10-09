using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Training.Locations;
using Training.Units;
using Training.Units.Abilities;

namespace Training
{
	public partial class WorldUI : Form
	{
		private World world;
		private Form parentForm;
		private Label clickedLabel;
        private List<Label> labelLocationList;
		private IUnit selectedUnit;
		private bool selectedAUnit = false;
		private string selectedCity = "";
		public Renderer renderer;
		List<Rectangle> rectList = new List<Rectangle>();

		private int PanelMinX;
		private int PanelMinY;
		private int PanelMaxX;
		private int PanelMaxY;

		internal WorldUI(World world, Form parentForm)
		{
			InitializeComponent();
			PanelMinX = panel1.Location.X;
			PanelMinY = panel1.Location.Y -50;
			PanelMaxX = panel1.Size.Width - 50;
			PanelMaxY = panel1.Size.Height - 50;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.world = world;
			renderer = new Renderer(world);
			this.parentForm = parentForm;
			timer1.Enabled = true;
			btnPlay.Enabled = false;
            SetLocations();
			RefreshScreen();
		}
		#region Locations as Rectangles - Overlapping Check
		private void SetLocations()
		{
            labelLocationList = new List<Label>();
			foreach (ILocation location in world.Locations())
			{
				if (location.Type != LocationType.Road)
				{
					Label labelLocation = new Label();
					labelLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
					labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
						System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

					Rectangle newRectangle = new Rectangle();
					newRectangle.Size = new Size(125, 125);
					if (rectList.Count() > 0)
						newRectangle.Location = OverlapCheck(newRectangle);
					else
						newRectangle.Location = NewPoint();
					rectList.Add(newRectangle);

					location.Location = newRectangle.Location;
					labelLocation.Location = location.Location;
					labelLocation.Name = location.Name;
					labelLocation.Size = new Size(50, 50);
					labelLocation.Text = location.Name;
					labelLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
					panel1.Controls.Add(labelLocation);
					labelLocation.Click += new System.EventHandler(this.labelLocation_Click);
					labelLocationList.Add(labelLocation);
				}
			}
		}

		private Point NewPoint()
		{
			return new Point(Helper.Helper.GenerateRandomNumber(PanelMinX, PanelMaxX),
							Helper.Helper.GenerateRandomNumber(PanelMinY, PanelMaxY));
		}

		private Point OverlapCheck(Rectangle newRectangle)
		{
			int overlapCount = 1;
			while (overlapCount > 0)
			{
				overlapCount = 0;
				newRectangle.Location = NewPoint();

				foreach (Rectangle existingRectangle in rectList)
				{
					Rectangle intersect = Rectangle.Intersect(existingRectangle, newRectangle);
					if (intersect != Rectangle.Empty)
					{
						overlapCount++;
					}
				}
			}
			return newRectangle.Location;
		}
		#endregion

		private void timer1_Tick(object sender, EventArgs e)
		{
			world.NextDay();
			RefreshScreen();
		}

		private void RefreshScreen()
		{
			groupBox1.Text = world.Date();
			lblCityReport.Text = world.CityReport(selectedCity);
			world.Go();
			panel1.Invalidate();
		}

		#region Time Controls
		private void btnPause_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			btnPause.Enabled = false;
			btnPlay.Enabled = true;
			btnFastForward.Enabled = false;
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			timer1.Interval = 500;
			btnPlay.Enabled = false;
			btnPause.Enabled = true;
			btnFastForward.Enabled = true;
		}

		private void btnFastForward_Click(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			timer1.Interval = 100;
			btnFastForward.Enabled = false;
			btnPlay.Enabled = true;
			btnPause.Enabled = true;
		}
#endregion

		private void WorldUI_FormClosed(object sender, FormClosedEventArgs e)
		{
			parentForm.Show();
		}

        private void lBoxUnits_SelectedValueChanged(object sender, EventArgs e)
        {
			if (lBoxUnits.SelectedIndex != -1)
			{
				selectedUnit = world.SelectUnit(selectedCity, lBoxUnits.SelectedIndex);
				PopulateAbilitiesBox();
			}
        }

		private void AddUnit(UnitType type)
        {
            if (selectedCity.Length > 0)
            {
                world.AddUnit(type, selectedCity);
                PopulateUnitBox();
            }
            else
            {
                MessageBox.Show("You must click on a city before you can add units");
            }
        }

        private void diplomatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUnit(UnitType.Diplomat);
        }

        private void spyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUnit(UnitType.Spy);
        }

        private void archerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUnit(UnitType.Archer);
        }

        private void swordsmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUnit(UnitType.Swordsman);
        }

        private void labelLocation_Click(object sender, EventArgs e)
		{
			clickedLabel = sender as Label;
            foreach(Label label in labelLocationList)
            {
                label.BackColor = SystemColors.Control;
            }
			clickedLabel.BackColor = Color.Gray;
			selectedCity = clickedLabel.Text;
			lblCityReport.Text = world.CityReport(selectedCity);
			PopulateUnitBox();
		}

		private void PopulateUnitBox()
		{
			lBoxUnits.DataSource = null;
			lBoxUnits.DataSource = world.CityUnitList(selectedCity);
			lBoxUnits.DisplayMember = "Type";
		}

		private void PopulateAbilitiesBox()
		{
			cBoxActions.DataSource = null;
			cBoxActions.DataSource = selectedUnit.Abilities;
			cBoxActions.DisplayMember = "AbilityName";
		}

		private void PopulateTargetBox()
		{
			IAbility ability = (IAbility)cBoxActions.SelectedValue;
			if (ability.TargetType == AbilityTarget.City)
			{
				lBoxTargets.DataSource = null;
				lBoxTargets.DataSource = world.Locations();
				lBoxTargets.DisplayMember = "Name";
			}
			else if (ability.TargetType == AbilityTarget.Unit)
			{
				lBoxTargets.DataSource = null;
				lBoxTargets.DataSource = world.CityUnitList(selectedCity);
				lBoxTargets.DisplayMember = "Type";
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			renderer.PaintUnits(e.Graphics);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			IAbility selectedAbility = (IAbility)cBoxActions.SelectedItem;
			selectedUnit.CurrentAbility = selectedAbility;

			if (selectedAbility.Type == AbilityType.Move)
			{
				ILocation target = (ILocation)lBoxTargets.SelectedItem;
				selectedUnit.Target = target.Name;
			}
			selectedAUnit = false;
			IsUnitSelected();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			selectedAUnit = true;
			IsUnitSelected();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			selectedAUnit = false;
			IsUnitSelected();
		}

		private void IsUnitSelected()
		{
			if (selectedAUnit)
			{
				label3.Visible = true;
				cBoxActions.Visible = true;
				Targets.Visible = true;
				lBoxTargets.Visible = true;
				button1.Visible = true;
				lBoxUnits.Enabled = false;
			}
			else
			{
				label3.Visible = false;
				cBoxActions.Visible = false;
				Targets.Visible = false;
				lBoxTargets.Visible = false;
				button1.Visible = false;
				lBoxUnits.Enabled = true;
			}
		}

		private void cBoxActions_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cBoxActions.SelectedItem != null)
			{
				PopulateTargetBox();
			}
		}

		private void cBoxActions_VisibleChanged(object sender, EventArgs e)
		{
			if (cBoxActions.Visible)
			{
				if (cBoxActions.SelectedItem != null)
				{
					PopulateTargetBox();
				}
			}
		}
	}
}
