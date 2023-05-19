namespace Типа_кликер__v1._0
{
    partial class DataTableView
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
            this.DataGridViewOcenki = new System.Windows.Forms.DataGridView();
            this.RichTextBoxScripter = new System.Windows.Forms.RichTextBox();
            this.ButtonRequest = new Типа_кликер__v1._0.RJButton();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quarter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.child = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOcenki)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewOcenki
            // 
            this.DataGridViewOcenki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOcenki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.year,
            this.quarter,
            this.child,
            this.Subject,
            this.Grades,
            this.Points});
            this.DataGridViewOcenki.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridViewOcenki.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewOcenki.Name = "DataGridViewOcenki";
            this.DataGridViewOcenki.Size = new System.Drawing.Size(800, 268);
            this.DataGridViewOcenki.TabIndex = 0;
            // 
            // RichTextBoxScripter
            // 
            this.RichTextBoxScripter.Dock = System.Windows.Forms.DockStyle.Top;
            this.RichTextBoxScripter.Location = new System.Drawing.Point(0, 268);
            this.RichTextBoxScripter.Name = "RichTextBoxScripter";
            this.RichTextBoxScripter.Size = new System.Drawing.Size(800, 130);
            this.RichTextBoxScripter.TabIndex = 1;
            this.RichTextBoxScripter.Text = "SELECT * FROM `grades`";
            // 
            // ButtonRequest
            // 
            this.ButtonRequest.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonRequest.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonRequest.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonRequest.BorderRadius = 15;
            this.ButtonRequest.BorderSize = 0;
            this.ButtonRequest.FlatAppearance.BorderSize = 0;
            this.ButtonRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRequest.ForeColor = System.Drawing.Color.White;
            this.ButtonRequest.Location = new System.Drawing.Point(12, 409);
            this.ButtonRequest.Name = "ButtonRequest";
            this.ButtonRequest.Size = new System.Drawing.Size(145, 29);
            this.ButtonRequest.TabIndex = 173;
            this.ButtonRequest.Text = "Запрос";
            this.ButtonRequest.TextColor = System.Drawing.Color.White;
            this.ButtonRequest.UseVisualStyleBackColor = false;
            this.ButtonRequest.Click += new System.EventHandler(this.ButtonRequest_Click);
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "Код";
            this.code.Name = "code";
            // 
            // year
            // 
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "Год";
            this.year.Name = "year";
            // 
            // quarter
            // 
            this.quarter.DataPropertyName = "quarter";
            this.quarter.HeaderText = "Четверть";
            this.quarter.Name = "quarter";
            // 
            // child
            // 
            this.child.DataPropertyName = "child";
            this.child.HeaderText = "Ребёнок";
            this.child.Name = "child";
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "subject";
            this.Subject.HeaderText = "Предмет";
            this.Subject.Name = "Subject";
            // 
            // Grades
            // 
            this.Grades.DataPropertyName = "grades";
            this.Grades.HeaderText = "Оценки";
            this.Grades.Name = "Grades";
            // 
            // Points
            // 
            this.Points.DataPropertyName = "points";
            this.Points.HeaderText = "Бонус";
            this.Points.Name = "Points";
            // 
            // DataTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonRequest);
            this.Controls.Add(this.RichTextBoxScripter);
            this.Controls.Add(this.DataGridViewOcenki);
            this.Name = "DataTableView";
            this.Text = "DataTableView";
            this.Load += new System.EventHandler(this.DataTableView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOcenki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewOcenki;
        private System.Windows.Forms.RichTextBox RichTextBoxScripter;
        private RJButton ButtonRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn quarter;
        private System.Windows.Forms.DataGridViewTextBoxColumn child;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
    }
}