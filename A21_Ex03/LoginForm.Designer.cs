namespace A21_Ex02
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.RunButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// RunButton
			// 
			this.RunButton.BackColor = System.Drawing.Color.Black;
			this.RunButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RunButton.BackgroundImage")));
			this.RunButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.RunButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.RunButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
			this.RunButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.RunButton.Location = new System.Drawing.Point(136, 116);
			this.RunButton.Name = "RunButton";
			this.RunButton.Size = new System.Drawing.Size(202, 76);
			this.RunButton.TabIndex = 0;
			this.RunButton.Text = "Run";
			this.RunButton.UseVisualStyleBackColor = false;
			this.RunButton.Click += new System.EventHandler(this.start_Click);
			// 
			// LoginForm
			// 
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(477, 237);
			this.Controls.Add(this.RunButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Opening Form";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button RunButton;
	}
}