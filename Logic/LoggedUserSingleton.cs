using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using SingletonT;

namespace Logic
{
	public sealed class LoggedUserSingleton
	{
		// Data Members
		public static LoggedUserSingleton Instance
		{
			get
			{
				return Singleton<LoggedUserSingleton>.Instance;
			}
		}

		private User s_LoggedUser = null;		

		public User LoggedUser
		{
			get
			{
				if (s_LoggedUser == null)
				{
					loginToFB();
				}

				return s_LoggedUser;
			}

			private set
			{
				s_LoggedUser = value;
			}
		}		

		// Constructor
		private LoggedUserSingleton()
		{
			loginToFB();
		}

		// Methods
		private void loginToFB()
		{
			LoginResult loginResult = null;
			bool isTokenEmpty;

			loginResult = FacebookService.Login(
				"832189520941307",
				"public_profile",
				"email",
				"user_birthday",
				"user_age_range",
				"user_gender",
				"user_link",
				"user_tagged_places",
				"user_videos",
				"user_friends",
				"user_events",
				"user_likes",
				"user_location",
				"user_photos",
				"user_posts",
				"user_hometown");

			isTokenEmpty = string.IsNullOrEmpty(loginResult.AccessToken);
			if (!isTokenEmpty)
			{
				LoggedUser = new User();
				LoggedUser = loginResult.LoggedInUser;
			}
			else
			{
				throw new Exception("No Access!");
			}
		}

		public void Logout()
		{
			s_LoggedUser = null;
		}
	}
}
