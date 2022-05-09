using Microsoft.VisualStudio.TestTools.UnitTesting;
using LensAngle;
using System;

namespace ViewAngleTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var t1 = new ViewAngle();
			Console.WriteLine(t1);
			
			var ang = 45;
			var rad = ViewAngle.Rad(ang);
			var deg = ViewAngle.Deg(rad);
			Console.WriteLine($"{ang} rad={rad} deg={deg}");

			var da = t1.Ad;
			Console.WriteLine(t1);

			t1.Ad = 90;
			Console.WriteLine(t1);

			var t2 = new ViewAngle(23.6f, 15.6f, "aps-c");
			t2.f = 35.0f;
			Console.WriteLine(t2);

			t2.DiagonalAngle = t1.DiagonalAngle;
			Console.WriteLine(t2);

			t1.f = 21.0f;
			Console.WriteLine(t1);
			
			t2.f = t1.f;
			Console.WriteLine(t2);

			t1.Ad = t2.Ad;
			Console.WriteLine(t1);

			t1.Ah = 80;
			Console.WriteLine(t1);

			t1.f = 25;
			Console.WriteLine(t1);

			t2.f = 25;
			Console.WriteLine(t2);

			t1.Ad = t2.Ad;
			Console.WriteLine(t1);

			var t3 = new ViewAngle();
			t3.DiagonalLength = 43;
			Console.WriteLine(t3);

			var t4 = new ViewAngle(56, 56f/4*3, "6x45");
			t4.f = t4.D;
			Console.WriteLine(t4);

			t4.Ad = 45;
			Console.WriteLine(t4);
			t4.f = 80;
			Console.WriteLine(t4);
			t4.f = 60;
			Console.WriteLine(t4);
		}
	}
}
