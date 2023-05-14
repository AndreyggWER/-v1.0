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
            this.LabelNameSubject = new System.Windows.Forms.Label();
            this.TextBoxNameBaby = new System.Windows.Forms.ComboBox();
            this.ButtonYearPlus = new System.Windows.Forms.Button();
            this.ButtonYearMinus = new System.Windows.Forms.Button();
            this.TextBoxNameSubject = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.ButtonQuartPlus = new System.Windows.Forms.Button();
            this.ButtonQuartMinus = new System.Windows.Forms.Button();
            this.PanelDecor = new System.Windows.Forms.Panel();
            this.ButtonCreateFields = new Типа_кликер__v1._0.RJButton();
            this.ButtonTotal = new Типа_кликер__v1._0.RJButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ButtonRegOrLog = new Типа_кликер__v1._0.RJButton();
            this.ButtonPrint = new Типа_кликер__v1._0.RJButton();
            this.ButtonGO = new Типа_кликер__v1._0.RJButton();
            this.PanelDecor.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxYear.Location = new System.Drawing.Point(154, 25);
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.Size = new System.Drawing.Size(119, 26);
            this.TextBoxYear.TabIndex = 84;
            this.TextBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Location = new System.Drawing.Point(154, 9);
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
            this.TextBoxQuart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxQuart.Location = new System.Drawing.Point(294, 25);
            this.TextBoxQuart.Name = "TextBoxQuart";
            this.TextBoxQuart.Size = new System.Drawing.Size(108, 26);
            this.TextBoxQuart.TabIndex = 86;
            this.TextBoxQuart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxQuart.TextChanged += new System.EventHandler(this.TextBoxQuart_TextChanged);
            this.TextBoxQuart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxQuart_KeyDown);
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
            this.LabelAddSubject.Location = new System.Drawing.Point(13, 13);
            this.LabelAddSubject.Name = "LabelAddSubject";
            this.LabelAddSubject.Size = new System.Drawing.Size(277, 34);
            this.LabelAddSubject.TabIndex = 154;
            this.LabelAddSubject.Text = "Добавление предмета";
            this.LabelAddSubject.Visible = false;
            // 
            // LabelNameSubject
            // 
            this.LabelNameSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameSubject.ForeColor = System.Drawing.Color.White;
            this.LabelNameSubject.Location = new System.Drawing.Point(13, 51);
            this.LabelNameSubject.Name = "LabelNameSubject";
            this.LabelNameSubject.Size = new System.Drawing.Size(85, 23);
            this.LabelNameSubject.TabIndex = 159;
            this.LabelNameSubject.Text = "Название";
            this.LabelNameSubject.Visible = false;
            // 
            // TextBoxNameBaby
            // 
            this.TextBoxNameBaby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNameBaby.FormattingEnabled = true;
            this.TextBoxNameBaby.Items.AddRange(new object[] {
            "Андрей",
            "Рома",
            "Света"});
            this.TextBoxNameBaby.Location = new System.Drawing.Point(12, 24);
            this.TextBoxNameBaby.Name = "TextBoxNameBaby";
            this.TextBoxNameBaby.Size = new System.Drawing.Size(120, 28);
            this.TextBoxNameBaby.TabIndex = 161;
            this.TextBoxNameBaby.Text = "Андрей";
            // 
            // ButtonYearPlus
            // 
            this.ButtonYearPlus.BackColor = System.Drawing.Color.White;
            this.ButtonYearPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonYearPlus.Location = new System.Drawing.Point(248, 24);
            this.ButtonYearPlus.Name = "ButtonYearPlus";
            this.ButtonYearPlus.Size = new System.Drawing.Size(28, 28);
            this.ButtonYearPlus.TabIndex = 162;
            this.ButtonYearPlus.Text = "+";
            this.ButtonYearPlus.UseVisualStyleBackColor = false;
            this.ButtonYearPlus.Click += new System.EventHandler(this.ButtonYearMinus_Click);
            // 
            // ButtonYearMinus
            // 
            this.ButtonYearMinus.BackColor = System.Drawing.Color.White;
            this.ButtonYearMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonYearMinus.Location = new System.Drawing.Point(154, 24);
            this.ButtonYearMinus.Name = "ButtonYearMinus";
            this.ButtonYearMinus.Size = new System.Drawing.Size(28, 28);
            this.ButtonYearMinus.TabIndex = 163;
            this.ButtonYearMinus.Text = "-";
            this.ButtonYearMinus.UseVisualStyleBackColor = false;
            this.ButtonYearMinus.Click += new System.EventHandler(this.ButtonYearPlus_Click);
            // 
            // TextBoxNameSubject
            // 
            this.TextBoxNameSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            "Родной язык",
            "Физкультура",
            "Основы религиозных культур и светской этики",
            "Иностранный язык",
            "Алгебра",
            "Граждановедение",
            "Краеведение",
            "История",
            "Литература",
            "Основы безопасности жизнедеятельности (ОБЖ)\t",
            "Технология",
            "География",
            "Биология\t",
            "Информатик",
            "Обществознание\t",
            "Черчение\t",
            "Геометрия",
            "Физика",
            "Химия",
            "Естествознание",
            "Основы экономики\t",
            "Правоведение",
            "Философия",
            "Экология\t",
            "Астрономия",
            "Начальная военная подготовка НВП\t",
            "Мировая художественная культура МХК\t",
            "Риторика"});
            this.TextBoxNameSubject.Location = new System.Drawing.Point(15, 77);
            this.TextBoxNameSubject.Name = "TextBoxNameSubject";
            this.TextBoxNameSubject.Size = new System.Drawing.Size(164, 28);
            this.TextBoxNameSubject.TabIndex = 164;
            this.TextBoxNameSubject.Text = "Алгебра";
            this.TextBoxNameSubject.Visible = false;
            // 
            // ButtonQuartPlus
            // 
            this.ButtonQuartPlus.BackColor = System.Drawing.Color.White;
            this.ButtonQuartPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonQuartPlus.Location = new System.Drawing.Point(377, 24);
            this.ButtonQuartPlus.Name = "ButtonQuartPlus";
            this.ButtonQuartPlus.Size = new System.Drawing.Size(28, 28);
            this.ButtonQuartPlus.TabIndex = 168;
            this.ButtonQuartPlus.Text = "+";
            this.ButtonQuartPlus.UseVisualStyleBackColor = false;
            this.ButtonQuartPlus.Click += new System.EventHandler(this.ButtonQuartMinus_Click);
            // 
            // ButtonQuartMinus
            // 
            this.ButtonQuartMinus.BackColor = System.Drawing.Color.White;
            this.ButtonQuartMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonQuartMinus.Location = new System.Drawing.Point(294, 25);
            this.ButtonQuartMinus.Name = "ButtonQuartMinus";
            this.ButtonQuartMinus.Size = new System.Drawing.Size(28, 28);
            this.ButtonQuartMinus.TabIndex = 169;
            this.ButtonQuartMinus.Text = "-";
            this.ButtonQuartMinus.UseVisualStyleBackColor = false;
            this.ButtonQuartMinus.Click += new System.EventHandler(this.ButtonQuartPlus_Click);
            // 
            // PanelDecor
            // 
            this.PanelDecor.BackColor = System.Drawing.Color.SlateBlue;
            this.PanelDecor.Controls.Add(this.LabelAddSubject);
            this.PanelDecor.Controls.Add(this.LabelNameSubject);
            this.PanelDecor.Controls.Add(this.TextBoxNameSubject);
            this.PanelDecor.Controls.Add(this.ButtonCreateFields);
            this.PanelDecor.Controls.Add(this.ButtonTotal);
            this.PanelDecor.Location = new System.Drawing.Point(-2, 70);
            this.PanelDecor.Name = "PanelDecor";
            this.PanelDecor.Size = new System.Drawing.Size(1847, 128);
            this.PanelDecor.TabIndex = 170;
            this.PanelDecor.Visible = false;
            // 
            // ButtonCreateFields
            // 
            this.ButtonCreateFields.BackColor = System.Drawing.Color.White;
            this.ButtonCreateFields.BackgroundColor = System.Drawing.Color.White;
            this.ButtonCreateFields.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonCreateFields.BorderRadius = 15;
            this.ButtonCreateFields.BorderSize = 0;
            this.ButtonCreateFields.FlatAppearance.BorderSize = 0;
            this.ButtonCreateFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreateFields.ForeColor = System.Drawing.Color.SlateBlue;
            this.ButtonCreateFields.Location = new System.Drawing.Point(199, 75);
            this.ButtonCreateFields.Name = "ButtonCreateFields";
            this.ButtonCreateFields.Size = new System.Drawing.Size(125, 30);
            this.ButtonCreateFields.TabIndex = 167;
            this.ButtonCreateFields.Text = "Создать";
            this.ButtonCreateFields.TextColor = System.Drawing.Color.SlateBlue;
            this.ButtonCreateFields.UseVisualStyleBackColor = false;
            this.ButtonCreateFields.Visible = false;
            this.ButtonCreateFields.Click += new System.EventHandler(this.ButtonCreateFields_Click_1);
            // 
            // ButtonTotal
            // 
            this.ButtonTotal.BackColor = System.Drawing.Color.White;
            this.ButtonTotal.BackgroundColor = System.Drawing.Color.White;
            this.ButtonTotal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonTotal.BorderRadius = 15;
            this.ButtonTotal.BorderSize = 0;
            this.ButtonTotal.FlatAppearance.BorderSize = 0;
            this.ButtonTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonTotal.ForeColor = System.Drawing.Color.SlateBlue;
            this.ButtonTotal.Location = new System.Drawing.Point(343, 75);
            this.ButtonTotal.Name = "ButtonTotal";
            this.ButtonTotal.Size = new System.Drawing.Size(125, 30);
            this.ButtonTotal.TabIndex = 166;
            this.ButtonTotal.Text = "Итог";
            this.ButtonTotal.TextColor = System.Drawing.Color.SlateBlue;
            this.ButtonTotal.UseVisualStyleBackColor = false;
            this.ButtonTotal.Visible = false;
            this.ButtonTotal.Click += new System.EventHandler(this.ButtonTotal_Click_1);
            // 
            // ButtonRegOrLog
            // 
            this.ButtonRegOrLog.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonRegOrLog.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonRegOrLog.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonRegOrLog.BorderRadius = 15;
            this.ButtonRegOrLog.BorderSize = 0;
            this.ButtonRegOrLog.FlatAppearance.BorderSize = 0;
            this.ButtonRegOrLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegOrLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRegOrLog.ForeColor = System.Drawing.Color.White;
            this.ButtonRegOrLog.Location = new System.Drawing.Point(540, 22);
            this.ButtonRegOrLog.Name = "ButtonRegOrLog";
            this.ButtonRegOrLog.Size = new System.Drawing.Size(145, 29);
            this.ButtonRegOrLog.TabIndex = 172;
            this.ButtonRegOrLog.Text = "Авторизация";
            this.ButtonRegOrLog.TextColor = System.Drawing.Color.White;
            this.ButtonRegOrLog.UseVisualStyleBackColor = false;
            this.ButtonRegOrLog.Click += new System.EventHandler(this.ButtonRegOrLog_Click);
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonPrint.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonPrint.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonPrint.BorderRadius = 15;
            this.ButtonPrint.BorderSize = 0;
            this.ButtonPrint.FlatAppearance.BorderSize = 0;
            this.ButtonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPrint.ForeColor = System.Drawing.Color.White;
            this.ButtonPrint.Location = new System.Drawing.Point(248, 489);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(100, 30);
            this.ButtonPrint.TabIndex = 171;
            this.ButtonPrint.Text = "Печать";
            this.ButtonPrint.TextColor = System.Drawing.Color.White;
            this.ButtonPrint.UseVisualStyleBackColor = false;
            this.ButtonPrint.Visible = false;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // ButtonGO
            // 
            this.ButtonGO.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonGO.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonGO.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonGO.BorderRadius = 15;
            this.ButtonGO.BorderSize = 0;
            this.ButtonGO.FlatAppearance.BorderSize = 0;
            this.ButtonGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonGO.ForeColor = System.Drawing.Color.White;
            this.ButtonGO.Location = new System.Drawing.Point(421, 22);
            this.ButtonGO.Name = "ButtonGO";
            this.ButtonGO.Size = new System.Drawing.Size(113, 30);
            this.ButtonGO.TabIndex = 165;
            this.ButtonGO.Text = "Поехали";
            this.ButtonGO.TextColor = System.Drawing.Color.White;
            this.ButtonGO.UseVisualStyleBackColor = false;
            this.ButtonGO.Click += new System.EventHandler(this.ButtonGO_Click_1);
            // 
            // Grades_Scoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1911, 1061);
            this.Controls.Add(this.ButtonRegOrLog);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.PanelDecor);
            this.Controls.Add(this.ButtonQuartMinus);
            this.Controls.Add(this.ButtonQuartPlus);
            this.Controls.Add(this.ButtonGO);
            this.Controls.Add(this.ButtonYearMinus);
            this.Controls.Add(this.ButtonYearPlus);
            this.Controls.Add(this.TextBoxNameBaby);
            this.Controls.Add(this.LabelNameBaby);
            this.Controls.Add(this.LabelQuart);
            this.Controls.Add(this.TextBoxQuart);
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.TextBoxYear);
            this.Name = "Grades_Scoring";
            this.Text = "Form1";
            this.PanelDecor.ResumeLayout(false);
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
        private System.Windows.Forms.Button ButtonQuartPlus;
        private System.Windows.Forms.Button ButtonQuartMinus;
        private System.Windows.Forms.Panel PanelDecor;
        private RJButton ButtonPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private RJButton ButtonRegOrLog;
    }
}

