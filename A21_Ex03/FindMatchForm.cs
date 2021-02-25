using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Logic;

namespace A21_Ex02
{
	public partial class FindMatchForm : Form
	{
		// Data Members
		private readonly string[] r_AgeRangeAnswers = 
		{
			"18 - 24",
			"25 - 31",
			"32 - 38",
			"39 - 45",
			"46 - 52",
			"53 - 59",
			"60 - 66",
			"67 - 120"
		};

		private readonly string[] r_Genders = 
		{
			"M",
			"F"
		};

		private readonly string[] r_FindMatchQuestions =
		{
			"Please choose a gender",
			"Please choose an age range"
		};

		private int m_QuestionIndex = 1;
		private User m_LoggedUser;
		private FindMatchLogicManager m_LogicManager;
		private int m_IndexOfCurrentMatch = 0;
		private IEnumerator<User> m_UserIterator;

		// Constructor
		public FindMatchForm()
		{
			InitializeComponent();

			FacebookService.s_CollectionLimit = 200;
			FacebookService.s_FbApiVersion = 2.8f;
			m_LoggedUser = LoggedUserSingleton.Instance.LoggedUser;
			m_LogicManager = new FindMatchLogicManager();
		}

		// Enum
		public enum eQuestion
		{
			Gender = 1,
			AgeRange = 2,
			Done = 3
		}

		// Methods
		private void nextQuestionButton_Click(object sender, EventArgs e)
		{
			goToNextQuestion();
		}

		private void goToNextQuestion()
		{
			eQuestion eQuestion;

			switch (m_QuestionIndex)
			{
				case 1:
					{
						eQuestion = eQuestion.Gender;
						break;
					}

				case 2:
					{
						eQuestion = eQuestion.AgeRange;
						break;
					}

				case 3:
					{
						eQuestion = eQuestion.Done;
						break;
					}

				default:
					{
						eQuestion = eQuestion.Done;
						break;
					}
			}

			getMatches();
			m_QuestionIndex++;
			initializeNextQuestion(eQuestion);
		}

		private void getMatches()
		{
			int selectedAnswerIndex = answersListBox.SelectedIndex;

			try
			{
				switch (m_QuestionIndex)
				{
					case 2:
						{
							m_LogicManager.RemoveAllUnmatchingGenderMatches(
							answersListBox.Items[selectedAnswerIndex].ToString());
							break;
						}

					case 3:
						{
							AgeRange ageRange = pickedAgeRangeToValues(selectedAnswerIndex);
							m_LogicManager.RemoveAllUnmatchingAgeRangeMatches(ageRange);
							break;
						}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				backToMainForm();
			}
		}

		private void initializeNextQuestion(eQuestion i_Question)
		{
			int questionIndexFromEnum = (int)(i_Question - 1);
			questionLabel.Text = r_FindMatchQuestions[questionIndexFromEnum];
			answersListBox.Items.Clear();

			switch (i_Question)
			{
				case eQuestion.Gender:
					{	
						answersListBox.Items.AddRange(r_Genders);
						answersListBox.Text = r_Genders[0];
						break;
					}

				case eQuestion.AgeRange:
					{
						answersListBox.Items.AddRange(r_AgeRangeAnswers);
						answersListBox.Text = r_AgeRangeAnswers[0];
						break;
					}

				case eQuestion.Done:
					{
						createShowMatchesButton();
						break;
					}
			}
		}

		private void backToMainForm()
		{
			MainForm backForm = new MainForm();

			backForm.StartPosition = FormStartPosition.Manual;
			backForm.Location = Location;
			Hide();
			backForm.ShowDialog();
			Close();
		}

		private AgeRange pickedAgeRangeToValues(int i_SelectedAgeRange)
		{
			int minAge, maxAge;

			minAge = 18 + (i_SelectedAgeRange * 7);
			maxAge = 18 + (i_SelectedAgeRange * 7) + 6;

			if (minAge == 67)
			{
				maxAge = 120;
			}

			return new AgeRange(minAge, maxAge);
		}
		
		private void loadMatchingFriendsPage()
		{
			matchedProfilePictureOld.Visible = true;
			loadMatchedProfileControls();
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			backToMainForm();
		}

		private void loadMatchedProfileControls()
		{
			if (m_UserIterator.MoveNext())
			{				
				matchedProfilePictureOld.Load(m_UserIterator.Current.PictureNormalURL);				
				matchedNameLabel.Text = string.Format("Name: {0}", m_UserIterator.Current.Name);
				m_IndexOfCurrentMatch++;
				matchedNameLabel.Visible = true;
				findMatchLabel.Text = "The match is ";
				findMatchLabel.Visible = true;			
				nextMatchButton.Visible = true;
			}
			else
			{
				makeControllersUnvisible();
				backButton.Visible = true;
				gamePicture.Visible = true;
				loadByeByeLabel();
			}
		}

		private void showResultsButton_Click(object sender, EventArgs e)
		{
			resultsButton.Visible = false;
			findMatchLabel.Visible = false;
			loadMatchingFriendsPage();
		}

		private void createShowMatchesButton()
		{
			m_UserIterator = m_LogicManager.GetEnumerator();
			makeControllersUnvisible();			
			backButton.Visible = true;
			gamePicture.Visible = true;

			resultsButton.Visible = true;
			resultsButton.Location = new Point(250, 200);

			findMatchLabel.Visible = true;
			findMatchLabel.Text = "Ready?";
			findMatchLabel.Font = new Font("Segoe UI Semibold", 20);
			findMatchLabel.Location = new Point(144, 50);
			findMatchLabel.BackColor = Color.Transparent;			
		}

		private void makeControllersUnvisible()
		{
			foreach (Control currentControl in Controls)
			{
				currentControl.Visible = false;
			}
		}

		private void nextMatchButton_Click(object sender, EventArgs e)
		{
			loadMatchedProfileControls();
		}

		private void loadByeByeLabel()
		{
			Label endGameLabel = new Label();
			bool noMatchesFound = m_IndexOfCurrentMatch == 0;

			endGameLabel.Parent = gamePicture;
			endGameLabel.BackColor = Color.White;
			endGameLabel.Font = new Font("Segoe UI Semibold", 20);
			endGameLabel.Location = matchedProfilePictureOld.Location;
			endGameLabel.Left -= 200;			
			endGameLabel.Anchor = AnchorStyles.None;
			endGameLabel.AutoSize = true;
			endGameLabel.ForeColor = Color.Black;			

			if (noMatchesFound)
			{
				endGameLabel.Left += 100;
				endGameLabel.Text = "Sorry, No Matches";				
			}
			else
			{
				endGameLabel.Text = "Invite Us to Your Wedding!";
			}

			Controls.Add(endGameLabel);
		}		
	}
}
