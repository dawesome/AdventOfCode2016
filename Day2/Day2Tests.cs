using System;
using NUnit.Framework;

namespace AdventOfCode2016
{
	public class Day2Tests
	{
		[Test]
		public void CanCallSolve()
		{
			Day2 day2 = new Day2();
			Assert.AreEqual ("5", day2.Solve (string.Empty));
		}

		[Test]
		public void Example1() 
		{
			Day2 day2 = new Day2 ();
			Assert.AreEqual("1985", day2.Solve ("ULL\nRRDDD\nLURDL\nUUUUD"));
		}

		[Test]
		public void MovingLeftOnLeftSide_StaysAtNumber() {
			Day2 day2 = new Day2 ();
			Assert.AreEqual ("5", day2.Solve (""));
			Assert.AreEqual ("4", day2.Solve ("L"));
			Assert.AreEqual ("4", day2.Solve ("L"));
			Assert.AreEqual ("1", day2.Solve ("U"));
			Assert.AreEqual ("1", day2.Solve ("L"));
			Assert.AreEqual ("4", day2.Solve ("D"));
			Assert.AreEqual ("7", day2.Solve ("D"));
			Assert.AreEqual ("7", day2.Solve ("L"));
		}

		[Test]
		public void MovingRightOnRightSide_StaysAtNumber ()
		{
			Day2 day2 = new Day2 ();
			Assert.AreEqual ("5", day2.Solve (""));
			Assert.AreEqual ("6", day2.Solve ("R"));
			Assert.AreEqual ("6", day2.Solve ("R"));
			Assert.AreEqual ("3", day2.Solve ("U"));
			Assert.AreEqual ("3", day2.Solve ("R"));
			Assert.AreEqual ("6", day2.Solve ("D"));
			Assert.AreEqual ("9", day2.Solve ("D"));
			Assert.AreEqual ("9", day2.Solve ("R"));
		}

		[Test]
		public void MovingUpOnTopSide_StaysAtNumber ()
		{
			Day2 day2 = new Day2 ();
			Assert.AreEqual ("5", day2.Solve (""));
			Assert.AreEqual ("2", day2.Solve ("U"));
			Assert.AreEqual ("2", day2.Solve ("U"));
			Assert.AreEqual ("1", day2.Solve ("L"));
			Assert.AreEqual ("1", day2.Solve ("U"));
			Assert.AreEqual ("3", day2.Solve ("RR"));
			Assert.AreEqual ("3", day2.Solve ("U"));
			
		}

		[Test]
		public void MovingDownOnBottomSide_StaysAtNumber ()
		{
			Day2 day2 = new Day2 ();
			Assert.AreEqual ("5", day2.Solve (""));
			Assert.AreEqual ("8", day2.Solve ("D"));
			Assert.AreEqual ("8", day2.Solve ("D"));
			Assert.AreEqual ("7", day2.Solve ("L"));
			Assert.AreEqual ("7", day2.Solve ("D"));
			Assert.AreEqual ("9", day2.Solve ("RR"));
			Assert.AreEqual ("9", day2.Solve ("D"));
		}

		[Test]
		public void MovingToEmptySpace_StaysAtNumber() {
			Day2 day2 = new Day2 ();
			day2.SetupForPart2 ();
			Assert.AreEqual ("5", day2.Solve (""));
			Assert.AreEqual ("5", day2.Solve ("U"));
			Assert.AreEqual ("5", day2.Solve ("D"));
		}
	}
}

// 59983 too high