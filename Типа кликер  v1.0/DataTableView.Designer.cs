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
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quarter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.child = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RichTextBoxScripter = new System.Windows.Forms.RichTextBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.ButtonQuartMinus = new System.Windows.Forms.Button();
            this.ButtonQuartPlus = new System.Windows.Forms.Button();
            this.ButtonYearMinus = new System.Windows.Forms.Button();
            this.ButtonYearPlus = new System.Windows.Forms.Button();
            this.TextBoxNameBaby = new System.Windows.Forms.ComboBox();
            this.LabelNameBaby = new System.Windows.Forms.Label();
            this.LabelQuart = new System.Windows.Forms.Label();
            this.TextBoxQuart = new System.Windows.Forms.TextBox();
            this.LabelYear = new System.Windows.Forms.Label();
            this.TextBoxYear = new System.Windows.Forms.TextBox();
            this.PanelDecor = new System.Windows.Forms.Panel();
            this.ButtonDetails = new Типа_кликер__v1._0.RJButton();
            this.ButtonRequest = new Типа_кликер__v1._0.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOcenki)).BeginInit();
            this.Panel.SuspendLayout();
            this.PanelDecor.SuspendLayout();
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
            this.DataGridViewOcenki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewOcenki.Location = new System.Drawing.Point(0, 62);
            this.DataGridViewOcenki.Name = "DataGridViewOcenki";
            this.DataGridViewOcenki.Size = new System.Drawing.Size(800, 376);
            this.DataGridViewOcenki.TabIndex = 0;
            this.DataGridViewOcenki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewOcenki_CellClick);
            this.DataGridViewOcenki.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewOcenki_CellContentClick);
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
            // RichTextBoxScripter
            // 
            this.RichTextBoxScripter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RichTextBoxScripter.Location = new System.Drawing.Point(0, 324);
            this.RichTextBoxScripter.Name = "RichTextBoxScripter";
            this.RichTextBoxScripter.Size = new System.Drawing.Size(800, 61);
            this.RichTextBoxScripter.TabIndex = 1;
            this.RichTextBoxScripter.Text = "SELECT * FROM grades WHERE 1=1";
            this.RichTextBoxScripter.TextChanged += new System.EventHandler(this.RichTextBoxScripter_TextChanged);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.ButtonQuartMinus);
            this.Panel.Controls.Add(this.ButtonQuartPlus);
            this.Panel.Controls.Add(this.ButtonYearMinus);
            this.Panel.Controls.Add(this.ButtonYearPlus);
            this.Panel.Controls.Add(this.TextBoxNameBaby);
            this.Panel.Controls.Add(this.LabelNameBaby);
            this.Panel.Controls.Add(this.LabelQuart);
            this.Panel.Controls.Add(this.TextBoxQuart);
            this.Panel.Controls.Add(this.LabelYear);
            this.Panel.Controls.Add(this.TextBoxYear);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(800, 62);
            this.Panel.TabIndex = 174;
            // 
            // ButtonQuartMinus
            // 
            this.ButtonQuartMinus.BackColor = System.Drawing.Color.White;
            this.ButtonQuartMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonQuartMinus.Location = new System.Drawing.Point(374, 26);
            this.ButtonQuartMinus.Name = "ButtonQuartMinus";
            this.ButtonQuartMinus.Size = new System.Drawing.Size(28, 28);
            this.ButtonQuartMinus.TabIndex = 180;
            this.ButtonQuartMinus.Text = "+";
            this.ButtonQuartMinus.UseVisualStyleBackColor = false;
            this.ButtonQuartMinus.Click += new System.EventHandler(this.ButtonQuartMinus_Click_1);
            // 
            // ButtonQuartPlus
            // 
            this.ButtonQuartPlus.BackColor = System.Drawing.Color.White;
            this.ButtonQuartPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonQuartPlus.Location = new System.Drawing.Point(294, 25);
            this.ButtonQuartPlus.Name = "ButtonQuartPlus";
            this.ButtonQuartPlus.Size = new System.Drawing.Size(28, 28);
            this.ButtonQuartPlus.TabIndex = 179;
            this.ButtonQuartPlus.Text = "-";
            this.ButtonQuartPlus.UseVisualStyleBackColor = false;
            this.ButtonQuartPlus.Click += new System.EventHandler(this.ButtonQuartPlus_Click_1);
            // 
            // ButtonYearMinus
            // 
            this.ButtonYearMinus.BackColor = System.Drawing.Color.White;
            this.ButtonYearMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonYearMinus.Location = new System.Drawing.Point(154, 25);
            this.ButtonYearMinus.Name = "ButtonYearMinus";
            this.ButtonYearMinus.Size = new System.Drawing.Size(28, 28);
            this.ButtonYearMinus.TabIndex = 177;
            this.ButtonYearMinus.Text = "-";
            this.ButtonYearMinus.UseVisualStyleBackColor = false;
            this.ButtonYearMinus.Click += new System.EventHandler(this.ButtonYearMinus_Click_1);
            // 
            // ButtonYearPlus
            // 
            this.ButtonYearPlus.BackColor = System.Drawing.Color.White;
            this.ButtonYearPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonYearPlus.Location = new System.Drawing.Point(248, 25);
            this.ButtonYearPlus.Name = "ButtonYearPlus";
            this.ButtonYearPlus.Size = new System.Drawing.Size(28, 28);
            this.ButtonYearPlus.TabIndex = 176;
            this.ButtonYearPlus.Text = "+";
            this.ButtonYearPlus.UseVisualStyleBackColor = false;
            this.ButtonYearPlus.Click += new System.EventHandler(this.ButtonYearPlus_Click_1);
            // 
            // TextBoxNameBaby
            // 
            this.TextBoxNameBaby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNameBaby.FormattingEnabled = true;
            this.TextBoxNameBaby.Items.AddRange(new object[] {
            "Андрей",
            "Рома",
            "Света"});
            this.TextBoxNameBaby.Location = new System.Drawing.Point(12, 25);
            this.TextBoxNameBaby.Name = "TextBoxNameBaby";
            this.TextBoxNameBaby.Size = new System.Drawing.Size(120, 28);
            this.TextBoxNameBaby.TabIndex = 175;
            this.TextBoxNameBaby.Text = "Андрей";
            this.TextBoxNameBaby.SelectedIndexChanged += new System.EventHandler(this.TextBoxNameBaby_SelectedIndexChanged);
            // 
            // LabelNameBaby
            // 
            this.LabelNameBaby.AutoSize = true;
            this.LabelNameBaby.Location = new System.Drawing.Point(12, 10);
            this.LabelNameBaby.Name = "LabelNameBaby";
            this.LabelNameBaby.Size = new System.Drawing.Size(44, 13);
            this.LabelNameBaby.TabIndex = 174;
            this.LabelNameBaby.Text = "Ученик";
            // 
            // LabelQuart
            // 
            this.LabelQuart.AutoSize = true;
            this.LabelQuart.Location = new System.Drawing.Point(291, 10);
            this.LabelQuart.Name = "LabelQuart";
            this.LabelQuart.Size = new System.Drawing.Size(55, 13);
            this.LabelQuart.TabIndex = 173;
            this.LabelQuart.Text = "Четверть";
            // 
            // TextBoxQuart
            // 
            this.TextBoxQuart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxQuart.Location = new System.Drawing.Point(294, 26);
            this.TextBoxQuart.Name = "TextBoxQuart";
            this.TextBoxQuart.Size = new System.Drawing.Size(108, 26);
            this.TextBoxQuart.TabIndex = 172;
            this.TextBoxQuart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxQuart.TextChanged += new System.EventHandler(this.TextBoxQuart_TextChanged);
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Location = new System.Drawing.Point(154, 10);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(25, 13);
            this.LabelYear.TabIndex = 171;
            this.LabelYear.Text = "Год";
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxYear.Location = new System.Drawing.Point(154, 26);
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.Size = new System.Drawing.Size(119, 26);
            this.TextBoxYear.TabIndex = 170;
            this.TextBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxYear.TextChanged += new System.EventHandler(this.TextBoxYear_TextChanged);
            // 
            // PanelDecor
            // 
            this.PanelDecor.Controls.Add(this.ButtonDetails);
            this.PanelDecor.Controls.Add(this.ButtonRequest);
            this.PanelDecor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelDecor.Location = new System.Drawing.Point(0, 385);
            this.PanelDecor.Name = "PanelDecor";
            this.PanelDecor.Size = new System.Drawing.Size(800, 53);
            this.PanelDecor.TabIndex = 175;
            // 
            // ButtonDetails
            // 
            this.ButtonDetails.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonDetails.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonDetails.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonDetails.BorderRadius = 15;
            this.ButtonDetails.BorderSize = 0;
            this.ButtonDetails.FlatAppearance.BorderSize = 0;
            this.ButtonDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDetails.ForeColor = System.Drawing.Color.White;
            this.ButtonDetails.Location = new System.Drawing.Point(163, 12);
            this.ButtonDetails.Name = "ButtonDetails";
            this.ButtonDetails.Size = new System.Drawing.Size(145, 29);
            this.ButtonDetails.TabIndex = 174;
            this.ButtonDetails.Text = "Подробности";
            this.ButtonDetails.TextColor = System.Drawing.Color.White;
            this.ButtonDetails.UseVisualStyleBackColor = false;
            this.ButtonDetails.Click += new System.EventHandler(this.ButtonDetails_Click);
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
            this.ButtonRequest.Location = new System.Drawing.Point(12, 12);
            this.ButtonRequest.Name = "ButtonRequest";
            this.ButtonRequest.Size = new System.Drawing.Size(145, 29);
            this.ButtonRequest.TabIndex = 173;
            this.ButtonRequest.Text = "Запрос";
            this.ButtonRequest.TextColor = System.Drawing.Color.White;
            this.ButtonRequest.UseVisualStyleBackColor = false;
            this.ButtonRequest.Click += new System.EventHandler(this.ButtonRequest_Click);
            // 
            // DataTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.RichTextBoxScripter);
            this.Controls.Add(this.PanelDecor);
            this.Controls.Add(this.DataGridViewOcenki);
            this.Controls.Add(this.Panel);
            this.Name = "DataTableView";
            this.Text = "DataTableView";
            this.Load += new System.EventHandler(this.DataTableView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOcenki)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.PanelDecor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel;
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
        private System.Windows.Forms.Panel PanelDecor;
        private System.Windows.Forms.Button ButtonQuartMinus;
        private System.Windows.Forms.Button ButtonQuartPlus;
        private System.Windows.Forms.Button ButtonYearMinus;
        private System.Windows.Forms.Button ButtonYearPlus;
        private System.Windows.Forms.ComboBox TextBoxNameBaby;
        private System.Windows.Forms.Label LabelNameBaby;
        private System.Windows.Forms.Label LabelQuart;
        private System.Windows.Forms.TextBox TextBoxQuart;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.TextBox TextBoxYear;
        private RJButton ButtonDetails;
    }
}