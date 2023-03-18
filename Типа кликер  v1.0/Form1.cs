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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxALG.Text = "";
            textBoxANG.Text = "";
        }
        int total = 0;
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
        private void BONYSALG_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSALG.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxALG.Text));
        }
        private void BONYSANG_Click_1(object sender, EventArgs e)
        {
            total = 0;
            BONYSANG.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxANG.Text));
        }
        private void BONYSRODLIT_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSRODLIT.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxRODLIT.Text));
        }
        private void BONYSGEOG_Click_1(object sender, EventArgs e)
        {
            total = 0;
            BONYSGEOG.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxGEOG.Text));
        }
        private void BONYSGEOM_Click_1(object sender, EventArgs e)
        {
            total = 0;
            BONYSGEOM.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxGEOM.Text));
        }






        private void checkALG_CheckedChanged(object sender, EventArgs e)
        {
            if (checkALG.Checked)
            {
                textBoxALG.Visible = true;
                ALGEBRATEXT.Visible = true;
                BONYSALG.Visible = true;
            }
            else
            {
                BONYSALG.Visible = false;
                textBoxALG.Visible = false;
                ALGEBRATEXT.Visible = false;
            }
        }
        private void checkANG_CheckedChanged(object sender, EventArgs e)
        {
            if (checkANG.Checked)
            {
                textBoxANG.Visible = true;
                labelANG.Visible = true;
                BONYSANG.Visible = true;
            }
            else
            {
                BONYSANG.Visible = false;
                textBoxANG.Visible = false;
                labelANG.Visible = false;
            }
        }

        private void checkRODLIT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRODLIT.Checked)
            {
                textBoxRODLIT.Visible = true;
                labelRODLIT.Visible = true;
                BONYSRODLIT.Visible = true;
            }
            else
            {
                BONYSRODLIT.Visible = false;
                textBoxRODLIT.Visible = false;
                labelRODLIT.Visible = false;
            }
        }

        private void checkGEOG_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGEOG.Checked)
            {
                textBoxGEOG.Visible = true;
                labelGEOG.Visible = true;
                BONYSGEOG.Visible = true;
            }
            else
            {
                BONYSGEOG.Visible = false;
                textBoxGEOG.Visible = false;
                labelGEOG.Visible = false;
            }
        }

        private void checkGEOM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGEOM.Checked)
            {
                textBoxGEOM.Visible = true;
                labelGEOM.Visible = true;
                BONYSGEOM.Visible = true;
            }
            else
            {
                BONYSGEOM.Visible = false;
                textBoxGEOM.Visible = false;
                labelGEOM.Visible = false;
            }
        }

        private void checkINF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkINF.Checked)
            {
                textBoxINF.Visible = true;
                labelINF.Visible = true;
                BONYSINF.Visible = true;
            }
            else
            {
                BONYSINF.Visible = false;
                textBoxINF.Visible = false;
                labelINF.Visible = false;
            }
        }

        private void checkHIS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHIS.Checked)
            {
                textBoxHIS.Visible = true;
                labelHIS.Visible = true;
                BONYSHIS.Visible = true;
            }
            else
            {
                BONYSHIS.Visible = false;
                textBoxHIS.Visible = false;
                labelHIS.Visible = false;
            }
        }

        private void checkLIT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLIT.Checked)
            {
                textBoxLIT.Visible = true;
                labelLIT.Visible = true;
                BONYSLIT.Visible = true;
            }
            else
            {
                BONYSLIT.Visible = false;
                textBoxLIT.Visible = false;
                labelLIT.Visible = false;
            }
        }

        private void checkMUS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMUS.Checked)
            {
                textBoxMUS.Visible = true;
                labelMUS.Visible = true;
                BONYSMUS.Visible = true;
            }
            else
            {
                BONYSMUS.Visible = false;
                textBoxMUS.Visible = false;
                labelMUS.Visible = false;
            }
        }

        private void checkOBJ_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOBJ.Checked)
            {
                textBoxOBJ.Visible = true;
                labelOBJ.Visible = true;
                BONYSOBJ.Visible = true;
            }
            else
            {
                BONYSOBJ.Visible = false;
                textBoxOBJ.Visible = false;
                labelOBJ.Visible = false;
            }
        }

        private void checkRUS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRUS.Checked)
            {
                textBoxRUS.Visible = true;
                labelRUS.Visible = true;
                BONYSRUS.Visible = true;
            }
            else
            {
                BONYSRUS.Visible = false;
                textBoxRUS.Visible = false;
                labelRUS.Visible = false;
            }
        }

        private void checkBIO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBIO.Checked)
            {
                textBoxBIO.Visible = true;
                labelBIO.Visible = true;
                BONYSBIO.Visible = true;
            }
            else
            {
                BONYSBIO.Visible = false;
                textBoxBIO.Visible = false;
                labelBIO.Visible = false;
            }
        }

        private void checkPHY_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPHY.Checked)
            {
                textBoxPHY.Visible = true;
                labelPHY.Visible = true;
                BONYSPHY.Visible = true;
            }
            else
            {
                BONYSPHY.Visible = false;
                textBoxPHY.Visible = false;
                labelPHY.Visible = false;
            }
        }

        private void checkFIZRA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFIZRA.Checked)
            {
                textBoxFIZRA.Visible = true;
                labelFIZRA.Visible = true;
                BONYSFIZRA.Visible = true;
            }
            else
            {
                BONYSFIZRA.Visible = false;
                textBoxFIZRA.Visible = false;
                labelFIZRA.Visible = false;
            }
        }

        private void checkHIM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHIM.Checked)
            {
                textBoxHIM.Visible = true;
                labelHIM.Visible = true;
                BONYSHIM.Visible = true;
            }
            else
            {
                BONYSHIM.Visible = false;
                textBoxHIM.Visible = false;
                labelHIM.Visible = false;
            }
        }

        private void checkCHER_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCHER.Checked)
            {
                textBoxCHER.Visible = true;
                labelCHER.Visible = true;
                BONYSCHER.Visible = true;
            }
            else
            {
                BONYSCHER.Visible = false;
                textBoxCHER.Visible = false;
                labelCHER.Visible = false;
            }
        }

        private void checkOBS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOBS.Checked)
            {
                textBoxOBS.Visible = true;
                labelOBS.Visible = true;
                BONYSOBS.Visible = true;
            }
            else
            {
                BONYSOBS.Visible = false;
                textBoxOBS.Visible = false;
                labelOBS.Visible = false;
            }
        }

        private void checkIZO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIZO.Checked)
            {
                textBoxIZO.Visible = true;
                labelIZO.Visible = true;
                BONYSIZO.Visible = true;
            }
            else
            {
                BONYSIZO.Visible = false;
                textBoxIZO.Visible = false;
                labelIZO.Visible = false;
            }
        }

        private void BONYSINF_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSINF.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxINF.Text));
        }

        private void BONYSHIS_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSHIS.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxHIS.Text));
        }

        private void BONYSLIT_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSLIT.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxLIT.Text));
        }

        private void BONYSMUS_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSMUS.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxMUS.Text));
        }

        private void BONYSOBJ_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSOBJ.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxOBJ.Text));
        }

        private void checkBoxMATPRACT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMATPRACT.Checked)
            {
                textBoxMATPRACT.Visible = true;
                labelMATPRACT.Visible = true;
                BONYSMATPRACT.Visible = true;
            }
            else
            {
                BONYSMATPRACT.Visible = false;
                textBoxMATPRACT.Visible = false;
                labelMATPRACT.Visible = false;
            }
        }

        private void checkRODYAZ_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRODYAZ.Checked)
            {
                textBoxRODYAZ.Visible = true;
                labelRODYAZ.Visible = true;
                BONYSRODYAZ.Visible = true;
            }
            else
            {
                BONYSRODYAZ.Visible = false;
                textBoxRODYAZ.Visible = false;
                labelRODYAZ.Visible = false;
            }
        }

        private void BONYSMATPRACT_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSMATPRACT.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxMATPRACT.Text));
        }

        private void BONYSRUS_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSRUS.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxRUS.Text));
        }

        private void BONYSBIO_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSBIO.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxBIO.Text));
        }

        private void BONYSPHY_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSPHY.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxPHY.Text));
        }

        private void BONYSFIZRA_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSFIZRA.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxFIZRA.Text));
        }

        private void BONYSHIM_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSHIM.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxHIM.Text));
        }

        private void BONYSCHER_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSCHER.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxCHER.Text));
        }

        private void BONYSOBS_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSOBS.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxOBS.Text));
        }

        private void BONYSRODYAZ_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSRODYAZ.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxRODYAZ.Text));
        }

        private void BONYSIZO_Click(object sender, EventArgs e)
        {
            total = 0;
            BONYSIZO.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxIZO.Text));
        }
        private void buttonQuart_Click_1(object sender, EventArgs e)
        {
            total = 0;
            buttonQuart.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxQuart.Text) * 10);
        }
        private void buttonYear_Click(object sender, EventArgs e)
        {
            total = 0;
            buttonYear.Text = "Бонус равен: " + Convert.ToString(Oc(textBoxYear.Text) * 20);
        }

        private void buttonBONYSMIRA_Click(object sender, EventArgs e)
        {
            buttonBONYSMIRA.Text = "Общий бонус " + ":" + Convert.ToString(Oc(textBoxALG.Text) + Oc(textBoxANG.Text) + Oc(textBoxGEOG.Text) + Oc(textBoxRODLIT.Text) + Oc(textBoxGEOM.Text) + Oc(textBoxINF.Text) + Oc(textBoxHIS.Text) + Oc(textBoxLIT.Text) + Oc(textBoxMUS.Text) + Oc(textBoxOBJ.Text) + Oc(textBoxMATPRACT.Text) + Oc(textBoxRUS.Text) + Oc(textBoxBIO.Text) + Oc(textBoxPHY.Text) + Oc(textBoxFIZRA.Text) + Oc(textBoxHIM.Text) + Oc(textBoxCHER.Text) + Oc(textBoxOBS.Text) + Oc(textBoxRODYAZ.Text) + Oc(textBoxIZO.Text) + Oc(textBoxQuart.Text) * 10 + Oc(textBoxYear.Text) * 20);
            DB db = new DB();
            db.OpenC();
            //Алгебра
            string AAAAA = textBoxyerar.Text;
            string AAAA = textBoxchera.Text;
            string AAA = textBoxNAMEBABY.Text;
            string AA = textBoxALG.Text;
            string A = Convert.ToString(Oc(textBoxALG.Text));
            MySqlCommand command = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('1', @AAAAA, @AAAA, @AAA, 'Алгебра', @AA, @A)", db.getConnection());
            command.Parameters.Add("@AAAAA", MySqlDbType.VarChar).Value = AAAAA;
            command.Parameters.Add("@AAAA", MySqlDbType.VarChar).Value = AAAA;
            command.Parameters.Add("@AAA", MySqlDbType.VarChar).Value = AAA;
            command.Parameters.Add("@AA", MySqlDbType.VarChar).Value = AA;
            command.Parameters.Add("@A", MySqlDbType.VarChar).Value = A;
            command.ExecuteNonQuery();
            //Английский язык
            string BBBBB = textBoxyerar.Text;
            string BBBB = textBoxchera.Text;
            string BBB = textBoxNAMEBABY.Text;
            string BB = textBoxANG.Text;
            string B = Convert.ToString(Oc(textBoxANG.Text));
            MySqlCommand command1 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('2', @BBBBB, @BBBB, @BBB, 'Английский язык', @BB, @B)", db.getConnection());
            command1.Parameters.Add("@BBBBB", MySqlDbType.VarChar).Value = BBBBB;
            command1.Parameters.Add("@BBBB", MySqlDbType.VarChar).Value = BBBB;
            command1.Parameters.Add("@BBB", MySqlDbType.VarChar).Value = BBB;
            command1.Parameters.Add("@BB", MySqlDbType.VarChar).Value = BB;
            command1.Parameters.Add("@B", MySqlDbType.VarChar).Value = B;
            command1.ExecuteNonQuery();
            //Родная литература
            string ССССС = textBoxyerar.Text;
            string СССС = textBoxchera.Text;
            string ССС = textBoxNAMEBABY.Text;
            string СС = textBoxRODLIT.Text;
            string С = Convert.ToString(Oc(textBoxRODLIT.Text));
            MySqlCommand command2 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('3', @ССССС, @СССС, @ССС, 'Родная литература', @СС, @С)", db.getConnection());
            command2.Parameters.Add("@ССССС", MySqlDbType.VarChar).Value = ССССС;
            command2.Parameters.Add("@СССС", MySqlDbType.VarChar).Value = СССС;
            command2.Parameters.Add("@ССС", MySqlDbType.VarChar).Value = ССС;
            command2.Parameters.Add("@СС", MySqlDbType.VarChar).Value = СС;
            command2.Parameters.Add("@С", MySqlDbType.VarChar).Value = С;
            command2.ExecuteNonQuery();
            //География
            string DDDDD = textBoxyerar.Text;
            string DDDD = textBoxchera.Text;
            string DDD = textBoxNAMEBABY.Text;
            string DD = textBoxGEOG.Text;
            string D = Convert.ToString(Oc(textBoxGEOG.Text));
            MySqlCommand command3 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('4', @DDDDD, @DDDD, @DDD, 'География', @DD, @D)", db.getConnection());
            command3.Parameters.Add("@DDDDD", MySqlDbType.VarChar).Value = DDDDD;
            command3.Parameters.Add("@DDDD", MySqlDbType.VarChar).Value = DDDD;
            command3.Parameters.Add("@DDD", MySqlDbType.VarChar).Value = DDD;
            command3.Parameters.Add("@DD", MySqlDbType.VarChar).Value = DD;
            command3.Parameters.Add("@D", MySqlDbType.VarChar).Value = D;
            command3.ExecuteNonQuery();
            //Геометрия
            string EEEEE = textBoxyerar.Text;
            string EEEE = textBoxchera.Text;
            string EEE = textBoxNAMEBABY.Text;
            string EE = textBoxGEOM.Text;
            string E = Convert.ToString(Oc(textBoxGEOM.Text));
            MySqlCommand command4 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('5', @EEEEE, @EEEE, @EEE, 'Геометрия', @EE, @E)", db.getConnection());
            command4.Parameters.Add("@EEEEE", MySqlDbType.VarChar).Value = EEEEE;
            command4.Parameters.Add("@EEEE", MySqlDbType.VarChar).Value = EEEE;
            command4.Parameters.Add("@EEE", MySqlDbType.VarChar).Value = EEE;
            command4.Parameters.Add("@EE", MySqlDbType.VarChar).Value = EE;
            command4.Parameters.Add("@E", MySqlDbType.VarChar).Value = E;
            command4.ExecuteNonQuery();
            //Информатика
            string FFFFF = textBoxyerar.Text;
            string FFFF = textBoxchera.Text;
            string FFF = textBoxNAMEBABY.Text;
            string FF = textBoxINF.Text;
            string F = Convert.ToString(Oc(textBoxINF.Text));
            MySqlCommand command5 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('6', @FFFFF, @FFFF, @FFF, 'Информатика', @FF, @F)", db.getConnection());
            command5.Parameters.Add("@FFFFF", MySqlDbType.VarChar).Value = FFFFF;
            command5.Parameters.Add("@FFFF", MySqlDbType.VarChar).Value = FFFF;
            command5.Parameters.Add("@FFF", MySqlDbType.VarChar).Value = FFF;
            command5.Parameters.Add("@FF", MySqlDbType.VarChar).Value = FF;
            command5.Parameters.Add("@F", MySqlDbType.VarChar).Value = F;
            command5.ExecuteNonQuery();
            //История
            string GGGGG = textBoxyerar.Text;
            string GGGG = textBoxchera.Text;
            string GGG = textBoxNAMEBABY.Text;
            string GG = textBoxHIS.Text;
            string G = Convert.ToString(Oc(textBoxHIS.Text));
            MySqlCommand command6 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('7', @GGGGG, @GGGG, @GGG, 'История', @GG, @G)", db.getConnection());
            command6.Parameters.Add("@GGGGG", MySqlDbType.VarChar).Value = GGGGG;
            command6.Parameters.Add("@GGGG", MySqlDbType.VarChar).Value = GGGG;
            command6.Parameters.Add("@GGG", MySqlDbType.VarChar).Value = GGG;
            command6.Parameters.Add("@GG", MySqlDbType.VarChar).Value = GG;
            command6.Parameters.Add("@G", MySqlDbType.VarChar).Value = G;
            command6.ExecuteNonQuery();
            //Литература
            string IIIII = textBoxyerar.Text;
            string IIII = textBoxchera.Text;
            string III = textBoxNAMEBABY.Text;
            string II = textBoxLIT.Text;
            string I = Convert.ToString(Oc(textBoxLIT.Text));
            MySqlCommand command7 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('8', @IIIII, @IIII, @III, 'Литература', @II, @I)", db.getConnection());
            command7.Parameters.Add("@IIIII", MySqlDbType.VarChar).Value = IIIII;
            command7.Parameters.Add("@IIII", MySqlDbType.VarChar).Value = IIII;
            command7.Parameters.Add("@III", MySqlDbType.VarChar).Value = III;
            command7.Parameters.Add("@II", MySqlDbType.VarChar).Value = II;
            command7.Parameters.Add("@I", MySqlDbType.VarChar).Value = I;
            command7.ExecuteNonQuery();
            //Музыка
            string JJJJJ = textBoxyerar.Text;
            string JJJJ = textBoxchera.Text;
            string JJJ = textBoxNAMEBABY.Text;
            string JJ = textBoxMUS.Text;
            string J = Convert.ToString(Oc(textBoxMUS.Text));
            MySqlCommand command8 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('9', @JJJJJ, @JJJJ, @JJJ, 'Музыка', @JJ, @J)", db.getConnection());
            command8.Parameters.Add("@JJJJJ", MySqlDbType.VarChar).Value = JJJJJ;
            command8.Parameters.Add("@JJJJ", MySqlDbType.VarChar).Value = JJJJ;
            command8.Parameters.Add("@JJJ", MySqlDbType.VarChar).Value = JJJ;
            command8.Parameters.Add("@JJ", MySqlDbType.VarChar).Value = JJ;
            command8.Parameters.Add("@J", MySqlDbType.VarChar).Value = J;
            command8.ExecuteNonQuery();
            //ОБЖ
            string KKKKK = textBoxyerar.Text;
            string KKKK = textBoxchera.Text;
            string KKK = textBoxNAMEBABY.Text;
            string KK = textBoxOBJ.Text;
            string K = Convert.ToString(Oc(textBoxOBJ.Text));
            MySqlCommand command9 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('10', @KKKKK, @KKKK, @KKK, 'ОБЖ', @KK, @K)", db.getConnection());
            command9.Parameters.Add("@KKKKK", MySqlDbType.VarChar).Value = KKKKK;
            command9.Parameters.Add("@KKKK", MySqlDbType.VarChar).Value = KKKK;
            command9.Parameters.Add("@KKK", MySqlDbType.VarChar).Value = KKK;
            command9.Parameters.Add("@KK", MySqlDbType.VarChar).Value = KK;
            command9.Parameters.Add("@K", MySqlDbType.VarChar).Value = K;
            command9.ExecuteNonQuery();
            //Математический практикум
            string LLLLL = textBoxyerar.Text;
            string LLLL = textBoxchera.Text;
            string LLL = textBoxNAMEBABY.Text;
            string LL = textBoxMATPRACT.Text;
            string L = Convert.ToString(Oc(textBoxMATPRACT.Text));
            MySqlCommand command10 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('11', @LLLLL, @LLLL, @LLL, 'Математический практикум', @LL, @L)", db.getConnection());
            command10.Parameters.Add("@LLLLL", MySqlDbType.VarChar).Value = LLLLL;
            command10.Parameters.Add("@LLLL", MySqlDbType.VarChar).Value = LLLL;
            command10.Parameters.Add("@LLL", MySqlDbType.VarChar).Value = LLL;
            command10.Parameters.Add("@LL", MySqlDbType.VarChar).Value = LL;
            command10.Parameters.Add("@L", MySqlDbType.VarChar).Value = L;
            command10.ExecuteNonQuery();
            //Русский язык
            string MMMMM = textBoxyerar.Text;
            string MMMM = textBoxchera.Text;
            string MMM = textBoxNAMEBABY.Text;
            string MM = textBoxRUS.Text;
            string M = Convert.ToString(Oc(textBoxRUS.Text));
            MySqlCommand command11 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('12', @MMMMM, @MMMM, @MMM, 'Русский язык', @MM, @M)", db.getConnection());
            command11.Parameters.Add("@MMMMM", MySqlDbType.VarChar).Value = MMMMM;
            command11.Parameters.Add("@MMMM", MySqlDbType.VarChar).Value = MMMM;
            command11.Parameters.Add("@MMM", MySqlDbType.VarChar).Value = MMM;
            command11.Parameters.Add("@MM", MySqlDbType.VarChar).Value = MM;
            command11.Parameters.Add("@M", MySqlDbType.VarChar).Value = M;
            command11.ExecuteNonQuery();
            //Биология
            string NNNNN = textBoxyerar.Text;
            string NNNN = textBoxchera.Text;
            string NNN = textBoxNAMEBABY.Text;
            string NN = textBoxBIO.Text;
            string N = Convert.ToString(Oc(textBoxBIO.Text));
            MySqlCommand command12 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('13', @NNNNN, @NNNN, @NNN, 'Биология', @NN, @N)", db.getConnection());
            command12.Parameters.Add("@NNNNN", MySqlDbType.VarChar).Value = NNNNN;
            command12.Parameters.Add("@NNNN", MySqlDbType.VarChar).Value = NNNN;
            command12.Parameters.Add("@NNN", MySqlDbType.VarChar).Value = NNN;
            command12.Parameters.Add("@NN", MySqlDbType.VarChar).Value = NN;
            command12.Parameters.Add("@N", MySqlDbType.VarChar).Value = N;
            command12.ExecuteNonQuery();
            //Физика
            string OOOOO = textBoxyerar.Text;
            string OOOO = textBoxchera.Text;
            string OOO = textBoxNAMEBABY.Text;
            string OO = textBoxPHY.Text;
            string O = Convert.ToString(Oc(textBoxPHY.Text));
            MySqlCommand command13 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('14', @OOOOO, @OOOO, @OOO, 'Физика', @OO, @O)", db.getConnection());
            command13.Parameters.Add("@OOOOO", MySqlDbType.VarChar).Value = OOOOO;
            command13.Parameters.Add("@OOOO", MySqlDbType.VarChar).Value = OOOO;
            command13.Parameters.Add("@OOO", MySqlDbType.VarChar).Value = OOO;
            command13.Parameters.Add("@OO", MySqlDbType.VarChar).Value = OO;
            command13.Parameters.Add("@O", MySqlDbType.VarChar).Value = O;
            command13.ExecuteNonQuery();
            //Физ-ра
            string PPPPP = textBoxyerar.Text;
            string PPPP = textBoxchera.Text;
            string PPP = textBoxNAMEBABY.Text;
            string PP = textBoxFIZRA.Text;
            string P = Convert.ToString(Oc(textBoxFIZRA.Text));
            MySqlCommand command14 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('15', @PPPPP, @PPPP, @PPP, 'Физ-ра', @PP, @P)", db.getConnection());
            command14.Parameters.Add("@PPPPP", MySqlDbType.VarChar).Value = PPPPP;
            command14.Parameters.Add("@PPPP", MySqlDbType.VarChar).Value = PPPP;
            command14.Parameters.Add("@PPP", MySqlDbType.VarChar).Value = PPP;
            command14.Parameters.Add("@PP", MySqlDbType.VarChar).Value = PP;
            command14.Parameters.Add("@P", MySqlDbType.VarChar).Value = P;
            command14.ExecuteNonQuery();
            //Химия
            string QQQQQ = textBoxyerar.Text;
            string QQQQ = textBoxchera.Text;
            string QQQ = textBoxNAMEBABY.Text;
            string QQ = textBoxHIM.Text;
            string Q = Convert.ToString(Oc(textBoxHIM.Text));
            MySqlCommand command15 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('16', @QQQQQ, @QQQQ, @QQQ, 'Химия', @QQ, @Q)", db.getConnection());
            command15.Parameters.Add("@QQQQQ", MySqlDbType.VarChar).Value = QQQQQ;
            command15.Parameters.Add("@QQQQ", MySqlDbType.VarChar).Value = QQQQ;
            command15.Parameters.Add("@QQQ", MySqlDbType.VarChar).Value = QQQ;
            command15.Parameters.Add("@QQ", MySqlDbType.VarChar).Value = QQ;
            command15.Parameters.Add("@Q", MySqlDbType.VarChar).Value = Q;
            command15.ExecuteNonQuery();
            //Черчение
            string RRRRR = textBoxyerar.Text;
            string RRRR = textBoxchera.Text;
            string RRR = textBoxNAMEBABY.Text;
            string RR = textBoxCHER.Text;
            string R = Convert.ToString(Oc(textBoxCHER.Text));
            MySqlCommand command16 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('17', @RRRRR, @RRRR, @RRR, 'Черчение', @RR, @R)", db.getConnection());
            command16.Parameters.Add("@RRRRR", MySqlDbType.VarChar).Value = RRRRR;
            command16.Parameters.Add("@RRRR", MySqlDbType.VarChar).Value = RRRR;
            command16.Parameters.Add("@RRR", MySqlDbType.VarChar).Value = RRR;
            command16.Parameters.Add("@RR", MySqlDbType.VarChar).Value = RR;
            command16.Parameters.Add("@R", MySqlDbType.VarChar).Value = R;
            command16.ExecuteNonQuery();
            //Обществознание
            string SSSSS = textBoxyerar.Text;
            string SSSS = textBoxchera.Text;
            string SSS = textBoxNAMEBABY.Text;
            string SS = textBoxOBS.Text;
            string S = Convert.ToString(Oc(textBoxOBS.Text));
            MySqlCommand command17 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('18', @SSSSS, @SSSS, @SSS, 'Обществознание', @SS, @S)", db.getConnection());
            command17.Parameters.Add("@SSSSS", MySqlDbType.VarChar).Value = SSSSS;
            command17.Parameters.Add("@SSSS", MySqlDbType.VarChar).Value = SSSS;
            command17.Parameters.Add("@SSS", MySqlDbType.VarChar).Value = SSS;
            command17.Parameters.Add("@SS", MySqlDbType.VarChar).Value = SS;
            command17.Parameters.Add("@S", MySqlDbType.VarChar).Value = S;
            command17.ExecuteNonQuery();
            //Родной язык
            string TTTTT = textBoxyerar.Text;
            string TTTT = textBoxchera.Text;
            string TTT = textBoxNAMEBABY.Text;
            string TT = textBoxRODYAZ.Text;
            string T = Convert.ToString(Oc(textBoxRODYAZ.Text));
            MySqlCommand command18 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('19', @TTTTT, @TTTT, @TTT, 'Родной язык', @TT, @T)", db.getConnection());
            command18.Parameters.Add("@TTTTT", MySqlDbType.VarChar).Value = TTTTT;
            command18.Parameters.Add("@TTTT", MySqlDbType.VarChar).Value = TTTT;
            command18.Parameters.Add("@TTT", MySqlDbType.VarChar).Value = TTT;
            command18.Parameters.Add("@TT", MySqlDbType.VarChar).Value = TT;
            command18.Parameters.Add("@T", MySqlDbType.VarChar).Value = T;
            command18.ExecuteNonQuery();
            //ИЗО
            string HHHHH = textBoxyerar.Text;
            string HHHH = textBoxchera.Text;
            string HHH = textBoxNAMEBABY.Text;
            string HH = textBoxIZO.Text;
            string H = Convert.ToString(Oc(textBoxIZO.Text));
            MySqlCommand command19 = new MySqlCommand("INSERT INTO `grades` (`code`, `year`, `quarter`, `child`, `subject`, `grades`, `points`) VALUES ('20', @HHHHH, @HHHH, @HHH, 'ИЗО', @HH, @H)", db.getConnection());
            command19.Parameters.Add("@HHHHH", MySqlDbType.VarChar).Value = HHHHH;
            command19.Parameters.Add("@HHHH", MySqlDbType.VarChar).Value = HHHH;
            command19.Parameters.Add("@HHH", MySqlDbType.VarChar).Value = HHH;
            command19.Parameters.Add("@HH", MySqlDbType.VarChar).Value = HH;
            command19.Parameters.Add("@H", MySqlDbType.VarChar).Value = H;
            command19.ExecuteNonQuery();

        }

        private void checkALL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkALL.Checked)
            {
                checkALG.Checked = true;
                checkANG.Checked = true;
                checkRODLIT.Checked = true;
                checkGEOG.Checked = true;
                checkGEOM.Checked = true;
                checkINF.Checked = true;
                checkHIS.Checked = true;
                checkLIT.Checked = true;
                checkMUS.Checked = true;
                checkOBJ.Checked = true;
                checkBoxMATPRACT.Checked = true;
                checkRUS.Checked = true;
                checkBIO.Checked = true;
                checkPHY.Checked = true;
                checkFIZRA.Checked = true;
                checkHIM.Checked = true;
                checkCHER.Checked = true;
                checkOBS.Checked = true;
                checkRODYAZ.Checked = true;
                checkIZO.Checked = true;
            }
            else
            {
                checkALG.Checked = false;
                checkANG.Checked = false;
                checkRODLIT.Checked = false;
                checkGEOG.Checked = false;
                checkGEOM.Checked = false;
                checkINF.Checked = false;
                checkHIS.Checked = false;
                checkLIT.Checked = false;
                checkMUS.Checked = false;
                checkOBJ.Checked = false;
                checkBoxMATPRACT.Checked = false;
                checkRUS.Checked = false;
                checkBIO.Checked = false;
                checkPHY.Checked = false;
                checkFIZRA.Checked = false;
                checkHIM.Checked = false;
                checkCHER.Checked = false;
                checkOBS.Checked = false;
                checkRODYAZ.Checked = false;
                checkIZO.Checked = false;
            }
        }

    }
}