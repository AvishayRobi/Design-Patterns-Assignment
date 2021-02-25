namespace Logic
{
	public class AgeRange
	{
		// Data Members
		public int MinAge { get; set; }

		public int MaxAge { get; set; }

		// Constructors
		public AgeRange()
		{
			MinAge = 0;
			MaxAge = 0;
		}

		public AgeRange(int i_MinAge, int i_MaxAge)
		{
			MinAge = i_MinAge;
			MaxAge = i_MaxAge;
		}
	}
}
