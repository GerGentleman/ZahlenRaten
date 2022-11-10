using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZahlenRaten
{
    public partial class Form1 : Form
    {

        private int counter;
        private int zahl;
        private Boolean geraten = false;

        public Form1()
        {
            InitializeComponent();
            newgame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_newgame_Click(object sender, EventArgs e)
        {
            newgame();
        }

        private void txt_eingabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_raten_Click(object sender, EventArgs e)
        {
            if(!geraten)
            {
                counter++;
                Console.WriteLine("Der Counter ist bei :" + counter);
                try
                {
                    if (txt_eingabe.Text == zahl.ToString())
                    {
                        String richtig = "Du hast richtig geraten! Du hast " + counter.ToString() + " Versuche gebraucht!";
                        Console.WriteLine("Zahl erfolgreich gefunden!");
                        MessageBox.Show(richtig);
                        geraten = true;
                    }
                    else
                    {
                        double zahlen = Math.Round(Convert.ToDouble(txt_eingabe.Text));
                        Console.WriteLine(zahlen);
                        if(zahlen > 100)
                        {
                            String falsch = "Bitte gib eine gülltige Zahl zwischen 0 und 100 ein";
                            MessageBox.Show(falsch);
                        } 
                        else if (zahlen > zahl)
                        {
                            String falsch = "Die Zahl ist kleiner";
                            MessageBox.Show(falsch);
                        }
                        else if(zahlen < zahl && zahlen < 100)
                        {
                            String falsch = "Die Zahl ist größer!";
                            MessageBox.Show(falsch);
                        } 
                        else
                        {
                            String falsch = "Bitte gib eine gülltige Zahl zwischen 0 und 100 ein";
                            MessageBox.Show(falsch);
                        }

                    }
                }
                catch (Exception)
                {
                    String fehler = "Du musst eine Zahl eingeben!";
                    MessageBox.Show(fehler);
                }
            } else
            {
                String richtig = "Du hast die Zahl bereits erraten, starte ein neues Spiel um neu zu Raten!";
                MessageBox.Show(richtig);
            }
        }

        private void newgame()
        {
            counter = 0;
            geraten = false;
            Random random = new Random();
            zahl = random.Next(0, 100);
            txt_eingabe.Text = null;
        }
    }
}
