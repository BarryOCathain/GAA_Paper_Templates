using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public PlayerWindow()
        {
            InitializeComponent();
            context = new GAA_Templates_ModelContainer();
            loadTestData();
        }

        private void PlayerWindow_Load(object sender, EventArgs e)
        {
            refreshCounties();
            refreshClubTeams();
        }

        private void refreshCounties()
        {
            this.countiesTableAdapter.Fill(this.gAA_TemplatesDataSet.Counties);
        }

        private void refreshClubTeams()
        {
            this.teams_ClubTeamTableAdapter.Fill(this.gAA_TemplatesDataSet.Teams_ClubTeam);
        }

        private void loadTestData()
        {
            //CreateCounty("Kerry", Enums.Provinces.Munster);

            //CreateTeam(Enums.Classification.Club, "Austin Stacks", "Kerry");          
        }

        public Player CreatePlayer(string firstName, string lastName, bool isObsolete, CountyTeam countyTeam, ClubTeam clubTeam)
        {
            throw new NotImplementedException();
        }

        public Player UpdatePlayer(string firstName, string lastName, bool isObsolete, CountyTeam countyTeam, ClubTeam clubTeam)
        {
            throw new NotImplementedException();
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

        #region ICountyView implemented for test purposes
        public County CreateCounty(string name, Enums.Provinces province)
        {
            using (CountyView _context = new CountyView(context))
            {
                return _context.CreateCounty(name, province);
            }
        }

        public County DeleteCounty(County county)
        {
            throw new NotImplementedException();
        }

        public List<County> GetAllCounties()
        {
            throw new NotImplementedException();
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Team Region for test purposes
        public Team CreateTeam(Enums.Classification classification, string name, string county)
        {
            using (TeamView _context = new TeamView(context))
            {
                return _context.CreateTeam(classification, name, county);
            }
        }

        public Team DeleteTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public List<Team> GetAllTeams(Enums.Classification classification)
        {
            throw new NotImplementedException();
        }

        public List<ClubTeam> GetClubsByCounty(County county)
        {
            throw new NotImplementedException();
        }

        public Team UpdateTeam(Team team, string name)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
