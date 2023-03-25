using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
namespace Типа_кликер__v1._0
{
    public partial class Grades_Scoring : Form
    {
        public Grades_Scoring()
        {
            InitializeComponent();
        }
        DB db = new DB();
        int y = 205;
        int i = 0;
        TextBox Number = new TextBox();
        Label LabelGen = new Label();
        Label LabelCre = new Label();
        Label LabelCre2 = new Label();
        int id = -1;
        int TotalSum = 0;
        string Name_subject = "";
        int Oc(string s)
        {
            int total = 0;
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
                    Koef = Convert.ToInt32(number1[1]);
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
                    Sum -= 100 * Koef;
                }
            }
            total += Sum;
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
                    Koef = Convert.ToInt32(number1[1]);
                }

                if (Grade == "5")
                {
                    Sum = "30 * " + Koef + " + ";
                }
                if (Grade == "4")
                {
                    Sum = "4 * " + Koef + " + ";
                }
                if (Grade == "3")
                {
                    Sum = "0 * " + Koef + " + ";
                }
                if (Grade == "2")
                {
                    Sum = "-100 * " + Koef + " + ";
                }
                MainSum += Sum;
            }
            return MainSum;
        }
        private void ButtonCreateFields_Click(object sender, EventArgs e)
        {
            Name_subject = Convert.ToString(TextBoxNameSubject.Text);
            TextBoxNameSubject.Text = "";
            y += 90;
            i += 1;
            Label LabelGenerate = new Label()
            {
                Text = "" + Name_subject,
                Location = new Point(20, y + 5),
                TabIndex = 10,
                Name = "Lg" + i,
                Font = new Font("Microsoft Sans Serif", 8),
                AutoSize = false,
                Size = new Size(160, 13),
            };
            Controls.Add(LabelGenerate);
            System.Windows.Forms.TextBox textBoxGenerate = new System.Windows.Forms.TextBox()
            {

                Location = new Point(180, y),
                TabIndex = 10,
                Name = "Tg" + i,
            };
            Controls.Add(textBoxGenerate);
            Button ButtonGenerate = new Button()
            {
                Text = "подсчитать",
                Location = new Point(320, y),
                TabIndex = 8,
                Name = "B" + i,
                BackColor = Color.SlateBlue,
                Size = new Size(76, 30),
                ForeColor = Color.White
            };
            ButtonGenerate.Click += new EventHandler(ButtonGenerate_Click);
            Controls.Add(ButtonGenerate);
            Label LabelCreate1 = new Label()
            {
                Text = "",
                Location = new Point(400, y + 5),
                TabIndex = 11,
                Name = "Lc" + i,
                Font = new Font("Microsoft Sans Serif", 8),
                AutoSize = false,
                Size = new Size(160, 13),
            };
            Controls.Add(LabelCreate1);
            Label LabelCreate2 = new Label()
            {
                Text = "",
                Location = new Point(830, y + 5),
                TabIndex = 12,
                Name = "Lctwo" + i,
                Font = new Font("Microsoft Sans Serif", 8),
                AutoSize = false,
                Size = new Size(160, 13),
            };
            Controls.Add(LabelCreate2);
        }
        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            id += 1;
            Number = (System.Windows.Forms.TextBox)this.Controls.Find("Tg" + i, true)[0];
            LabelGen = (System.Windows.Forms.Label)this.Controls.Find("Lg" + i, true)[0];
            LabelCre = (System.Windows.Forms.Label)this.Controls.Find("Lc" + i, true)[0];
            LabelCre2 = (System.Windows.Forms.Label)this.Controls.Find("Lctwo" + i, true)[0];
            LabelCre.Text += Ocgrade(Number.Text);
            TotalSum += Oc(Number.Text);
            LabelCre2.Text = Convert.ToString(Oc(Number.Text));
            db.OpenC();
            MySqlCommand command = new MySqlCommand("INSERT INTO `grades` (`year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES (@year, @quarter, @child, @subject, @grades, @points)", db.getConnection());
            command.Parameters.Add("@year", MySqlDbType.VarChar).Value = TextBoxYear.Text;
            command.Parameters.Add("@quarter", MySqlDbType.VarChar).Value = TextBoxQuart.Text;
            command.Parameters.Add("@child", MySqlDbType.VarChar).Value = TextBoxNameBaby.Text;
            command.Parameters.Add("@subject", MySqlDbType.VarChar).Value = LabelGen.Text;
            command.Parameters.Add("@grades", MySqlDbType.VarChar).Value = Number.Text;
            command.Parameters.Add("@points", MySqlDbType.VarChar).Value = Convert.ToString(Oc(Number.Text)); ;
            command.ExecuteNonQuery();
        }

        private void ButtonGO_Click(object sender, EventArgs e)
        {
            LabelAddSubject.Visible = true;
            TextBoxNameSubject.Visible = true;
            ButtonCreateFields.Visible = true;
            ButtonDecor.Visible = true;
            LabelNameSubject.Visible = true;
            ButtonTotal.Visible = true;
        }

        private void ButtonTotal_Click(object sender, EventArgs e)
        {
            ButtonTotal.Visible = false;
            y += 90;
            i += 1;
            Label LabelGen = new Label()
            {
                Text = "ИТОГО: ",
                Location = new Point(20, y + 5),
                TabIndex = 10,
                Name = "Lg" + i,
                Font = new Font("Microsoft Sans Serif", 8),
                AutoSize = false,
                Size = new Size(160, 13),
            };
            Controls.Add(LabelGen);
            if ((i - 1) % 10 == 1 && (i - 1) % 10 != 11)
            {
                Label LabelGenerate = new Label()
                {
                    Text = Convert.ToInt32(i - 1) + "  предмет",
                    Location = new Point(180, y),
                    TabIndex = 11,
                    Name = "Lc" + i,
                    Font = new Font("Microsoft Sans Serif", 8),
                    AutoSize = false,
                    Size = new Size(160, 13),
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
                        Location = new Point(180, y),
                        TabIndex = 11,
                        Name = "Lc" + i,
                        Font = new Font("Microsoft Sans Serif", 8),
                        AutoSize = false,
                        Size = new Size(160, 13),
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
                            Location = new Point(180, y),
                            TabIndex = 11,
                            Name = "Lc" + i,
                            Font = new Font("Microsoft Sans Serif", 8),
                            AutoSize = false,
                            Size = new Size(160, 13),
                        };
                        Controls.Add(LabelGenerate);
                    }
                }
            }
            Label LabelCreate = new Label()
            {
                Text = "",
                Location = new Point(830, y + 5),
                TabIndex = 12,
                Name = "Lctwo" + i,
                Font = new Font("Microsoft Sans Serif", 8),
                AutoSize = false,
                Size = new Size(160, 13),
            };
            Button ButtonCreate = new Button()
            {
                Text = "Сохранить",
                Location = new Point(20, y + 60),
                TabIndex = 4,
                Name = "Bcr" + i,
                BackColor = Color.SlateBlue,
                Size = new Size(76, 30),
                ForeColor = Color.White
            };
            Controls.Add(ButtonCreate);
            ButtonCreate.Click += new EventHandler(ButtonCreate_Click);
            Controls.Add(LabelCreate);
            LabelCre2.Text = Convert.ToString(TotalSum);
        }
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `grades` (`year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES (@year, @quarter, @child, @subject, @grades, @points)", db.getConnection());
            command.Parameters.Add("@year", MySqlDbType.VarChar).Value = TextBoxYear.Text;
            command.Parameters.Add("@quarter", MySqlDbType.VarChar).Value = TextBoxQuart.Text;
            command.Parameters.Add("@child", MySqlDbType.VarChar).Value = TextBoxNameBaby.Text;
            command.Parameters.Add("@subject", MySqlDbType.VarChar).Value = "Общий итог";
            command.Parameters.Add("@grades", MySqlDbType.VarChar).Value = "";
            command.Parameters.Add("@points", MySqlDbType.VarChar).Value = Convert.ToString(TotalSum); ;
            command.ExecuteNonQuery();
        }
    }
}