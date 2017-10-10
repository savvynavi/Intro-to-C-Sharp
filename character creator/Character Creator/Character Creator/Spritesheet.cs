using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Character_Creator_Tool {
	class Spritesheet {

		private Image image = null;
		public Image Image{ 
			get{
				return image;
			}	
		}

		private string path;
		
		//returns width of spritesheet if the image has been loaded
		public int Width {
            get {
                return (image != null) ? image.Width : 0;
            }
		}

		//returns height of spritesheet
		public int Height {
            get {
                return (image != null) ? image.Height : 0;
            }
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
