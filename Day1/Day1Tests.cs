using System;
using NUnit.Framework;

namespace AdventOfCode2016
{
	public class Day1Tests
	{
		[Test]
		public void Example1 () {
			//R2, L3
			//answer: 5
			Assert.AreEqual(5, Day1.Run ("R2, L3"));
		}

		[Test]
		public void Example2() {
			Assert.AreEqual (2, Day1.Run ("R2, R2, R2"));
		}

		[Test]
		public void Example3() {
			Assert.AreEqual (12, Day1.Run ("R5, L5, R5, R3"));
		}

		[Test]
		public void SecondVisited() {
			Day1.Run ("R8, R4, R4, R8");
		}
	}
}
