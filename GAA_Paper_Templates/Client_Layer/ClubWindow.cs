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
    public partial class ClubWindow : Form, ITeamView, ICountyView
    {
        private GAA_Templates_ModelContainer context;
        private TeamView teamViewContext;
        private CountyView countyViewContext;
        private bool update;
        public ClubWindow(bool _update = false)
        {
            InitializeComponent();

            update = _update;

            context = new GAA_Templates_ModelContainer();
            teamViewContext = new TeamView(context);
            countyViewContext = new CountyView(context);

            bindCountiesToComboBox();
        }

        private void bindCountiesToComboBox()
        {
            this.countyComboBox.DataSource = GetAllCounties();
            this.countyComboBox.ValueMember = "ID";
            this.countyComboBox.DisplayMember = "Name";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ClubTeam ct = GetClub(this.nameTextBox.Text, (County)this.countyComboBox.SelectedItem);

            if (update)
            {
                if (ct != null)
                {
                    teamViewContext.UpdateTeam(ct, this.nameTextBox.Text);

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("A Club with that name does not exist.");
                }
            }
            else
            {
                if (ct == null)
                {
                    teamViewContext.CreateTeam(Enums.Classification.Club, this.nameTextBox.Text, (County)this.countyComboBox.SelectedItem);

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("A Club in that County, with that Name, already exists.");
                }
            } 
        }

        #region CountyView Methods
        public County CreateCounty(string name, Enums.Provinces province)
        {
            throw new NotImplementedException();
        }

        public County DeleteCounty(County county)
        {
            throw new NotImplementedException();
        }

        public County GetCounty(string name)
        {
            throw new NotImplementedException();
        }

        public List<County> GetAllCounties()
        {
            return countyViewContext.GetAllCounties();
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
        public Team CreateTeam(Enums.Classification classification, string name, County county)
        {
            return teamViewContext.CreateTeam(classification, name, county);
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

        public ClubTeam GetClub(string name, County county)
        {
            return teamViewContext.GetClub(name, county);
        }

        public CountyTeam GetCountyTeam(string name)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
