using System;
using System.Windows.Forms;
using Npgsql;

namespace MDiary
{
    public partial class MDiary : Form
    {
        btnDays btn = new btnDays();
        DataC db = new DataC();
        int[] days = new int[DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)];
        public MDiary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dayform dfm = new Dayform();
            dfm.Show();
        }

        private void btnDay2_Click(object sender, EventArgs e)
        {
                        NpgsqlConnection conn = db.Connection();
            
            try {
                conn.Open();
                MessageBox.Show("Conexão efetuada");
            }
            catch (Exception error)
            {
                Console.WriteLine(error);

            }


        }

        private void MDiary_Load(object sender, EventArgs e)
        {
            int monthnumb = 0;
            DateTime data = DateTime.Now;
            monthnumb = data.Month;
            switch (monthnumb)
            {
                case 1:
                    labelMonth.Text = "Janeiro";
                    break;
                case 2:
                    labelMonth.Text = "Fevereiro";
                    break;
                case 3:
                    labelMonth.Text = "Março";
                    break;
                case 4:
                    labelMonth.Text = "Abril";
                    break;
                case 5:
                    labelMonth.Text = "Maio";
                    break;
                case 6:
                    labelMonth.Text = "Junho";
                    break;
                case 7:
                    labelMonth.Text = "Julho";
                    break;
                case 8:
                    labelMonth.Text = "Agosto";
                    break;
                case 9:
                    labelMonth.Text = "Setembro";
                    break;
                case 10:
                    labelMonth.Text = "Outubro";
                    break;
                case 11:
                    labelMonth.Text = "Novembro";
                    break;
                case 12:
                    labelMonth.Text = "Dezembro";
                    break;
            }               
            //db.compareDay();

         
            for (int i = 1; i <DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);i++)
            {
                this.tableLayoutPanel1.Controls.Add((btn.GenerateBtn("Dia " + i, i)));
                days[i-1] = i;
                Console.WriteLine(i);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            tableLayoutPanel1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
        }
    }
}
