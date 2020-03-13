using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MDiary.Repositories;
using Npgsql;

namespace MDiary.Views
{
    public partial class MainForm : Form
    {
        private readonly int[] days = new int[DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)];

        public Button GenerateBtn(string text, int day)
        {
            Button btnDefault = new Button();
            btnDefault.Text = text;
            btnDefault.Name = Convert.ToString(day);
            btnDefault.Click += new EventHandler(btnDefault_Click);
            btnDefault.Font = new Font("Segoe Print", 12, FontStyle.Bold);
            btnDefault.Size = new Size(200, 200);
            btnDefault.TabIndex = day - 1;
            return btnDefault;
        }

        private static void btnDefault_Click(object sender, EventArgs e)
        {
            Button nameButton = sender as Button;

            if (Application.OpenForms.OfType<Dayform>().Count() > 0)
            {
                Application.OpenForms.OfType<Dayform>().First().Focus();
            }
            else
            {
                Dayform dfm = new Dayform(Convert.ToInt32(nameButton.Name));
                dfm.ShowDialog();
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MDiary_Load(object sender, EventArgs e)
        {
            labelMonth.Text=GetMonthName();
         
            for (int i = 1; i <DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);i++)
            {
                tableLayoutPanel1.Controls.Add(GenerateBtn("Dia " + i, i));
                days[i-1] = i;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            tableLayoutPanel1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            labelMonth.Anchor= (AnchorStyles.Bottom | AnchorStyles.Right);
        }

        public string GetMonthName()
        {
            return DateTime.Now.ToString("MMMM", CultureInfo.CurrentCulture);
        }
    }
}
