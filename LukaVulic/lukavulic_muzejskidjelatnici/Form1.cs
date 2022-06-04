using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lukavulic_muzejskidjelatnici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Model.Model1Entities Baza = new Model.Model1Entities(); // stvaramo kontekst objekt - objekt s kojim uređujemo podatke u DB

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Baza.Djelatniks.ToList(); // prikazujemo sadržaj BP
        }

        private void button1_Click(object sender, EventArgs e) // unos
        {
            try
            {
                string Polozaj = "";
                if (radioButton1.Checked)
                {
                    Polozaj = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    Polozaj = radioButton2.Text;
                }
                if (Polozaj == "")
                {
                    MessageBox.Show("Unesi Položaj");
                    int b = 0;
                    int a = 5 / b; // namjerni Error da spriječim spremanje podataka u bazu
                }
                Baza.Djelatniks.Add(new Model.Djelatnik{Ime=textBox1.Text, Prezime=textBox2.Text, Polozaj=Polozaj, Aktivan=checkBox1.Checked.ToString()}); // unos novog djelatnika sa unesenim podatcima
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Baza.SaveChanges();
            dataGridView1.DataSource = Baza.Djelatniks.ToList(); // spremamo sadržaj i refreshamo prikaz GridView-a 
        }

        private void button2_Click(object sender, EventArgs e) // uređivanje
        {
            try
            {
                // 
                int ID = Convert.ToInt32(textBox3.Text);
                var dj = Baza.Djelatniks.First(d => d.Id == ID);
                Baza.Djelatniks.Remove(dj); // brisanje postojećeg unosa
                Baza.SaveChanges();

                dj.Ime = textBox1.Text;
                dj.Prezime = textBox2.Text;
                
                string Polozaj = "";
                if (radioButton1.Checked)
                {
                    Polozaj = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    Polozaj = radioButton2.Text;
                }
                if (Polozaj == "")
                {
                    MessageBox.Show("Unesi Položaj");
                    int b = 0;
                    int a = 5 / b; // namjerni Error da spriječim spremanje podataka u bazu
                }

                dj.Polozaj = Polozaj;
                dj.Aktivan = checkBox1.Checked.ToString();
                Baza.Djelatniks.Add(dj); // unos novog djelatnika sa ažuriranim podatcima
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Baza.SaveChanges();
            dataGridView1.DataSource = Baza.Djelatniks.ToList(); // spremamo sadržaj i refreshamo prikaz GridView-a 
        }

        private void button3_Click(object sender, EventArgs e) // brisanje
        {
            try
            {
                // 
                int ID = Convert.ToInt32(textBox3.Text);
                var dj = Baza.Djelatniks.First(d => d.Id == ID);
                Baza.Djelatniks.Remove(dj); // brisanje unosa
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Baza.SaveChanges();
            dataGridView1.DataSource = Baza.Djelatniks.ToList(); // spremamo sadržaj i refreshamo prikaz GridView-a 
        }
    }
}
