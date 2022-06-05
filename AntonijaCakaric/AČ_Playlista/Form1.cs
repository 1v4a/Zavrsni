using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AČ_Playlista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Model.Playliste_AntonijaCEntities pl = new Model.Playliste_AntonijaCEntities(); // kreiramo kontekst koji nam služi za uređivanje sadržaja baze

        private void Form1_Load(object sender, EventArgs e)
        {
            GridView.DataSource = pl.Playlista.ToList(); // učitavamo podatke iz baze u dataGridView pod imenom GridView
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Pjesma p = new Model.Pjesma(); // stvaramo prazan objekt tipa Pjesma
                p.Ime = ImeTB.Text; 
                p.Autor = AutorTB.Text;
                p.Duljina = DuljinaTB.Text;
                if (SingleRB.Checked)
                    p.Distribucija = "Single";
                else if (EPRB.Checked)
                    p.Distribucija = "EP";
                else if (AlbumRB.Checked)
                    p.Distribucija = "Album";
                p.Eksplicitno = EksplicitnaCB.Checked.ToString();
                p.Grammy = GrammyCB.Checked.ToString();
                // popunjavamo properties objekta podatcima iz forme
                pl.Playlista.Add(p);
                // unosimo objekt u bazu
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            pl.SaveChanges(); // spremamo promjene
            GridView.DataSource = pl.Playlista.ToList(); // refreshamo prikaz tablice
        }

        private void Uredi_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(IdTB.Text);
                Model.Pjesma p = new Model.Pjesma();
                p = pl.Playlista.Find(id); // select-amo unos iz baze koji ima isti id kao onaj unesen u formi
                pl.Playlista.Remove(p); // brišemo unos, ali podatci ostaju u objektu p
                pl.SaveChanges(); // spremamo promjene radi ispravnog rada programa
                p.Ime = ImeTB.Text;
                p.Autor = AutorTB.Text;
                p.Duljina = DuljinaTB.Text;
                if (SingleRB.Checked)
                    p.Distribucija = "Single";
                else if (EPRB.Checked)
                    p.Distribucija = "EP";
                else if (AlbumRB.Checked)
                    p.Distribucija = "Album";
                p.Eksplicitno = EksplicitnaCB.Checked.ToString();
                p.Grammy = GrammyCB.Checked.ToString();
                // uređujemo properties objekta koji ćemo ponovo stvoriti
                pl.Playlista.Add(p);
                // stvaramo novi unos sa primijenjenim podatcima
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            pl.SaveChanges(); // spremamo promjene
            GridView.DataSource = pl.Playlista.ToList(); // refreshamo prikaz tablice
        }

        private void Ukloni_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(IdTB.Text);
                Model.Pjesma p = new Model.Pjesma();
                p = pl.Playlista.Find(id); // select-amo unos iz baze koji ima isti id kao onaj unesen u formi
                pl.Playlista.Remove(p); // brišemo unos

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            pl.SaveChanges(); // spremamo promjene
            GridView.DataSource = pl.Playlista.ToList(); // refreshamo prikaz tablice
        }
    }
}
