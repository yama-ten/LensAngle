/****************************************************************
 * title: レンズの画角と焦点距離
 * file: Form1.cs
 * version: 1.1
 * date: 2021.10.04
 * ver 1.0 / 2021.10.04
 * ver 1.1 / 2021.10.17
 * copyright: yama-ten
 */

//2021.10.17

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LensAngle
{
	public partial class LensAngle : Form
	{		public LensAngle()
		{
			InitializeComponent();
			this.Text = "画角と焦点距離";
		}

		Rectangle box;
		Point center;
		Bitmap canvas;
		Rectangle bigRect = new Rectangle(0,0, 400, 400);
		Rectangle littleRect = new Rectangle(0,0, 100, 100);

		private void Form1_Load(object sender, EventArgs e)
		{
			center.X = pictureBox1.Width/2;
			center.Y = pictureBox1.Height*3/4;

			//描画先とするImageオブジェクトを作成する
			canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);

			//draw_LensAngle(23);
			hScrollBar1.Minimum = 0;
			hScrollBar1.Maximum = 909;
			hScrollBar1.SmallChange = 1;
			hScrollBar1.Value = 230; // 23.0 degree (46/2 deg.)
			draw_LensAngle((double)hScrollBar1.Value/10);
		}


		int cvtAngle(int angle) {
			return (360 - angle - 90) %360; 
		}


		void draw_BigBox(Graphics g)
		{
			Pen p = new Pen(Color.Black, 1);

			int width = bigRect.Width;
			int height = bigRect.Height/2;
			int left = center.X - bigRect.Width/2;
			int	top = center.Y - height;
			
			g.DrawRectangle(p, left, top, width, height);
		}

		void draw_LittleBox(Graphics g)
		{
			Pen p = new Pen(Color.Black, 1);

			int	width = littleRect.Width;
			int	height = littleRect.Height/2;
			int	left = center.X - width/2;
			int	top = center.Y;
			
			g.DrawRectangle(p, left, top, width, height);
		}

		void draw_CenterLine(Graphics g)
		{
			int width = bigRect.Width;
			int height = bigRect.Height/2;
			int left = center.X - bigRect.Width/2;
			int top = center.Y - bigRect.Height/2;
			int bottom = center.Y + littleRect.Height/2;
			int length = bottom - top;
			g.DrawLine(Pens.Red, center.X, top, center.X, bottom);
		}

		void draw_pie(double degree, Graphics g, Rectangle rect, Pen p)
		{
			draw_BigPie(degree, g, bigRect, p);
			draw_LittlePie(degree, g, littleRect, p);
			draw_LittleBox(g);
			draw_BigBox(g);
			draw_CenterLine(g);
		}


		void draw_BigPie(double degree, Graphics g, Rectangle rect, Pen p)
		{
			float angle = cvtAngle(0);
			float width = bigRect.Width;
			float height = bigRect.Height;
			float left = center.X - width/2;
			float top = center.Y - height/2;
			g.DrawPie(p, left, top, width, height, angle,(float)-degree);
			g.DrawPie(p, left, top, width, height, angle,(float)degree);
		}

		void draw_LittlePie(double degree, Graphics g, Rectangle rect, Pen p)
		{
			float angle = cvtAngle(180);
			float width = littleRect.Width;
			float height = littleRect.Height;
			float left = center.X - width/2;
			float top = center.Y - height/2;
			g.DrawPie(p, left, top, width, height, angle, (float)-degree);
			g.DrawPie(p, left, top, width, height, angle, (float)degree);
		}

		private void pictureBox1_Resize(object sender, EventArgs e)
		{
			Control ctrl = (Control)sender;
			box = new Rectangle(0, 0, ctrl.Size.Width, ctrl.Size.Height);
			center = new Point(box.Width/2, box.Height/2);
		}


		//double last_degree = -1;
		private void draw_LensAngle(double degree)
		{
			canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			Graphics g = Graphics.FromImage(canvas);
			Pen p = new Pen(Color.Blue, 1);

			// 画角
			DiagonalAngle.Text = (2*degree).ToString("##0.0 ");

			// 35mm の焦点距離
			double tan = Math.Tan(degree*Math.PI/180);
			double diagonal = Math.Sqrt(36*36+24*24);
			double f = (diagonal/2)/tan;
			Lens_35mm.Text = (f+0.05).ToString("###0.0 ");
			
			// 水平画角
			double ah = Math.Atan((36/2)/f)/Math.PI*180;
			AngleH.Text = (2*ah).ToString("##0.0 ");

			// 垂直画角
			double av = Math.Atan((24/2)/f)/Math.PI*180;
			AngleV.Text = (2*av).ToString("##0.0 ");

			// APS-C(24mm) の焦点距離
			diagonal = Math.Sqrt(24*24+16*16);
			f = (diagonal/2)/tan;
			Lens_Apsc.Text = (f+0.05).ToString("###0.0 ");

			int top = center.Y - bigRect.Height/2;
			int left = center.X - bigRect.Width/2;
			int right = center.X + bigRect.Width/2;
			int bottom = center.Y + bigRect.Height/2;
			//int length = 0;
			int width = bigRect.Width;
			int height = bigRect.Height;

			draw_pie(av, g, bigRect, new Pen(Color.Pink,1)); 
			draw_pie(ah, g, bigRect, new Pen(Color.LightGreen,1)); 
			draw_pie(degree, g, bigRect, new Pen(Color.Blue,1)); 

			//PictureBox1に表示する
			pictureBox1.Image = canvas;

			//リソースを解放する
			p.Dispose();
			g.Dispose();
		}


		private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			ScrollBar ctrl = (ScrollBar)sender;
			double degree =  (double)(ctrl.Value)/10;
			draw_LensAngle(degree);
		}
	}

}