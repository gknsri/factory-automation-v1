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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 475;
            this.CenterToScreen();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void menu1_1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Location = new Point(0, 25);
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
            baglanti1.Open();
            OleDbCommand sorgu1 = new OleDbCommand("select * from urunstok", baglanti1);            
            DataTable tablo = new DataTable();
            tablo.Load(sorgu1.ExecuteReader());
            dataGridView1.DataSource = tablo;
            OleDbDataReader getir1 = sorgu1.ExecuteReader();            
            comboBox1.Items.Clear();
            comboBox1.Text = "Ürün Adı";
            comboBox2.Items.Clear();
            comboBox2.Text = "Ürün Kodu";
            while (getir1.Read())
            {
                comboBox1.Items.Add(getir1["urn_adi"]);
                comboBox2.Items.Add(getir1["urn_kodu"]);
            }
            baglanti1.Close();            
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            numericUpDown1.Visible = false;
            button2.Visible = false;
            button2.Enabled = false;
        }

        private void menu1_2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Location = new Point(0, 25);
            panel3.Visible = false;
            panel4.Visible = false;

            OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
            baglanti1.Open();
            OleDbCommand sorgu1 = new OleDbCommand("select * from hammadde", baglanti1);
            DataTable tablo = new DataTable();
            tablo.Load(sorgu1.ExecuteReader());
            dataGridView2.DataSource = tablo;
            OleDbDataReader getir1 = sorgu1.ExecuteReader();
            comboBox3.Items.Clear();
            comboBox3.Text = "Hammadde Adı";
            comboBox4.Items.Clear();
            comboBox4.Text = "Hammadde Kodu";
            while (getir1.Read())
            {
                comboBox3.Items.Add(getir1["ham_adi"]);
                comboBox4.Items.Add(getir1["ham_kodu"]);
            }
            baglanti1.Close();
            textBox1.Text = "";
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            textBox1.Visible = false;
            button4.Visible = false;
            button4.Enabled = false;
        }

        private void menu2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel3.Location = new Point(0, 25);
            panel4.Visible = false;

            OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
            baglanti1.Open();
            OleDbCommand sorgu1 = new OleDbCommand("select ham_kodu,ham_adi,ham_miktari from hammadde", baglanti1);
            DataTable tablo1 = new DataTable();
            tablo1.Load(sorgu1.ExecuteReader());
            dataGridView3.DataSource = tablo1;
            OleDbCommand sorgu2 = new OleDbCommand("select urn_kodu,urn_adi,urn_miktari from urunstok", baglanti1);
            DataTable tablo2 = new DataTable();
            tablo2.Load(sorgu2.ExecuteReader());
            dataGridView4.DataSource = tablo2;

            OleDbDataReader getir2 = sorgu2.ExecuteReader();
            comboBox5.Items.Clear();
            comboBox5.Text = "Seçiniz";
            while (getir2.Read())
            {
                comboBox5.Items.Add(getir2["urn_kodu"] + " | " + getir2["urn_adi"]);
            }
            baglanti1.Close();
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            numericUpDown2.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button9.Enabled = false;
        }

        private void menu3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;            
            panel4.Visible = true;
            panel4.Location = new Point(0, 25);

            label41.Text = Form1.goad;

            OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
            baglanti1.Open();
            OleDbCommand sorgu1 = new OleDbCommand("select * from kullanici where usr_kadi='"+label41.Text+"'", baglanti1);
            OleDbDataReader getir1 = sorgu1.ExecuteReader();

            while (getir1.Read())
            {
                label39.Text = Convert.ToString(getir1["usr_adi"]);
                label40.Text = Convert.ToString(getir1["usr_tcno"]);
                textBox2.Text = Convert.ToString(getir1["usr_sifre"]);
                label42.Text = Convert.ToString(getir1["usr_sifre"]);
                textBox3.Text = Convert.ToString(getir1["usr_sirket_adi"]);
                label43.Text = Convert.ToString(getir1["usr_sirket_adi"]);
                textBox4.Text = Convert.ToString(getir1["usr_telno"]);
                label44.Text = Convert.ToString(getir1["usr_telno"]);
                textBox5.Text = Convert.ToString(getir1["usr_sirket_adresi"]);
                label45.Text = Convert.ToString(getir1["usr_sirket_adresi"]);
            }

            button10.Enabled = false;

            baglanti1.Close();
        }

        private void menu4_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void menu5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //SAYFA-1

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
            baglanti1.Open();
            OleDbCommand sorgu1 = new OleDbCommand("select * from urunstok", baglanti1);
            DataTable tablo = new DataTable();
            tablo.Load(sorgu1.ExecuteReader());
            dataGridView1.DataSource = tablo;
            baglanti1.Close();
            comboBox1.Text = "Ürün Adı";
            comboBox2.Text = "Ürün Kodu";
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            numericUpDown1.Visible = false;            
            button2.Visible = false;
            button2.Enabled = false;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
            baglanti1.Open();
            OleDbCommand sorgu1 = new OleDbCommand("select * from urunstok where urn_adi='"+comboBox1.SelectedItem+"'", baglanti1);
            DataTable tablo = new DataTable();
            tablo.Load(sorgu1.ExecuteReader());
            dataGridView1.DataSource = tablo;
            OleDbDataReader getir1 = sorgu1.ExecuteReader();
            getir1.Read();
            comboBox2.SelectedItem = getir1["urn_kodu"];
            label6.Text = Convert.ToString(getir1["urn_kodu"]);
            label7.Text = Convert.ToString(getir1["urn_barkod"]);
            label8.Text = Convert.ToString(getir1["urn_adi"]);
            label9.Text = Convert.ToString(getir1["urn_miktari"]) + " " + Convert.ToString(getir1["urn_birim"]);
            numericUpDown1.Value = 0;
            numericUpDown1.Maximum = Convert.ToInt32(getir1["urn_miktari"]);
            baglanti1.Close();
            label11.Text = "Toplam Fiyat";
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            numericUpDown1.Visible = true;
            button2.Visible = true;
            button2.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
            baglanti1.Open();
            OleDbCommand sorgu1 = new OleDbCommand("select * from urunstok where urn_kodu='" + comboBox2.SelectedItem + "'", baglanti1);
            DataTable tablo = new DataTable();
            tablo.Load(sorgu1.ExecuteReader());
            dataGridView1.DataSource = tablo;
            OleDbDataReader getir1 = sorgu1.ExecuteReader();
            getir1.Read();
            comboBox1.SelectedItem = getir1["urn_adi"];
            label6.Text = Convert.ToString(getir1["urn_kodu"]);
            label7.Text = Convert.ToString(getir1["urn_barkod"]);
            label8.Text = Convert.ToString(getir1["urn_adi"]);
            label9.Text = Convert.ToString(getir1["urn_miktari"]) + " " + Convert.ToString(getir1["urn_birim"]);
            numericUpDown1.Value=0;
            numericUpDown1.Maximum = Convert.ToInt32(getir1["urn_miktari"]);
            baglanti1.Close();
            label11.Text = "Toplam Fiyat";
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            numericUpDown1.Visible = true;
            button2.Visible = true;
            button2.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                button2.Enabled = true;
                label11.Text = Convert.ToString(numericUpDown1.Value * Convert.ToInt32(dataGridView1.CurrentRow.Cells["urn_birim_fiyat"].Value)) + " TL";
             }
            else
            {
                button2.Enabled = false;
                label11.Text = "Toplam Fiyat";
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Ürün Satışını Onaylıyor Musunuz?", "Otomasyon Programı", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
                baglanti1.Open();
                OleDbCommand sorgu1 = new OleDbCommand("update urunstok set urn_miktari=urn_miktari-'"+numericUpDown1.Value+"' where urn_kodu='" + comboBox2.SelectedItem + "' and urn_barkod='"+label7.Text+"'", baglanti1);
                sorgu1.ExecuteNonQuery();
                OleDbCommand sorgu2 = new OleDbCommand("select * from urunstok where urn_adi='" + comboBox1.SelectedItem + "' and urn_kodu='"+comboBox2.SelectedItem+"'", baglanti1);
                DataTable tablo = new DataTable();
                tablo.Load(sorgu2.ExecuteReader());
                dataGridView1.DataSource = tablo;
                OleDbDataReader getir1 = sorgu2.ExecuteReader();
                getir1.Read();
                label6.Text = Convert.ToString(getir1["urn_kodu"]);
                label7.Text = Convert.ToString(getir1["urn_barkod"]);
                label8.Text = Convert.ToString(getir1["urn_adi"]);
                label9.Text = Convert.ToString(getir1["urn_miktari"]) + " " + Convert.ToString(getir1["urn_birim"]);
                numericUpDown1.Value = 0;
                numericUpDown1.Maximum = Convert.ToInt32(getir1["urn_miktari"]);
                MessageBox.Show("Kalan Stok -- " + label9.Text, "Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti1.Close();
            }
            else
            {
                numericUpDown1.Value = 0;
            }
        }

        //SAYFA-2

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
            baglanti1.Open();
            OleDbCommand sorgu1 = new OleDbCommand("select * from hammadde", baglanti1);
            DataTable tablo = new DataTable();
            tablo.Load(sorgu1.ExecuteReader());
            dataGridView2.DataSource = tablo;
            comboBox3.Text = "Hammadde Adı";
            comboBox4.Text = "Hammadde Kodu";
            textBox1.Text = "";
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            textBox1.Visible = false;
            button4.Visible = false;
            button4.Enabled = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
            baglanti1.Open();
            OleDbCommand sorgu1 = new OleDbCommand("select * from hammadde where ham_adi='" + comboBox3.SelectedItem + "'", baglanti1);
            DataTable tablo = new DataTable();
            tablo.Load(sorgu1.ExecuteReader());
            dataGridView2.DataSource = tablo;
            OleDbDataReader getir1 = sorgu1.ExecuteReader();
            getir1.Read();
            comboBox4.SelectedItem = getir1["ham_kodu"];
            label17.Text = Convert.ToString(getir1["ham_kodu"]);
            label18.Text = Convert.ToString(getir1["ham_barkod"]);
            label19.Text = Convert.ToString(getir1["ham_adi"]);
            label20.Text = Convert.ToString(getir1["ham_miktari"]) + " " + Convert.ToString(getir1["ham_birim"]);
            baglanti1.Close();
            label22.Text = "Ödenecek Tutar";
            textBox1.Text = "";
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            textBox1.Visible = true;
            button4.Visible = true;
            button4.Enabled = false;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
            baglanti1.Open();
            OleDbCommand sorgu1 = new OleDbCommand("select * from hammadde where ham_kodu='" + comboBox4.SelectedItem + "'", baglanti1);
            DataTable tablo = new DataTable();
            tablo.Load(sorgu1.ExecuteReader());
            dataGridView2.DataSource = tablo;
            OleDbDataReader getir1 = sorgu1.ExecuteReader();
            getir1.Read();
            comboBox3.SelectedItem = getir1["ham_adi"];
            label17.Text = Convert.ToString(getir1["ham_kodu"]);
            label18.Text = Convert.ToString(getir1["ham_barkod"]);
            label19.Text = Convert.ToString(getir1["ham_adi"]);
            label20.Text = Convert.ToString(getir1["ham_miktari"]) + " " + Convert.ToString(getir1["ham_birim"]);
            baglanti1.Close();
            label22.Text = "Ödenecek Tutar";
            textBox1.Text = "";
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            textBox1.Visible = true;
            button4.Visible = true;
            button4.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox1.Text != "0"))
            {
                button4.Enabled = true;
                label22.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(dataGridView2.CurrentRow.Cells["ham_birim_fiyat"].Value))+ " TL";
            }
            else
            {
                button4.Enabled = false;
                label22.Text = "Ödenecek Tutar";
            }            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Hammadde Alımını Onaylıyor Musunuz?", "Otomasyon Programı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
                baglanti1.Open();
                OleDbCommand sorgu1 = new OleDbCommand("update hammadde set ham_miktari='" + Convert.ToString(Convert.ToInt32(dataGridView2.CurrentRow.Cells["ham_miktari"].Value) + Convert.ToInt32(textBox1.Text)) + "' where ham_kodu='" + comboBox4.SelectedItem + "' and ham_barkod='" + label18.Text + "'", baglanti1);
                sorgu1.ExecuteNonQuery();
                OleDbCommand sorgu2 = new OleDbCommand("select * from hammadde where ham_adi='" + comboBox3.SelectedItem + "' and ham_kodu='" + comboBox4.SelectedItem + "'", baglanti1);
                DataTable tablo = new DataTable();
                tablo.Load(sorgu2.ExecuteReader());
                dataGridView2.DataSource = tablo;
                OleDbDataReader getir1 = sorgu2.ExecuteReader();
                getir1.Read();
                label17.Text = Convert.ToString(getir1["ham_kodu"]);
                label18.Text = Convert.ToString(getir1["ham_barkod"]);
                label19.Text = Convert.ToString(getir1["ham_adi"]);
                label20.Text = Convert.ToString(getir1["ham_miktari"]) + " " + Convert.ToString(getir1["ham_birim"]);
                textBox1.Text = "";
                MessageBox.Show("Güncel Stok -- " + label20.Text, "Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti1.Close();
            }
            else
            {
                textBox1.Text = "";
            }
        }        

       //SAYFA-3

        private void label30_Click(object sender, EventArgs e)
        {
            menu1_2_Click(menu1_2, new EventArgs());
        }

        private void label30_MouseHover(object sender, EventArgs e)
        {
            label30.ForeColor = Color.CornflowerBlue;
        }

        private void label30_MouseLeave(object sender, EventArgs e)
        {
            label30.ForeColor = Color.DarkSlateBlue;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secim = "";
            if (comboBox5.SelectedIndex == 0)
            {
                secim = "Şeftali";
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                secim = "Kayısı";
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                secim = "Vişne";
            }
            else if (comboBox5.SelectedIndex == 3)
            {
                secim = "Çilek";
            }
            else if (comboBox5.SelectedIndex == 4)
            {
                secim = "Elma";
            }            
        
            OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
            baglanti1.Open();
            OleDbCommand sorgu1 = new OleDbCommand("select ham_kodu,ham_adi,ham_miktari from hammadde where ham_adi like '%" + secim + "%'", baglanti1);
            DataTable tablo1 = new DataTable();
            tablo1.Load(sorgu1.ExecuteReader());
            dataGridView3.DataSource = tablo1;
            OleDbCommand sorgu2 = new OleDbCommand("select urn_kodu,urn_adi,urn_miktari from urunstok where urn_adi like '%" + secim + "%'", baglanti1);
            DataTable tablo2 = new DataTable();
            tablo2.Load(sorgu2.ExecuteReader());
            dataGridView4.DataSource = tablo2;

            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;

            if ((Convert.ToInt32(dataGridView3.CurrentRow.Cells["ham_miktari1"].Value) / 5) < 10)
            {
                button6.Enabled = false;
            }
            else
            {
                button6.Enabled = true;
            }
            if ((Convert.ToInt32(dataGridView3.CurrentRow.Cells["ham_miktari1"].Value) / 5) < 50)
            {
                button7.Enabled = false;
            }
            else
            {
                button7.Enabled = true;
            }
            if ((Convert.ToInt32(dataGridView3.CurrentRow.Cells["ham_miktari1"].Value) / 5) < 100)
            {
                button8.Enabled = false;
            }
            else
            {
                button8.Enabled = true;
            }            

            numericUpDown2.Value = 0;
            numericUpDown2.Visible = true;
            numericUpDown2.Maximum = Convert.ToInt32(dataGridView3.CurrentRow.Cells["ham_miktari1"].Value)/5;
            label30.Visible = true;
            label27.Text = "1 LT " + Convert.ToString(dataGridView4.CurrentRow.Cells["urn_adi1"].Value) + " Üretimi için 5 KG " + Convert.ToString(dataGridView3.CurrentRow.Cells["ham_adi1"].Value) + " Gerekli.";
            label27.Visible = true;
            label28.Text = "Mevcut Olan -- " + Convert.ToString(dataGridView3.CurrentRow.Cells["ham_miktari1"].Value) + " KG " + Convert.ToString(dataGridView3.CurrentRow.Cells["ham_adi1"].Value);
            label28.Visible = true;
            label29.Text = "Yapılabilecek " + Convert.ToString(dataGridView4.CurrentRow.Cells["urn_adi1"].Value) + " Miktarı";
            label29.Visible = true;
          
            baglanti1.Close();           
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value != 0)
            {
                button9.Enabled = true;
            }
            else
            {
                button9.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = Convert.ToInt32(dataGridView3.CurrentRow.Cells["ham_miktari1"].Value) / 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = 10;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = 50;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = 100;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult secim1 = MessageBox.Show(numericUpDown2.Value + " LT " + dataGridView4.CurrentRow.Cells["urn_adi1"].Value + " Üretimini Onaylıyor Musunuz?\n\n" + (numericUpDown2.Value * 5) + " KG " + dataGridView3.CurrentRow.Cells["ham_adi1"].Value + " Kullanılacak.", "Otomasyon Programı", MessageBoxButtons.YesNo);
            if (secim1 == DialogResult.Yes)
            {
                string secim = "";
                if (comboBox5.SelectedIndex == 0)
                {
                    secim = "Şeftali";
                }
                else if (comboBox5.SelectedIndex == 1)
                {
                    secim = "Kayısı";
                }
                else if (comboBox5.SelectedIndex == 2)
                {
                    secim = "Vişne";
                }
                else if (comboBox5.SelectedIndex == 3)
                {
                    secim = "Çilek";
                }
                else if (comboBox5.SelectedIndex == 4)
                {
                    secim = "Elma";
                }    

                OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
                baglanti1.Open();
                OleDbCommand sorgu1 = new OleDbCommand("update hammadde set ham_miktari=ham_miktari-'" + (numericUpDown2.Value * 5) + "' where ham_kodu='" + dataGridView3.CurrentRow.Cells["ham_kodu1"].Value + "' and ham_adi='" + dataGridView3.CurrentRow.Cells["ham_adi1"].Value + "'", baglanti1);
                sorgu1.ExecuteNonQuery();
                OleDbCommand sorgu2 = new OleDbCommand("update urunstok set urn_miktari='" + Convert.ToString(Convert.ToInt32(dataGridView4.CurrentRow.Cells["urn_miktari1"].Value) + numericUpDown2.Value) + "' where urn_kodu='" + dataGridView4.CurrentRow.Cells["urn_kodu1"].Value + "' and urn_adi='" + dataGridView4.CurrentRow.Cells["urn_adi1"].Value + "'", baglanti1);
                sorgu2.ExecuteNonQuery();
              
                OleDbCommand sorgu3 = new OleDbCommand("select ham_kodu,ham_adi,ham_miktari from hammadde where ham_adi like '%" + secim + "%'", baglanti1);
                DataTable tablo1 = new DataTable();
                tablo1.Load(sorgu3.ExecuteReader());
                dataGridView3.DataSource = tablo1;
                OleDbCommand sorgu4 = new OleDbCommand("select urn_kodu,urn_adi,urn_miktari from urunstok where urn_adi like '%" + secim + "%'", baglanti1);
                DataTable tablo2 = new DataTable();
                tablo2.Load(sorgu4.ExecuteReader());
                dataGridView4.DataSource = tablo2;

                if ((Convert.ToInt32(dataGridView3.CurrentRow.Cells["ham_miktari1"].Value) / 5) < 10)
                {
                    button6.Enabled = false;
                }
                else
                {
                    button6.Enabled = true;
                }
                if ((Convert.ToInt32(dataGridView3.CurrentRow.Cells["ham_miktari1"].Value) / 5) < 50)
                {
                    button7.Enabled = false;
                }
                else
                {
                    button7.Enabled = true;
                }
                if ((Convert.ToInt32(dataGridView3.CurrentRow.Cells["ham_miktari1"].Value) / 5) < 100)
                {
                    button8.Enabled = false;
                }
                else
                {
                    button8.Enabled = true;
                }
                
                label28.Text = "Mevcut Olan -- " + Convert.ToString(dataGridView3.CurrentRow.Cells["ham_miktari1"].Value) + " KG " + Convert.ToString(dataGridView3.CurrentRow.Cells["ham_adi1"].Value);
 
                MessageBox.Show(numericUpDown2.Value + " KG " + dataGridView4.CurrentRow.Cells["urn_adi1"].Value + " Üretimi Başarıyla Tamamlandı.", "Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                numericUpDown2.Value = 0;
                numericUpDown2.Maximum = Convert.ToInt32(dataGridView3.CurrentRow.Cells["ham_miktari1"].Value) / 5;
                
                baglanti1.Close();
            }
            else
            {
                numericUpDown2.Value = 0;
            }
        }        

        //SAYFA-4        


        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = label42.Text;
            textBox3.Text = label43.Text;
            textBox4.Text = label44.Text;
            textBox5.Text = label45.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == label42.Text && textBox3.Text == label43.Text &&
                textBox4.Text == label44.Text && textBox5.Text == label45.Text)
            {
                button10.Enabled = false;
            }
            else
            {
                button10.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == label42.Text && textBox3.Text == label43.Text &&
                textBox4.Text == label44.Text && textBox5.Text == label45.Text)
            {
                button10.Enabled = false;
            }
            else
            {
                button10.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == label42.Text && textBox3.Text == label43.Text &&
                textBox4.Text == label44.Text && textBox5.Text == label45.Text)
            {
                button10.Enabled = false;
            }
            else
            {
                button10.Enabled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == label42.Text && textBox3.Text == label43.Text &&
                textBox4.Text == label44.Text && textBox5.Text == label45.Text)
            {
                button10.Enabled = false;
            }
            else
            {
                button10.Enabled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Kullanıcı Bilgileri Güncellenecek. Onaylıyor Musunuz?", "Otomasyon Programı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
                baglanti1.Open();
                OleDbCommand sorgu1 = new OleDbCommand("update kullanici set usr_sifre='" + textBox2.Text + "', usr_sirket_adi='" + textBox3.Text + "', usr_telno='" + textBox4.Text + "', usr_sirket_adresi='" + textBox5.Text + "' where usr_kadi='" + label41.Text + "' and usr_tcno='" + label40.Text + "'", baglanti1);
                sorgu1.ExecuteNonQuery();
                baglanti1.Close();
                
                MessageBox.Show("Güncelleme Başarıyla Tamamlandı.", "Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                label42.Text = textBox2.Text;
                label43.Text = textBox3.Text;
                label44.Text = textBox4.Text;
                label45.Text = textBox5.Text;

                button10.Enabled = false;
            }
        }   


    }
}
