using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Character_Creator_Tool {
	class Spritesheet {

		private Image image = null;
		public string path;
		
		//returns width of spritesheet if the image has been loaded
		public int GetWidth() {
			if(image != null) {
				return image.Width;
			}
			return 0;
		}

		//returns height of spritesheet
		public int GetHeight() {
			if(image != null) {
				return image.Height;
			}
			return 0;
		}

		//constructor, takes in a filepath to spritesheet as paramater
		public Spritesheet(string path) {
			this.path = path;
			Load();
		}

		//loads image from path(edit later so that it checks if valid path)
		public void Load() {
			image = Image.FromFile(path);
		}
	}
}
