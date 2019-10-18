using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        private Ember ember;
        private List<Ember> emberek = new List<Ember>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nev = textBoxNev.Text;
                string szuldatum = textBoxSzulDatum.Text;
                Nem nem;
                if (radioButtonFerfi.Checked)
                {
                    nem = Nem.Ferfi;
                }
                else
                {
                    nem = Nem.No;
                }
                List<string> hobbik = new List<string>();
                foreach (string item in listBoxKedvencHobbi.Items)
                {
                    hobbik.Add(item);
                }
                listBoxKedvencHobbi.Items.Clear();
                listBoxKedvencHobbi.Text = "";
                ember = new Ember(nev, szuldatum, nem, hobbik);
                emberek.Add(ember);
                StreamWriter write = new StreamWriter(saveFileDialog1.FileName);
                for (int i = 0; i < emberek.Count; i++)
                {
                    write.WriteLine(emberek[i].ToString());
                }
                write.Close();
            }
        }

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBoxFile.Items.Clear();
                listBoxFile.Text = "";
                StreamReader read = new StreamReader(openFileDialog1.FileName);
                while (!read.EndOfStream)
                {   
                    string sor = read.ReadLine();
                    string[] adatok = sor.Split(';');
                    string nev = adatok[0];
                    string szuldatum = adatok[1];
                    Nem nem;
                    if (adatok[2] == "Ferfi")
                    {
                        nem = Nem.Ferfi;
                    }
                    else
                    {
                        nem = Nem.No;
                    }
                    List<string> hobbik = new List<string>();
                    for (int i = 3; i < adatok.Length; i++)
                    {
                        hobbik.Add(adatok[i]);
                    }

                    ember = new Ember(nev, szuldatum, nem, hobbik);
                    emberek.Add(ember);
                }
                for (int i = 0; i < emberek.Count; i++)
                {
                    listBoxFile.Items.Add(emberek[i].ToString());
                }
                read.Close();
            }
        }

        private void buttonUjHobbi_Click(object sender, EventArgs e)
        {
            listBoxKedvencHobbi.Items.Add(textBoxHobbi.Text);
            textBoxHobbi.Text = "";
        }
    }
}
