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

namespace RoomEditor {
	public partial class RoomForm : Form {
		Spritesheet spritesheet = null;
		Bitmap drawArea = null;

		public Point CurrentTile { get; private set; } = new Point();

		struct Tiles {
			public Point SourceCoord;
			public Point DestinationCoord;
		}

		List<Tiles> drawSpriteAtPos;

		public RoomForm() {
			InitializeComponent();
			drawSpriteAtPos = new List<Tiles>();

			drawArea = new Bitmap(pictureBox1.Width, pictureBox1.Height);
		}

		private void RoomForm_Activated(object sender, EventArgs e) {
			MdiClient parent = Parent as MdiClient;
			if(parent != null) {
				foreach(Form child in parent.MdiChildren) {
					if(child.GetType() == typeof(SpriteSheetForm)) {
						SpriteSheetForm sheet = child as SpriteSheetForm;
						Spritesheet ss = sheet.Spritesheet;
						if(ss != null && !comboBox1.Items.Contains(ss)) {
							comboBox1.Items.Add(ss);
						}
					}
				}
			}

			if(spritesheet != null) {
				comboBox1.SelectedItem = spritesheet;
			}else if(comboBox1.Items.Count > 0) {
				comboBox1.SelectedIndex = 0;
				spritesheet = comboBox1.SelectedItem as Spritesheet;
			}
		}

		//add button
		private void button1_Click(object sender, EventArgs e) {
			if(spritesheet != null) {
				SpriteSheetForm sheet = FindSheet();
				if(sheet != null) {
					listBox1.Items.Add(sheet.CurrentTile);
					DrawRoom();
				}
			}
		}

		private void addToListbox(Tiles tileName, SpriteSheetForm sheet) {
			if(sheet != null) {
				listBox1.Items.Add(sheet.CurrentTile);
				DrawRoom();
			}
		}

		//delete button - make work with new stuff
		private void button2_Click(object sender, EventArgs e) {
			if(listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < listBox1.Items.Count) {
				listBox1.Items.RemoveAt(listBox1.SelectedIndex);
				//drawSpriteAtPos.RemoveAt(listBox1.SelectedIndex);



				DrawRoom();
			}
		}

		//sheet selection
		private void comboBox1_SelectedValueChanged(object sender, EventArgs e) {
			listBox1.Items.Clear();
			spritesheet = comboBox1.SelectedItem as Spritesheet;

			Graphics graphics = Graphics.FromImage(drawArea);
			graphics.FillRectangle(Brushes.White, 0, 0, drawArea.Width, drawArea.Height);
			graphics.Dispose();
			pictureBox1.Image = drawArea;
		}

		SpriteSheetForm FindSheet() {
			MdiClient parent = Parent as MdiClient;
			if(parent != null) {
				foreach(Form child in parent.MdiChildren) {
					if(child.GetType() == typeof(SpriteSheetForm)) {
						SpriteSheetForm sheet = child as SpriteSheetForm;
						if(sheet.Spritesheet == spritesheet) {
							return sheet;
						}
					}
				}
			}
			return null;
		}

		private void DrawRoom() {
			drawGrid();
			Graphics graphics = Graphics.FromImage(drawArea);

			//change this to selectes coord
			//foreach(Point tile in listBox1.Items) {
			//	Rectangle source = new Rectangle(
			//		tile.X * (spritesheet.GridWidth + spritesheet.Spacing),
			//		tile.Y * (spritesheet.GridHeight + spritesheet.Spacing),
			//		spritesheet.GridWidth,
			//		spritesheet.GridHeight);
			//	Rectangle destination = new Rectangle(tile.X * (spritesheet.GridWidth + spritesheet.Spacing), tile.Y * (spritesheet.GridHeight + spritesheet.Spacing), spritesheet.GridWidth, spritesheet.GridHeight);
			//	graphics.DrawImage(spritesheet.Image, destination, source, GraphicsUnit.Pixel);
			//}

			foreach(Tiles tile in drawSpriteAtPos) {
				Rectangle source = new Rectangle(
					tile.SourceCoord.X * (spritesheet.GridWidth + spritesheet.Spacing),
					tile.SourceCoord.Y * (spritesheet.GridHeight + spritesheet.Spacing),
					spritesheet.GridWidth,
					spritesheet.GridHeight);
				Rectangle destination = new Rectangle(tile.DestinationCoord.X * (spritesheet.GridWidth + spritesheet.Spacing), tile.DestinationCoord.Y * (spritesheet.GridHeight + spritesheet.Spacing), spritesheet.GridWidth, spritesheet.GridHeight);
				graphics.DrawImage(spritesheet.Image, destination, source, GraphicsUnit.Pixel);
			}
			graphics.Dispose();
			pictureBox1.Image = drawArea;
		}

		//draw grid over the sprite area
		private void drawGrid() {
			pictureBox1.DrawToBitmap(drawArea, pictureBox1.Bounds);

			Graphics graphics;
			graphics = Graphics.FromImage(drawArea);
			graphics.Clear(Color.FromArgb(0, 255, 255, 255));

			if(spritesheet == null) {
				return;
			}

			Pen pen = new Pen(Brushes.Black);

			int height = pictureBox1.Height;
			int width = pictureBox1.Width;
			for(int y = 0; y < height; y += spritesheet.GridHeight + spritesheet.Spacing) {
				graphics.DrawLine(pen, 0, y, width, y);
			}

			for(int x = 0; x < width; x += spritesheet.GridWidth + spritesheet.Spacing) {
				graphics.DrawLine(pen, x, 0, x, height);
			}

			Pen highlight = new Pen(Brushes.Red);
			graphics.DrawRectangle(highlight, CurrentTile.X * (spritesheet.GridWidth + spritesheet.Spacing), CurrentTile.Y * (spritesheet.GridHeight + spritesheet.Spacing), spritesheet.GridWidth + spritesheet.Spacing, spritesheet.GridHeight + spritesheet.Spacing);

			graphics.Dispose();
			pictureBox1.Image = drawArea;
		}

		//clicking picbox will grag coord and let you dump image at that point
		private void pictureBox1_Click(object sender, EventArgs e) {
			if(spritesheet == null) {
				return;
			}

			if(e.GetType() == typeof(MouseEventArgs)) {
				MouseEventArgs mouse = e as MouseEventArgs;
				CurrentTile = new Point(mouse.X / (spritesheet.GridWidth + spritesheet.Spacing), mouse.Y / (spritesheet.GridHeight + spritesheet.Spacing));

				//save tile coord here for draw use
				Tiles tmp = new Tiles();
				tmp.DestinationCoord = new Point(CurrentTile.X, CurrentTile.Y);

				SpriteSheetForm sheet = FindSheet();
				if(sheet != null) {
					tmp.SourceCoord = new Point(sheet.CurrentTile.X, sheet.CurrentTile.Y);
				} else {
					tmp.SourceCoord = new Point(0, 0);
				}
				drawSpriteAtPos.Add(tmp);
				addToListbox(tmp, sheet);
				DrawRoom();
			}
		}

		private void RoomForm_Shown(object sender, EventArgs e) {
			drawGrid();
		}
	}
}
