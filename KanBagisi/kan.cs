using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace KanBagisi
{
    class kan
    {

        public string verilisNedeni;

        

        public static string dosya = "blood.xml";//private olmalı

        private DataSet dsKan = new DataSet("kan");
        private DataTable dataTableKimlik = new DataTable("kimlik");
        //private DataTable dataTableiletisim = new DataTable("iletisim");
        public kan()
        {
            DataSetOlustur();
        }


        private void DataSetOlustur()
        {//xml yoksa oluşturur.
            if (System.IO.File.Exists(dosya)) //Daha önce dosya oluşturulmuşsa dosyadan bilgileri oku
            {  //Dosya var mı yokmu kontrol ediyoruz...
                //bunu yapmazsak sürekli üstüne yazar altına eklemez
                dsKan.ReadXml(dosya);//xml dosyası varsa data seti read işlemi yapıyoruz.
                dataTableKimlik = dsKan.Tables[0];//Veriyi dataTable a aktardık.
               
            }
            else //Dosya yoksa ilk defa kayıt için DataTable oluştur:
            {
                dataTableKimlik.Columns.Add("AdSoyad");
                dataTableKimlik.Columns.Add("cinsiyet");
                dataTableKimlik.Columns.Add("DogumTarihi");
                dataTableKimlik.Columns.Add("AnneBaba");
                dataTableKimlik.Columns.Add("Tc");
                dataTableKimlik.Columns.Add("Durum");
                dataTableKimlik.Columns.Add("GRUP");
                


                /*
                dataTableiletisim.Columns.Add("Adres");
                dataTableiletisim.Columns.Add("Cep");
                dataTableiletisim.Columns.Add("Eposta");
                dataTableiletisim.Columns.Add("Egitim");
                */
                dsKan.Tables.Add(dataTableKimlik);

                //dsKan.Tables.Add(dataTableiletisim);

                dsKan.WriteXml(dosya, XmlWriteMode.WriteSchema);
            }

        }

        public DataTable BagisListesiGetir()
        {
            /* Ders listesini getirirken */
            //1.yöntem: XML dosyasından okuyup getirebilirsiniz:

            //if (System.IO.File.Exists(dosyaDersler))
            //{
            //    DataSet ds = new DataSet();
            //    ds.ReadXml(dosyaDersler);

            //    return ds.Tables[0];
            //}
            //else
            //    return dataTableDers; //Eğer XML dosyasında kayıt yoksa boş datatable döndürür



            //2.yöntem : o anki datatable direk return edebilirsiniz:
            return dataTableKimlik;

        }

        public void KanKaydet(kimlik ki)
        {
            //Kayıt ekleme:
            DataRow row = dataTableKimlik.NewRow();
            

            row["AdSoyad"] = ki.adSoyad;
            row["cinsiyet"] = ki.cinsiyet;
            row["GRUP"] = ki.kangrubu + "" + ki.rh;
            row["DogumTarihi"] = ki.dogumTarihi.Date;
            row["AnneBaba"] = ki.anne +"/"+ ki.baba;
            row["Tc"] = ki.tc;
            row["Durum"] = ki.medeniDurum;
            

            dataTableKimlik.Rows.Add(row);

            //2.kayıt ekleme yöntemi:
            //dataTableDers.Rows.Add(DersAdi, DersKodu, Kredi);
            //parametre sırası ile ekleme sırası önemli!

            dsKan.WriteXml(dosya, XmlWriteMode.WriteSchema);

        }


       /* public void İletisimKaydet(iletisim il)
        {
            //Kayıt ekleme:
            DataRow row = dataTableiletisim.NewRow();

            
              dataTableiletisim.Columns.Add("Adres");
                dataTableiletisim.Columns.Add("Cep");
                dataTableiletisim.Columns.Add("Eposta");
                dataTableiletisim.Columns.Add("Egitim");
             


            row["Adres"] = il.adres;
            row["Cep"] = il.telno;
            row["Eposta"] = il.eposta;
            row["Egitim"] = il.egitim;


            dataTableiletisim.Rows.Add(row);

            //2.kayıt ekleme yöntemi:
            //dataTableDers.Rows.Add(DersAdi, DersKodu, Kredi);
            //parametre sırası ile ekleme sırası önemli!

            dsKan.WriteXml(dosya, XmlWriteMode.WriteSchema);

        }*/


        public void GridKaydet(DataTable dt)
        {

            //dataTableDers=dt olmaz
            //----------------------
            //Gridview tamamını tablo olarak kaydetmek için Datasetteki Datatable önce silinir:
            dsKan.Tables.Clear();
            //Yeni Datatable kopyalanır:
            dataTableKimlik = dt.Copy();
            //Datatable tekrar datasete eklenir:
            dsKan.Tables.Add(dataTableKimlik);

            dsKan.WriteXml(dosya, XmlWriteMode.WriteSchema);
        }

    }
}
