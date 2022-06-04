using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarkoKaratur_TrgovineNTL.Model;

namespace MarkoKaratur_TrgovineNTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Model1Entities db = new Model1Entities(); // konteks objekt - služi za upravljanje bazom iz programa
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Trgovines.ToList();  // refreshamo prikaz tablice
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // onaj checkbox pored Dodaj/Unesi mijenja trenutnu funkciju, kad nije pritisnut je omogućena akcija Dodaj, kad je pritisnut Unesi
                if (!checkBox1.Checked)
                {
                    // DODAJ - unos podataka u bazu, stvaramo novi objekt sa unesenim podatcima
                    if (radioButton1.Checked)
                    {
                        db.Trgovines.Add(new Trgovine() { ImeTrgovine = textBox1.Text, Lokacija = textBox2.Text, BrojRadnika = textBox3.Text, Kategorija = radioButton1.Text });
                    }
                    else if (radioButton2.Checked)
                    { 
                        db.Trgovines.Add(new Trgovine() { ImeTrgovine = textBox1.Text, Lokacija = textBox2.Text, BrojRadnika = textBox3.Text, Kategorija = radioButton2.Text }); 
                    }
                    
                }
                else
                {
                    // UNESI - prvo SELECT-amo unos sa ID-em iz textBox4, brišemo ga te unosimo novi sa novim podatcima, ako takvih ima
                    int id = Convert.ToInt32(textBox4.Text);
                    Trgovine trg = db.Trgovines.First(i => id == i.Id);
                    db.Trgovines.Remove(trg);
                    db.SaveChanges();

                    trg.ImeTrgovine = textBox1.Text;
                    trg.Lokacija = textBox2.Text;
                    trg.BrojRadnika = textBox3.Text;

                    if (radioButton1.Checked)
                    {
                        trg.Kategorija = radioButton1.Text;
                    }
                    else if (radioButton2.Checked)
                    {
                        trg.Kategorija = radioButton2.Text;
                    }

                    db.Trgovines.Add(trg);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // OBRIŠI - SELECT-aj objekt sa ID-em iz textBox5 te ga obriši
                int id = Convert.ToInt32(textBox5.Text);
                Trgovine trg = db.Trgovines.First(i => id == i.Id);
                db.Trgovines.Remove(trg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // SPREMI - sprema promjene i osvježava prikaz baze u dataGridView1
            db.SaveChanges();
            dataGridView1.DataSource = db.Trgovines.ToList();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // kad pritisnemo checkbox, Enable-amo textBox4 (nije potreban prilikom akcije DODAJ)
            if (checkBox1.Checked)
            {
                textBox4.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
            }
        }
    }
}
