using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MazeGenerator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void GameTimerTick(object sender, EventArgs e)
		{
			//invalide le contenu du Canvas ce qui entraine sa repeinte
			Canvas.Invalidate();
		}
	}
}
