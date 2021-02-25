using System.Windows.Forms;

namespace A21_Ex02
{
	public class ActiveLabel : Label
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