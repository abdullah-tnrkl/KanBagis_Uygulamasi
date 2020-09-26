using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace KanBagisi
{
    public partial class Form1 : Form
    {


        public virtual Color BackColor { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCinsiyet.Items.Add("Erkek");
            comboBoxCinsiyet.Items.Add("Kadin");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kan blood = new kan();

            kimlik k = new kimlik();
            bool validMi = true;
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    if (ctl.Text == String.Empty)
                    {
                        MessageBox.Show(Convert.ToString(((TextBox)ctl).Name + " boş!"));
                        validMi = false;
                    }

                }
            }
            /*
            if(radioBekar.Checked == false || radioevli.Checked == false )
                {
                labelMedeni.ForeColor = Color.DarkRed;
                validMi = false;
            }

            if(radioPozitif.Checked == false || radioNegatif.Checked == false)
            {
                groupBoxRh.ForeColor = Color.DarkRed;
         
                validMi = false;
            }

            if(radioa.Checked==false
                || radioAB.Checked == false || radioB.Checked == false || radio0.Checked == false )
            {

                groupBoxKan.ForeColor = Color.DarkOrange;
                validMi = false;
            }
            */

            if (validMi)
            {

                k.adSoyad = textBoxAdiSoyadi.Text;

                if (comboBoxCinsiyet.Text == "Erkek")
                {
                    k.cinsiyet = "Erkek";
                }
                else
                {
                    k.cinsiyet = "Kadin";
                }

                k.dogumTarihi = DateTimePicker.Value;

                k.anne = textBoxAnneAdi.Text;
                k.baba = textBoxBabaAdi.Text;

                if (radioBekar.Checked == true)
                {
                    k.medeniDurum = "Bekar";
                }
                else if (radioevli.Checked == true)
                {
                    k.medeniDurum = "Evli";
                }
                

                k.tc = textBoxKimlikNo.Text;


                Boolean radio = false;
                Boolean rHadio = false;

                if (radioa.Checked == true)
                {
                    k.kangrubu = "A";
              
                }
                else if (radioAB.Checked == true)
                {
                    k.kangrubu = "AB";
                    
                }
                else if (radioB.Checked == true)
                {
                    k.kangrubu = "B";
               
                }
                else if (radio0.Checked == true)
                {
                    k.kangrubu = "0";
                   
                }
               


                if (radioPozitif.Checked == true)
                {
                    k.rh = "+";
            

                }
                else if (radioNegatif.Checked == true)
                {
                    k.rh = "-";
                   
                }
               





                blood.KanKaydet(k);
                labelinfo.Visible = true;
               
                /* iletisim i = new iletisim();

                 i.adres = textBoxAdres.Text;
                 i.telno = textBoxTelefon.Text;

                 if (radioilkokul.Checked == true)
                 {
                     i.meslek = "ilkokul";
                 }
                 else if (radioLise.Checked == true)
                 {
                     i.meslek = "Lİse";
                 }
                 else if (radioOrtaOkul.Checked == true)
                 {
                     i.meslek = "ortaokul";
                 }
                 else if (radiouniversite.Checked == true)
                 {
                     i.meslek = "universite";
                 }
                 else
                 {
                     i.meslek = "ümmi";
                 }

                 i.eposta = textBoxEposta.Text;



                 blood.İletisimKaydet(i);*/
                groupBoxRh.ForeColor = Color.Black;
                groupBoxRh.ForeColor = Color.Black; 
                labelMedeni.ForeColor = Color.Black;
                groupBoxKan.ForeColor = Color.Black;
            
            }



        
            
        }



        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            temizle();
            labelinfo.Visible = false;
        }

        public void temizle()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void labelinfo_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAdiSoyadi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
