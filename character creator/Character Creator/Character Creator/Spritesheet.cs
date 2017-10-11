using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Character_Creator_Tool {
	public class Spritesheet {

		public Image Image{get; private set;}
		public string Path { get; private set; }

		public int GridWidth { get; set; } = 16;
		public int GridHeight {get; set;} = 16;
		public int Spacing { get; set; } = 1;


		public int Width {
			get { return (Image != null) ? Image.Width : 0; }
		}
		public int Height {
			get { return (Image != null) ? Image.Height : 0; }
		}

		 public string Filename {
			get { return Path.Substring(Path.LastIndexOf('\\')); }
		}

		//constructor, takes in a filepath to spritesheet as paramater
		public Spritesheet(string path) {
			Path = path;
			Image = Image.FromFile(Path);
		}

		//loads image from path(edit later so that it checks if valid path)
		//public void Load() {
		//	Image = Image.FromFile(Path);
		//}

		public override string ToString() {
			return Filename;
		}
	}
}
