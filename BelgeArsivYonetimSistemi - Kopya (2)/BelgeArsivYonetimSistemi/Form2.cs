using BelgeArsivYonetimSistemi.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BelgeArsivYonetimSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("select * from admin", new dbbaglanti().baglantiGetir());
            MySqlDataReader reader = command.ExecuteReader();
            bool sonuc = false;

            while (reader.Read())
            {
                if (reader[1].ToString().Trim() == textBox1.Text && reader[2].ToString().Trim() == textBox2.Text)
                {
                    sonuc = true;
                    kayıt_ekranı ke = new kayıt_ekranı();
                    this.Hide();
                    ke.Show();
                    break;
                }

            }

            if (sonuc)
            {
                sonuc = false;
            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        
    }
}
