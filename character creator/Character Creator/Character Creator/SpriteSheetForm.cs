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
		Spritesheet spritesheet = null;
		Bitmap drawArea;

		int gridWidth = 16;
		int gridHeight = 16;
		int spacing = 0;

		public SpriteSheetForm() {
            InitializeComponent();
			drawArea = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e) {
			OpenFileDialog dlg = new OpenFileDialog();

			if(dlg.ShowDialog() == DialogResult.OK) {
				if(dlg.CheckFileExists == true) {
					spritesheet = new Spritesheet(dlg.FileName);
					drawGrid();
				}
			}
        }

		private void drawGrid() {
			pictureBox1.DrawToBitmap(drawArea, pictureBox1.Bounds);
			Graphics g;
			g = Graphics.FromImage(drawArea);

			g.Clear(Color.White);

			if(spritesheet != null) {
				g.DrawImage(spritesheet.Image, 0, 0);
			}

			Pen pen = new Pen(Brushes.Black);

			int height = pictureBox1.Height;
			int width = pictureBox1.Width;
			for(int y = 0; y < height; y += gridHeight + spacing) {
				g.DrawLine(pen, 0, y, width, y);
			}

			for(int x = 0; x < width; x += gridWidth + spacing) {
				g.DrawLine(pen, x, 0, x, height);
			}

			g.Dispose();
			pictureBox1.Image = drawArea;
		}

        private void textboxTileWidth_TextChanged(object sender, EventArgs e) {
			if(int.TryParse(textboxTileWidth.Text, out gridWidth) == true) {
				drawGrid();
			}
			textboxTileWidth.Text = gridWidth.ToString();
        }

        private void textboxTileHeight_TextChanged(object sender, EventArgs e) {
			if(int.TryParse(textboxTileHeight.Text, out gridHeight) == true) {
				drawGrid();
			}
			textboxTileHeight.Text = gridHeight.ToString();
        }

        private void textboxSpacing_TextChanged(object sender, EventArgs e) {
			if(int.TryParse(textboxSpacing.Text, out gridHeight) == true) {
				drawGrid();
			}
			textboxSpacing.Text = spacing.ToString();
		}

        private void SpriteSheetForm_Shown(object sender, EventArgs e) {
			drawGrid();
        }
    }
}
