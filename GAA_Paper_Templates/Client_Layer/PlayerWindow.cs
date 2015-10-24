using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GAA_Paper_Templates;
using GAA_Paper_Templates.Common;
using GAA_Paper_Templates.Interfaces;
using GAA_Paper_Templates.Views;

namespace Client_Layer
{
    public partial class PlayerWindow : Form, IPlayerView, ICountyView, ITeamView
    {
        GAA_Templates_ModelContainer context;
        TeamView teamViewContext;
        CountyView countyViewContext;
        PlayerView playerViewContext;
        private bool update;
        public PlayerWindow(bool _update = false)
        {
            InitializeComponent();

            update = _update;
            context = new GAA_Templates_ModelContainer();
            teamViewContext = new TeamView(context);
            countyViewContext = new CountyView(context);
            playerViewContext = new PlayerView(context);
            loadTestData();
            addEventHandlers();
        }

        private void PlayerWindow_Load(object sender, EventArgs e)
        {
            refreshComboBoxes();
        }

        private void refreshComboBoxes()
        {
            refreshCounties();
            refreshClubTeams();
        }

        private void refreshCounties()
        {
            this.countyComboBox.DataSource = GetAllCounties();
            this.countyComboBox.ValueMember = "ID";
            this.countyComboBox.DisplayMember = "Name";
        }

        private void refreshClubTeams()
        {
            this.clubComboBox.DataSource = GetClubsByCounty((County)this.countyComboBox.SelectedItem);
            this.clubComboBox.ValueMember = "ID";
            this.clubComboBox.DisplayMember = "Name";
        }

        private void loadTestData()
        {
            //CreateCounty("Kerry", Enums.Provinces.Munster);

            //CreateTeam(Enums.Classification.Club, "Austin Stacks", "Kerry");          
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region PlayerView Methods
        public Player CreatePlayer(string firstName, string lastName, bool isObsolete, CountyTeam countyTeam, ClubTeam clubTeam)
        {
            using (playerViewContext)
            {
                return playerViewContext.CreatePlayer(firstName, lastName, isObsolete, countyTeam, clubTeam);
            }
        }

        public Player UpdatePlayer(string firstName, string lastName, bool isObsolete, CountyTeam countyTeam, ClubTeam clubTeam)
        {
            using (playerViewContext)
            {
                return playerViewContext.UpdatePlayer(firstName, lastName, isObsolete, countyTeam, clubTeam);
            }
        }

        public Player GetPlayerByFirstOrLastName(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public Player GetPlayerByClubAndFirstOrLastName(ClubTeam club, string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public Player GetPlayerByCOuntyAndFirstOrLastName(CountyTeam county, string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetPlayersByClub(ClubTeam club)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetPlayersByCounty(CountyTeam county)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetPlayersByFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetPlayersByLastName(string lastName)
        {
            throw new NotImplementedException();
        } 
        #endregion

        #region CountyView Methods
        public County CreateCounty(string name, Enums.Provinces province)
        {
            using (countyViewContext)
            {
                return countyViewContext.CreateCounty(name, province);
            }
        }

        public County DeleteCounty(County county)
        {
            throw new NotImplementedException();
        }

        public County GetCounty(string name)
        {
            using (countyViewContext)
            {
                return countyViewContext.GetCounty(name);
            }
        }

        public List<County> GetAllCounties()
        {
            using (countyViewContext)
            {
                return countyViewContext.GetAllCounties();
            }
        }

        public List<County> GetCountiesByProvince(Enums.Provinces province)
        {
            throw new NotImplementedException();
        }

        public County UpdateCounty(County county, string name, Enums.Provinces province)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region TeamView Methods
        public Team CreateTeam(Enums.Classification classification, string name, string county)
        {
            using (teamViewContext)
            {
                return teamViewContext.CreateTeam(classification, name, county);
            }
        }

        public Team DeleteTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public ClubTeam GetClub(string name, County county)
        {
            using (teamViewContext)
            {
                return teamViewContext.GetClub(name, county);
            }
        }

        public CountyTeam GetCountyTeam(string name)
        {
            using (teamViewContext)
            {
                return teamViewContext.GetCountyTeam(name);
            }
        }

        public List<Team> GetAllTeams(Enums.Classification classification)
        {
            throw new NotImplementedException();
        }

        public List<ClubTeam> GetClubsByCounty(County county)
        {
            using (teamViewContext)
            {
                return teamViewContext.GetClubsByCounty(county);
            }
        }

        public Team UpdateTeam(Team team, string name)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Event Handlers and Helpers
        private void addEventHandlers()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(ComboBox))
                {
                    addHandlersToControl(ctrl);
                }
            }
        }

        private void addHandlersToControl(Control ctrl)
        {
            if (ctrl.GetType() == typeof(TextBox))
                ctrl.TextChanged += new EventHandler(checkTextBoxIsNotEmpty);
            else
                ctrl.TextChanged += new EventHandler(checkComboBoxIsNotEmpty);

            ctrl.KeyPress += new KeyPressEventHandler(enterKeyPressed);
        }

        private void checkTextBoxIsNotEmpty(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;

            if (string.IsNullOrEmpty(temp.Text))
                temp.BackColor = Color.DarkRed;
            else
                temp.BackColor = Color.Empty;
        }

        private void checkComboBoxIsNotEmpty(object sender, EventArgs e)
        {
            ComboBox temp = (ComboBox)sender;

            if (string.IsNullOrEmpty(temp.Text))
                temp.BackColor = Color.DarkRed;
            else
                temp.BackColor = Color.Empty;
        }


        private void enterKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                saveButton_Click(this, null);
        } 
        #endregion

        private void newCountyButton_Click(object sender, EventArgs e)
        {
            using (CountyWindow cw = new CountyWindow())
            {
                if (cw.ShowDialog() == DialogResult.OK)
                {
                    refreshComboBoxes();
                }
            }
        }

        private void newClubButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (checkEntriesAreValid())
            {
                CountyTeam ctyTm;
                ClubTeam club;

                if (this.countyPlayerCheckBox.Checked)
                    ctyTm = GetCountyTeam(this.countyComboBox.Text);
                else
                    ctyTm = null;

                using (GAA_Templates_ModelContainer _context = new GAA_Templates_ModelContainer())
                {
                    club = GetClub(this.clubComboBox.Text, GetCounty(this.countyComboBox.Text));                       
                }

                if (update)
                {
                    UpdatePlayer(this.firstNameTextBox.Text, this.lastNameTextBox.Text, this.obsoleteCheckBox.Checked,
                        ctyTm, club);
                }
                else
                {
                    CreatePlayer(this.firstNameTextBox.Text, this.lastNameTextBox.Text, this.obsoleteCheckBox.Checked,
                        ctyTm, club);
                }

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private bool checkEntriesAreValid()
        {
            bool isValid = true;

            foreach (Control ctrl in this.Controls)
             {
                if (ctrl.GetType() == typeof(TextBox))
                    if (string.IsNullOrEmpty(ctrl.Text))
                        isValid = false;

                if (ctrl.GetType() == typeof(ComboBox))
                {
                    ComboBox temp = (ComboBox)ctrl;

                    if (temp.SelectedIndex == -1 || string.IsNullOrEmpty(temp.Text))
                        isValid = false;
                }
            }

            if (!isValid)
            {
                MessageBox.Show("Ensure that you have entered all the required details."); 
            }

            return isValid;
        }

        private void countyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.clubComboBox.SelectedIndex = -1;
            refreshClubTeams();
        }
    }
}
