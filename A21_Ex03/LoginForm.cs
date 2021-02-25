using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;

namespace A21_Ex02
{
	public partial class LoginForm : Form
	{
		// Constructor
		public LoginForm()
		{
			InitializeComponent();
			FacebookService.s_FbApiVersion = 2.8f;
			FacebookService.s_CollectionLimit = 200;
			MaximizeBox = false;
		}

		// Methods
		private void start_Click(object sender, EventArgs e)
		{
			MainForm nextForm = new MainForm();

			Hide();
			nextForm.ShowDialog();
			Close();
		}		
	}
}
