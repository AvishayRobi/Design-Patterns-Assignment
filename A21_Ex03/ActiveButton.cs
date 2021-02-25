using System;
using System.Windows.Forms;
using System.Drawing;
using ControlFlicker;

namespace A21_Ex02
{
	public class ActiveButton : Button
	{
		// Data members
		private ControlFlicker.ControlFlicker m_Flicker = new ControlFlicker.ControlFlicker();

		// Methods
		public void Flick()
		{
			m_Flicker.Flick(this);
		}
	}
}