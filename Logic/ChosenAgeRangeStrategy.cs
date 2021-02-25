using System;
using FacebookWrapper.ObjectModel;

namespace Logic
{
	public class ChosenAgeRangeStrategy : IAgeRangeStrategy
	{
		public bool IsToAdd(User i_CurrentFriend, AgeRange i_AgeRange)
		{
			int matchAge;
			string matchBrithdayInString;
			DateTime matchBirthdayInDateTime;
			bool isMatchAgeInRange = false;
			
			matchBrithdayInString = i_CurrentFriend.Birthday;
			if (DateTime.TryParse(matchBrithdayInString, out matchBirthdayInDateTime))
			{
				matchAge = DateTime.Today.Year - matchBirthdayInDateTime.Year;
				isMatchAgeInRange = matchAge >= i_AgeRange.MinAge && matchAge <= i_AgeRange.MaxAge;
			}

			return isMatchAgeInRange;
		}
	}
}
