﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace MDiary
{
    class btnDays
    {
        private int i = 0;
        public Button GenerateBtn(string text, int day)
        {
            Button btnDefault = new Button();
            btnDefault.Text =text;
            btnDefault.Name =Convert.ToString(day);
            btnDefault.Click += new EventHandler(btnDefault_Click);
            btnDefault.Font = new Font("Segoe Print", 12, FontStyle.Bold);
            btnDefault.Size = new Size(200, 200);
            btnDefault.TabIndex = day-1;
            return btnDefault;
        }

        public void btnDefault_Click(object sender, EventArgs e)
        {
            Button nameButton = sender as Button;
            
            Dayform dfm = new Dayform(Convert.ToInt32(nameButton.Name),DateTime.Now.Month);
                dfm.Show();
        }
    }
}