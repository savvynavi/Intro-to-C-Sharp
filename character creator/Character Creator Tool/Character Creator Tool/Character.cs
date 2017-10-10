using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Character_Creator_Tool {
	class Character {

		public string name;
		public Spritesheet spritesheet;
		public Point tileCoord = new Point(0, 0);

		public Character(string name, Spritesheet spritesheet) {
			this.name = name;
			this.spritesheet = spritesheet;
		}

		public override string ToString() {
			return base.ToString() + "\n\tpath: \t" + spritesheet.path + "\n\ttitle coordinates: \t" + tileCoord.ToString();
		}
	}
}
