using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Logic
{
	public class AgeRangeFeature
	{
		// Data Members
		public IAgeRangeStrategy AgeRangeStrategy { get; set; }

		// Methods
		public List<User> BuildMatchingList(User i_LoggedUser, AgeRange i_AgeRangeMatch)
		{
			List<User> matchingList = new List<User>();

			collectMatchingAgeRangeFriends(i_LoggedUser, i_AgeRangeMatch, matchingList);

			return matchingList;
		}		

		private void collectMatchingAgeRangeFriends(User i_LoggedUser, AgeRange i_AgeRangeMatch, List<User> i_MatchingList)
		{
			for (int i = 0; i < i_LoggedUser.Friends.Count; i++)
			{
				if (AgeRangeStrategy.IsToAdd(i_LoggedUser.Friends[i], i_AgeRangeMatch))
				{
					i_MatchingList.Add(i_LoggedUser.Friends[i]);
				}
			}
		}
	}
}
