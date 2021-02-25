using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlFlicker
{
    public class ControlFlicker
    {
		// Data members
		private readonly ushort r_FlickerFactor = 5;
		private readonly ushort r_ThreadSleepFactor = 20;
		
		// Methods
		public void Flick(Control i_Control)
		{
			for (int i = 0; i < r_FlickerFactor; i++)
			{
				System.Threading.Thread.Sleep(r_ThreadSleepFactor);
				i_Control.Visible = false;
				System.Threading.Thread.Sleep(r_ThreadSleepFactor);
				i_Control.Visible = true;
			}
		}	
	}
}
