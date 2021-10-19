
namespace LensAngle
{
	partial class LensAngle
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.DiagonalAngle = new System.Windows.Forms.TextBox();
			this.lbl_Diagonal = new System.Windows.Forms.Label();
			this.lbl_35mm = new System.Windows.Forms.Label();
			this.Lens_35mm = new System.Windows.Forms.TextBox();
			this.lbl_APS_C = new System.Windows.Forms.Label();
			this.Lens_Apsc = new System.Windows.Forms.TextBox();
			this.lbl_H = new System.Windows.Forms.Label();
			this.AngleH = new System.Windows.Forms.TextBox();
			this.lbl_V = new System.Windows.Forms.Label();
			this.AngleV = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(486, 325);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(12, 340);
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(486, 19);
			this.hScrollBar1.TabIndex = 7;
			this.hScrollBar1.TabStop = true;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// DiagonalAngle
			// 
			this.DiagonalAngle.BackColor = System.Drawing.Color.DodgerBlue;
			this.DiagonalAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DiagonalAngle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.DiagonalAngle.ForeColor = System.Drawing.Color.White;
			this.DiagonalAngle.Location = new System.Drawing.Point(88, 375);
			this.DiagonalAngle.Multiline = true;
			this.DiagonalAngle.Name = "DiagonalAngle";
			this.DiagonalAngle.Size = new System.Drawing.Size(52, 27);
			this.DiagonalAngle.TabIndex = 8;
			this.DiagonalAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbl_Diagonal
			// 
			this.lbl_Diagonal.AutoSize = true;
			this.lbl_Diagonal.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_Diagonal.Location = new System.Drawing.Point(22, 379);
			this.lbl_Diagonal.Name = "lbl_Diagonal";
			this.lbl_Diagonal.Size = new System.Drawing.Size(60, 17);
			this.lbl_Diagonal.TabIndex = 9;
			this.lbl_Diagonal.Text = "Diagonal";
			// 
			// lbl_35mm
			// 
			this.lbl_35mm.AutoSize = true;
			this.lbl_35mm.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_35mm.Location = new System.Drawing.Point(301, 380);
			this.lbl_35mm.Name = "lbl_35mm";
			this.lbl_35mm.Size = new System.Drawing.Size(44, 17);
			this.lbl_35mm.TabIndex = 11;
			this.lbl_35mm.Text = "35mm";
			// 
			// Lens_35mm
			// 
			this.Lens_35mm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Lens_35mm.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Lens_35mm.Location = new System.Drawing.Point(346, 376);
			this.Lens_35mm.Name = "Lens_35mm";
			this.Lens_35mm.Size = new System.Drawing.Size(42, 25);
			this.Lens_35mm.TabIndex = 10;
			this.Lens_35mm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbl_APS_C
			// 
			this.lbl_APS_C.AutoSize = true;
			this.lbl_APS_C.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_APS_C.Location = new System.Drawing.Point(397, 380);
			this.lbl_APS_C.Name = "lbl_APS_C";
			this.lbl_APS_C.Size = new System.Drawing.Size(43, 17);
			this.lbl_APS_C.TabIndex = 13;
			this.lbl_APS_C.Text = "APS-C";
			// 
			// Lens_Apsc
			// 
			this.Lens_Apsc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Lens_Apsc.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Lens_Apsc.Location = new System.Drawing.Point(440, 375);
			this.Lens_Apsc.Name = "Lens_Apsc";
			this.Lens_Apsc.Size = new System.Drawing.Size(42, 25);
			this.Lens_Apsc.TabIndex = 12;
			this.Lens_Apsc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbl_H
			// 
			this.lbl_H.AutoSize = true;
			this.lbl_H.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_H.Location = new System.Drawing.Point(157, 379);
			this.lbl_H.Name = "lbl_H";
			this.lbl_H.Size = new System.Drawing.Size(17, 17);
			this.lbl_H.TabIndex = 15;
			this.lbl_H.Text = "H";
			// 
			// AngleH
			// 
			this.AngleH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.AngleH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.AngleH.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AngleH.Location = new System.Drawing.Point(175, 376);
			this.AngleH.Name = "AngleH";
			this.AngleH.Size = new System.Drawing.Size(42, 25);
			this.AngleH.TabIndex = 14;
			this.AngleH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbl_V
			// 
			this.lbl_V.AutoSize = true;
			this.lbl_V.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_V.Location = new System.Drawing.Point(224, 378);
			this.lbl_V.Name = "lbl_V";
			this.lbl_V.Size = new System.Drawing.Size(16, 17);
			this.lbl_V.TabIndex = 17;
			this.lbl_V.Text = "V";
			// 
			// AngleV
			// 
			this.AngleV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.AngleV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.AngleV.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AngleV.Location = new System.Drawing.Point(241, 376);
			this.AngleV.Name = "AngleV";
			this.AngleV.Size = new System.Drawing.Size(42, 25);
			this.AngleV.TabIndex = 16;
			this.AngleV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// LensAngle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 414);
			this.Controls.Add(this.lbl_V);
			this.Controls.Add(this.AngleV);
			this.Controls.Add(this.lbl_H);
			this.Controls.Add(this.AngleH);
			this.Controls.Add(this.lbl_APS_C);
			this.Controls.Add(this.Lens_Apsc);
			this.Controls.Add(this.lbl_35mm);
			this.Controls.Add(this.Lens_35mm);
			this.Controls.Add(this.lbl_Diagonal);
			this.Controls.Add(this.DiagonalAngle);
			this.Controls.Add(this.hScrollBar1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "LensAngle";
			this.Text = "LensAngleForm";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.TextBox DiagonalAngle;
		private System.Windows.Forms.Label lbl_Diagonal;
		private System.Windows.Forms.Label lbl_35mm;
		private System.Windows.Forms.TextBox Lens_35mm;
		private System.Windows.Forms.Label lbl_APS_C;
		private System.Windows.Forms.TextBox Lens_Apsc;
		private System.Windows.Forms.Label lbl_H;
		private System.Windows.Forms.TextBox AngleH;
		private System.Windows.Forms.Label lbl_V;
		private System.Windows.Forms.TextBox AngleV;
	}
}

