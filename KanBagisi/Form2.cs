using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBagisi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Listele();

         }



        private void Listele()
        {
            kan b = new kan();
            //DataTable olarak geliyor. Grid view 'e aktarmak gerekiyor.
            DataTable dt = b.BagisListesiGetir();
            dataGridViewListe.DataSource = dt;
        }

        private void buttonDetayGoster_Click(object sender, EventArgs e)
        {
            kan b = new kan();
         

            DataTable dt = (DataTable)dataGridViewListe.DataSource;
            b.GridKaydet(dt);
            MessageBox.Show("Bilgiler kaydedildi");
        }
    }
}
