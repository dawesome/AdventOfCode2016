using System;
namespace AdventOfCode2016
{
	public class Day2
	{
		public Day2 ()
		{
		}

		string [] keypad = { "1", "2", "3", 
			                 "4", "5", "6", 
			                 "7", "8", "9" };
		int currentIndex = 4; // number '5' on the keypad
		int stride = 3;

		void Reset() {
			currentIndex = 4;
		}

		public void SetupForPart1() {
			keypad = new string [] { "1", "2", "3",
				                     "4", "5", "6",
					                 "7", "8", "9" };
			currentIndex = 4;
			stride = 3;
		}

		public void SetupForPart2 ()
		{
			keypad = new string [] { "" ,  "", "1", "" , "" ,
									 "" , "2", "3", "4", "" ,
									 "5", "6", "7", "8", "9",
									 "" , "A", "B", "C", "" ,
								     "",  "",  "D", "",  "" };
			currentIndex = 10;
			stride = 5;
		}

		public string Solve(string input)
		{
			string keys = string.Empty;
			string [] lines = input.Split ('\n');
			for (int lineIndex = 0; lineIndex < lines.Length; ++lineIndex) {
				keys += MoveLine (lines [lineIndex]);
			}
			return keys;
		}

		public string MoveLine(string line)
		{
			for (int characterIndex = 0; characterIndex < line.Length; ++characterIndex) {
				if (line[characterIndex] == 'U') {
					if (currentIndex > stride - 1 && keypad[currentIndex - stride] != "") {
						currentIndex -= stride;
					}
				}
				else if (line [characterIndex] == 'D') {
					if (currentIndex < keypad.Length - stride && keypad[currentIndex + stride] != "") {
						currentIndex += stride;
					}
				}
				else if (line [characterIndex] == 'L') {
					if (currentIndex % stride != 0 && keypad[currentIndex - 1] != "") {
						currentIndex--;
					}
				}
				else if (line [characterIndex] == 'R') {
					if (currentIndex % stride != stride - 1 && keypad[currentIndex + 1] != "") {
						currentIndex++;
					}
				}
			}

			return keypad [currentIndex];
		}
	}
}
