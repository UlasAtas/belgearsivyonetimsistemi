using BelgeArsivYonetimSistemi.SERVİCE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BelgeArsivYonetimSistemi.SERVICE;
using System.Data.SqlClient;
using BelgeArsivYonetimSistemi.DAL;
using BelgeArsivYonetimSistemi.DOMAIN;
using MySql.Data.MySqlClient;

namespace BelgeArsivYonetimSistemi
{
    public partial class anaekran : Form
    {
        public anaekran()
        {
            InitializeComponent();
        }

        

        public void listele()
        {
            MySqlDataAdapter dataAdapter= new MySqlDataAdapter("select * from evraklar", new dbbaglanti().baglantiGetir());
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public void listele2()
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from emanetci", new dbbaglanti().baglantiGetir());
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView2.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("boş alamları doldurunuz");
            }
            else
            {
                new Evrakservice().evrakKaydet(textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("kayıt başarılı");
                listele();
            }
        }

        private void anaekran_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'belgeArşivYönetimSistemiDataSet1.Evrak' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.evrakTableAdapter1.Fill(this.belgeArşivYönetimSistemiDataSet1.Evrak);
            // TODO: Bu kod satırı 'belgeArşivYönetimSistemiDataSet.Evrak' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.evrakTableAdapter.Fill(this.belgeArşivYönetimSistemiDataSet.Evrak);
            listele();
            listele2();

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("boş alamları doldurunuz");
            }

            else
            {

                new Evrakservice().evrakGuncelle(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("güncelleme başarılı");
                listele();
            }
        }

        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
            MySqlDataAdapter da = new MySqlDataAdapter("select * from evraklar where evrakaciklama like '" + textBox5.Text + "%' or evraktipi like '" + textBox5.Text + "%' or evrakyeri like'" + textBox5.Text + "%'", (new dbbaglanti()).baglantiGetir());
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource= table;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Evrakservice().evrakSil(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show("silme başarılı");
            listele();

        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox6.Text == "" || textBox7.Text==""|| textBox8.Text=="")
            {
                MessageBox.Show("boş alamları doldurunuz");
            }

            else
            {
                new Emanetciservice().emanetciKaydet(textBox6.Text, textBox7.Text, textBox8.Text, textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("kayıt başarılı");
                listele2();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from emanetci where ad like '" + textBox4.Text + "%' or soyad like '" + textBox4.Text + "%' or iletisim like'" + textBox4.Text + "%' or evrakaciklama like'" + textBox4.Text + "%' or evraktipi like'" + textBox4.Text + "%' or evrakyeri like'" + textBox4.Text + "%' ", (new dbbaglanti()).baglantiGetir());
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Emanetciservice().emanetciSil(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()), textBox6.Text, textBox7.Text, textBox8.Text,textBox1.Text,textBox2.Text,textBox3.Text);
            MessageBox.Show("silme başarılı");
            listele2();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox7.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox8.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        /*private void button6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("boş alamları doldurunuz");
            }

            else
            {

                new Emanetciservice().emanetGuncelle(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), textBox6.Text, textBox7.Text, textBox8.Text);
                MessageBox.Show("güncelleme başarılı");
                listele2();
            }
        }*/
    }
}
