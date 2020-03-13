namespace MDiary.Views
{
    partial class Dayform
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
            this.lvObjectives = new System.Windows.Forms.ListView();
            this.columnActivity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelDay = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelScheduleTitle = new System.Windows.Forms.Label();
            this.labelSchedule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvObjectives
            // 
            this.lvObjectives.CheckBoxes = true;
            this.lvObjectives.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnActivity,
            this.columnHour});
            this.lvObjectives.HideSelection = false;
            this.lvObjectives.Location = new System.Drawing.Point(12, 54);
            this.lvObjectives.Name = "lvObjectives";
            this.lvObjectives.Size = new System.Drawing.Size(305, 351);
            this.lvObjectives.TabIndex = 2;
            this.lvObjectives.UseCompatibleStateImageBehavior = false;
            this.lvObjectives.View = System.Windows.Forms.View.List;
            this.lvObjectives.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnActivity
            // 
            this.columnActivity.Text = "Atividade";
            this.columnActivity.Width = 200;
            // 
            // columnHour
            // 
            this.columnHour.Text = "Horário";
            this.columnHour.Width = 105;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Location = new System.Drawing.Point(122, 9);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(69, 28);
            this.labelDay.TabIndex = 3;
            this.labelDay.Text = "Dia 30";
            this.labelDay.Click += new System.EventHandler(this.labelDay_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(40, 411);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 37);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Adicionar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(210, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelScheduleTitle
            // 
            this.labelScheduleTitle.AutoSize = true;
            this.labelScheduleTitle.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScheduleTitle.Location = new System.Drawing.Point(209, 9);
            this.labelScheduleTitle.Name = "labelScheduleTitle";
            this.labelScheduleTitle.Size = new System.Drawing.Size(85, 19);
            this.labelScheduleTitle.TabIndex = 6;
            this.labelScheduleTitle.Text = "Horário Atual";
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchedule.Location = new System.Drawing.Point(237, 32);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(0, 19);
            this.labelSchedule.TabIndex = 7;
            // 
            // Dayform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 460);
            this.Controls.Add(this.labelSchedule);
            this.Controls.Add(this.labelScheduleTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.lvObjectives);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Dayform";
            this.Text = "Dayform";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView lvObjectives;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ColumnHeader columnActivity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHour;
        private System.Windows.Forms.Label labelScheduleTitle;
        private System.Windows.Forms.Label labelSchedule;
    }
}