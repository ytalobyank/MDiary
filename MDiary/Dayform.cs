using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDiary
{
    public partial class Dayform : Form
    {
        public Dayform()
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dayform_Load(object sender, EventArgs e)
        {

        }

        private void labelDay_Click(object sender, EventArgs e)
        {

        }
        public Dayform(int day, int mes)
        {
            InitializeComponent();
            labelDay.Text="dia " + day;
        }
    }
}
