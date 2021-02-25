using System;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Logic;

namespace A21_Ex02
{
	public partial class MainForm : Form
	{
		// Data Members
		private User m_LoggedUser;

		// Constructor
		public MainForm()
		{
			InitializeComponent();
			FacebookService.s_CollectionLimit = 200;
			FacebookService.s_FbApiVersion = 2.8f;
			m_LoggedUser = LoggedUserSingleton.Instance.LoggedUser;
			initializeHomePage();
			filterFriendsWelcomeLabel.BackColor = Color.Transparent;
			findSignificantOtherWelcomeLabel.BackColor = Color.Transparent;
		}

		// Methods
		private void initializeHomePage()
		{
			fetchProfilePicture();
			fetchCoverPicture();
			fetchWelcomeMessege();
			fetchHomeLables();
			fetchAboutInfoListBox();

			checkinsListBox.Hide();
			lastPostsListBox.Hide();
			friendsListBox.Hide();
		}

		private void fetchHomeLables()
		{
			checkinsLabel.Show();
			checkinsLabel.BackColor = Color.Transparent;
			aboutInfoLabel.Show();
			aboutInfoLabel.BackColor = Color.Transparent;
			lastPostsLabel.Show();
			lastPostsLabel.BackColor = Color.Transparent;
			friendsLabel.Show();
			friendsLabel.BackColor = Color.Transparent;
		}

		private void fetchProfilePicture()
		{
			try
			{
				if (m_LoggedUser.PictureNormalURL != null)
				{
					profilePicPictureBox.Load(m_LoggedUser.PictureNormalURL);
					profilePicPictureBox.Show();
				}
				else
				{
					profilePicPictureBox.Hide();
				}
			}
			catch
			{
				profilePicPictureBox.Hide();
			}
		}

		private void fetchCoverPicture()
		{
			try
			{
				if (m_LoggedUser.Albums != null)
				{
					foreach (Album currentAlbum in m_LoggedUser.Albums)
					{
						if (string.Compare(currentAlbum.Name, "תמונות נושא") == 0 || string.Compare(currentAlbum.Name, "Cover Photos") == 0)
						{
							coverPictureBox.Load(currentAlbum.Photos[0].PictureNormalURL);
							coverPictureBox.Show();
						}
					}
				}
				else
				{
					coverPictureBox.Hide();
				}
			}
			catch
			{
				coverPictureBox.Hide();
			}
		}

		private void fetchWelcomeMessege()
		{
			StringBuilder dayTime = new StringBuilder();
			string welcomeMessege;

			try
			{
				DateTime now = DateTime.Now;
				if (now.Hour > 6 && now.Hour < 12)
				{
					dayTime.Append("Morning");
				}
				else if (now.Hour >= 12 && now.Hour < 18)
				{
					dayTime.Append("Afternoon");
				}
				else
				{
					dayTime.Append("Evening");
				}

				welcomeMessege = string.Format("Hi {0}, Good {1}!", m_LoggedUser.FirstName, dayTime);
			}
			catch
			{
				welcomeMessege = "Welcome!";
			}

			WelcomeLabelOld.Text = welcomeMessege;
			WelcomeLabelOld.BackColor = Color.Transparent;
		}

		private void fetchAboutInfoListBox()
		{
			userBindingSource.DataSource = m_LoggedUser;
			setBirthdayToDatetimePicker();
		}

		private void setBirthdayToDatetimePicker()
		{
			birthdayDateTimePicker.Value = DateTime.ParseExact(
				m_LoggedUser.Birthday, 
				"MM/dd/yyyy", 
				CultureInfo.InstalledUICulture);
		}

		private void fetchFriendsListBox()
		{
			try
			{
				if (m_LoggedUser.Friends != null)
				{
					foreach (User currentFriend in m_LoggedUser.Friends)
					{
						if (!string.IsNullOrEmpty(currentFriend.FirstName))
						{
							friendsListBox.Invoke(new Action(() => friendsListBox.Items.Add(currentFriend.FirstName)));
						}
					}

					friendsListBox.Invoke(new Action(() => friendsListBox.Show()));
				}
			}
			catch
			{
				MessageBox.Show("We Can't Access Your Facebook Friends Information");
				friendsListBox.Invoke(new Action(() => friendsListBox.Hide()));
			}
		}

		private void fetchPostsListBox()
		{
			try
			{
				if (m_LoggedUser.Posts != null)
				{
					foreach (Post currentPost in m_LoggedUser.Posts)
					{
						if (!string.IsNullOrEmpty(currentPost.Message) && lastPostsListBox.Items.Count <= 10)
						{
							lastPostsListBox.Invoke(new Action(() => lastPostsListBox.Items.Add(currentPost.Message)));
						}
					}

					lastPostsListBox.Invoke(new Action(() => lastPostsListBox.Show()));
				}
			}
			catch
			{
				MessageBox.Show("We Can't Access Your Facebook Posts Information");
				lastPostsListBox.Invoke(new Action(() => lastPostsListBox.Hide()));
			}
		}

		private void fetchCheckinsListBox()
		{
			try
			{
				if (m_LoggedUser.Checkins != null)
				{
					foreach (Checkin currentCheckin in m_LoggedUser.Checkins)
					{
						if (!string.IsNullOrEmpty(currentCheckin.Place.Name) && lastPostsListBox.Items.Count <= 20)
						{
							checkinsListBox.Invoke(new Action(() => checkinsListBox.Items.Add(currentCheckin.Place.Name)));
						}
					}

					checkinsListBox.Invoke(new Action(() => checkinsListBox.Show()));
				}
			}
			catch
			{
				MessageBox.Show("We Can't Access Your Facebook checkins information");
				checkinsListBox.Invoke(new Action(() => checkinsListBox.Hide()));
			}
		}		

		private void playButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (m_LoggedUser.Friends.Count > 0)
				{
					startFriendsFilter();
				}
				else
				{
					throw new Exception();
				}
			}
			catch
			{
				MessageBox.Show("We Can't Access Your Friend's Facebook Information");
			}
		}

		private void startFriendsFilter()
		{
			FilterFriendsForm nextForm = new FilterFriendsForm();
			Hide();
			nextForm.ShowDialog();
			Close();
		}

		private void startSignificantOtherButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (m_LoggedUser.Friends.Count > 0)
				{
					startSignificantOtherMatch();
				}
				else
				{
					throw new Exception();
				}
			}
			catch
			{
				MessageBox.Show("We Can't Access Your Friend's Facebook Information");
			}
		}

		private void startSignificantOtherMatch()
		{
			FindMatchForm nextForm = new FindMatchForm();
			nextForm.StartPosition = FormStartPosition.Manual;
			nextForm.Location = this.Location;
			Hide();
			nextForm.ShowDialog();
			Close();
		}		

		private void friendsLabel_Click(object sender, EventArgs e)
		{
			friendsListBox.Items.Clear();
			new Thread(fetchFriendsListBox).Start();
		}

		private void lastPostsLable_Click(object sender, EventArgs e)
		{
			lastPostsListBox.Items.Clear();
			new Thread(fetchPostsListBox).Start();
		}		

		private void checkinsLabel_Click(object sender, EventArgs e)
		{
			checkinsListBox.Items.Clear();
			new Thread(fetchCheckinsListBox).Start();
		}

		private void logOutButton_Click(object sender, EventArgs e)
		{
			LoginForm nextForm = new LoginForm();
			Hide();
			nextForm.ShowDialog();
			Close();
		}

		private void WelcomeLabel_Click(object sender, EventArgs e)
		{
			ActiveLabel activeLabel = WelcomeLabel as ActiveLabel;
			activeLabel.Flick();
		}
	}
}