using System;
using System.Windows.Forms;
using System.Drawing;

namespace A21_Ex02
{
	public class PictureBoxProxy : PictureBox
	{
		// Data Members
		private readonly ushort r_ResizeFactor = 90;

		// Constructor
		public PictureBoxProxy()
		{
			this.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		// Methods
		protected override void OnMouseClick(MouseEventArgs e)
		{
			// Invert Color of Picture
			Bitmap invertedPicture = new Bitmap(this.Image);
			Color inverterFactor;

			for (int y = 0; y <= invertedPicture.Height - 1; y++)
			{
				for (int x = 0; x <= invertedPicture.Width - 1; x++)
				{
					inverterFactor = invertedPicture.GetPixel(x, y);
					inverterFactor = Color.FromArgb(255, 255 - inverterFactor.R, 255 - inverterFactor.G, 255 - inverterFactor.B);
					invertedPicture.SetPixel(x, y, inverterFactor);
				}
			}

			this.Image = invertedPicture;
		}
		
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.Height += r_ResizeFactor;
			this.Width += r_ResizeFactor;
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.Height -= r_ResizeFactor;
			this.Width -= r_ResizeFactor;
		}
	}
}