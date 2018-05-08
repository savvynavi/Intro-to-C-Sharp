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

		public RoomForm() {
			InitializeComponent();
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

		//delete button
		private void button2_Click(object sender, EventArgs e) {
			if(listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < listBox1.Items.Count) {
				listBox1.Items.RemoveAt(listBox1.SelectedIndex);
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
			Graphics graphics = Graphics.FromImage(drawArea);
			graphics.FillRectangle(Brushes.White, 0, 0, drawArea.Width, drawArea.Height);
			Rectangle destination = new Rectangle(0, 0, spritesheet.GridWidth<<2, spritesheet.GridHeight<<2);

			foreach(Point tile in listBox1.Items) {
				Rectangle source = new Rectangle(
					tile.X * (spritesheet.GridWidth + spritesheet.Spacing),
					tile.Y * (spritesheet.GridHeight + spritesheet.Spacing),
					spritesheet.GridWidth,
					spritesheet.GridHeight);
				graphics.DrawImage(spritesheet.Image, destination, source, GraphicsUnit.Pixel);
			}
			graphics.Dispose();
			pictureBox1.Image = drawArea;
		}
	}
}
