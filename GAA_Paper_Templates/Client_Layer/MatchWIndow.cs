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
    public partial class MatchWIndow : Form, IMatchView
    {
        GAA_Templates_ModelContainer context;
        MatchView matchViewContext;

        private bool update;

        private Match match;

        private ComboBox[] homeAndAwayTeamComboboxes;
        public MatchWIndow(Match _match = null)
        {
            InitializeComponent();

            context = new GAA_Templates_ModelContainer();
            matchViewContext = new MatchView(context);

            match = _match;

            if (match != null)
            {
                update = false;
                //loadMatchDetails();
            }
            else
                update = true;

            homeAndAwayTeamComboboxes = new ComboBox[2];

            homeAndAwayTeamComboboxes[0] = this.homeTeamComboBox;
            homeAndAwayTeamComboboxes[1] = this.awayTeamComboBox;

            bindClassificationsToComboBox(this.classificationComboBox);
            bindCountiesToComboBox(this.countiesComboBox);

            toggleCountyComboBox();
        }

        private void bindHomeAndAwayTeamComboboxes(ComboBox[] cba)
        {
            for (int i = 0; i < cba.Length; i++)
            {
                if (this.classificationComboBox.Text == Enums.Classification.County.ToString())
                    bindCountiesToComboBox(cba[i]);
                else
                    bindClubsToComboBox(cba[i], (County)this.countiesComboBox.SelectedItem);

                cba[i].SelectedIndex = -1;
            }
        }

        #region MatchView Methods
        public Match CreateMatch(DateTime matchDate, TimeSpan time, Venue venue, CompetitionMatchType matchType, Competition competition, Team homeTeam, Team awayTeam)
        {
            return matchViewContext.CreateMatch(matchDate, time, venue, matchType, competition, homeTeam, awayTeam);
        }

        public Match DeleteMatch(DateTime MatchDate, TimeSpan time, Venue venue)
        {
            return matchViewContext.DeleteMatch(MatchDate, time, venue);
        }

        public Match GetMatchByDateTimeAndVenue(DateTime matchDate, TimeSpan time, Venue venue)
        {
            return matchViewContext.GetMatchByDateTimeAndVenue(matchDate, time, venue);
        }

        public List<Match> GetMatchesByDate(DateTime matchDate)
        {
            return matchViewContext.GetMatchesByDate(matchDate);
        }

        public List<Match> GetMatchesByTeam(Team team)
        {
            return matchViewContext.GetMatchesByTeam(team);
        }

        public List<Match> GetMatchesByVenue(Venue venue)
        {
            return matchViewContext.GetMatchesByVenue(venue);
        }

        public Match UpdateMatch(DateTime matchDate, TimeSpan time, Venue venue, CompetitionMatchType matchType, Competition competition, Team homeTeam, Team awayTeam)
        {
            return matchViewContext.UpdateMatch(matchDate, time, venue, matchType, competition, homeTeam, awayTeam);
        } 
        #endregion

        private void loadMatchDetails(Team homeTeam, Team awayTeam)
        {
            // TODO
        }

        private List<MatchPlayer> loadTeamPlayers(Match match, Team team)
        {
            return context.MatchPlayers
                .Where(mp => mp.Match.MatchDate == match.MatchDate && mp.Match.MatchTime == match.MatchTime
                && mp.Match.Venue == match.Venue && (mp.Match.AwayTeam == team || mp.Match.HomeTeam == team))
                .ToList();
        }

        private void toggleCountyComboBox()
        {
            bool visible = this.classificationComboBox.Text == Enums.Classification.Club.ToString();

            this.countyLabel.Visible = visible;
            this.countiesComboBox.Visible = visible;
        }

        private void bindClassificationsToComboBox(ComboBox cb)
        {
            cb.DataSource = Enum.GetValues(typeof(Enums.Classification));
        }

        private void bindCountiesToComboBox(ComboBox cb)
        {
            using (CountyView _context = new CountyView(context))
            {
                cb.DataSource = _context.GetAllCounties();
                cb.ValueMember = "ID";
                cb.DisplayMember = "Name";
            }
        }

        private void bindClubsToComboBox(ComboBox cb, County county)
        {
            using (TeamView _context = new TeamView(context))
            {
                cb.DataSource = _context.GetClubsByCounty(county);
                cb.ValueMember = "ID";
                cb.DisplayMember = "Name";
            }
        }

        private void classificationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            toggleCountyComboBox();
            bindHomeAndAwayTeamComboboxes(homeAndAwayTeamComboboxes);
        }

        private void countiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindHomeAndAwayTeamComboboxes(homeAndAwayTeamComboboxes);
        }
    }
}
