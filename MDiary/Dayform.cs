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
        Timer timec = new Timer();
        
        private int day = 0;
        private int mes = DateTime.Now.Month;
        public Dayform()
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dayform_Load(object sender, EventArgs e)
        {
            timec.Interval = 1000;
            timec.Tick += new EventHandler(this.t_Tick);
            timec.Start();
            FormClosed += Form_FormClosed;
        }
        private void Form_FormClosed(Object sender, FormClosedEventArgs e)
        {
            timec.Stop();
        }

        private void labelDay_Click(object sender, EventArgs e)
        {

        }
        public void LoadActivities()
        {
            lvObjectives.Items.Clear();
            DataC dt = new DataC();
            try
            {
                dt.SelectingActivities(this.day);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                MessageBox.Show("Algo deu errado");
            }
            ListViewItem[] items = new ListViewItem[dt.getDescriptActivities().Length];
            if (dt.getDescriptActivities().Length != 0)
            {
                for (int i = 0; i < dt.getDescriptActivities().Length; i++)
                {
                    string[] test = new string[dt.getDescriptActivities().Length];
                    int[] testint = new int[dt.getTimeInMinutes().Length];
                    testint = dt.getTimeInMinutes();
                    test = dt.getDescriptActivities();
                    items[i] = new ListViewItem(test[i]);
                    items[i].SubItems.Add(Convert.ToString(testint[i]));
                    lvObjectives.Items.Add(items[i]);
                }
            }

        }
        public Dayform(int day)
        {
            InitializeComponent();
            
            this.day = day;
            labelDay.Text="dia " + day;
            lvObjectives.View = View.Details;
            LoadActivities();
            lvObjectives.ColumnWidthChanging +=new ColumnWidthChangingEventHandler(lvObjectives_ColumnWidthChanging);
        }
        private void lvObjectives_ColumnWidthChanging(object sender,ColumnWidthChangingEventArgs e)
            {
            // Check if the new width is too big or too small.
            if (e.NewWidth > 1 || e.NewWidth < 1)
            {
                    MessageBox.Show("Não é possível mudar isto.");
                e.Cancel = true;
            }
        }

    private void t_Tick(object sender, EventArgs e)
        {

            Invoke((MethodInvoker)delegate () { updateTimer(); });

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Edit>().Count() > 0)
            {
                Application.OpenForms.OfType<Edit>().First().Focus();
            }
            else
            {
                
                Edit ed = new Edit(day);
                ed.ShowDialog();
            }
        }
        private void updateTimer()
        {
            var agora = DateTime.Now;
            labelSchedule.Text = Convert.ToString(agora.TimeOfDay.Hours) + ":" + Convert.ToString(agora.TimeOfDay.Minutes);
        }
    }
}
