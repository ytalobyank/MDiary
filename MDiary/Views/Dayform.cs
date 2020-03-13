using MDiary.Models;
using MDiary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDiary.Views
{
    public partial class Dayform : Form
    {
        private int Day { get; }
        private int Month { get; } = DateTime.Now.Month;

        public Dayform()
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelDay_Click(object sender, EventArgs e)
        {

        }
        public void LoadActivities()
        {
            lvObjectives.Items.Clear();
            var actRepository = new ActivitiesRepository();
            try
            {
                var activities = actRepository.GetActivitiesForDay(Day, Month);

                foreach(Activity act in activities)
                {
                    var item = new ListViewItem(act.Description);
                    item.SubItems.Add(act.TimeSpent.ToString());
                    lvObjectives.Items.Add(item);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                MessageBox.Show("Algo deu errado");
            }
        }

        public Dayform(int day)
        {
            InitializeComponent();

            this.Day = day;
            labelDay.Text = "dia " + day;
            lvObjectives.View = View.Details;
            LoadActivities();
            lvObjectives.ColumnWidthChanging += new ColumnWidthChangingEventHandler(lvObjectives_ColumnWidthChanging);
        }

        private void lvObjectives_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // Check if the new width is too big or too small.
            if (e.NewWidth > 1 || e.NewWidth < 1)
            {
                MessageBox.Show("Não é possível mudar isto.");
                e.Cancel = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Edit>().Count() > 0)
            {
                Application.OpenForms.OfType<Edit>().First().Focus();
            }
            else
            {
                Edit ed = new Edit(Day);
                ed.ShowDialog();
                LoadActivities();
            }
        }
    }
}
