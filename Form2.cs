using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SingletonPattern
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            Singleton nesne = Singleton.Nesne();

            if (txtPassWord.Text != txtPassWord2.Text)
            {
                MessageBox.Show(" Şifreleriniz Uyuşmuyor !", " UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtAd.Text == string.Empty || txtSoyad.Text == string.Empty || txtId2.Text == string.Empty || txtPassWord.Text == string.Empty ||
                    txtPassWord2.Text == string.Empty || txtPosta.Text == string.Empty)
            {
                MessageBox.Show(" Boş Alanları Doldurunuz ! ", " UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nesne.veriEkle(txtAd.Text, txtSoyad.Text, txtId2.Text, txtPassWord.Text, txtPassWord2.Text, txtPosta.Text);

                MessageBox.Show(" Kayıt Tamamlandı."," BİLGİ ",MessageBoxButtons.OK,MessageBoxIcon.Information);

                txtAd.Text = string.Empty;
                txtSoyad.Text = string.Empty;
                txtId2.Text = string.Empty;
                txtPassWord.Text = string.Empty;
                txtPassWord2.Text = string.Empty;
                txtPosta.Text = string.Empty;
            } 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
