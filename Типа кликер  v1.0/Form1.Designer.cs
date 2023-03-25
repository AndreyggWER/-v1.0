namespace Типа_кликер__v1._0
{
    partial class Grades_Scoring
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxYear = new System.Windows.Forms.TextBox();
            this.LabelYear = new System.Windows.Forms.Label();
            this.LabelQuart = new System.Windows.Forms.Label();
            this.TextBoxQuart = new System.Windows.Forms.TextBox();
            this.LabelNameBaby = new System.Windows.Forms.Label();
            this.LabelAddSubject = new System.Windows.Forms.Label();
            this.ButtonDecor = new System.Windows.Forms.Button();
            this.LabelNameSubject = new System.Windows.Forms.Label();
            this.TextBoxNameBaby = new System.Windows.Forms.ComboBox();
            this.ButtonYearPlus = new System.Windows.Forms.Button();
            this.ButtonYearMinus = new System.Windows.Forms.Button();
            this.TextBoxNameSubject = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.ButtonGO = new Типа_кликер__v1._0.RJButton();
            this.ButtonTotal = new Типа_кликер__v1._0.RJButton();
            this.ButtonCreateFields = new Типа_кликер__v1._0.RJButton();
            this.SuspendLayout();
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.Location = new System.Drawing.Point(156, 25);
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.Size = new System.Drawing.Size(119, 20);
            this.TextBoxYear.TabIndex = 84;
            this.TextBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Location = new System.Drawing.Point(168, 9);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(25, 13);
            this.LabelYear.TabIndex = 85;
            this.LabelYear.Text = "Год";
            // 
            // LabelQuart
            // 
            this.LabelQuart.AutoSize = true;
            this.LabelQuart.Location = new System.Drawing.Point(291, 9);
            this.LabelQuart.Name = "LabelQuart";
            this.LabelQuart.Size = new System.Drawing.Size(55, 13);
            this.LabelQuart.TabIndex = 87;
            this.LabelQuart.Text = "Четверть";
            // 
            // TextBoxQuart
            // 
            this.TextBoxQuart.Location = new System.Drawing.Point(294, 25);
            this.TextBoxQuart.Name = "TextBoxQuart";
            this.TextBoxQuart.Size = new System.Drawing.Size(68, 20);
            this.TextBoxQuart.TabIndex = 86;
            // 
            // LabelNameBaby
            // 
            this.LabelNameBaby.AutoSize = true;
            this.LabelNameBaby.Location = new System.Drawing.Point(12, 9);
            this.LabelNameBaby.Name = "LabelNameBaby";
            this.LabelNameBaby.Size = new System.Drawing.Size(44, 13);
            this.LabelNameBaby.TabIndex = 152;
            this.LabelNameBaby.Text = "Ученик";
            // 
            // LabelAddSubject
            // 
            this.LabelAddSubject.BackColor = System.Drawing.Color.SlateBlue;
            this.LabelAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddSubject.ForeColor = System.Drawing.Color.White;
            this.LabelAddSubject.Location = new System.Drawing.Point(10, 78);
            this.LabelAddSubject.Name = "LabelAddSubject";
            this.LabelAddSubject.Size = new System.Drawing.Size(277, 34);
            this.LabelAddSubject.TabIndex = 154;
            this.LabelAddSubject.Text = "Добавление предмета";
            this.LabelAddSubject.Visible = false;
            // 
            // ButtonDecor
            // 
            this.ButtonDecor.BackColor = System.Drawing.Color.SlateBlue;
            this.ButtonDecor.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonDecor.Enabled = false;
            this.ButtonDecor.ForeColor = System.Drawing.Color.White;
            this.ButtonDecor.Location = new System.Drawing.Point(-2, 61);
            this.ButtonDecor.Name = "ButtonDecor";
            this.ButtonDecor.Size = new System.Drawing.Size(1843, 185);
            this.ButtonDecor.TabIndex = 158;
            this.ButtonDecor.UseVisualStyleBackColor = false;
            this.ButtonDecor.Visible = false;
            // 
            // LabelNameSubject
            // 
            this.LabelNameSubject.BackColor = System.Drawing.Color.SlateBlue;
            this.LabelNameSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameSubject.ForeColor = System.Drawing.Color.White;
            this.LabelNameSubject.Location = new System.Drawing.Point(12, 117);
            this.LabelNameSubject.Name = "LabelNameSubject";
            this.LabelNameSubject.Size = new System.Drawing.Size(85, 23);
            this.LabelNameSubject.TabIndex = 159;
            this.LabelNameSubject.Text = "Название";
            this.LabelNameSubject.Visible = false;
            // 
            // TextBoxNameBaby
            // 
            this.TextBoxNameBaby.FormattingEnabled = true;
            this.TextBoxNameBaby.Items.AddRange(new object[] {
            "Андрей",
            "Рома",
            "Света"});
            this.TextBoxNameBaby.Location = new System.Drawing.Point(12, 24);
            this.TextBoxNameBaby.Name = "TextBoxNameBaby";
            this.TextBoxNameBaby.Size = new System.Drawing.Size(120, 21);
            this.TextBoxNameBaby.TabIndex = 161;
            this.TextBoxNameBaby.Text = "Андрей";
            // 
            // ButtonYearPlus
            // 
            this.ButtonYearPlus.BackColor = System.Drawing.Color.White;
            this.ButtonYearPlus.Location = new System.Drawing.Point(250, 25);
            this.ButtonYearPlus.Name = "ButtonYearPlus";
            this.ButtonYearPlus.Size = new System.Drawing.Size(25, 20);
            this.ButtonYearPlus.TabIndex = 162;
            this.ButtonYearPlus.Text = "+";
            this.ButtonYearPlus.UseVisualStyleBackColor = false;
            this.ButtonYearPlus.Click += new System.EventHandler(this.ButtonYearMinus_Click);
            // 
            // ButtonYearMinus
            // 
            this.ButtonYearMinus.BackColor = System.Drawing.Color.White;
            this.ButtonYearMinus.Location = new System.Drawing.Point(156, 24);
            this.ButtonYearMinus.Name = "ButtonYearMinus";
            this.ButtonYearMinus.Size = new System.Drawing.Size(25, 21);
            this.ButtonYearMinus.TabIndex = 163;
            this.ButtonYearMinus.Text = "-";
            this.ButtonYearMinus.UseVisualStyleBackColor = false;
            this.ButtonYearMinus.Click += new System.EventHandler(this.ButtonYearPlus_Click);
            // 
            // TextBoxNameSubject
            // 
            this.TextBoxNameSubject.FormattingEnabled = true;
            this.TextBoxNameSubject.Items.AddRange(new object[] {
            "Чистописание",
            "Чтение",
            "Труд",
            "Природоведение",
            "Математика",
            "Музыка, Пение",
            "Изо",
            "Русский язык",
            "Родной язык\t",
            "Физкультура",
            "Основы религиозных культур и светской этики\t\t",
            "Иностранный язык",
            "Алгебра",
            "Граждановедение\t",
            "Краеведение\t",
            "История",
            "Литература\t",
            "Основы безопасности жизнедеятельности (ОБЖ)\t",
            "Технология\t",
            "География\t\t",
            "Биология\t",
            "Информатик\t",
            "Обществознание\t",
            "Черчение\t\t",
            "Геометрия",
            "Физика\t",
            "Химия\t",
            "Естествознание\t",
            "Основы экономики\t",
            "Правоведение\t",
            "Философия\t",
            "Экология\t",
            "Астрономия\t",
            "Начальная военная подготовка НВП\t",
            "Мировая художественная культура МХК\t",
            "Риторика"});
            this.TextBoxNameSubject.Location = new System.Drawing.Point(12, 142);
            this.TextBoxNameSubject.Name = "TextBoxNameSubject";
            this.TextBoxNameSubject.Size = new System.Drawing.Size(164, 21);
            this.TextBoxNameSubject.TabIndex = 164;
            this.TextBoxNameSubject.Text = "Алгебра";
            this.TextBoxNameSubject.Visible = false;
            // 
            // ButtonGO
            // 
            this.ButtonGO.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonGO.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonGO.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonGO.BorderRadius = 8;
            this.ButtonGO.BorderSize = 0;
            this.ButtonGO.FlatAppearance.BorderSize = 0;
            this.ButtonGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGO.ForeColor = System.Drawing.Color.White;
            this.ButtonGO.Location = new System.Drawing.Point(379, 24);
            this.ButtonGO.Name = "ButtonGO";
            this.ButtonGO.Size = new System.Drawing.Size(79, 21);
            this.ButtonGO.TabIndex = 165;
            this.ButtonGO.Text = "Поехали";
            this.ButtonGO.TextColor = System.Drawing.Color.White;
            this.ButtonGO.UseVisualStyleBackColor = false;
            // 
            // ButtonTotal
            // 
            this.ButtonTotal.BackColor = System.Drawing.Color.White;
            this.ButtonTotal.BackgroundColor = System.Drawing.Color.White;
            this.ButtonTotal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonTotal.BorderRadius = 8;
            this.ButtonTotal.BorderSize = 0;
            this.ButtonTotal.FlatAppearance.BorderSize = 0;
            this.ButtonTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTotal.ForeColor = System.Drawing.Color.SlateBlue;
            this.ButtonTotal.Location = new System.Drawing.Point(304, 136);
            this.ButtonTotal.Name = "ButtonTotal";
            this.ButtonTotal.Size = new System.Drawing.Size(91, 31);
            this.ButtonTotal.TabIndex = 166;
            this.ButtonTotal.Text = "Итог";
            this.ButtonTotal.TextColor = System.Drawing.Color.SlateBlue;
            this.ButtonTotal.UseVisualStyleBackColor = false;
            this.ButtonTotal.Visible = false;
            // 
            // ButtonCreateFields
            // 
            this.ButtonCreateFields.BackColor = System.Drawing.Color.White;
            this.ButtonCreateFields.BackgroundColor = System.Drawing.Color.White;
            this.ButtonCreateFields.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonCreateFields.BorderRadius = 8;
            this.ButtonCreateFields.BorderSize = 0;
            this.ButtonCreateFields.FlatAppearance.BorderSize = 0;
            this.ButtonCreateFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateFields.ForeColor = System.Drawing.Color.SlateBlue;
            this.ButtonCreateFields.Location = new System.Drawing.Point(196, 136);
            this.ButtonCreateFields.Name = "ButtonCreateFields";
            this.ButtonCreateFields.Size = new System.Drawing.Size(91, 31);
            this.ButtonCreateFields.TabIndex = 167;
            this.ButtonCreateFields.Text = "Создать";
            this.ButtonCreateFields.TextColor = System.Drawing.Color.SlateBlue;
            this.ButtonCreateFields.UseVisualStyleBackColor = false;
            this.ButtonCreateFields.Visible = false;
            // 
            // Grades_Scoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1472, 762);
            this.Controls.Add(this.ButtonCreateFields);
            this.Controls.Add(this.ButtonTotal);
            this.Controls.Add(this.ButtonGO);
            this.Controls.Add(this.TextBoxNameSubject);
            this.Controls.Add(this.ButtonYearMinus);
            this.Controls.Add(this.ButtonYearPlus);
            this.Controls.Add(this.TextBoxNameBaby);
            this.Controls.Add(this.LabelNameSubject);
            this.Controls.Add(this.LabelAddSubject);
            this.Controls.Add(this.LabelNameBaby);
            this.Controls.Add(this.LabelQuart);
            this.Controls.Add(this.TextBoxQuart);
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.TextBoxYear);
            this.Controls.Add(this.ButtonDecor);
            this.Name = "Grades_Scoring";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxYear;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.Label LabelQuart;
        private System.Windows.Forms.TextBox TextBoxQuart;
        private System.Windows.Forms.Label LabelNameBaby;
        private System.Windows.Forms.Label LabelAddSubject;
        private System.Windows.Forms.Button ButtonDecor;
        private System.Windows.Forms.Label LabelNameSubject;
        private System.Windows.Forms.ComboBox TextBoxNameBaby;
        private System.Windows.Forms.Button ButtonYearPlus;
        private System.Windows.Forms.Button ButtonYearMinus;
        private System.Windows.Forms.ComboBox TextBoxNameSubject;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private RJButton ButtonGO;
        private RJButton ButtonTotal;
        private RJButton ButtonCreateFields;
    }
}

