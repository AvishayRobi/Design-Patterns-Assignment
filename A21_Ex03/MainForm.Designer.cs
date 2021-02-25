namespace A21_Ex02
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label birthdayLabel;
			System.Windows.Forms.Label emailLabel;
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label religionLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.HomePageTab = new System.Windows.Forms.TabControl();
			this.homeTab = new System.Windows.Forms.TabPage();
			this.panelDataBindingAboutInfo = new System.Windows.Forms.Panel();
			this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.religionTextBox = new System.Windows.Forms.TextBox();
			this.coverPictureBox = new A21_Ex02.PictureBoxProxy();
			this.profilePicPictureBox = new A21_Ex02.PictureBoxProxy();
			this.coverPhotoLabel = new System.Windows.Forms.Label();
			this.profilePictureLabel = new System.Windows.Forms.Label();
			this.logOutButton = new System.Windows.Forms.Button();
			this.lastPostsLabel = new System.Windows.Forms.Label();
			this.checkinsLabel = new System.Windows.Forms.Label();
			this.friendsLabel = new System.Windows.Forms.Label();
			this.aboutInfoLabel = new System.Windows.Forms.Label();
			this.personalInfoListBox = new System.Windows.Forms.ListBox();
			this.friendsListBox = new System.Windows.Forms.ListBox();
			this.checkinsListBox = new System.Windows.Forms.ListBox();
			this.lastPostsListBox = new System.Windows.Forms.ListBox();
			this.WelcomeLabelOld = new System.Windows.Forms.Label();
			this.filterFriendsTab = new System.Windows.Forms.TabPage();
			this.goFilterYourFriendsButton = new System.Windows.Forms.Button();
			this.filterFriendsWelcomeLabel = new System.Windows.Forms.Label();
			this.findSignificantOtherTab = new System.Windows.Forms.TabPage();
			this.findSignificantOtherWelcomeLabel = new System.Windows.Forms.Label();
			this.goFindSignificantOtherButton = new System.Windows.Forms.Button();
			this.WelcomeLabel = new A21_Ex02.ActiveLabel();
			birthdayLabel = new System.Windows.Forms.Label();
			emailLabel = new System.Windows.Forms.Label();
			nameLabel = new System.Windows.Forms.Label();
			religionLabel = new System.Windows.Forms.Label();
			this.HomePageTab.SuspendLayout();
			this.homeTab.SuspendLayout();
			this.panelDataBindingAboutInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.profilePicPictureBox)).BeginInit();
			this.filterFriendsTab.SuspendLayout();
			this.findSignificantOtherTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// birthdayLabel
			// 
			birthdayLabel.AutoSize = true;
			birthdayLabel.Location = new System.Drawing.Point(9, 15);
			birthdayLabel.Name = "birthdayLabel";
			birthdayLabel.Size = new System.Drawing.Size(53, 13);
			birthdayLabel.TabIndex = 0;
			birthdayLabel.Text = "Birthday:";
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Location = new System.Drawing.Point(9, 54);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new System.Drawing.Size(38, 13);
			emailLabel.TabIndex = 2;
			emailLabel.Text = "Email:";
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(9, 93);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(40, 13);
			nameLabel.TabIndex = 4;
			nameLabel.Text = "Name:";
			// 
			// religionLabel
			// 
			religionLabel.AutoSize = true;
			religionLabel.Location = new System.Drawing.Point(9, 128);
			religionLabel.Name = "religionLabel";
			religionLabel.Size = new System.Drawing.Size(52, 13);
			religionLabel.TabIndex = 6;
			religionLabel.Text = "Religion:";
			// 
			// HomePageTab
			// 
			this.HomePageTab.Controls.Add(this.homeTab);
			this.HomePageTab.Controls.Add(this.filterFriendsTab);
			this.HomePageTab.Controls.Add(this.findSignificantOtherTab);
			this.HomePageTab.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.HomePageTab.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
			this.HomePageTab.Location = new System.Drawing.Point(2, 2);
			this.HomePageTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.HomePageTab.Name = "HomePageTab";
			this.HomePageTab.SelectedIndex = 0;
			this.HomePageTab.ShowToolTips = true;
			this.HomePageTab.Size = new System.Drawing.Size(795, 594);
			this.HomePageTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.HomePageTab.TabIndex = 0;
			this.HomePageTab.TabStop = false;
			// 
			// homeTab
			// 
			this.homeTab.AutoScroll = true;
			this.homeTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeTab.BackgroundImage")));
			this.homeTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.homeTab.Controls.Add(this.WelcomeLabel);
			this.homeTab.Controls.Add(this.panelDataBindingAboutInfo);
			this.homeTab.Controls.Add(this.coverPictureBox);
			this.homeTab.Controls.Add(this.profilePicPictureBox);
			this.homeTab.Controls.Add(this.coverPhotoLabel);
			this.homeTab.Controls.Add(this.profilePictureLabel);
			this.homeTab.Controls.Add(this.logOutButton);
			this.homeTab.Controls.Add(this.lastPostsLabel);
			this.homeTab.Controls.Add(this.checkinsLabel);
			this.homeTab.Controls.Add(this.friendsLabel);
			this.homeTab.Controls.Add(this.aboutInfoLabel);
			this.homeTab.Controls.Add(this.personalInfoListBox);
			this.homeTab.Controls.Add(this.friendsListBox);
			this.homeTab.Controls.Add(this.checkinsListBox);
			this.homeTab.Controls.Add(this.lastPostsListBox);
			this.homeTab.Controls.Add(this.WelcomeLabelOld);
			this.homeTab.Location = new System.Drawing.Point(4, 22);
			this.homeTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.homeTab.Name = "homeTab";
			this.homeTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.homeTab.Size = new System.Drawing.Size(787, 568);
			this.homeTab.TabIndex = 0;
			this.homeTab.Text = "Home";
			this.homeTab.UseVisualStyleBackColor = true;
			// 
			// panelDataBindingAboutInfo
			// 
			this.panelDataBindingAboutInfo.BackColor = System.Drawing.Color.Lavender;
			this.panelDataBindingAboutInfo.Controls.Add(birthdayLabel);
			this.panelDataBindingAboutInfo.Controls.Add(this.birthdayDateTimePicker);
			this.panelDataBindingAboutInfo.Controls.Add(emailLabel);
			this.panelDataBindingAboutInfo.Controls.Add(this.emailTextBox);
			this.panelDataBindingAboutInfo.Controls.Add(nameLabel);
			this.panelDataBindingAboutInfo.Controls.Add(this.nameTextBox);
			this.panelDataBindingAboutInfo.Controls.Add(religionLabel);
			this.panelDataBindingAboutInfo.Controls.Add(this.religionTextBox);
			this.panelDataBindingAboutInfo.Location = new System.Drawing.Point(566, 206);
			this.panelDataBindingAboutInfo.Name = "panelDataBindingAboutInfo";
			this.panelDataBindingAboutInfo.Size = new System.Drawing.Size(220, 159);
			this.panelDataBindingAboutInfo.TabIndex = 16;
			// 
			// birthdayDateTimePicker
			// 
			this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "Birthday", true));
			this.birthdayDateTimePicker.Location = new System.Drawing.Point(68, 11);
			this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
			this.birthdayDateTimePicker.Size = new System.Drawing.Size(145, 22);
			this.birthdayDateTimePicker.TabIndex = 1;
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// emailTextBox
			// 
			this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
			this.emailTextBox.Location = new System.Drawing.Point(68, 51);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(145, 22);
			this.emailTextBox.TabIndex = 3;
			// 
			// nameTextBox
			// 
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
			this.nameTextBox.Location = new System.Drawing.Point(68, 90);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(145, 22);
			this.nameTextBox.TabIndex = 5;
			// 
			// religionTextBox
			// 
			this.religionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Religion", true));
			this.religionTextBox.Location = new System.Drawing.Point(68, 125);
			this.religionTextBox.Name = "religionTextBox";
			this.religionTextBox.Size = new System.Drawing.Size(145, 22);
			this.religionTextBox.TabIndex = 7;
			// 
			// coverPictureBox
			// 
			this.coverPictureBox.Location = new System.Drawing.Point(170, 43);
			this.coverPictureBox.Name = "coverPictureBox";
			this.coverPictureBox.Size = new System.Drawing.Size(388, 154);
			this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.coverPictureBox.TabIndex = 15;
			this.coverPictureBox.TabStop = false;
			// 
			// profilePicPictureBox
			// 
			this.profilePicPictureBox.Location = new System.Drawing.Point(8, 43);
			this.profilePicPictureBox.Name = "profilePicPictureBox";
			this.profilePicPictureBox.Size = new System.Drawing.Size(155, 151);
			this.profilePicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.profilePicPictureBox.TabIndex = 14;
			this.profilePicPictureBox.TabStop = false;
			// 
			// coverPhotoLabel
			// 
			this.coverPhotoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
			this.coverPhotoLabel.Location = new System.Drawing.Point(167, 17);
			this.coverPhotoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.coverPhotoLabel.Name = "coverPhotoLabel";
			this.coverPhotoLabel.Size = new System.Drawing.Size(90, 22);
			this.coverPhotoLabel.TabIndex = 13;
			this.coverPhotoLabel.Text = "Cover Photo:";
			this.coverPhotoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// profilePictureLabel
			// 
			this.profilePictureLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
			this.profilePictureLabel.Location = new System.Drawing.Point(13, 17);
			this.profilePictureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.profilePictureLabel.Name = "profilePictureLabel";
			this.profilePictureLabel.Size = new System.Drawing.Size(90, 22);
			this.profilePictureLabel.TabIndex = 12;
			this.profilePictureLabel.Text = "Profile Picture:";
			this.profilePictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// logOutButton
			// 
			this.logOutButton.BackColor = System.Drawing.Color.SeaShell;
			this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logOutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
			this.logOutButton.Location = new System.Drawing.Point(302, 513);
			this.logOutButton.Margin = new System.Windows.Forms.Padding(4);
			this.logOutButton.Name = "logOutButton";
			this.logOutButton.Size = new System.Drawing.Size(122, 41);
			this.logOutButton.TabIndex = 11;
			this.logOutButton.Text = "Log Out";
			this.logOutButton.UseVisualStyleBackColor = false;
			this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
			// 
			// lastPostsLabel
			// 
			this.lastPostsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
			this.lastPostsLabel.Location = new System.Drawing.Point(236, 236);
			this.lastPostsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lastPostsLabel.Name = "lastPostsLabel";
			this.lastPostsLabel.Size = new System.Drawing.Size(81, 30);
			this.lastPostsLabel.TabIndex = 10;
			this.lastPostsLabel.Text = "Last Posts:";
			this.lastPostsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lastPostsLabel.Click += new System.EventHandler(this.lastPostsLable_Click);
			// 
			// checkinsLabel
			// 
			this.checkinsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
			this.checkinsLabel.Location = new System.Drawing.Point(13, 368);
			this.checkinsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.checkinsLabel.Name = "checkinsLabel";
			this.checkinsLabel.Size = new System.Drawing.Size(80, 26);
			this.checkinsLabel.TabIndex = 9;
			this.checkinsLabel.Text = "Last Checkins:";
			this.checkinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkinsLabel.Click += new System.EventHandler(this.checkinsLabel_Click);
			// 
			// friendsLabel
			// 
			this.friendsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
			this.friendsLabel.Location = new System.Drawing.Point(563, 368);
			this.friendsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.friendsLabel.Name = "friendsLabel";
			this.friendsLabel.Size = new System.Drawing.Size(57, 21);
			this.friendsLabel.TabIndex = 8;
			this.friendsLabel.Text = "Friends:";
			this.friendsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.friendsLabel.Click += new System.EventHandler(this.friendsLabel_Click);
			// 
			// aboutInfoLabel
			// 
			this.aboutInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
			this.aboutInfoLabel.Location = new System.Drawing.Point(555, 9);
			this.aboutInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.aboutInfoLabel.Name = "aboutInfoLabel";
			this.aboutInfoLabel.Size = new System.Drawing.Size(90, 22);
			this.aboutInfoLabel.TabIndex = 7;
			this.aboutInfoLabel.Text = "About Info:";
			this.aboutInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// personalInfoListBox
			// 
			this.personalInfoListBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.personalInfoListBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.personalInfoListBox.DataSource = this.userBindingSource;
			this.personalInfoListBox.DisplayMember = "Name";
			this.personalInfoListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
			this.personalInfoListBox.FormattingEnabled = true;
			this.personalInfoListBox.ItemHeight = 15;
			this.personalInfoListBox.Location = new System.Drawing.Point(565, 43);
			this.personalInfoListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.personalInfoListBox.Name = "personalInfoListBox";
			this.personalInfoListBox.Size = new System.Drawing.Size(221, 154);
			this.personalInfoListBox.TabIndex = 5;
			// 
			// friendsListBox
			// 
			this.friendsListBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.friendsListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
			this.friendsListBox.FormattingEnabled = true;
			this.friendsListBox.ItemHeight = 15;
			this.friendsListBox.Location = new System.Drawing.Point(565, 399);
			this.friendsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.friendsListBox.Name = "friendsListBox";
			this.friendsListBox.Size = new System.Drawing.Size(221, 154);
			this.friendsListBox.TabIndex = 4;
			// 
			// checkinsListBox
			// 
			this.checkinsListBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.checkinsListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
			this.checkinsListBox.FormattingEnabled = true;
			this.checkinsListBox.HorizontalScrollbar = true;
			this.checkinsListBox.ItemHeight = 15;
			this.checkinsListBox.Location = new System.Drawing.Point(16, 399);
			this.checkinsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkinsListBox.Name = "checkinsListBox";
			this.checkinsListBox.Size = new System.Drawing.Size(167, 154);
			this.checkinsListBox.TabIndex = 3;
			// 
			// lastPostsListBox
			// 
			this.lastPostsListBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lastPostsListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
			this.lastPostsListBox.ForeColor = System.Drawing.Color.Black;
			this.lastPostsListBox.FormattingEnabled = true;
			this.lastPostsListBox.HorizontalScrollbar = true;
			this.lastPostsListBox.ItemHeight = 15;
			this.lastPostsListBox.Location = new System.Drawing.Point(239, 266);
			this.lastPostsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lastPostsListBox.Name = "lastPostsListBox";
			this.lastPostsListBox.Size = new System.Drawing.Size(267, 229);
			this.lastPostsListBox.TabIndex = 2;
			// 
			// WelcomeLabelOld
			// 
			this.WelcomeLabelOld.BackColor = System.Drawing.Color.LightSteelBlue;
			this.WelcomeLabelOld.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WelcomeLabelOld.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.WelcomeLabelOld.Location = new System.Drawing.Point(355, 247);
			this.WelcomeLabelOld.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.WelcomeLabelOld.Name = "WelcomeLabelOld";
			this.WelcomeLabelOld.Size = new System.Drawing.Size(10, 10);
			this.WelcomeLabelOld.TabIndex = 1;
			this.WelcomeLabelOld.Text = "Welcome messege";
			this.WelcomeLabelOld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.WelcomeLabelOld.Visible = false;
			// 
			// filterFriendsTab
			// 
			this.filterFriendsTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("filterFriendsTab.BackgroundImage")));
			this.filterFriendsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.filterFriendsTab.Controls.Add(this.goFilterYourFriendsButton);
			this.filterFriendsTab.Controls.Add(this.filterFriendsWelcomeLabel);
			this.filterFriendsTab.Location = new System.Drawing.Point(4, 22);
			this.filterFriendsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.filterFriendsTab.Name = "filterFriendsTab";
			this.filterFriendsTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.filterFriendsTab.Size = new System.Drawing.Size(787, 568);
			this.filterFriendsTab.TabIndex = 1;
			this.filterFriendsTab.Text = "Friends Filter";
			this.filterFriendsTab.UseVisualStyleBackColor = true;
			// 
			// goFilterYourFriendsButton
			// 
			this.goFilterYourFriendsButton.BackColor = System.Drawing.Color.SeaShell;
			this.goFilterYourFriendsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.goFilterYourFriendsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
			this.goFilterYourFriendsButton.Location = new System.Drawing.Point(293, 376);
			this.goFilterYourFriendsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.goFilterYourFriendsButton.Name = "goFilterYourFriendsButton";
			this.goFilterYourFriendsButton.Size = new System.Drawing.Size(181, 75);
			this.goFilterYourFriendsButton.TabIndex = 3;
			this.goFilterYourFriendsButton.Text = "Go";
			this.goFilterYourFriendsButton.UseVisualStyleBackColor = false;
			this.goFilterYourFriendsButton.Click += new System.EventHandler(this.playButton_Click);
			// 
			// filterFriendsWelcomeLabel
			// 
			this.filterFriendsWelcomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 62F, System.Drawing.FontStyle.Bold);
			this.filterFriendsWelcomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.filterFriendsWelcomeLabel.Location = new System.Drawing.Point(0, 38);
			this.filterFriendsWelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.filterFriendsWelcomeLabel.Name = "filterFriendsWelcomeLabel";
			this.filterFriendsWelcomeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.filterFriendsWelcomeLabel.Size = new System.Drawing.Size(767, 198);
			this.filterFriendsWelcomeLabel.TabIndex = 2;
			this.filterFriendsWelcomeLabel.Text = "Filter Your Friends";
			this.filterFriendsWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// findSignificantOtherTab
			// 
			this.findSignificantOtherTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("findSignificantOtherTab.BackgroundImage")));
			this.findSignificantOtherTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.findSignificantOtherTab.Controls.Add(this.findSignificantOtherWelcomeLabel);
			this.findSignificantOtherTab.Controls.Add(this.goFindSignificantOtherButton);
			this.findSignificantOtherTab.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.findSignificantOtherTab.Location = new System.Drawing.Point(4, 22);
			this.findSignificantOtherTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.findSignificantOtherTab.Name = "findSignificantOtherTab";
			this.findSignificantOtherTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.findSignificantOtherTab.Size = new System.Drawing.Size(787, 568);
			this.findSignificantOtherTab.TabIndex = 2;
			this.findSignificantOtherTab.Text = "Find a Significant Other";
			this.findSignificantOtherTab.UseVisualStyleBackColor = true;
			// 
			// findSignificantOtherWelcomeLabel
			// 
			this.findSignificantOtherWelcomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold);
			this.findSignificantOtherWelcomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.findSignificantOtherWelcomeLabel.Location = new System.Drawing.Point(4, 27);
			this.findSignificantOtherWelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.findSignificantOtherWelcomeLabel.Name = "findSignificantOtherWelcomeLabel";
			this.findSignificantOtherWelcomeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.findSignificantOtherWelcomeLabel.Size = new System.Drawing.Size(762, 191);
			this.findSignificantOtherWelcomeLabel.TabIndex = 5;
			this.findSignificantOtherWelcomeLabel.Text = "Find a Significant Other";
			this.findSignificantOtherWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// goFindSignificantOtherButton
			// 
			this.goFindSignificantOtherButton.BackColor = System.Drawing.Color.SeaShell;
			this.goFindSignificantOtherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.goFindSignificantOtherButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
			this.goFindSignificantOtherButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.goFindSignificantOtherButton.Location = new System.Drawing.Point(293, 376);
			this.goFindSignificantOtherButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.goFindSignificantOtherButton.Name = "goFindSignificantOtherButton";
			this.goFindSignificantOtherButton.Size = new System.Drawing.Size(181, 75);
			this.goFindSignificantOtherButton.TabIndex = 4;
			this.goFindSignificantOtherButton.Text = "Go";
			this.goFindSignificantOtherButton.UseVisualStyleBackColor = false;
			this.goFindSignificantOtherButton.Click += new System.EventHandler(this.startSignificantOtherButton_Click);
			// 
			// WelcomeLabel
			// 
			this.WelcomeLabel.BackColor = System.Drawing.Color.LightSteelBlue;
			this.WelcomeLabel.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold);
			this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.WelcomeLabel.Location = new System.Drawing.Point(219, 200);
			this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.WelcomeLabel.Name = "WelcomeLabel";
			this.WelcomeLabel.Size = new System.Drawing.Size(277, 36);
			this.WelcomeLabel.TabIndex = 17;
			this.WelcomeLabel.Text = "Welcome messege";
			this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.WelcomeLabel.Click += new System.EventHandler(this.WelcomeLabel_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(811, 596);
			this.Controls.Add(this.HomePageTab);
			this.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Welcome";
			this.HomePageTab.ResumeLayout(false);
			this.homeTab.ResumeLayout(false);
			this.panelDataBindingAboutInfo.ResumeLayout(false);
			this.panelDataBindingAboutInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.profilePicPictureBox)).EndInit();
			this.filterFriendsTab.ResumeLayout(false);
			this.findSignificantOtherTab.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl HomePageTab;
		private System.Windows.Forms.TabPage homeTab;
		private System.Windows.Forms.TabPage filterFriendsTab;
		private System.Windows.Forms.TabPage findSignificantOtherTab;
		private System.Windows.Forms.ListBox personalInfoListBox;
		private System.Windows.Forms.ListBox friendsListBox;
		private System.Windows.Forms.ListBox checkinsListBox;
		private System.Windows.Forms.ListBox lastPostsListBox;
		private System.Windows.Forms.Label WelcomeLabelOld;
		private System.Windows.Forms.Button goFilterYourFriendsButton;
		private System.Windows.Forms.Label filterFriendsWelcomeLabel;
		private System.Windows.Forms.Button goFindSignificantOtherButton;
		private System.Windows.Forms.Label findSignificantOtherWelcomeLabel;
		private System.Windows.Forms.Label checkinsLabel;
		private System.Windows.Forms.Label friendsLabel;
		private System.Windows.Forms.Label aboutInfoLabel;
		private System.Windows.Forms.Label lastPostsLabel;
		private System.Windows.Forms.Button logOutButton;
		private System.Windows.Forms.Label coverPhotoLabel;
		private System.Windows.Forms.Label profilePictureLabel;
		private PictureBoxProxy coverPictureBox;
		private PictureBoxProxy profilePicPictureBox;
		private System.Windows.Forms.Panel panelDataBindingAboutInfo;
		private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
		private System.Windows.Forms.BindingSource userBindingSource;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox religionTextBox;
		private ActiveLabel WelcomeLabel;
	}
}