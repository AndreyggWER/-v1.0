using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

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
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=ocenki");
        public void OpenC()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
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
        int y = 178;
        int i = 0;
        int a = -1;
        System.Windows.Forms.TextBox Number = new System.Windows.Forms.TextBox();
        Label LabelGen = new Label();
        Label LabelCre = new Label();
        Label LabelCre2 = new Label();
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
        private void ButtonCreateFields_Click_1(object sender, EventArgs e)
        {
            a += 1;
            if (a > 0)
            {
                TotalOcSum += TotalSum;
                TotalOcGradeSum += Number.Text;
                int strLen = Name_subject.Length;
                result += "          " + Name_subject + Convert.ToString(TotalSum).PadLeft(48 - strLen, ' ') + "\n";
                result += "          " + Number.Text + "\n\n";
            }
            Name_subject = Convert.ToString(TextBoxNameSubject.Text);
            TextBoxNameSubject.Text = "";
            y += 42;
            i += 1;
            Label LabelGenerate = new Label()
            {
                Text = "" + Name_subject,
                Location = new Point(20, y + 5),
                TabIndex = 10,
                Name = "Lg" + i,
                Font = new Font("Microsoft Sans Serif", 8),
                AutoSize = false,
                Size = new Size(120, 13),
            };
            Controls.Add(LabelGenerate);
            System.Windows.Forms.TextBox TextBoxGenerate = new System.Windows.Forms.TextBox()
            {

                Location = new Point(150, y),
                TabIndex = 10,
                Font = new Font("Microsoft Sans Serif", 12),
                Name = "Tg" + i,
            };
            TextBoxGenerate.TextChanged += new EventHandler(TextBoxGenerate_TextChanged);

            Controls.Add(TextBoxGenerate);
            Label LabelCreate1 = new Label()
            {
                Text = "",
                Location = new Point(260, y + 8),
                TabIndex = 11,
                Name = "Lc" + i,
                Font = new Font("Microsoft Sans Serif", 8),
                AutoSize = true
            };
            Controls.Add(LabelCreate1);
            Label LabelCreate2 = new Label()
            {
                Text = "",
                Location = new Point(900, y + 6),
                Anchor = AnchorStyles.Right | AnchorStyles.Top,
                TabIndex = 12,
                Name = "Lctwo" + i,
                Font = new Font("Microsoft Sans Serif", 18),
                AutoSize = false,
                Size = new Size(80, 30),
            };
            Controls.Add(LabelCreate2);
        }
        private void TextBoxGenerate_TextChanged(object sender, EventArgs e)
        {
            Number = (System.Windows.Forms.TextBox)this.Controls.Find("Tg" + i, true)[0];
            LabelGen = (System.Windows.Forms.Label)this.Controls.Find("Lg" + i, true)[0];
            LabelCre = (System.Windows.Forms.Label)this.Controls.Find("Lc" + i, true)[0];
            LabelCre2 = (System.Windows.Forms.Label)this.Controls.Find("Lctwo" + i, true)[0];
            LabelCre.Text = Ocgrade(Number.Text);
            LabelCre2.Text = Convert.ToString(Oc(Number.Text));
            TotalSum = Oc(Number.Text);
        }

        private void ButtonTotal_Click_1(object sender, EventArgs e)
        {
            TotalOcSum += TotalSum;
            TotalOcGradeSum += Number.Text;
            int strLen = Name_subject.Length;
            result += "          " + Name_subject + Convert.ToString(TotalSum).PadLeft(48 - strLen, ' ') + "\n";
            result += "          " + Number.Text + "\n\n";
            result += "          ------------------------------------------------\n\n";
            ButtonTotal.Visible = false;
            y += 42;
            i += 1;
            ButtonPrint.Size = new Size(100, 30);
            ButtonPrint.BorderRadius = 15;
            ButtonPrint.Location = new Point(140, y + 60);
            ButtonPrint.Visible = true;
            Label LabelGen = new Label()
            {
                Text = "ИТОГО: ",
                Location = new Point(20, y + 5),
                TabIndex = 10,
                Name = "Lg" + i,
                Font = new Font("Microsoft Sans Serif", 18),
                AutoSize = false,
                ForeColor = Color.MediumSlateBlue,
                Size = new Size(110, 25),
            };
            Controls.Add(LabelGen);
            if ((i - 1) % 10 == 1 && (i - 1) % 10 != 11)
            {
                Label LabelGenerate = new Label()
                {
                    Text = Convert.ToInt32(i - 1) + "  предмет",
                    Location = new Point(130, y + 4),
                    TabIndex = 11,
                    Name = "Lc" + i,
                    Font = new Font("Microsoft Sans Serif", 18),
                    AutoSize = true,
                    ForeColor = Color.MediumSlateBlue
                };
                Controls.Add(LabelGenerate);
            }
            else
            {
                if (((i - 1) % 10 >= 5 && (i - 1) % 10 <= 20) || (i - 1) % 10 == 0)
                {
                    Label LabelGenerate = new Label()
                    {
                        Text = Convert.ToInt32(i - 1) + "  предметов",
                        Location = new Point(130, y + 4),
                        TabIndex = 11,
                        Name = "Lc" + i,
                        Font = new Font("Microsoft Sans Serif", 18),
                        AutoSize = true,
                        ForeColor = Color.MediumSlateBlue
                    };
                    Controls.Add(LabelGenerate);
                }
                else
                {
                    if ((i - 1) % 10 >= 2 && (i - 1) % 10 <= 4)
                    {
                        Label LabelGenerate = new Label()
                        {
                            Text = Convert.ToInt32(i - 1) + "  предмета",
                            Location = new Point(130, y + 4),
                            TabIndex = 11,
                            Name = "Lc" + i,
                            Font = new Font("Microsoft Sans Serif", 18),
                            AutoSize = true,
                            ForeColor = Color.MediumSlateBlue
                        };
                        Controls.Add(LabelGenerate);
                    }
                }
            }
            Label LabelCreated = new Label()
            {
                Text = "",
                Location = new Point(900, y + 8),
                TabIndex = 12,
                Name = "Lctwod" + i,
                Font = new Font("Microsoft Sans Serif", 18),
                AutoSize = false,
                ForeColor = Color.MediumSlateBlue,
                Size = new Size(60, 25),
            };
            Controls.Add(LabelCreated);
            RJButton ButtonCreate = new RJButton()
            {
                Text = "Сохранить",
                Location = new Point(20, y + 60),
                TabIndex = 4,
                Name = "Bcr" + i,
                BackColor = Color.MediumSlateBlue,
                Size = new Size(100, 30),
                BorderRadius = 15,
                ForeColor = Color.White
            };
            Controls.Add(ButtonCreate);
            ButtonCreate.Click += new EventHandler(ButtonCreate_Click);
            Label LabelCred = (System.Windows.Forms.Label)this.Controls.Find("Lctwod" + i, true)[0];
            LabelCred.Text = Convert.ToString(TotalOcSum);
        }
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            for (int b = 1; b < i; b++)
            {
                Number = (System.Windows.Forms.TextBox)this.Controls.Find("Tg" + b, true)[0];
                LabelGen = (System.Windows.Forms.Label)this.Controls.Find("Lg" + b, true)[0];
                LabelCre = (System.Windows.Forms.Label)this.Controls.Find("Lc" + b, true)[0];
                LabelCre2 = (System.Windows.Forms.Label)this.Controls.Find("Lctwo" + b, true)[0];
                LabelCre2.Text = Convert.ToString(TotalOcGradeSum);
                OpenC();
                MySqlCommand command = new MySqlCommand("INSERT INTO `grades` (`year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES (@year, @quarter, @child, @subject, @grades, @points)", GetConnection());
                command.Parameters.Add("@year", MySqlDbType.VarChar).Value = TextBoxYear.Text;
                command.Parameters.Add("@quarter", MySqlDbType.VarChar).Value = TextBoxQuart.Text;
                command.Parameters.Add("@child", MySqlDbType.VarChar).Value = TextBoxNameBaby.Text;
                command.Parameters.Add("@subject", MySqlDbType.VarChar).Value = LabelGen.Text;
                command.Parameters.Add("@grades", MySqlDbType.VarChar).Value = Number.Text;
                command.Parameters.Add("@points", MySqlDbType.VarChar).Value = Convert.ToString(Oc(Number.Text));
                command.ExecuteNonQuery();
            }
            OpenC();

            //MySqlConnection connection = GetConnection();

            //MySqlCommand command1 = new MySqlCommand("SET NAMES utf8", GetConnection());
            //command1.ExecuteNonQuery();

            MySqlCommand command2 = new MySqlCommand("INSERT INTO `grades` (`year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES (@year, @quarter, @child, @subject, '', @points)", GetConnection());
            command2.Parameters.Add("@year", MySqlDbType.VarChar).Value = TextBoxYear.Text;
            command2.Parameters.Add("@quarter", MySqlDbType.VarChar).Value = TextBoxQuart.Text;
            command2.Parameters.Add("@child", MySqlDbType.VarChar).Value = TextBoxNameBaby.Text;
            command2.Parameters.Add("@subject", MySqlDbType.VarChar).Value = "ИТОГ";
            command2.Parameters.Add("@points", MySqlDbType.VarChar).Value = Convert.ToString(TotalOcSum);
            command2.ExecuteNonQuery();
            MessageBox.Show("Успешно сохранено!");
        }

        private void ButtonYearPlus_Click(object sender, EventArgs e)
        {
            TextBoxYear.Text = Convert.ToString(Convert.ToInt32(TextBoxYear.Text) - 1);
        }

        private void ButtonYearMinus_Click(object sender, EventArgs e)
        {
            TextBoxYear.Text = Convert.ToString(Convert.ToInt32(TextBoxYear.Text) + 1);
        }

        private void ButtonGO_Click_1(object sender, EventArgs e)
        {
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
                DialogResult result = MessageBox.Show("Вы уже вошли, всё равно перейти в окно авторизации?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Login LogREG = new Login();
                    LogREG.ShowDialog();

                }
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
        }
    }
}