using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton nesne;

        private static object lockObject = new object();
        private Singleton() { }

        public static Singleton Nesne()
        {
            if (nesne == null)
            {
                lock (lockObject)
                {
                    if (nesne == null)
                    {
                        nesne = new Singleton();

                    }
                }

            }
            return nesne;
        }
        MySqlConnection baglan = new MySqlConnection("Server=localhost;Port=3306;Database=odev;Uid=root;Pwd=1234;");
        public void veriEkle(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            if (baglan.State == System.Data.ConnectionState.Closed)
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("Insert into kayit(Ad,Soyad,KullaniciAdi,Parola,Parola2,ePosta) values ('" + text1 + "','" + text2 + "','" + text3 + "','" + text4 + "','" + text5 + "','" + text6 + "')", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();

        }

        bool isThere;
        public void veriOku(string text1,string text2)
        {
          
            if (baglan.State == System.Data.ConnectionState.Closed)
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("Select *from kayit", baglan);
            MySqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                if(text1 == read["KullaniciAdi"].ToString().TrimEnd() && text2 == read["Parola"].ToString().TrimEnd())
                {
                    isThere = true;
                    break;
                }
                else 
                {
                    isThere = false;
                }
            }
            if(isThere)
            {
                MessageBox.Show(" Başarılı Giriş.", " BİLGİ ", MessageBoxButtons.OK, MessageBoxIcon.Information);    
            }
            else
            {
                MessageBox.Show(" Hatalı Giriş ! ", " HATA ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            baglan.Close();
        }
    }
}
