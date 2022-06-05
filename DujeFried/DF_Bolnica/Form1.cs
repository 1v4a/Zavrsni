using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DF_Bolnica.Model;

namespace DF_Bolnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Zadatak_DF_BolnicaEntities db = new Zadatak_DF_BolnicaEntities(); // stvaramo kontekst objekt radi upravljanja podatcima

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Pacijenti.ToList(); // dodajemo prikaz baze u dataGridView
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string rez = "";
                if (radioButton1.Checked == true)
                {
                    rez = radioButton1.Checked.ToString();
                }
                if (radioButton2.Checked == true)
                {
                    rez = radioButton2.Checked.ToString();
                }
                if (radioButton3.Checked == true)
                {
                    rez = radioButton3.Checked.ToString();
                } // grananje zbog radio buttona - tražimo checked radio button
                var p = new Pacijent() {Ime=textBox1.Text, Prezime=textBox2.Text, Odjel=textBox3.Text, Kriticnost=rez, Stacioniran=checkBox1.Checked.ToString()}; // stvaramo unos koristeći parametre iz forme
                db.Pacijenti.Add(p); // dodajemo unos u bazu
                db.SaveChanges(); // spremamo bazu
                dataGridView1.DataSource = db.Pacijenti.ToList(); // refreshamo prikaz u dataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(textBox4.Text);
                var p = db.Pacijenti.Find(Id); // tražimo unos sa id-em iz forme
                db.Pacijenti.Remove(p); // brišemo unos, ali ne i podatke (sadržani su u p-objektu)
                db.SaveChanges(); // spremamo promjene u bazi radi ispravnog rada programa
                p.Ime = textBox1.Text;
                p.Prezime = textBox2.Text;
                p.Odjel = textBox3.Text;
                string rez = "";
                if (radioButton1.Checked == true)
                {
                    rez = radioButton1.Checked.ToString();
                }
                if (radioButton2.Checked == true)
                {
                    rez = radioButton2.Checked.ToString();
                }
                if (radioButton3.Checked == true)
                {
                    rez = radioButton3.Checked.ToString();
                }
                p.Kriticnost = rez;
                p.Stacioniran = checkBox1.Checked.ToString();
                // mijenjamo podatke u objektu
                db.Pacijenti.Add(p); // dodajemo izmijenjeni unos u bazu
                db.SaveChanges(); // spremamo bazu
                dataGridView1.DataSource = db.Pacijenti.ToList(); // refreshamo prikaz u dataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(textBox4.Text);
                var p = db.Pacijenti.Find(Id); // tražimo unos sa id-em iz forme
                db.Pacijenti.Remove(p); // brišemo unos
                db.SaveChanges(); // spremamo bazu
                dataGridView1.DataSource = db.Pacijenti.ToList(); // refreshamo prikaz u dataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
