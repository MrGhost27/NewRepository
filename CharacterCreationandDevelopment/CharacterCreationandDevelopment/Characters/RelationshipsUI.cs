using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreationandDevelopment.Characters
{
    public partial class RelationshipsUI : Form
    {
        private PlayerCharacter player;

        public RelationshipsUI(PlayerCharacter player)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.player = player;
            PopulateTable();
        }

        private void PopulateTable()
        {
            int row = 1;
            foreach (Relationship relationship in HelperClass.listOfRelationships)
            {
                AddPicture(relationship.GetPortrait(), row);
                AddLabel(relationship.type, 1, row);
                AddLabel(relationship.name, 2, row);
                AddLabel(relationship.opinionofPlayer.ToString(), 3, row);
                AddLabel(relationship.playerOpinion.ToString(), 4, row);
                row++;
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            }
        }

        private void AddPicture(Image image, int row)
        {
            PictureBox picture = new PictureBox();
            picture.Image = image;
            picture.Size = new System.Drawing.Size(100, 100);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            tableLayoutPanel1.Controls.Add(picture, 0, row);
        }

        private void AddLabel(string text, int column, int row)
        {
            Label typeLabel = new Label();
            typeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            typeLabel.AutoSize = true;
            typeLabel.Size = new System.Drawing.Size(35, 13);
            typeLabel.Text = text;
            typeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tableLayoutPanel1.Controls.Add(typeLabel, column, row);
        }

    }
}
