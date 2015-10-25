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
using GAA_Paper_Templates.Interfaces;
using GAA_Paper_Templates.Views;

namespace Client_Layer
{
    public partial class CompetitionWindow : Form, ICompetitionView
    {
        GAA_Templates_ModelContainer context;
        CompetitionView competitionViewContext;

        private bool update;
        public CompetitionWindow(bool _update = false)
        {
            InitializeComponent();

            update = _update;

            context = new GAA_Templates_ModelContainer();
            competitionViewContext = new CompetitionView(context);

            bindCountiesToComboBox();
        }

        private void bindCountiesToComboBox()
        {
            using (CountyView _context = new CountyView(context))
            {
                this.countyComboBox.DataSource = _context.GetAllCounties();
                this.countyComboBox.ValueMember = "ID";
                this.countyComboBox.DisplayMember = "Name";
            }
        }

        #region CompetitionView Methods
        public Competition CreateCompetition(string name, DateTime startDate, DateTime endDate, County county)
        {
            return competitionViewContext.CreateCompetition(name, startDate, endDate, county);
        }

        public Competition DeleteCompetition(Competition comp)
        {
            return competitionViewContext.DeleteCompetition(comp);
        }

        public Competition GetCompetitionByNameYearAndCounty(string name, DateTime year, County county)
        {
            return competitionViewContext.GetCompetitionByNameYearAndCounty(name, year, county);
        }

        public List<Competition> GetAllCompetitions()
        {
            return competitionViewContext.GetAllCompetitions();
        }

        public List<Competition> GetCompetitionsByCountyAndYear(County county, DateTime year)
        {
            return competitionViewContext.GetCompetitionsByCountyAndYear(county, year);
        }

        public List<Competition> GetCompetitionsByYear(DateTime year)
        {
            return  competitionViewContext.GetCompetitionsByYear(year);
        }

        public Competition UpdateCompetition(Competition comp, string name, DateTime startDate, DateTime endDate, County county)
        {
            return competitionViewContext.UpdateCompetition(comp, name, startDate, endDate, county);
        }
        #endregion

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Competition comp = competitionViewContext.GetCompetitionByNameYearAndCounty(this.nameTextBox.Text,
                this.startDateTimePicker.Value, (County)this.countyComboBox.SelectedItem);

            if (update)
            {
                if (comp != null)
                {
                    competitionViewContext.UpdateCompetition(comp, this.nameTextBox.Text, this.startDateTimePicker.Value,
                        this.endDateTimePicker.Value, (County)this.countyComboBox.SelectedItem);
                    MessageBox.Show("Competition Updated.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("A Competition with that Name / Year / County, does not exist.");
            }
            else
            {
                if (comp == null)
                {
                    competitionViewContext.CreateCompetition(this.nameTextBox.Text, this.startDateTimePicker.Value,
                        this.endDateTimePicker.Value, (County)this.countyComboBox.SelectedItem);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("A Competition with that Name / Year / County, already exists.");
            }
            
        }
    }
}
