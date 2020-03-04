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
    public partial class Edit : Form
    {
        Dayform df = new Dayform();
        public Edit()
        {
            InitializeComponent();
        }
        private int day;
        public int timeminutes;
        public int timehours;

        private void button4_Click(object sender, EventArgs e)
        {
            DataC db = new DataC();
            Console.WriteLine(textBoxHour.Text);
            int timespent=Convert.ToInt32(textBoxHour.Text);
            timeminutes=timespent;
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
                db.addActivity(rTBEdit.Text, timespent, day, data.Month);
                //df.LoadActivities();
            }
            else
            {
                MessageBox.Show("Atribua quantos minutos vai usar para esta atividade");
            }
        }
        public Edit(int day)
        {
            InitializeComponent();
            
            MDiary md = new MDiary();
            labelMonth.Text =md.MonthForLabels();
            labelDayedit.Text = "Dia : " + day;
            textBoxHour.MaxLength = 3;
            this.day = day;
            Edit ed = new Edit();
            ed.FormClosed += Edit_FormClosed;

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

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            df.LoadActivities();
        }

}
}
