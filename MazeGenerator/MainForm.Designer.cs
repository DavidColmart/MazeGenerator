/*
 * Created by SharpDevelop.
 * User: Utilisateur
 * Date: 09/12/2016
 * Time: 00:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MazeGenerator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox Canvas;
		private System.Windows.Forms.Timer GameTimer;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Canvas = new System.Windows.Forms.PictureBox();
			this.GameTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
			this.SuspendLayout();
			// 
			// Canvas
			// 
			this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canvas.Location = new System.Drawing.Point(0, 0);
			this.Canvas.Name = "Canvas";
			this.Canvas.Size = new System.Drawing.Size(800, 800);
			this.Canvas.TabIndex = 0;
			this.Canvas.TabStop = false;
			// 
			// GameTimer
			// 
			this.GameTimer.Tick += new System.EventHandler(this.GameTimerTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 800);
			this.Controls.Add(this.Canvas);
			this.Name = "MainForm";
			this.Text = "MazeGenerator";
			((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
