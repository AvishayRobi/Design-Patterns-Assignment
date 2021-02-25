namespace A21_Ex02
{
	partial class FindMatchForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindMatchForm));
			this.label1 = new System.Windows.Forms.Label();
			this.findMatchLabel = new System.Windows.Forms.Label();
			this.questionLabel = new System.Windows.Forms.Label();
			this.nextQuestionButton = new System.Windows.Forms.Button();
			this.answersListBox = new System.Windows.Forms.ComboBox();
			this.backButton = new System.Windows.Forms.Button();
			this.resultsButton = new System.Windows.Forms.Button();
			this.nextMatchButton = new System.Windows.Forms.Button();
			this.gamePicture = new System.Windows.Forms.PictureBox();
			this.matchedNameLabel = new System.Windows.Forms.Label();
			this.labelProfilePicture = new System.Windows.Forms.Label();
			this.labelFullName = new System.Windows.Forms.Label();
			this.matchedProfilePictureOld = new System.Windows.Forms.PictureBox();
			this.matchedProfilePicture = new A21_Ex02.PictureBoxProxy();
			((System.ComponentModel.ISupportInitialize)(this.gamePicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.matchedProfilePictureOld)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.matchedProfilePicture)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(296, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 0;
			// 
			// findMatchLabel
			// 
			this.findMatchLabel.AllowDrop = true;
			this.findMatchLabel.AutoEllipsis = true;
			this.findMatchLabel.BackColor = System.Drawing.Color.Black;
			this.findMatchLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.findMatchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
			this.findMatchLabel.ForeColor = System.Drawing.Color.White;
			this.findMatchLabel.Location = new System.Drawing.Point(167, 31);
			this.findMatchLabel.Name = "findMatchLabel";
			this.findMatchLabel.Size = new System.Drawing.Size(356, 56);
			this.findMatchLabel.TabIndex = 3;
			this.findMatchLabel.Text = "Find a Significant Other";
			this.findMatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.findMatchLabel.UseMnemonic = false;
			// 
			// questionLabel
			// 
			this.questionLabel.AutoSize = true;
			this.questionLabel.BackColor = System.Drawing.Color.Black;
			this.questionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.questionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
			this.questionLabel.ForeColor = System.Drawing.Color.White;
			this.questionLabel.Location = new System.Drawing.Point(29, 121);
			this.questionLabel.Name = "questionLabel";
			this.questionLabel.Size = new System.Drawing.Size(221, 25);
			this.questionLabel.TabIndex = 4;
			this.questionLabel.Text = " Please Choose a Gender";
			this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nextQuestionButton
			// 
			this.nextQuestionButton.BackColor = System.Drawing.Color.Black;
			this.nextQuestionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextQuestionButton.BackgroundImage")));
			this.nextQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.nextQuestionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nextQuestionButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.nextQuestionButton.Location = new System.Drawing.Point(49, 217);
			this.nextQuestionButton.Name = "nextQuestionButton";
			this.nextQuestionButton.Size = new System.Drawing.Size(171, 28);
			this.nextQuestionButton.TabIndex = 6;
			this.nextQuestionButton.Text = "Next Question";
			this.nextQuestionButton.UseVisualStyleBackColor = false;
			this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
			// 
			// answersListBox
			// 
			this.answersListBox.BackColor = System.Drawing.Color.White;
			this.answersListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.answersListBox.FormattingEnabled = true;
			this.answersListBox.Items.AddRange(new object[] {
            "Aguarius",
            "Pisces",
            "Aries",
            "Taurus",
            "Gemini",
            "Cancer",
            "Leo",
            "Virgo",
            "Libra",
            "Scorpio",
            "Sagittarius",
            "Capricorn"});
			this.answersListBox.Location = new System.Drawing.Point(31, 161);
			this.answersListBox.Name = "answersListBox";
			this.answersListBox.Size = new System.Drawing.Size(218, 29);
			this.answersListBox.TabIndex = 7;
			this.answersListBox.Text = "M";
			// 
			// backButton
			// 
			this.backButton.BackColor = System.Drawing.Color.Maroon;
			this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
			this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.backButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
			this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.backButton.Location = new System.Drawing.Point(13, 8);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(120, 23);
			this.backButton.TabIndex = 8;
			this.backButton.Text = "Back";
			this.backButton.UseVisualStyleBackColor = false;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// resultsButton
			// 
			this.resultsButton.BackColor = System.Drawing.Color.Black;
			this.resultsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resultsButton.BackgroundImage")));
			this.resultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.resultsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.resultsButton.Location = new System.Drawing.Point(49, 266);
			this.resultsButton.Name = "resultsButton";
			this.resultsButton.Size = new System.Drawing.Size(171, 45);
			this.resultsButton.TabIndex = 10;
			this.resultsButton.Text = "Results";
			this.resultsButton.UseVisualStyleBackColor = false;
			this.resultsButton.Visible = false;
			this.resultsButton.Click += new System.EventHandler(this.showResultsButton_Click);
			// 
			// nextMatchButton
			// 
			this.nextMatchButton.BackColor = System.Drawing.Color.Black;
			this.nextMatchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextMatchButton.BackgroundImage")));
			this.nextMatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.nextMatchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nextMatchButton.ForeColor = System.Drawing.Color.White;
			this.nextMatchButton.Location = new System.Drawing.Point(389, 338);
			this.nextMatchButton.Name = "nextMatchButton";
			this.nextMatchButton.Size = new System.Drawing.Size(153, 33);
			this.nextMatchButton.TabIndex = 11;
			this.nextMatchButton.Text = "Next Match";
			this.nextMatchButton.UseVisualStyleBackColor = false;
			this.nextMatchButton.Visible = false;
			this.nextMatchButton.Click += new System.EventHandler(this.nextMatchButton_Click);
			// 
			// gamePicture
			// 
			this.gamePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gamePicture.BackColor = System.Drawing.Color.Transparent;
			this.gamePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gamePicture.BackgroundImage")));
			this.gamePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.gamePicture.ErrorImage = null;
			this.gamePicture.InitialImage = null;
			this.gamePicture.Location = new System.Drawing.Point(0, -2);
			this.gamePicture.Name = "gamePicture";
			this.gamePicture.Size = new System.Drawing.Size(696, 409);
			this.gamePicture.TabIndex = 13;
			this.gamePicture.TabStop = false;
			this.gamePicture.WaitOnLoad = true;
			// 
			// matchedNameLabel
			// 
			this.matchedNameLabel.AutoSize = true;
			this.matchedNameLabel.BackColor = System.Drawing.Color.Black;
			this.matchedNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.matchedNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
			this.matchedNameLabel.ForeColor = System.Drawing.Color.White;
			this.matchedNameLabel.Location = new System.Drawing.Point(393, 300);
			this.matchedNameLabel.Name = "matchedNameLabel";
			this.matchedNameLabel.Size = new System.Drawing.Size(145, 25);
			this.matchedNameLabel.TabIndex = 14;
			this.matchedNameLabel.Text = "Matched Name";
			this.matchedNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelProfilePicture
			// 
			this.labelProfilePicture.AutoSize = true;
			this.labelProfilePicture.BackColor = System.Drawing.Color.Transparent;
			this.labelProfilePicture.ForeColor = System.Drawing.Color.Black;
			this.labelProfilePicture.Location = new System.Drawing.Point(321, 94);
			this.labelProfilePicture.Name = "labelProfilePicture";
			this.labelProfilePicture.Size = new System.Drawing.Size(72, 13);
			this.labelProfilePicture.TabIndex = 15;
			this.labelProfilePicture.Text = "ProfilePicture:";
			// 
			// labelFullName
			// 
			this.labelFullName.AutoSize = true;
			this.labelFullName.BackColor = System.Drawing.Color.Transparent;
			this.labelFullName.Location = new System.Drawing.Point(321, 281);
			this.labelFullName.Name = "labelFullName";
			this.labelFullName.Size = new System.Drawing.Size(57, 13);
			this.labelFullName.TabIndex = 16;
			this.labelFullName.Text = "Full Name:";
			// 
			// matchedProfilePictureOld
			// 
			this.matchedProfilePictureOld.Location = new System.Drawing.Point(262, 123);
			this.matchedProfilePictureOld.Name = "matchedProfilePictureOld";
			this.matchedProfilePictureOld.Size = new System.Drawing.Size(34, 23);
			this.matchedProfilePictureOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.matchedProfilePictureOld.TabIndex = 9;
			this.matchedProfilePictureOld.TabStop = false;
			this.matchedProfilePictureOld.Visible = false;
			// 
			// matchedProfilePicture
			// 
			this.matchedProfilePicture.Location = new System.Drawing.Point(373, 114);
			this.matchedProfilePicture.Name = "matchedProfilePicture";
			this.matchedProfilePicture.Size = new System.Drawing.Size(193, 161);
			this.matchedProfilePicture.TabIndex = 17;
			this.matchedProfilePicture.TabStop = false;
			this.matchedProfilePicture.Visible = false;
			// 
			// FindMatchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(690, 401);
			this.Controls.Add(this.matchedProfilePicture);
			this.Controls.Add(this.labelFullName);
			this.Controls.Add(this.labelProfilePicture);
			this.Controls.Add(this.matchedNameLabel);
			this.Controls.Add(this.nextMatchButton);
			this.Controls.Add(this.resultsButton);
			this.Controls.Add(this.matchedProfilePictureOld);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.answersListBox);
			this.Controls.Add(this.nextQuestionButton);
			this.Controls.Add(this.questionLabel);
			this.Controls.Add(this.findMatchLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gamePicture);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FindMatchForm";
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Find a Match";
			((System.ComponentModel.ISupportInitialize)(this.gamePicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.matchedProfilePictureOld)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.matchedProfilePicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label findMatchLabel;
		private System.Windows.Forms.Label questionLabel;
		private System.Windows.Forms.Button nextQuestionButton;
		private System.Windows.Forms.ComboBox answersListBox;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Button resultsButton;
		private System.Windows.Forms.Button nextMatchButton;
		private System.Windows.Forms.PictureBox gamePicture;
		private System.Windows.Forms.Label matchedNameLabel;
		private System.Windows.Forms.Label labelProfilePicture;
		private System.Windows.Forms.Label labelFullName;
		private System.Windows.Forms.PictureBox matchedProfilePictureOld;
		private PictureBoxProxy matchedProfilePicture;
	}
}