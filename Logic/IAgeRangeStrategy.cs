using FacebookWrapper.ObjectModel;

namespace Logic
{
	public interface IAgeRangeStrategy
	{
		bool IsToAdd(User i_CurrentFriend, AgeRange i_AgeRange);
	}
}
