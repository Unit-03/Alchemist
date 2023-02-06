using System;

using Eto.Drawing;
using Eto.Forms;

namespace Alchemist
{
	internal class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			new Application(Eto.Platform.Detect).Run(new MainForm());
		}
	}
}
