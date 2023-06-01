using BelgeArsivYonetimSistemi.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BelgeArsivYonetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command2 = new MySqlCommand("select * from admin", new dbbaglanti().baglantiGetir());
            MySqlDataReader reader2 = command2.ExecuteReader();
            //bool sonuc2 = false;
            MySqlCommand command= new MySqlCommand("select * from kullanicilar",new dbbaglanti().baglantiGetir());
            MySqlDataReader reader=command.ExecuteReader();
            bool sonuc = false;

            while(reader.Read())
            {
                if (reader[1].ToString().Trim() == Kullanıciaditxt.Text && reader[2].ToString().Trim() == sifretxt.Text)
                {
                    sonuc= true;
                    anaekran ae = new anaekran();
                    this.Hide();
                    ae.Show();
                    break;
                }

                
                
            }

            while (reader2.Read())
            {
                if (reader2[1].ToString().Trim() == Kullanıciaditxt.Text && reader2[2].ToString().Trim() == sifretxt.Text)
                {
                    sonuc = true;
                    anaekran ae = new anaekran();
                    this.Hide();
                    ae.Show();
                    break;
                }
            }

            if(sonuc) 
            {
                sonuc= false;
            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }

           
           

           /* while (reader2.Read())
            {
                if ()
                {
                    
                }
            }

            if(sonuc2)
            {
                sonuc2 = false;

            }

            else
            {
                MessageBox.Show("hatalı giriş");
            }*/
        }
    }
}
