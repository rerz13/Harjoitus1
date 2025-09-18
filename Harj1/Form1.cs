using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harj1
{
    public partial class VaihdaForm : Form
    {
        public VaihdaForm()
        {
            InitializeComponent();
        }

        private void VaihdaBT_Click(object sender, EventArgs e)
        {
            OtsikkoLB.Text = "Heippa maailma!";
        }
    }
}
