using System;
using System.IO;

namespace AdventOfCode2016
{
	class MainClass {
		public static void Main ()
		{
			//Day1.Run (ReadFile("../../Day1/Day1Input.txt"));
			Day2 day2 = new Day2();
			day2.SetupForPart2 ();
			string answer = day2.Solve (ReadFile ("../../Day2/Input.txt"));
			Console.WriteLine (answer);
		}


		public static string ReadFile(string filename) {
			return File.ReadAllText (filename);
		}
	}
}
