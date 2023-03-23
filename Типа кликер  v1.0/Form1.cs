using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
namespace Типа_кликер__v1._0
{
    public partial class Grades_Scoring : Form
    {
        public Grades_Scoring()
        {
            InitializeComponent();
        }
        int total = 0;
        int sum = 0;
        DB db = new DB();
        int y = -74;
        int i = 0;
        int id = -1;
        int Oc(string s)
        {
            int sum = 0;
            string[] subs = s.Split(' ');
            foreach (var sub in subs)
            {

                string ocenka = sub;
                int koef = 1;

                if (sub.IndexOf("*") > 0)
                {
                    string[] number1 = sub.Split('*');
                    ocenka = number1[0];
                    koef = Convert.ToInt32(number1[1]);
                }

                if (ocenka == "5")
                {
                    sum += 20 * koef;
                }
                if (ocenka == "4")
                {
                    sum += 4 * koef;
                }
                if (ocenka == "2")
                {
                    sum -= 100 * koef;
                }
            }
            total += sum;
            return sum;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Name_subject = Convert.ToString(TextBoxNameSubject.Text);
            TextBoxNameSubject.Text = "";
            y += 90;
            i += 1;
            Label labelGenerate = new Label()
            {
                Text = "" + Name_subject,
                Location = new Point(250, y),
                TabIndex = 10,
                Name = "l" + i,
                Font = new Font("Microsoft Sans Serif", 8),
                AutoSize = false,
                Size = new Size(109, 13)
            };
            Controls.Add(labelGenerate);
            System.Windows.Forms.TextBox textBoxGenerate = new System.Windows.Forms.TextBox()
            {

                Location = new Point(250, y + 18),
                TabIndex = 10,
                Name = "t" + i,
            };
            Controls.Add(textBoxGenerate);
            Button ButtonGenerate = new Button()
            {
                Text = "подсчитать",
                Location = new Point(250, y + 40),
                TabIndex = 8,
                Name = "b" + i,
            };
            ButtonGenerate.Click += new EventHandler(ButtonGenerate_Click);
            Controls.Add(ButtonGenerate);
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            id += 1;
            System.Windows.Forms.TextBox chislo = (System.Windows.Forms.TextBox)this.Controls.Find("t" + i, true)[0];
            System.Windows.Forms.Label nadpis = (System.Windows.Forms.Label)this.Controls.Find("l" + i, true)[0];

            db.OpenC();
            string AAAAAAA = TextBoxYear.Text;
            string AAAAAA = TextBoxQuart.Text;
            string AAAAA = TextBoxNameBaby.Text;
            string AAAA = nadpis.Text;
            string AAA = chislo.Text;
            string AA = Convert.ToString(Oc(chislo.Text));
            int A = id + 1;
            MySqlCommand command = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES (@A, @AAAAAAA, @AAAAAA, @AAAAA, @AAAA, @AAA, @AA)", db.getConnection());
            command.Parameters.Add("@AAAAAAA", MySqlDbType.VarChar).Value = AAAAAAA;
            command.Parameters.Add("@AAAAAA", MySqlDbType.VarChar).Value = AAAAAA;
            command.Parameters.Add("@AAAAA", MySqlDbType.VarChar).Value = AAAAA;
            command.Parameters.Add("@AAAA", MySqlDbType.VarChar).Value = AAAA;
            command.Parameters.Add("@AAA", MySqlDbType.VarChar).Value = AAA;
            command.Parameters.Add("@AA", MySqlDbType.VarChar).Value = AA;
            command.Parameters.Add("@A", MySqlDbType.VarChar).Value = A;
            command.ExecuteNonQuery();
        }
    }
}