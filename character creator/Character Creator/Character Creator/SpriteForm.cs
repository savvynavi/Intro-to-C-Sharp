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
	public partial class SpriteForm : Form {
		Spritesheet spritesheet = null;
		Bitmap drawArea = null;

		public SpriteForm() {
			InitializeComponent();
			drawArea = new Bitmap(pictureBox.Width, pictureBox.Height);
		}
	}
}
