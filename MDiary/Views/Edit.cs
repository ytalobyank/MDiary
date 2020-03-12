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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private readonly int Day;
        public int timehours;

        private void button4_Click(object sender, EventArgs e)
        {
            var activityRepo = new ActivitiesRepository();

            Console.WriteLine(textBoxHour.Text);

            int timespent=Convert.ToInt32(textBoxHour.Text);
            /*if (timespent>60 && timespent>0)
            {
                if (timespent % 60 == 0)
                {
                    timehours = timespent / 60;
                }
                else
                {
                    timeminutes = timespent % 60;
                }
            }
            else if(timespent>0 && timespent<60)
            {
                timeminutes = timespent;
            }*/
            DateTime data = DateTime.Now;

            if (!textBoxHour.Text.Equals(null))
            {
                var activity = new Activity
                {
                    Description = rTBEdit.Text,
                    TimeSpent = timespent,
                    Day = Day,
                    Month = data.Month,
                };
                activityRepo.AddActivity(activity);
            }
            else
            {
                MessageBox.Show("Atribua quantos minutos vai usar para esta atividade");
            }
        }

        public Edit(int day)
        {
            InitializeComponent();

            var activityRepo = new ActivitiesRepository();
            MainForm md = new MainForm();
            labelMonth.Text = md.GetMonthName();
            //labelDayedit.Text = "Dia : " + day;
            textBoxHour.MaxLength = 3;
            Day = day;
            int tempoDispTotalMinutos = 24 * 60 - activityRepo.GetAvailableTime(Day, DateTime.Now.Month);
            int tempoDispHoras = tempoDispTotalMinutos / 60;
            int tempoDispMinutos = tempoDispTotalMinutos % 60;

            string tempoText = tempoDispHoras.ToString() + "h";
            if(tempoDispMinutos > 0)
            {
                tempoText += " " + tempoDispMinutos + "m";
            }
            labelSchedule.Text = tempoText;
        }

        private void textBoxHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void textBoxHour_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Load(object sender, EventArgs e) 
        {
            
        }
    }
}
