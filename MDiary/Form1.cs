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

        private void MDiary_Load(object sender, EventArgs e)
        {

            //db.compareDay();
            labelMonth.Text=MonthForLabels();
         
            for (int i = 1; i <DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);i++)
            {
                this.tableLayoutPanel1.Controls.Add((btn.GenerateBtn("Dia " + i, i)));
                days[i-1] = i;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            tableLayoutPanel1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            labelMonth.Anchor= (AnchorStyles.Bottom | AnchorStyles.Right);
        }
        public string MonthForLabels()
        {
            int monthnumb;
            DateTime data = DateTime.Now;
            monthnumb = data.Month;
            if(monthnumb!= 0)
            {
                switch (monthnumb)
                {
                    case 1:
                        return "Janeiro";
                    case 2:
                        return "Fevereiro";
                    case 3:
                        return "Março";
                    case 4:
                        return "Abril";
                    case 5:
                        return "Maio";
                    case 6:
                        return "Junho";
                    case 7:
                        return "Julho";
                    case 8:
                        return "Agosto";
                    case 9:
                        return "Setembro";
                    case 10:
                        return "Outubro";
                    case 11:
                        return "Novembro";
                    case 12:
                        return "Dezembro";
                }
            }
            else
            {
                return "não há valor";
            }
            return "ok";
        }
    }
}
