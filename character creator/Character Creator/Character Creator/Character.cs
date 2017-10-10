using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.Generic;

namespace Character_Creator_Tool {
	class Character {

        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        private Spritesheet spritesheet;
        public Spritesheet Spritesheet {
            get { return spritesheet; }
        }

        private List<Layer> layers = new List<Layer>();

		public Character(string name, Spritesheet spritesheet) {
			this.name = name;
			this.spritesheet = spritesheet;
		}

        public void AddLayer(Layer layer) {
            layers.Add(layer);
        }

		public override string ToString() {
			return base.ToString() + "\n\tpath: \t" + spritesheet.ToString() + "\n\ttitle coordinates: \t" + layers[0].TileCoordinates.ToString();
		}
	}
}
