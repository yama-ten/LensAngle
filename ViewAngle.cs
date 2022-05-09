using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms.Design;

namespace LensAngle
{
	public class ViewAngle
	{
		//public double Angle			{ get; set; }
		public string Name;
		
		private RectangleF rect;
		public static float Deg(float rad) { return rad / MathF.PI * 180; }
		public static float Rad(float deg) { return deg / 180 * MathF.PI; }

		public float Ad { 
			get { return Deg(MathF.Atan(D/2/f))*2; }
			set { f = D/2 / MathF.Tan(Rad(value/2)); } 
		}

		public float Ah { 
			get { return Deg(MathF.Atan(X/2/f))*2; }
			set { f = X/2 / MathF.Tan(Rad(value/2)); } 
		}

		public float Av {
			get { return Deg(MathF.Atan(Y/2/f))*2; }
			set { f = Y/2 / MathF.Tan(Rad(value/2)); } 
		}

		public float f;
		public float X { get { return rect.X; } set { rect.X = value; }}
		public float Y { get { return rect.Y; } set { rect.Y = value; }}
		public float D { 
			get { return MathF.Sqrt(X*X + Y*Y); }
			set {
				var r = value; 
				var a = X/Y;
				X = MathF.Cos(a)*r;
				Y = MathF.Sin(a)*r;
			}
		}
		public float A { 
			get { return X/Y; }
			set {
				var a = value;
				var r = MathF.Sqrt(X*X+Y*Y);
				X = r*MathF.Cos(a);
				Y = r*MathF.Sin(r);
			}
		}

		public float FocalLength	{ get { return f; } set { f = value; }}
		public float Height			{ get { return X; } set { X = value; }}
		public float Width			{ get { return Y; } set { Y = value; }}
		public float DiagonalLength { get { return D; } set { D = value; }}
		public float Aspect			{ get { return A; } set { A = value; }} 
		public float DiagonalAngle	 { get { return Ad; } set { Ad = value; }}
		public float HorizontalAngle { get { return Ah; } set { Ah = value; }}
		public float VerticalAngle	 { get { return Av; } set { Av = value; }}
	

		public override string ToString()
		{
			//return base.ToString();
			return $"{Name}(X={X:f1}, Y={Y:f1}, D={D:f1}) f={f:f1}mm, Ad={Ad:f1}, Av={Av:f1}, Ah={Ah:f1}";
		}

		public ViewAngle()
		{
			Name = "35mm";
			f = 51.6f;
			X = 36;
			Y = 24;
		}
		public ViewAngle(float x, float y, string name ="")
		{ 
			Name = name;
			X = x;
			Y = y;
		}
	}
}
