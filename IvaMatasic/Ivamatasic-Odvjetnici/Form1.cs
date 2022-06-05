using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ivamatasic_Odvjetnici.Model;

namespace Ivamatasic_Odvjetnici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ZavrsniNOPEntities db;

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new ZavrsniNOPEntities(); // dodajemo novi konekst objekt u db (služi za mijenjanje podataka u bazi)
            dataGridView1.DataSource = db.Odvjetniks.ToList(); // dodajemo sadržaj u dataGridView iz baze
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new ZavrsniNOPEntities(); // dodajemo novi konekst objekt u db (služi za mijenjanje podataka u bazi)
            try
            {
                string Razina = radioButton1.Checked ? "Niža" : "Viša"; // mijenjamo vrijednost varijable Razina ovisno o radio buttonima
                db.Odvjetniks.Add(new Odvjetnik { Ime=textBox1.Text, Prezime=textBox2.Text, Godine=textBox4.Text, TICOugovor=checkBox1.Checked.ToString(), Posudba=checkBox2.Checked.ToString(), Razina=Razina});
                // stvaramo novi unos sa podatcima iz forme
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.SaveChanges(); // sprema bazu
            dataGridView1.DataSource = db.Odvjetniks.ToList(); // refresha dataGridView
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db = new ZavrsniNOPEntities(); // dodajemo novi konekst objekt u db (služi za mijenjanje podataka u bazi)
            try
            {
                int Id = Convert.ToInt32(textBox3.Text);
                var Odv = db.Odvjetniks.Find(Id);
                db.Odvjetniks.Remove(Odv); // brišemo unos sa danim id-em, ali ne i korisnika (sadržan u Odv-objektu)
                db.SaveChanges(); // spremamo bazu glede ispravnog rada programa

                Odv.Ime = textBox1.Text;
                Odv.Prezime = textBox2.Text;
                Odv.Godine = textBox4.Text;
                Odv.TICOugovor = checkBox1.Checked.ToString();
                Odv.Posudba = checkBox2.Checked.ToString();
                Odv.Razina = radioButton1.Checked ? "Niža" : "Viša"; // mijenjamo podatke prema unosima iz forme
                db.Odvjetniks.Add(Odv); // stvaramo novi unos 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.SaveChanges(); // sprema bazu
            dataGridView1.DataSource = db.Odvjetniks.ToList(); // refresha dataGridView
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db = new ZavrsniNOPEntities(); // dodajemo novi konekst objekt u db (služi za mijenjanje podataka u bazi)
            try
            {
                int Id = Convert.ToInt32(textBox3.Text);
                var Odv = db.Odvjetniks.Find(Id);
                db.Odvjetniks.Remove(Odv); // brišemo unos sa danim id-em
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.SaveChanges(); // sprema bazu
            dataGridView1.DataSource = db.Odvjetniks.ToList(); // refresha dataGridView
        }
    }
}
