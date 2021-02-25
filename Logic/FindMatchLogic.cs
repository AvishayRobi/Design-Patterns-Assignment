using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Logic
{
	internal class FindMatchLogic
	{
		// Data Members
		internal List<User> m_MatchingList = new List<User>();

		public AgeRangeFeature AgeRangeFeature { get; set; }

		private User m_LoggedUser { get; set; }

		public List<User> MatchedList
		{
			get
			{
				return m_MatchingList;
			}
		}

		// Constructor
		internal FindMatchLogic()
		{
			m_LoggedUser = LoggedUserSingleton.Instance.LoggedUser;
			AgeRangeFeature = new AgeRangeFeature() { AgeRangeStrategy = new ChosenAgeRangeStrategy() };
		}

		// Methods
		internal void RemoveAllUnmatchingGenderMatches(string i_Gender)
		{
			bool isGenderMatches;

			foreach (User user in m_MatchingList)
			{
				isGenderMatches = user.Gender.ToString() == i_Gender;
				if (!isGenderMatches)
				{
					m_MatchingList.Remove(user);
				}
			}
		}

		internal void RemoveAllUnmatchingAgeRangeMatches(AgeRange i_AgeRange)
		{
			int matchAge;
			string matchBrithdayInString;
			DateTime matchBirthdayInDateTime;
			bool isMatchAgeInRange;

			foreach (User user in m_LoggedUser.Friends)
			{
				matchBrithdayInString = user.Birthday;
				if (DateTime.TryParse(matchBrithdayInString, out matchBirthdayInDateTime))
				{
					matchAge = DateTime.Today.Year - matchBirthdayInDateTime.Year;
					isMatchAgeInRange = matchAge >= i_AgeRange.MinAge && matchAge <= i_AgeRange.MaxAge;

					if (!isMatchAgeInRange)
					{
						m_MatchingList.Remove(user);
					}
				}
			}
		}

		internal enum eGender
		{
			female = 0,
			male = 1
		}
	}
}
