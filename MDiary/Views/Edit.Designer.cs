namespace MDiary.Views
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.rTBEdit = new System.Windows.Forms.RichTextBox();
            this.labelTitleedit = new System.Windows.Forms.Label();
            this.labelHouredit = new System.Windows.Forms.Label();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.labelDayedit = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelScheduleTitle = new System.Windows.Forms.Label();
            this.labelSchedule = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(12, 78);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 96);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button4_Click);
            // 
            // rTBEdit
            // 
            this.rTBEdit.Location = new System.Drawing.Point(126, 78);
            this.rTBEdit.Name = "rTBEdit";
            this.rTBEdit.Size = new System.Drawing.Size(239, 63);
            this.rTBEdit.TabIndex = 4;
            this.rTBEdit.Text = "";
            // 
            // labelTitleedit
            // 
            this.labelTitleedit.AutoSize = true;
            this.labelTitleedit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitleedit.Location = new System.Drawing.Point(65, 36);
            this.labelTitleedit.Name = "labelTitleedit";
            this.labelTitleedit.Size = new System.Drawing.Size(258, 28);
            this.labelTitleedit.TabIndex = 5;
            this.labelTitleedit.Text = "Adicione atividades ao seu dia.";
            // 
            // labelHouredit
            // 
            this.labelHouredit.AutoSize = true;
            this.labelHouredit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.labelHouredit.Location = new System.Drawing.Point(126, 148);
            this.labelHouredit.Name = "labelHouredit";
            this.labelHouredit.Size = new System.Drawing.Size(76, 28);
            this.labelHouredit.TabIndex = 6;
            this.labelHouredit.Text = "Minutos";
            // 
            // textBoxHour
            // 
            this.textBoxHour.Location = new System.Drawing.Point(203, 154);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(42, 20);
            this.textBoxHour.TabIndex = 7;
            this.textBoxHour.TextChanged += new System.EventHandler(this.textBoxHour_TextChanged);
            this.textBoxHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHour_KeyPress);
            // 
            // labelDayedit
            // 
            this.labelDayedit.AutoSize = true;
            this.labelDayedit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.labelDayedit.Location = new System.Drawing.Point(285, 149);
            this.labelDayedit.Name = "labelDayedit";
            this.labelDayedit.Size = new System.Drawing.Size(0, 28);
            this.labelDayedit.TabIndex = 8;
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonth.Location = new System.Drawing.Point(141, 9);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(61, 19);
            this.labelMonth.TabIndex = 9;
            this.labelMonth.Text = "Fevereiro";
            // 
            // labelScheduleTitle
            // 
            this.labelScheduleTitle.AutoSize = true;
            this.labelScheduleTitle.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScheduleTitle.Location = new System.Drawing.Point(271, 144);
            this.labelScheduleTitle.Name = "labelScheduleTitle";
            this.labelScheduleTitle.Size = new System.Drawing.Size(108, 19);
            this.labelScheduleTitle.TabIndex = 10;
            this.labelScheduleTitle.Text = "Horário disponível";
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchedule.Location = new System.Drawing.Point(312, 163);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(25, 19);
            this.labelSchedule.TabIndex = 11;
            this.labelSchedule.Text = "24";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 6.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(141, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Digite o valor em MINUTOS!";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 195);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSchedule);
            this.Controls.Add(this.labelScheduleTitle);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelDayedit);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.labelHouredit);
            this.Controls.Add(this.labelTitleedit);
            this.Controls.Add(this.rTBEdit);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Edit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rTBEdit;
        private System.Windows.Forms.Label labelTitleedit;
        private System.Windows.Forms.Label labelHouredit;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.Label labelDayedit;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelScheduleTitle;
        private System.Windows.Forms.Label labelSchedule;
        private System.Windows.Forms.Label label2;
    }
}