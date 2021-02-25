using System;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Logic;

namespace A21_Ex02
{
	public partial class FilterFriendsForm : Form
	{
		// Data Members
		private FilterFriendsLogic m_FilterFriendsLogic;

		// Constructor
		public FilterFriendsForm()
		{
			InitializeComponent();
			FacebookService.s_CollectionLimit = 200;
			FacebookService.s_FbApiVersion = 2.8f;
			m_FilterFriendsLogic = new FilterFriendsLogic();
		}

		// Methods
		private void backToMainAppForm()
		{
			MainForm backForm = new MainForm();

			backForm.StartPosition = FormStartPosition.Manual;
			backForm.Location = this.Location;
			Hide();
			backForm.ShowDialog();
			Close();
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			backToMainAppForm();
		}

		private void buttonGo_Click(object sender, EventArgs e)
		{
			ActiveButton activeButton = buttonGo as ActiveButton;
			activeButton.Flick();
			goFilterFriends();
		}

		private void goFilterFriends()
		{
			bool isFetchOnlySingles = checkBoxSingles.Checked;
			FacebookObjectCollection<User> filteredFriends = fetchFilteredFriends();
			printFilteredFriendsNamesToScreen(filteredFriends, isFetchOnlySingles);
		}

		private FacebookObjectCollection<User> fetchFilteredFriends()
		{
			bool isFetchMales = checkBoxMales.Checked;
			bool isFetchFemales = checkBoxFemales.Checked;
			bool isFetchOnlyUsersCity = checkBoxMyCity.Checked;
			bool isFetchOnlySingles = checkBoxSingles.Checked;
			bool isFetchOnlyUsersReligion = checkBoxMyReligion.Checked;

			FacebookObjectCollection<User> filteredFriendsList;
			filteredFriendsList = m_FilterFriendsLogic.BuildDesiredUsers(isFetchMales, isFetchFemales, isFetchOnlyUsersCity, isFetchOnlySingles, isFetchOnlyUsersReligion);

			return filteredFriendsList;
		}

		private void printFilteredFriendsNamesToScreen(FacebookObjectCollection<User> i_FilteredFriends, bool i_IsFetchOnlySingles)
		{
			StringBuilder strToPrint = new StringBuilder();
			string space = " ";
			string newLine = Environment.NewLine;

			foreach (User friend in i_FilteredFriends)
			{
				strToPrint.Append(friend.FirstName);
				strToPrint.Append(space);
				strToPrint.Append(friend.LastName);
				if (i_IsFetchOnlySingles)
				{
					strToPrint.Append(addBracketsAndSpaceToWord(singleStatusIfExists(friend)));
				}

				strToPrint.Append(newLine);
			}

			groupBoxFilteredFriends.Text = strToPrint.ToString();
		}		

		private string singleStatusIfExists(User i_User)
		{
			string status = string.Empty;

			status = m_FilterFriendsLogic.SingleStatusToString(i_User.RelationshipStatus);

			return status;
		}

		private string addBracketsAndSpaceToWord(string i_Word)
		{
			StringBuilder fixedString = new StringBuilder();
			string space = " ";
			bool isWordEmpty = string.IsNullOrEmpty(i_Word);

			fixedString.Append(string.Empty);
			if (!isWordEmpty)
			{
				fixedString.Append(space);
				fixedString.Append("(");
				fixedString.Append(i_Word);
				fixedString.Append(")");
			}			

			return fixedString.ToString();
		}
	}
}
