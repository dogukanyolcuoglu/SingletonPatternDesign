using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SingletonPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }

        private void btnAna_Click(object sender, EventArgs e)
        {

        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move)
            {
               this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Singleton nesne = Singleton.Nesne();
  
             nesne.veriOku(txtId.Text,txtPw.Text);
   
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtPw.Text = string.Empty;
        }
    }
}
