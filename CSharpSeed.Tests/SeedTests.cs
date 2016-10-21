using NUnit.Framework;
using System;
using CSharpSeed;

namespace CSharpSeed.Tests
{
  [TestFixture()]
	public class SeedTests
	{
		[Test()]
		public void TestTheTruth()
		{
      var seed = new Seed();
			Assert.IsTrue(seed.ReturnTheTruth());
		}
	}
}
