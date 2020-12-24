using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace uretim_ve_imalat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string goad;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 500;
            this.Height = 375;
            this.CenterToScreen();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.SkyBlue;            
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Location = new Point(0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select * from kullanici where usr_kadi='"+textBox1.Text+"' and usr_sifre='"+textBox2.Text+"'", baglanti);
            OleDbDataReader getir = sorgu.ExecuteReader(); 
            //if (textBox1.Text.ToString() == getir["usr_kadi"].ToString() && textBox2.Text.ToString() == getir["usr_sifre"].ToString())
            if(getir.Read())
            {    
                this.Hide();
                Form2 form2 = new Form2();                
                form2.Show();

                goad = textBox1.Text;

            }
            else
            {
                MessageBox.Show("Hatalı Giriş!!!", "Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == "")
                || (textBox7.TextLength != 11) || (textBox8.TextLength != 11) || (textBox9.Text == "") || (textBox10.Text == ""))
           {
               MessageBox.Show("Tüm Alanları Doldurunuz!!!", "Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           else
           {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
                baglanti.Open();
                OleDbCommand sorgu = new OleDbCommand("insert into kullanici (usr_kadi,usr_sifre,usr_adi,usr_soyadi,usr_tcno,usr_telno,usr_sirket_adi,usr_sirket_adresi) values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')", baglanti);
                sorgu.ExecuteNonQuery();
                baglanti.Close();
                textBox1.Text = textBox3.Text;
                textBox2.Text = textBox4.Text;                
                textBox3.Text = ("");
                textBox4.Text = ("");
                textBox5.Text = ("");
                textBox6.Text = ("");
                textBox7.Text = ("");
                textBox8.Text = ("");
                textBox9.Text = ("");
                textBox10.Text = ("");
                MessageBox.Show("Kayıt İşlemi Başarıyla Tamamlandı.", "Otomasyon Programı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                panel1.Visible = true;
                panel2.Visible = false;
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = ("");
            textBox4.Text = ("");
            textBox5.Text = ("");
            textBox6.Text = ("");
            textBox7.Text = ("");
            textBox8.Text = ("");
            textBox9.Text = ("");
            textBox10.Text = ("");
        }
    }
}
