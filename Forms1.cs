using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Conversor
{
    public partial class Forms1 : Form
    {
        public Forms1()
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem Area = new ListViewItem("Área");
            ListViewItem Tempo = new ListViewItem("Tempo");

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
