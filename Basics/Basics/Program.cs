using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Basics{
	class Program{
		static void Main(string[] args){
			//Console.Write("Enter name: ");
			//string input = Console.ReadLine();
			//Console.Write("Hello " + input);
			TestClass test = new TestClass();
			int answer = test.simpleAddFn(2, 3);
			Console.Write(answer);
			while(true);
		}
	}
}
