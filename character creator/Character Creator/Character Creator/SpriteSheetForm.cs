using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Character_Creator_Tool;

namespace Character_Creator {
	public partial class SpriteSheetForm : Form {
		public Spritesheet Spritesheet { get; private set; }
		Bitmap drawArea;

		public Point CurrentTile { get; private set; } = new Point();
		public string Filename {
			get { return (Spritesheet != null) ? Spritesheet.Filename : string.Empty; }
		}

		public SpriteSheetForm() {
            InitializeComponent();
			drawArea = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e) {
			OpenFileDialog dlg = new OpenFileDialog();

			if(dlg.ShowDialog() == DialogResult.OK) {
				if(dlg.CheckFileExists == true) {
					Spritesheet = new Spritesheet(dlg.FileName);
					drawGrid();
				}
			}
        }

		private void drawGrid() {
			pictureBox1.DrawToBitmap(drawArea, pictureBox1.Bounds);
			Graphics g;
			g = Graphics.FromImage(drawArea);

			g.Clear(Color.White);

			if(Spritesheet == null) {
				return;
			}

			g.DrawImage(Spritesheet.Image, 0, 0);
			Pen pen = new Pen(Brushes.Black);

			int height = pictureBox1.Height;
			int width = pictureBox1.Width;
			for(int y = 0; y < height; y += Spritesheet.GridHeight + Spritesheet.Spacing) {
				g.DrawLine(pen, 0, y, width, y);
			}

			for(int x = 0; x < width; x += Spritesheet.GridWidth + Spritesheet.Spacing) {
				g.DrawLine(pen, x, 0, x, height);
			}

			Pen highlight = new Pen(Brushes.Red);
			g.DrawRectangle(highlight, CurrentTile.X * (Spritesheet.GridWidth + Spritesheet.Spacing), CurrentTile.Y * (Spritesheet.GridHeight + Spritesheet.Spacing), Spritesheet.GridWidth + Spritesheet.Spacing, Spritesheet.GridHeight + Spritesheet.Spacing);

			g.Dispose();
			pictureBox1.Image = drawArea;
		}

		private void textboxTileHeight_TextChanged(object sender, EventArgs e) {
			int height;
			if(int.TryParse(textboxTileHeight.Text, out height) == true) {
				Spritesheet.GridHeight = height;
				drawGrid();
			}
			textboxTileHeight.Text = Spritesheet.GridHeight.ToString();
		}

		private void textboxTileWidth_TextChanged(object sender, EventArgs e) {
			int width;
			if(int.TryParse(textboxTileWidth.Text, out width) == true) {
				Spritesheet.GridWidth = width;
				drawGrid();
			}
			textboxTileWidth.Text = Spritesheet.GridWidth.ToString();
        }

        private void textboxSpacing_TextChanged(object sender, EventArgs e) {
			int spacing;
			if(int.TryParse(textboxSpacing.Text, out spacing) == true) {
				Spritesheet.Spacing = spacing;
				drawGrid();
			}
			textboxSpacing.Text = Spritesheet.Spacing.ToString();
		}

        private void SpriteSheetForm_Shown(object sender, EventArgs e) {
			drawGrid();
        }
    }
}
