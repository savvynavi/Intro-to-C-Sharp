using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Room_Creator_Tool;
using RoomEditor;

namespace RoomEditor {
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

		private void label1_Click(object sender, EventArgs e) {

		}

		//loads in spritesheet
		private void button1_Click(object sender, EventArgs e) {
			OpenFileDialog dialog = new OpenFileDialog();
			if(dialog.ShowDialog() == DialogResult.OK) {
				if(dialog.CheckFileExists == true) {
					Spritesheet = new Spritesheet(dialog.FileName);
					drawGrid();
				}
			}
		}

		private void drawGrid() {
			pictureBox1.DrawToBitmap(drawArea, pictureBox1.Bounds);

			Graphics graphics;
			graphics = Graphics.FromImage(drawArea);
			graphics.Clear(Color.White);

			if(Spritesheet == null) {
				return;
			}
			graphics.DrawImage(Spritesheet.Image, 0, 0);

			Pen pen = new Pen(Brushes.Black);

			int height = pictureBox1.Height;
			int width = pictureBox1.Width;
			for(int y = 0; y < height; y += Spritesheet.GridHeight + Spritesheet.Spacing) {
				graphics.DrawLine(pen, 0, y, width, y);
			}

			for(int x = 0; x < width; x += Spritesheet.GridWidth + Spritesheet.Spacing) {
				graphics.DrawLine(pen, x, 0, x, height);
			}

			Pen highlight = new Pen(Brushes.Red);
			graphics.DrawRectangle(highlight, CurrentTile.X * (Spritesheet.GridWidth + Spritesheet.Spacing), CurrentTile.Y * (Spritesheet.GridHeight + Spritesheet.Spacing), Spritesheet.GridWidth + Spritesheet.Spacing, Spritesheet.GridHeight + Spritesheet.Spacing);

			graphics.Dispose();
			pictureBox1.Image = drawArea;
		}

		//width
		private void textBox1_TextChanged(object sender, EventArgs e) {
			int width;
			if(int.TryParse(textBox1.Text, out width) == true) {
				Spritesheet.GridWidth = width;
				drawGrid();
			}
			textBox1.Text = Spritesheet.GridWidth.ToString();
		}

		//height
		private void textBox2_TextChanged(object sender, EventArgs e) {
			int height;
			if(int.TryParse(textBox2.Text, out height) == true) {
				Spritesheet.GridHeight = height;
				drawGrid();
			}
			textBox2.Text = Spritesheet.GridHeight.ToString();
		}

		//spacing
		private void textBox3_TextChanged(object sender, EventArgs e) {
			int spacing;
			if(int.TryParse(textBox3.Text, out spacing) == true) {
				Spritesheet.Spacing = spacing;
				drawGrid();
			}
			textBox3.Text = Spritesheet.Spacing.ToString();
		}

		private void SpriteSheetForm_Shown(object sender, EventArgs e) {
			drawGrid();
		}

		private void pictureBox1_Click_1(object sender, EventArgs e) {
			if(Spritesheet == null) {
				return;
			}

			if(e.GetType() == typeof(MouseEventArgs)) {
				MouseEventArgs mouse = e as MouseEventArgs;
				CurrentTile = new Point(mouse.X / (Spritesheet.GridWidth + Spritesheet.Spacing), mouse.Y / (Spritesheet.GridHeight + Spritesheet.Spacing));
				drawGrid();
			}
		}

		private void SpriteSheetForm_Activated(object sender, EventArgs e) {

		}
	}
}
