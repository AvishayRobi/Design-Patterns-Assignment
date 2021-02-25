using System.Reflection;

namespace SingletonT
{
	public static class Singleton<T> where T : class
	{
		// Data Members
		private static readonly object sr_lockObject = new object();
		private static T s_instance;		

		public static T Instance
		{
			get
			{
				if (s_instance == null)
				{
					lock (sr_lockObject)
					{
						if (s_instance == null)
						{
							ConstructorInfo[] constructors = typeof(T).GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);
							s_instance = (T)constructors[0].Invoke(null) as T;
						}
					}
				}

				return s_instance;
			}
		}
	}
}
