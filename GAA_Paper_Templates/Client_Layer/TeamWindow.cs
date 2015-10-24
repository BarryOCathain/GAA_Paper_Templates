using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAA_Paper_Templates.Common;

namespace Client_Layer
{
    public partial class TeamWindow : Form
    {
        private Enums.Classification? classification; 
        public TeamWindow(Enums.Classification? _classification = null)
        {
            InitializeComponent();

            classification = _classification;
        }

        private void TeamWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
