using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Room_Creator_Tool {
    class Layer {
        public string Name { get; set; }
        public Point TileCoordinates { get; set; }
        public int Priority { get; set; }

		public Layer(string name) {
			Name = name;
		}

        public Layer(string name, Point coord) {
            Name = name;
            TileCoordinates = coord;
        }
    }
}
