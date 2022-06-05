using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dario_Golubović__Popis_arhitekata.Model;

namespace Dario_Golubović__Popis_arhitekata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Zavrsni_DarioGEntities db = new Zavrsni_DarioGEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Arhitekti.ToList(); // učitavamo sadržaj baze u dataGridView kao listu (jer ne ide drugačije)
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                // ovi if-ovi su za svaki slučaj u radio buttonima
                if (radioButton1.Checked)
                {
                    db.Arhitekti.Add(new Arhitekt { Ime = textBox2.Text, Prezime = textBox3.Text, Zvanje = "Inženjer", GodineIskustva = textBox4.Text, Zauzet = checkBox1.Checked.ToString() });
                }
                else if(radioButton2.Checked)
                {
                    db.Arhitekti.Add(new Arhitekt { Ime = textBox2.Text, Prezime = textBox3.Text, Zvanje = "Diplomirani inženjer", GodineIskustva = textBox4.Text, Zauzet = checkBox1.Checked.ToString() });
                }
                else if(radioButton3.Checked)
                {
                    db.Arhitekti.Add(new Arhitekt { Ime = textBox2.Text, Prezime = textBox3.Text, Zvanje = "Magistar", GodineIskustva=textBox4.Text, Zauzet=checkBox1.Checked.ToString()});
                }
                // stvara unos sa parametrima iz forme
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.SaveChanges(); // sprema bazu
            dataGridView1.DataSource = db.Arhitekti.ToList(); // refresha dataGridView
        }

        private void Promijeni_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(textBox1.Text);
                Arhitekt a = db.Arhitekti.Find(Id);
                db.Arhitekti.Remove(a); // brišemo stari unos, ali ne i stare podatke (ostaju u a-objektu)
                db.SaveChanges(); // potrebno spremanje baze glede ispravnog rada
                a.Ime = textBox2.Text;
                a.Prezime = textBox3.Text;
                // ovi if-ovi su za svaki slučaj u radio buttonima
                if (radioButton1.Checked)
                {
                    a.Zvanje = "Inženjer";
                }
                else if (radioButton2.Checked)
                {
                    a.Zvanje = "Diplomirani inženjer";
                }
                else if (radioButton3.Checked)
                {
                    a.Zvanje = "Magistar";
                }
                a.GodineIskustva = textBox4.Text;
                a.Zauzet = checkBox1.Checked.ToString();
                // mijenjamo podatke za one iz forme
                db.Arhitekti.Add(a); // dodajemo novi unos
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.SaveChanges(); // sprema bazu
            dataGridView1.DataSource = db.Arhitekti.ToList(); // refresha dataGridView
        }

        private void Izbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(textBox1.Text);
                Arhitekt a = db.Arhitekti.Find(Id);
                db.Arhitekti.Remove(a); // brišemo stari unos
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.SaveChanges(); // sprema bazu
            dataGridView1.DataSource = db.Arhitekti.ToList(); // refresha dataGridView
        }
    }
}
