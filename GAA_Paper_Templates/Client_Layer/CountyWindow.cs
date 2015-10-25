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
    public partial class CountyWindow : Form, ICountyView
    {
        private GAA_Templates_ModelContainer context;
        private CountyView countyViewContext;

        private bool update;
        public CountyWindow(bool _update = false)
        {
            InitializeComponent();

            update = _update;

            context = new GAA_Templates_ModelContainer();
            countyViewContext = new CountyView(context);

            bindProvincesToComboBox();
        }

        private void CountyWindow_Load(object sender, EventArgs e)
        {

        }

        private void bindProvincesToComboBox()
        {
            this.provinceComboBox.DataSource = Enum.GetValues(typeof(Enums.Provinces));
        }

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

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.nameTextBox.Text))
            {
                County cty = GetCounty(this.nameTextBox.Text);
                if (update && cty != null)
                {
                    UpdateCounty(GetCounty(this.nameTextBox.Text), this.nameTextBox.Text, (Enums.Provinces)this.provinceComboBox.SelectedItem);
                    MessageBox.Show("County Updated.");
                }
                else if (!update && cty == null)
                {
                    CreateCounty(this.nameTextBox.Text, (Enums.Provinces)this.provinceComboBox.SelectedItem);
                }

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
