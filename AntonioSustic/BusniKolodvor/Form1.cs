using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusniKolodvor.Model;

namespace BusniKolodvor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BusniKolodvorEntities busevi = new BusniKolodvorEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busevi.Buses.ToList(); // 
        }

        private void Umetni_Click(object sender, EventArgs e)
        {
            try
            {
                RadioButton[] radios = new RadioButton[3] { Cazmatrans, Slavijatrans, Vincek };
                Bus b = null;
                foreach(RadioButton radio in radios)
                {
                    if(radio.Checked == true)
                    {
                        b = new Bus() { Linija = Linija_tb.Text, Registracija = Registracija_tb.Text, Kapacitet = Kapacitet_tb.Text, Skolski = Skolski_cb.Checked.ToString(), Kompanija=radio.Name};
                        
                    }
                }
                busevi.Buses.Add(b);
                busevi.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}" + ex);
            }
            dataGridView1.DataSource = busevi.Buses.ToList();
        }

        private void Uredi_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(Id_tb.Text);
                var b = busevi.Buses.First(i => i.Id == ID);
                busevi.Buses.Remove(b);
                busevi.SaveChanges();

                b.Linija = Linija_tb.Text;
                b.Registracija = Registracija_tb.Text;
                b.Kapacitet = Kapacitet_tb.Text;
                b.Skolski = Skolski_cb.Checked.ToString();
                RadioButton[] radios = new RadioButton[3] { Cazmatrans, Slavijatrans, Vincek };
                string Kompanija = " ";
                foreach (RadioButton radio in radios)
                {
                    if (radio.Checked == true)
                    {
                        Kompanija = radio.Name;
                    }
                }
                b.Kompanija = Kompanija;
                busevi.Buses.Add(b);
                busevi.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}" + ex);
            }
            dataGridView1.DataSource = busevi.Buses.ToList();
        }

        private void Ukloni_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(Id_tb.Text);
                var b = busevi.Buses.First(i => i.Id == ID);
                busevi.Buses.Remove(b);
                busevi.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}" + ex);
            }
            dataGridView1.DataSource = busevi.Buses.ToList();
        }
    }
}
