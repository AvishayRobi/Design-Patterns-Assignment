using System;
using FacebookWrapper.ObjectModel;

namespace Logic
{
	public class FilterFriendsLogic
	{
		// Data Members
		public User m_LoggedUser { get; private set; }

		private readonly string r_Male = "M";
		private readonly string r_Female = "F";

		// Constructors
		public FilterFriendsLogic()
		{
			m_LoggedUser = LoggedUserSingleton.Instance.LoggedUser;
		}

		// Methods
		public FacebookObjectCollection<User> BuildDesiredUsers(
			bool i_IsFetchMales,
			bool i_IsFetchFemales,
			bool i_IsFetchOnlyMyCity,
			bool i_IsFetchOnlySingles,
			bool i_IsFetchOnlyMyReligion)
		{
			FacebookObjectCollection<User> listOfUsersToReturn = new FacebookObjectCollection<User>();

			listOfUsersToReturn = getAllFriends();
			listOfUsersToReturn = filterFriends(listOfUsersToReturn, i_IsFetchMales, i_IsFetchFemales, i_IsFetchOnlyMyCity, i_IsFetchOnlySingles, i_IsFetchOnlyMyReligion);

			return listOfUsersToReturn;
		}

		private FacebookObjectCollection<User> getAllFriends()
		{
			bool isFriendListEmpty = m_LoggedUser.Friends == null;
			bool isFriendsNameEmpty;
			FacebookObjectCollection<User> friendsList = new FacebookObjectCollection<User>();

			// If user have no friends, throw an exception
			if (isFriendListEmpty)
			{
				throw new ArgumentException("Your Friends List is Empty...");
			}

			// Get all user's friends
			foreach (User friend in m_LoggedUser.Friends)
			{
				isFriendsNameEmpty = string.IsNullOrEmpty(friend.FirstName) == true;
				if (!isFriendsNameEmpty)
				{
					friendsList.Add(friend);
				}
			}

			return friendsList;
		}

		private FacebookObjectCollection<User> filterFriends(
			FacebookObjectCollection<User> i_FriendsList,
			bool i_IsFetchMales,
			bool i_IsFetchFemales,
			bool i_IsFetchOnlyMyCity,
			bool i_IsFetchOnlySingles,
			bool i_IsFetchOnlyMyReligion)
		{
			string friendsGender;
			bool isFriendsGenderNotWanted, isFriendsCityNotWanted, isFriendsRelationshipStatusNotWanted, isFriendsReligionNotWanted;

			foreach (User friend in i_FriendsList)
			{
				friendsGender = enumGenderToString(friend.Gender);
				isFriendsGenderNotWanted = (!i_IsFetchMales && friendsGender == "M") || (!i_IsFetchFemales && friendsGender == "F");
				if (isFriendsGenderNotWanted)
				{
					i_FriendsList.Remove(friend);
					continue;
				}

				isFriendsCityNotWanted = i_IsFetchOnlyMyCity && friend.Hometown.Name != m_LoggedUser.Hometown.Name;
				if (isFriendsCityNotWanted)
				{
					i_FriendsList.Remove(friend);
					continue;
				}

				isFriendsRelationshipStatusNotWanted = i_IsFetchOnlySingles && !isStatusSingle(SingleStatusToString(friend.RelationshipStatus));
				if (isFriendsRelationshipStatusNotWanted)
				{
					i_FriendsList.Remove(friend);
					continue;
				}

				isFriendsReligionNotWanted = i_IsFetchOnlyMyReligion && friend.Religion != m_LoggedUser.Religion;
				if (isFriendsReligionNotWanted)
				{
					i_FriendsList.Remove(friend);
				}
			}

			return i_FriendsList;
		}

		private string enumGenderToString(User.eGender? i_Gender)
		{
			string strToReturn = r_Male;

			if (i_Gender == 0)
			{
				strToReturn = r_Female;
			}

			return strToReturn;
		}

		public string SingleStatusToString(User.eRelationshipStatus? i_Status)
		{
			string singleStatus = string.Empty;

			if (i_Status == User.eRelationshipStatus.Single || 
				i_Status == User.eRelationshipStatus.Divorced || 
				i_Status == User.eRelationshipStatus.Separated || 
				i_Status == User.eRelationshipStatus.Widowed)
			{
				singleStatus = i_Status.ToString();
			}

			return singleStatus;
		}

		private bool isStatusSingle(string i_Status)
		{
			bool isSingle = true;

			if (i_Status == string.Empty)
			{
				isSingle = false;
			}

			return isSingle;
		}
	}
}
