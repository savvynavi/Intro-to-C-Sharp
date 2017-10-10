using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace Character_Creator_Tool {
	class Program {
		static Spritesheet spritesheet = null;
        static List<Character> characters = new List<Character>();
        		
		static void Main(string[] args) {
			string path;
			string name;

			Console.WriteLine("Working directory is " + Directory.GetCurrentDirectory());

			Console.WriteLine("Enter the relative path of the sprite sheet texture: ");
			path = Console.ReadLine();

            Console.WriteLine("Make a new character (y/n): ");
            while(Console.ReadLine().ToLower().StartsWith("y") == true) {
                Console.WriteLine("Enter the name of the character to create: ");
                name = Console.ReadLine();

                spritesheet = new Spritesheet(Directory.GetCurrentDirectory() + "\\" + path);
                if(spritesheet == null) {
                    Console.WriteLine("Error loading spritesheet. Exiting program");
                    return;
                }

                Character character = new Character(name, spritesheet);

                Console.WriteLine("Enter the x tile index: ");
                int x = int.Parse(Console.ReadLine());

                //line not in tute?
                Console.WriteLine("Enter the y tile index: ");
                int y = int.Parse(Console.ReadLine());

                Layer layer = new Layer("base", new System.Drawing.Point(x, y));
                character.AddLayer(layer);
                characters.Add(character);

                Console.WriteLine("Make a new character (y/n): ");
            }

            Console.Clear();

            foreach(Character character in characters) {
                Console.WriteLine(character.ToString());
            }

			Console.ReadKey();
		}
	}
}
