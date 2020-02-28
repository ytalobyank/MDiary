namespace MDiary
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
            this.labelDay = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvObjectives
            // 
            this.lvObjectives.HideSelection = false;
            this.lvObjectives.Location = new System.Drawing.Point(12, 54);
            this.lvObjectives.Name = "lvObjectives";
            this.lvObjectives.Size = new System.Drawing.Size(305, 326);
            this.lvObjectives.TabIndex = 2;
            this.lvObjectives.UseCompatibleStateImageBehavior = false;
            this.lvObjectives.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
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
            this.btnEdit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(197, 386);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 47);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // Dayform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 460);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.lvObjectives);
            this.Name = "Dayform";
            this.Text = "Dayform";
            this.Load += new System.EventHandler(this.Dayform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvObjectives;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Button btnEdit;
    }
}