using System;
using System.Collections.Generic;

namespace AdventOfCode2016
{
	public class Day1
	{
		public Day1 ()
		{
		}

		internal enum CardinalDirection {
			North = 0,
			East,
			South,
			West
		};

		internal struct Point
		{
			public Point(int first, int second) {
				x = first;
				y = second;
			}

			public int x { get; set; }
			public int y { get; set; }
		};

		public static int Run (string input)
		{

			HashSet<Point> pointsVisited = new HashSet<Point>();

			CardinalDirection currentFacing = CardinalDirection.North;
			Point currentLocation = new Point (0, 0);

			string [] directions = input.Split (',');
			foreach (string dir in directions) {
				string turn = dir.Trim ();
				currentFacing = PerformTurn (currentFacing, turn[0]);

				int steps = Int32.Parse (turn.Substring (1));
				currentLocation = TakeSteps (currentLocation, currentFacing, pointsVisited, steps);
			}


			int blocksAway = GetBlocksFromOrigin(currentLocation);
			Console.WriteLine (blocksAway);
			return blocksAway;
		}

		private static CardinalDirection PerformTurn (CardinalDirection currentFacing, char direction)
		{
			if (direction== 'L') {
				currentFacing--;
			} else {
				currentFacing++;
			}
			if (currentFacing < 0) {
				currentFacing = CardinalDirection.West;
			} else if (currentFacing > CardinalDirection.West) {
				currentFacing = CardinalDirection.North;
			}
			return currentFacing;
		}

		private static Point TakeSteps(Point currentLocation, CardinalDirection currentFacing, HashSet<Point> pointsVisited, int steps) 
		{
			for (int i = 0; i < steps; ++i) {
				if (currentFacing == CardinalDirection.North) {
					currentLocation.y++;
				} else if (currentFacing == CardinalDirection.South) {
					currentLocation.y--;
				} else if (currentFacing == CardinalDirection.East) {
					currentLocation.x++;
				} else if (currentFacing == CardinalDirection.West) {
					currentLocation.x--;
				}
			

				if (!pointsVisited.Contains (currentLocation)) {
					pointsVisited.Add (currentLocation);
				} else {
					Console.WriteLine ("Second visited = " + currentLocation.x + ", " + currentLocation.y + " , blocksAway = " + GetBlocksFromOrigin (currentLocation));
				}
			}
			return currentLocation;
		}

		private static int GetBlocksFromOrigin(Point location) {
			return Math.Abs (location.x) + Math.Abs (location.y);
		}
	}
}
