using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Units;

namespace Training
{
	public class Renderer
	{
		private World world;

		internal Renderer(World TheWorld)
		{
			this.world = TheWorld;
		}

		public static Bitmap ResizeImage(Image ImageToResize, int Width, int Height)
		{
			Bitmap bitmap = new Bitmap(Width, Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.DrawImage(ImageToResize, 0, 0, Width, Height);
			}
			return bitmap;
		}

		public void PaintUnits(Graphics g)
		{
			using (Pen brownPen = new Pen(Color.Brown, 6.0F))
			{
				foreach (IUnit unit in world.WorldUnitList())
				{
					g.DrawImageUnscaled(unit.Image, unit.Location.X, unit.Location.Y);
				}
			}
		}
	}
}
