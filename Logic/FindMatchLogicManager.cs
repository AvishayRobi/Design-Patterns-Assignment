using System.Collections;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Logic
{
	public class FindMatchLogicManager : IEnumerable<User>
	{
		// Data Members
		private FindMatchLogic m_FindMatchLogic;		
		
		// Constructor
		public FindMatchLogicManager()
		{
			startFindMatch();
		}

		// Methods
		private void startFindMatch()
		{
			m_FindMatchLogic = new FindMatchLogic();
		}

		public void RemoveAllUnmatchingGenderMatches(string i_Gender)
		{			
			m_FindMatchLogic.RemoveAllUnmatchingGenderMatches(i_Gender);
		}

		public void RemoveAllUnmatchingAgeRangeMatches(AgeRange i_AgeRange)
		{
			m_FindMatchLogic.RemoveAllUnmatchingAgeRangeMatches(i_AgeRange);
		}

		public IEnumerator<User> GetEnumerator()
		{
			foreach (User match in m_FindMatchLogic.MatchedList)
			{
				yield return match;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
