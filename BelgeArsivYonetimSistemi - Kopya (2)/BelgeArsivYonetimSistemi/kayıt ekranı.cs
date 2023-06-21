using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BelgeArsivYonetimSistemi.DAL;
using BelgeArsivYonetimSistemi.SERVİCE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using BelgeArsivYonetimSistemi.SERVICE;

namespace BelgeArsivYonetimSistemi
{
    public partial class kayıt_ekranı : Form
    {
        public kayıt_ekranı()
        {
            InitializeComponent();
        }

        public void listele()
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from kullanicilar", new dbbaglanti().baglantiGetir());
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Kullaniciaditxt2.Text == "" || sifretxt2.Text == "" || gorevtxt.Text == "") 
            {
                MessageBox.Show("tüm alanları doldurunuz");
            }

            else
            {
                new Kullanıcıservice().kullaniciKaydet(Kullaniciaditxt2.Text, sifretxt2.Text, gorevtxt.Text);
                MessageBox.Show("kayıt başarılı");
                listele();
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1= new Form1();
            this.Hide();
            form1.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Kullaniciaditxt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sifretxt2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            gorevtxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void kayıt_ekranı_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Kullaniciaditxt2.Text == "" || sifretxt2.Text == "" || gorevtxt.Text == "")
            {
                MessageBox.Show("boş alamları doldurunuz");
            }

            else
            {

                new Kullanıcıservice().kullaniciGuncelle(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), Kullaniciaditxt2.Text, sifretxt2.Text, gorevtxt.Text);
                MessageBox.Show("güncelleme başarılı");
                listele();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Kullanıcıservice().kullaniciSil(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), Kullaniciaditxt2.Text, sifretxt2.Text, gorevtxt.Text);
            MessageBox.Show("silme başarılı");
            listele();
        }
    }
}
