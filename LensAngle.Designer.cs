
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
			this.lbl_35mm = new System.Windows.Forms.Label();
			this.Lens_35mm = new System.Windows.Forms.TextBox();
			this.lbl_APS_C = new System.Windows.Forms.Label();
			this.Lens_Apsc = new System.Windows.Forms.TextBox();
			this.AngleH = new System.Windows.Forms.TextBox();
			this.AngleV = new System.Windows.Forms.TextBox();
			this.chkDiagonal = new System.Windows.Forms.CheckBox();
			this.chkHorizontal = new System.Windows.Forms.CheckBox();
			this.chkVertical = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
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
			this.DiagonalAngle.Location = new System.Drawing.Point(48, 383);
			this.DiagonalAngle.Multiline = true;
			this.DiagonalAngle.Name = "DiagonalAngle";
			this.DiagonalAngle.Size = new System.Drawing.Size(52, 27);
			this.DiagonalAngle.TabIndex = 8;
			this.DiagonalAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbl_35mm
			// 
			this.lbl_35mm.AutoSize = true;
			this.lbl_35mm.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_35mm.Location = new System.Drawing.Point(361, 364);
			this.lbl_35mm.Name = "lbl_35mm";
			this.lbl_35mm.Size = new System.Drawing.Size(65, 17);
			this.lbl_35mm.TabIndex = 11;
			this.lbl_35mm.Text = "35mm  f=";
			// 
			// Lens_35mm
			// 
			this.Lens_35mm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Lens_35mm.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Lens_35mm.Location = new System.Drawing.Point(431, 362);
			this.Lens_35mm.Name = "Lens_35mm";
			this.Lens_35mm.Size = new System.Drawing.Size(43, 25);
			this.Lens_35mm.TabIndex = 10;
			this.Lens_35mm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbl_APS_C
			// 
			this.lbl_APS_C.AutoSize = true;
			this.lbl_APS_C.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_APS_C.Location = new System.Drawing.Point(361, 390);
			this.lbl_APS_C.Name = "lbl_APS_C";
			this.lbl_APS_C.Size = new System.Drawing.Size(64, 17);
			this.lbl_APS_C.TabIndex = 13;
			this.lbl_APS_C.Text = "APS-C  f=";
			// 
			// Lens_Apsc
			// 
			this.Lens_Apsc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Lens_Apsc.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Lens_Apsc.Location = new System.Drawing.Point(431, 388);
			this.Lens_Apsc.Name = "Lens_Apsc";
			this.Lens_Apsc.Size = new System.Drawing.Size(43, 25);
			this.Lens_Apsc.TabIndex = 12;
			this.Lens_Apsc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// AngleH
			// 
			this.AngleH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.AngleH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.AngleH.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AngleH.Location = new System.Drawing.Point(153, 383);
			this.AngleH.Name = "AngleH";
			this.AngleH.Size = new System.Drawing.Size(42, 25);
			this.AngleH.TabIndex = 14;
			this.AngleH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// AngleV
			// 
			this.AngleV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.AngleV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.AngleV.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AngleV.Location = new System.Drawing.Point(267, 383);
			this.AngleV.Name = "AngleV";
			this.AngleV.Size = new System.Drawing.Size(42, 25);
			this.AngleV.TabIndex = 16;
			this.AngleV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// chkDiagonal
			// 
			this.chkDiagonal.AutoSize = true;
			this.chkDiagonal.Location = new System.Drawing.Point(29, 362);
			this.chkDiagonal.Name = "chkDiagonal";
			this.chkDiagonal.Size = new System.Drawing.Size(102, 19);
			this.chkDiagonal.TabIndex = 18;
			this.chkDiagonal.Text = "対角/Diagonal";
			this.chkDiagonal.UseVisualStyleBackColor = true;
			this.chkDiagonal.CheckedChanged += new System.EventHandler(this.chkDiagonal_CheckedChanged);
			// 
			// chkHorizontal
			// 
			this.chkHorizontal.AutoSize = true;
			this.chkHorizontal.Location = new System.Drawing.Point(134, 362);
			this.chkHorizontal.Name = "chkHorizontal";
			this.chkHorizontal.Size = new System.Drawing.Size(110, 19);
			this.chkHorizontal.TabIndex = 19;
			this.chkHorizontal.Text = "水平/Horizontal";
			this.chkHorizontal.UseVisualStyleBackColor = true;
			this.chkHorizontal.CheckedChanged += new System.EventHandler(this.chkHorizontal_CheckedChanged);
			// 
			// chkVertical
			// 
			this.chkVertical.AutoSize = true;
			this.chkVertical.Location = new System.Drawing.Point(247, 362);
			this.chkVertical.Name = "chkVertical";
			this.chkVertical.Size = new System.Drawing.Size(93, 19);
			this.chkVertical.TabIndex = 20;
			this.chkVertical.Text = "垂直/Vertical";
			this.chkVertical.UseVisualStyleBackColor = true;
			this.chkVertical.CheckedChanged += new System.EventHandler(this.chkVertical_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(480, 366);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 15);
			this.label1.TabIndex = 21;
			this.label1.Text = "mm";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(480, 390);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 15);
			this.label2.TabIndex = 22;
			this.label2.Text = "mm";
			// 
			// LensAngle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(510, 414);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chkVertical);
			this.Controls.Add(this.chkHorizontal);
			this.Controls.Add(this.chkDiagonal);
			this.Controls.Add(this.AngleV);
			this.Controls.Add(this.AngleH);
			this.Controls.Add(this.lbl_APS_C);
			this.Controls.Add(this.Lens_Apsc);
			this.Controls.Add(this.lbl_35mm);
			this.Controls.Add(this.Lens_35mm);
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
		private System.Windows.Forms.Label lbl_35mm;
		private System.Windows.Forms.TextBox Lens_35mm;
		private System.Windows.Forms.Label lbl_APS_C;
		private System.Windows.Forms.TextBox Lens_Apsc;
		private System.Windows.Forms.TextBox AngleH;
		private System.Windows.Forms.TextBox AngleV;
		private System.Windows.Forms.CheckBox chkDiagonal;
		private System.Windows.Forms.CheckBox chkHorizontal;
		private System.Windows.Forms.CheckBox chkVertical;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

