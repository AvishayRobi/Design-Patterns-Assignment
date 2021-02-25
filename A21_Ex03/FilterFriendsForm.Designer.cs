namespace A21_Ex02
{
	partial class FilterFriendsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterFriendsForm));
			this.backButton = new System.Windows.Forms.Button();
			this.checkBoxMales = new System.Windows.Forms.CheckBox();
			this.checkBoxFemales = new System.Windows.Forms.CheckBox();
			this.buttonGoOld = new System.Windows.Forms.Button();
			this.groupBoxFilteredFriends = new System.Windows.Forms.GroupBox();
			this.checkBoxMyCity = new System.Windows.Forms.CheckBox();
			this.checkBoxSingles = new System.Windows.Forms.CheckBox();
			this.checkBoxMyReligion = new System.Windows.Forms.CheckBox();
			this.buttonGo = new A21_Ex02.ActiveButton();
			this.SuspendLayout();
			// 
			// backButton
			// 
			this.backButton.BackColor = System.Drawing.Color.Transparent;
			this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
			this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.backButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
			this.backButton.ForeColor = System.Drawing.Color.White;
			this.backButton.Location = new System.Drawing.Point(12, 12);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(120, 22);
			this.backButton.TabIndex = 10;
			this.backButton.Text = "Back";
			this.backButton.UseVisualStyleBackColor = false;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// checkBoxMales
			// 
			this.checkBoxMales.AutoSize = true;
			this.checkBoxMales.BackColor = System.Drawing.Color.Black;
			this.checkBoxMales.ForeColor = System.Drawing.Color.White;
			this.checkBoxMales.Location = new System.Drawing.Point(304, 57);
			this.checkBoxMales.Name = "checkBoxMales";
			this.checkBoxMales.Size = new System.Drawing.Size(54, 17);
			this.checkBoxMales.TabIndex = 11;
			this.checkBoxMales.Text = "Males";
			this.checkBoxMales.UseVisualStyleBackColor = false;
			// 
			// checkBoxFemales
			// 
			this.checkBoxFemales.AutoSize = true;
			this.checkBoxFemales.BackColor = System.Drawing.Color.Black;
			this.checkBoxFemales.ForeColor = System.Drawing.Color.White;
			this.checkBoxFemales.Location = new System.Drawing.Point(304, 95);
			this.checkBoxFemales.Name = "checkBoxFemales";
			this.checkBoxFemales.Size = new System.Drawing.Size(65, 17);
			this.checkBoxFemales.TabIndex = 12;
			this.checkBoxFemales.Text = "Females";
			this.checkBoxFemales.UseVisualStyleBackColor = false;
			// 
			// buttonGoOld
			// 
			this.buttonGoOld.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGoOld.BackgroundImage")));
			this.buttonGoOld.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonGoOld.ForeColor = System.Drawing.Color.White;
			this.buttonGoOld.Location = new System.Drawing.Point(549, 150);
			this.buttonGoOld.Name = "buttonGoOld";
			this.buttonGoOld.Size = new System.Drawing.Size(10, 10);
			this.buttonGoOld.TabIndex = 13;
			this.buttonGoOld.Text = "Go";
			this.buttonGoOld.UseVisualStyleBackColor = true;
			this.buttonGoOld.Visible = false;
			this.buttonGoOld.Click += new System.EventHandler(this.buttonGo_Click);
			// 
			// groupBoxFilteredFriends
			// 
			this.groupBoxFilteredFriends.Location = new System.Drawing.Point(12, 57);
			this.groupBoxFilteredFriends.Name = "groupBoxFilteredFriends";
			this.groupBoxFilteredFriends.Size = new System.Drawing.Size(259, 250);
			this.groupBoxFilteredFriends.TabIndex = 14;
			this.groupBoxFilteredFriends.TabStop = false;
			this.groupBoxFilteredFriends.Text = " ";
			// 
			// checkBoxMyCity
			// 
			this.checkBoxMyCity.AutoSize = true;
			this.checkBoxMyCity.BackColor = System.Drawing.Color.Black;
			this.checkBoxMyCity.ForeColor = System.Drawing.Color.White;
			this.checkBoxMyCity.Location = new System.Drawing.Point(304, 134);
			this.checkBoxMyCity.Name = "checkBoxMyCity";
			this.checkBoxMyCity.Size = new System.Drawing.Size(60, 17);
			this.checkBoxMyCity.TabIndex = 15;
			this.checkBoxMyCity.Text = "My City";
			this.checkBoxMyCity.UseVisualStyleBackColor = false;
			// 
			// checkBoxSingles
			// 
			this.checkBoxSingles.AutoSize = true;
			this.checkBoxSingles.BackColor = System.Drawing.Color.Black;
			this.checkBoxSingles.ForeColor = System.Drawing.Color.White;
			this.checkBoxSingles.Location = new System.Drawing.Point(304, 173);
			this.checkBoxSingles.Name = "checkBoxSingles";
			this.checkBoxSingles.Size = new System.Drawing.Size(60, 17);
			this.checkBoxSingles.TabIndex = 16;
			this.checkBoxSingles.Text = "Singles";
			this.checkBoxSingles.UseVisualStyleBackColor = false;
			// 
			// checkBoxMyReligion
			// 
			this.checkBoxMyReligion.AutoSize = true;
			this.checkBoxMyReligion.BackColor = System.Drawing.Color.Black;
			this.checkBoxMyReligion.ForeColor = System.Drawing.Color.White;
			this.checkBoxMyReligion.Location = new System.Drawing.Point(304, 212);
			this.checkBoxMyReligion.Name = "checkBoxMyReligion";
			this.checkBoxMyReligion.Size = new System.Drawing.Size(81, 17);
			this.checkBoxMyReligion.TabIndex = 17;
			this.checkBoxMyReligion.Text = "My Religion";
			this.checkBoxMyReligion.UseVisualStyleBackColor = false;
			// 
			// buttonGo
			// 
			this.buttonGo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGo.BackgroundImage")));
			this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonGo.ForeColor = System.Drawing.Color.White;
			this.buttonGo.Location = new System.Drawing.Point(436, 144);
			this.buttonGo.Name = "buttonGo";
			this.buttonGo.Size = new System.Drawing.Size(75, 23);
			this.buttonGo.TabIndex = 18;
			this.buttonGo.Text = "Go";
			this.buttonGo.UseVisualStyleBackColor = true;
			this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
			// 
			// FilterFriendsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(571, 334);
			this.Controls.Add(this.buttonGo);
			this.Controls.Add(this.checkBoxMyReligion);
			this.Controls.Add(this.checkBoxSingles);
			this.Controls.Add(this.checkBoxMyCity);
			this.Controls.Add(this.groupBoxFilteredFriends);
			this.Controls.Add(this.buttonGoOld);
			this.Controls.Add(this.checkBoxFemales);
			this.Controls.Add(this.checkBoxMales);
			this.Controls.Add(this.backButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FilterFriendsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Filter Friends";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.CheckBox checkBoxMales;
		private System.Windows.Forms.CheckBox checkBoxFemales;
		private System.Windows.Forms.Button buttonGoOld;
		private System.Windows.Forms.GroupBox groupBoxFilteredFriends;
		private System.Windows.Forms.CheckBox checkBoxMyCity;
		private System.Windows.Forms.CheckBox checkBoxSingles;
		private System.Windows.Forms.CheckBox checkBoxMyReligion;
		private ActiveButton buttonGo;
	}
}