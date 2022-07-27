using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class nicki : Form
    {
        public bool nameCheck = false;
        DaneEntities bazadanych = new DaneEntities();

        public nicki()
        {
            InitializeComponent();
        }

        private void nicki_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void checkPlayers_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(playerBlack.Text) || String.IsNullOrEmpty(playerWhite.Text))
            {
                MessageBox.Show("Nie można zostawić pustej nazwy gracza. Spróbuj ponownie");
            }
            else
            {
                // zmienne do zapytania
                string nickWhite = playerWhite.Text;
                string nickBlack = playerBlack.Text;
                //MessageBox.Show(nickWhite + " " + nickBlack); // testowe - do usuniecia
                MessageBox.Show("Poprawnie wprowadzono nazwy. Pora przjeść do gry");
                Form1 ChildForm = new Form1();

                // tu wyslij zapytanie insert into ze powyższymi zmiennymi


                    // tworzenie nowego rekordu
                    int noweId = bazadanych.Partia.Max(p => p.Id) + 1;
                    Partia nowaPartia = new Partia()
                    {
                        Id = noweId,
                        graczW = nickWhite,
                        graczB = nickBlack,
                        data = DateTime.Now

                    };
                    // dodanie rekordu do bazy i zapisanie zmian
                    bazadanych.Partia.Add(nowaPartia);
                    bazadanych.SaveChanges();
                    // prezentacja zmodyfikowanych danych
                    string s = "Lista osób:\n";
                    foreach (Partia p in bazadanych.Partia)
                        s += p.Id + " " + p.graczW + " " + p.graczB + " " + p.data + "\n";
                    MessageBox.Show(s);

                


                ChildForm.Show();
                this.Hide();
            }
        }

        private void playerWhite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


// uruchamiamy to --> jeżeli wprowadzono nicki to pokaż form1.cs i ukryj nicki.cs --> po zamknięciu form1.cs wywoływane jest (plik form1.cs):
// private void Form1_FormClosing(object sender, FormClosingEventArgs e)
// {
//     Application.Exit();
// }
//