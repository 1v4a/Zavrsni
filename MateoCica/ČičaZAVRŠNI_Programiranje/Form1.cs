using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ČičaZAVRŠNI_Programiranje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Model.ZadatakProgramiranjeEntities et = new Model.ZadatakProgramiranjeEntities(); // dodajemo kontekst (služi za uređivanje baze iz našeg koda)

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = et.GrafickeKartice.ToList(); // dodajemo sadržaj iz baze u dataGridView 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RadioButton[] r = new RadioButton[6] { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6 }; // deklariramo niz radio buttona radi lakšeg pristupa
                string i = "1";
                foreach(RadioButton x in r)
                {
                    if (x.Checked)
                    {
                        i = x.Text; // provjeravamo koji je radio button pritisnut
                    }
                }
                var g = new Model.GrafickaKartica { Marka=textBox1.Text, MjesecDostave=textBox2.Text, BrojMjeseci=textBox3.Text, Odjeljak=i, Rezervirana=checkBox1.Checked.ToString()};
                // stvaramo unos u obliku objekta koristeći parametre iz forme
                et.GrafickeKartice.Add(g); // unos u bazu
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}" + ex);
            }
            et.SaveChanges(); // spremamo promjene u bazi
            dataGridView1.DataSource = et.GrafickeKartice.ToList(); // refreshamo dataGridView
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBox4.Text);
                var g = et.GrafickeKartice.Find(ID); // select-amo unos sa ID-em iz forme
                et.GrafickeKartice.Remove(g); // brišemo unos, ali ne i podatke (sadržani su u g-objektu)
                et.SaveChanges(); // spremamo bazu glede ispravnog rada programa

                g.Marka = textBox1.Text;
                g.MjesecDostave = textBox2.Text;
                g.BrojMjeseci = textBox3.Text;
                RadioButton[] r = new RadioButton[6] { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6 }; // deklariramo niz radio buttona radi lakšeg pristupa
                string i = "1";
                foreach (RadioButton x in r)
                {
                    if (x.Checked)
                    {
                        i = x.Text;
                    }
                }
                g.Odjeljak = i;
                g.Rezervirana = checkBox1.Checked.ToString();
                // mijenjamo podatke koristeći parametre iz forme
                et.GrafickeKartice.Add(g); // unosimo novi objekt
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}" + ex);
            }
            et.SaveChanges(); // spremamo promjene u bazi
            dataGridView1.DataSource = et.GrafickeKartice.ToList(); // refreshamo dataGridView
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBox4.Text);
                var g = et.GrafickeKartice.Find(ID); // select-amo unos sa ID-em iz forme
                et.GrafickeKartice.Remove(g); // brišemo unos
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}" + ex);
            }
            et.SaveChanges(); // spremamo promjene u bazi
            dataGridView1.DataSource = et.GrafickeKartice.ToList(); // refreshamo dataGridView
        }
    }
}
