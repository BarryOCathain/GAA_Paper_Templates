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
    public partial class VenueWindow : Form, IVenueView
    {
        GAA_Templates_ModelContainer context;
        VenueView venueViewContext;

        bool update;
        public VenueWindow(bool _update = false)
        {
            InitializeComponent();

            update = _update;

            context = new GAA_Templates_ModelContainer();
            venueViewContext = new VenueView(context);

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

        private void saveButton_Click(object sender, EventArgs e)
        {
            Venue v = GetVenue(this.nameTextBox.Text);

            if (update)
            {
                if (v != null)
                {
                    UpdateVenue(v, this.nameTextBox.Text, this.locationTextBox.Text, (County)this.countyComboBox.SelectedItem);
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Venue updated.");
                    this.Close();
                }
                else
                    MessageBox.Show("A Venue with that Name does not exist.");

            }
            else
            {
                if (v == null)
                {
                    CreateVenue(this.nameTextBox.Text, this.locationTextBox.Text, (County)this.countyComboBox.SelectedItem);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("A Venue with that Name already exists.");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region VenueView Methods
        public Venue CreateVenue(string name, string location, County county)
        {
            return venueViewContext.CreateVenue(name, location, county);
        }

        public Venue DeleteVenue(Venue venue)
        {
            throw new NotImplementedException();
        }

        public Venue GetVenue(string name)
        {
            return venueViewContext.GetVenue(name);
        }

        public List<Venue> GetAllVenues()
        {
            throw new NotImplementedException();
        }

        public List<Venue> GetVenuesByCounty(County county)
        {
            throw new NotImplementedException();
        }

        public List<Venue> GetVenuesByLocation(string location)
        {
            throw new NotImplementedException();
        }

        public Venue UpdateVenue(Venue venue, string name, string location, County county)
        {
            return venueViewContext.UpdateVenue(venue, name, location, county);
        } 
        #endregion
    }
}
