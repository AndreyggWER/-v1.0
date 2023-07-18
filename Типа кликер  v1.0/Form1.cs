using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data;
using SD = System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics;
using Mysqlx.Crud;

namespace Типа_кликер__v1._0
{

    public partial class Grades_Scoring : Form
    {
        public Grades_Scoring()
        {
            InitializeComponent();
            TextBoxYear.Text = DateTime.Now.Year.ToString();
            TextBoxQuart.Text = "1";

        }
        MySqlConnection connection = new MySqlConnection(File.ReadAllText("DB.txt"));

        public void OpenC()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public SD.DataSet ds;

        public void CloseC()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        int currentTop = 178;
        int currentIndex = 0;
        int a = -1;
        System.Windows.Forms.TextBox textboxRates = new System.Windows.Forms.TextBox();
        Label labelCaption = new Label();
        Label labelFormula = new Label();
        Label labelReward = new Label();
        string TotalOcGradeSum = "";
        int TotalOcSum = 0;
        private string result = "";
        int TotalSum = 0;
        string Name_subject = "";
        int Oc(string s)
        {
            int Sum = 0;
            string[] subs = s.Split(' ');
            foreach (var sub in subs)
            {

                string Grade = sub;
                int Koef = 1;

                if (sub.IndexOf("*") > 0)
                {
                    string[] number1 = sub.Split('*');
                    Grade = number1[0];
                    try
                    {
                        Koef = Convert.ToInt32(number1[1]);
                    }
                    catch (Exception)
                    {
                        Koef = 1;
                    }
                }

                if (Grade == "5")
                {
                    Sum += 30 * Koef;
                }
                if (Grade == "4")
                {
                    Sum += 4 * Koef;
                }
                if (Grade == "2")
                {
                    Sum += -100 * Koef;
                }
            }
            return Sum;
        }
        string Ocgrade(string s)
        {
            string Sum = "";
            string MainSum = "";
            string[] subs = s.Split(' ');
            foreach (var sub in subs)
            {

                string Grade = sub;
                int Koef = 1;

                if (sub.IndexOf("*") > 0)
                {
                    string[] number1 = sub.Split('*');
                    Grade = number1[0];
                    try
                    {
                        Koef = Convert.ToInt32(number1[1]);
                    }
                    catch (Exception)
                    {
                        // recover from exception
                        Koef = 1;
                    }
                }

                if (Grade == "5")
                {
                    Sum += "30 * " + Koef + " + ";
                }
                if (Grade == "4")
                {
                    Sum += "4 * " + Koef + " + ";
                }
                if (Grade == "3")
                {
                    Sum += "0 * " + Koef + " + ";
                }
                if (Grade == "2")
                {
                    Sum += "-100 * " + Koef + " + ";
                }
                MainSum = Sum;
            }
            return MainSum;
        }

        private void CreateRow(string caption, string rates, string formula, string reward)
        {
            currentTop += 42;
            currentIndex += 1;
            Debug.WriteLine(currentIndex);

            /*
            a += 1;
            if (a > 0)
            {
                TotalOcSum += TotalSum;
                TotalOcGradeSum += Number.Text;
                int strLen = Name_subject.Length;
                result += "          " + Name_subject + Convert.ToString(TotalSum).PadLeft(48 - strLen, ' ') + "\n";
                result += "          " + Number.Text + "\n\n";
            }
            */

            Label labelCaption = new Label()
            {
                Text = caption,
                Location = new Point(20, currentTop + 5),
                TabIndex = 10,
                Name = "Lg" + currentIndex,
                Font = new Font("Microsoft Sans Serif", 8),
                AutoSize = false,
                Size = new Size(120, 13),
            };
            Controls.Add(labelCaption);

            System.Windows.Forms.TextBox textboxRates = new System.Windows.Forms.TextBox()
            {
                Text = rates,
                Location = new Point(150, currentTop),
                TabIndex = 10,
                Font = new Font("Microsoft Sans Serif", 12),
                Name = "Tg" + currentIndex,
            };
            textboxRates.TextChanged += new EventHandler(TextBoxGenerate_TextChanged);
            Controls.Add(textboxRates);

            Label labelFormula = new Label()
            {
                Text = formula,
                Location = new Point(260, currentTop + 8),
                TabIndex = 11,
                Name = "Lc" + currentIndex,
                Font = new Font("Microsoft Sans Serif", 8),
                AutoSize = true
            };
            Controls.Add(labelFormula);

            Label labelReward = new Label()
            {
                Text = reward,
                Location = new Point(900, currentTop + 6),
                Anchor = AnchorStyles.Right | AnchorStyles.Top,
                TabIndex = 12,
                Name = "Lctwo" + currentIndex,
                Font = new Font("Microsoft Sans Serif", 18),
                AutoSize = false,
                Size = new Size(80, 30),
            };
            Controls.Add(labelReward);
        }

        private void ButtonCreateFields_Click_1(object sender, EventArgs e)
        {
            
            Name_subject = Convert.ToString(TextBoxNameSubject.Text);
            TextBoxNameSubject.Text = "";
            
            
            CreateRow(Name_subject, "", "", "");
        }
        private void TextBoxGenerate_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = (sender as System.Windows.Forms.TextBox);
            string tt = tb.Name.Replace("Tg", "");
            int senderTag = Int32.Parse(tt);
            textboxRates = (System.Windows.Forms.TextBox)this.Controls.Find("Tg" + senderTag, true)[0];
            
            //labelCaption = (System.Windows.Forms.Label)this.Controls.Find("Lg" + senderTag, true)[0];
            labelFormula = (System.Windows.Forms.Label)this.Controls.Find("Lc" + senderTag, true)[0];
            labelFormula.Text = Ocgrade(textboxRates.Text);
            labelReward = (System.Windows.Forms.Label)this.Controls.Find("Lctwo" + senderTag, true)[0];
            labelReward.Text = Convert.ToString(Oc(textboxRates.Text));
            //TotalSum = Oc(textboxRates.Text);
        }

        private void ButtonTotal_Click_1(object sender, EventArgs e)
        {
            connection = new MySqlConnection(File.ReadAllText("DB.txt"));
            OpenC();
            MySqlDataAdapter DataAdapter = new MySqlDataAdapter("DELETE FROM `grades`", GetConnection());
            SD.DataTable Table = new SD.DataTable();
            DataAdapter.Fill(Table);
            DataGridViewOcenki.DataSource = Table;
            CloseC();
            TotalOcSum += TotalSum;
            TotalOcGradeSum += textboxRates.Text;
            int strLen = Name_subject.Length;
            result += "          " + Name_subject + Convert.ToString(TotalSum).PadLeft(48 - strLen, ' ') + "\n";
            result += "          " + textboxRates.Text + "\n\n";
            result += "          ------------------------------------------------\n\n";
            ButtonTotal.Visible = false;
            currentTop += 42;
            //currentIndex += 1;
            ButtonPrint.Size = new Size(100, 30);
            ButtonPrint.BorderRadius = 15;
            ButtonPrint.Location = new Point(140, currentTop + 60);
            ButtonPrint.Visible = true;
            Label labelCaption = new Label()
            {
                Text = "ИТОГО: ",
                Location = new Point(20, currentTop + 5),
                TabIndex = 10,
                Name = "LgItogo",
                Font = new Font("Microsoft Sans Serif", 18),
                AutoSize = false,
                ForeColor = Color.MediumSlateBlue,
                Size = new Size(110, 25),
            };
            Controls.Add(labelCaption);

            string postfix = "предмета";
            if ((currentIndex) % 10 == 1 && (currentIndex) % 10 != 11)
            {
                postfix = "предмет";
            }
            else if (((currentIndex - 1) % 10 >= 5 && (currentIndex - 1) % 10 <= 20) || (currentIndex - 1) % 10 == 0)
            {
                postfix = "предметов";
            }

            Label labelFormula = new Label()
            {
                Text = Convert.ToInt32(currentIndex) + " " + postfix,
                Location = new Point(130, currentTop + 4),
                TabIndex = 11,
                Name = "LcItogo",
                Font = new Font("Microsoft Sans Serif", 18),
                AutoSize = true,
                ForeColor = Color.MediumSlateBlue
            };
            Controls.Add(labelFormula);


            TotalOcSum = 0;
            for (int b = 1; b <= currentIndex; b++)
            {
                System.Windows.Forms.Label labelRewardInline = (System.Windows.Forms.Label)this.Controls.Find("Lctwo" + b, true)[0];

                TotalOcSum += Int32.Parse(labelRewardInline.Text);
                Debug.WriteLine(TotalOcSum);
            }

            Label labelReward = new Label()
            {
                Text = Convert.ToString(TotalOcSum),
                Location = new Point(900, currentTop + 8),
                TabIndex = 12,
                Name = "Lctwod" + currentIndex,
                Font = new Font("Microsoft Sans Serif", 18),
                AutoSize = false,
                ForeColor = Color.MediumSlateBlue,
                Size = new Size(60, 25),
            };
            Controls.Add(labelReward);
            RJButton ButtonCreate = new RJButton()
            {
                Text = "Сохранить",
                Location = new Point(20, currentTop + 60),
                TabIndex = 4,
                Name = "Bcr" + currentIndex,
                BackColor = Color.MediumSlateBlue,
                Size = new Size(100, 30),
                BorderRadius = 15,
                ForeColor = Color.White
            };
            Controls.Add(ButtonCreate);
            ButtonCreate.Click += new EventHandler(ButtonCreate_Click);
            //Label LabelCred = (System.Windows.Forms.Label)this.Controls.Find("Lctwod" + currentIndex, true)[0];

        }
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(File.ReadAllText("DB.txt"));
            OpenC();
            MySqlDataAdapter DataAdapter = new MySqlDataAdapter("DELETE FROM `grades`", GetConnection());
            SD.DataTable Table = new SD.DataTable();
            DataAdapter.Fill(Table);
            DataGridViewOcenki.DataSource = Table;
            CloseC();
            for (int b = 1; b <= currentIndex; b++)
            {
                textboxRates = (System.Windows.Forms.TextBox)this.Controls.Find("Tg" + b, true)[0];
                labelCaption = (System.Windows.Forms.Label)this.Controls.Find("Lg" + b, true)[0];
                labelFormula = (System.Windows.Forms.Label)this.Controls.Find("Lc" + b, true)[0];
                labelReward = (System.Windows.Forms.Label)this.Controls.Find("Lctwo" + b, true)[0];
                labelReward.Text = Convert.ToString(TotalOcGradeSum);
                OpenC();
                MySqlCommand command = new MySqlCommand("INSERT INTO `grades` (`year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES (@year, @quarter, @child, @subject, @grades, @points)", GetConnection());
                command.Parameters.Add("@year", MySqlDbType.VarChar).Value = TextBoxYear.Text;
                command.Parameters.Add("@quarter", MySqlDbType.VarChar).Value = TextBoxQuart.Text;
                command.Parameters.Add("@child", MySqlDbType.VarChar).Value = TextBoxNameBaby.Text;
                command.Parameters.Add("@subject", MySqlDbType.VarChar).Value = labelCaption.Text;
                command.Parameters.Add("@grades", MySqlDbType.VarChar).Value = textboxRates.Text;
                command.Parameters.Add("@points", MySqlDbType.VarChar).Value = Convert.ToString(Oc(textboxRates.Text));
                command.ExecuteNonQuery();
            }
        }
        private void ButtonYearPlus_Click(object sender, EventArgs e)
        {
            TextBoxYear.Text = Convert.ToString(Convert.ToInt32(TextBoxYear.Text) - 1);
        }
        private void DataTableView_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(File.ReadAllText("DB.txt"));
            OpenC();
            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(DataInProgramm.Script, GetConnection());
            SD.DataTable Table = new SD.DataTable();
            DataAdapter.Fill(Table);
            DataGridViewOcenki.DataSource = Table;
            CloseC();
        }
        private void ButtonYearMinus_Click(object sender, EventArgs e)
        {
            TextBoxYear.Text = Convert.ToString(Convert.ToInt32(TextBoxYear.Text) + 1);
        }
        private void ShowOD()
        {
            OpenC();
            string sql = "SElECT subject, grades, points "+
                " FROM `grades`" + 
                " WHERE child='" + TextBoxNameBaby.Text + "'" +
                "   AND quarter='" + TextBoxQuart.Text + "'" +
                "   AND year='" + TextBoxYear.Text + "'";


            MySqlCommand command = new MySqlCommand(sql, GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);

            Console.Write(table.Rows);
        }
        private void ButtonGO_Click_1(object sender, EventArgs e)
        {
           //string[] noned = File.ReadAllText("DBR.txt").Split('\n');//
            ButtonTable.Visible = true;
            LabelAddSubject.Visible = true;
            TextBoxNameSubject.Visible = true;
            ButtonCreateFields.Visible = true;
            PanelDecor.Visible = true;
            LabelNameSubject.Visible = true;
            ButtonTotal.Visible = true;
            result += "\n\n\n\n";
            result += "          " + TextBoxNameBaby.Text + "\n";
            result += "          " + TextBoxYear.Text + "/" + TextBoxQuart.Text + "четверть" + "\n\n";
            result += "          ------------------------------------------------\n\n";
            ShowOD();

            for (int i = 0; i < DataGridViewOcenki.RowCount - 1; i++)
            {
                DataGridViewRow SlctRow = DataGridViewOcenki.Rows[i];

                DataInProgramm.CodeDetails = SlctRow.Cells[0].Value.ToString();
                DataInProgramm.YearDetails = SlctRow.Cells[1].Value.ToString();
                DataInProgramm.QuarterDetails = SlctRow.Cells[2].Value.ToString();
                DataInProgramm.ChildDetails = SlctRow.Cells[3].Value.ToString();
                DataInProgramm.SubjectDetails = SlctRow.Cells[4].Value.ToString();
                DataInProgramm.GradesDetails = SlctRow.Cells[5].Value.ToString();
                DataInProgramm.PointsDetails = SlctRow.Cells[6].Value.ToString();
                CreateRow(DataInProgramm.SubjectDetails, DataInProgramm.GradesDetails, Ocgrade(DataInProgramm.GradesDetails), DataInProgramm.PointsDetails);
            }
        }

        private void ButtonQuartMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextBoxQuart.Text) <= 3)
            {
                TextBoxQuart.Text = Convert.ToString(Convert.ToInt32(TextBoxQuart.Text) + 1);
            }
        }

        private void ButtonQuartPlus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextBoxQuart.Text) >= 2)
            {
                TextBoxQuart.Text = Convert.ToString(Convert.ToInt32(TextBoxQuart.Text) - 1);
            }
        }
        private void TextBoxQuart_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(TextBoxQuart.Text);
                if (Convert.ToInt32(TextBoxQuart.Text) > 4)
                {
                    TextBoxQuart.Text = 4.ToString();
                }
                if (Convert.ToInt32(TextBoxQuart.Text) < 1)
                {
                    TextBoxQuart.Text = 1.ToString();
                }
            }
            catch (FormatException)
            {
                Convert.ToString(TextBoxQuart.Text);
            }
        }

        private void TextBoxQuart_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageHandler;
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            string Str = "Итог: ";
            int strLen = Str.Length;
            result += "          Итог: " + Convert.ToString(TotalOcSum).PadLeft(48 - strLen, ' ');
            e.Graphics.DrawString(result, new Font("Courier New", 14), Brushes.Black, 0, 0);
        }

        private void ButtonRegOrLog_Click(object sender, EventArgs e)
        {
            if (DataInProgramm.UserLogin == "")
            {
                Login LogREG = new Login();
                LogREG.ShowDialog();
                ButtonRegOrLog.Text = DataInProgramm.UserLogin;
            }
            else
            {
                ButtonRegOrLog.Text = DataInProgramm.UserLogin;
                MessageBox.Show("Вы уже вошли.", "", MessageBoxButtons.OK);
            }
        }
            private void  PictureBox1_Click(object sender, EventArgs e)
            {
                DataBaseAccess DBSET = new DataBaseAccess();
                DBSET.ShowDialog();
                DataInProgramm.DBA = DataInProgramm.DBServer + DataInProgramm.DBPort + DataInProgramm.DBUserName + DataInProgramm.DBPassword + DataInProgramm.DataBase;
                File.WriteAllText("DB.txt", DataInProgramm.DBA);
                connection = new MySqlConnection(File.ReadAllText("DB.txt"));

        }

        private void ButtonTable_Click(object sender, EventArgs e)
        {
            DataTableView DataViewTable = new DataTableView();
            DataViewTable.ShowDialog();
            if (DataInProgramm.ClickDetails == "1")
            {
                currentTop += 42;
                currentIndex += 1;
                Label LabelGenerate = new Label()
                {
                    Text = "" + DataInProgramm.SubjectDetails,
                    Location = new Point(20, currentTop + 5),
                    TabIndex = 10,
                    Name = "Lg" + currentIndex,
                    Font = new Font("Microsoft Sans Serif", 8),
                    AutoSize = false,
                    Size = new Size(120, 13),
                };
                Controls.Add(LabelGenerate);
                System.Windows.Forms.TextBox TextBoxGenerate = new System.Windows.Forms.TextBox()
                {
                    Text = "" + DataInProgramm.GradesDetails,
                    Location = new Point(150, currentTop),
                    TabIndex = 10,
                    Font = new Font("Microsoft Sans Serif", 12),
                    Name = "Tg" + currentIndex,
                };
                TextBoxGenerate.TextChanged += new EventHandler(TextBoxGenerate_TextChanged);

                Controls.Add(TextBoxGenerate);
                Label LabelCreate1 = new Label()
                {
                    Text = "",
                    Location = new Point(260, currentTop + 8),
                    TabIndex = 11,
                    Name = "Lc" + currentIndex,
                    Font = new Font("Microsoft Sans Serif", 8),
                    AutoSize = true
                };
                Controls.Add(LabelCreate1);
                Label LabelCreate2 = new Label()
                {
                    Text = "" + DataInProgramm.PointsDetails,
                    Location = new Point(900, currentTop + 6),
                    Anchor = AnchorStyles.Right | AnchorStyles.Top,
                    TabIndex = 12,
                    Name = "Lctwo" + currentIndex,
                    Font = new Font("Microsoft Sans Serif", 18),
                    AutoSize = false,
                    Size = new Size(80, 30),
                };
                Controls.Add(LabelCreate2);

                
                labelFormula = (System.Windows.Forms.Label)this.Controls.Find("Lc" + currentIndex, true)[0];
                labelReward = (System.Windows.Forms.Label)this.Controls.Find("Lctwo" + currentIndex, true)[0];
                labelFormula.Text = Ocgrade(DataInProgramm.GradesDetails);
                labelReward.Text = Convert.ToString(Oc(DataInProgramm.GradesDetails));
            }
        }

    }
}