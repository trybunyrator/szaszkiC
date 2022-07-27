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
    public partial class Form1 : Form
    {
        
        int licznik = 0;
        static Board myBoard = new Board(8);

        public Button[,] btnGrid = new Button[8, 8];

        //zmienna przechowująca aktualną figure
        //deafultowa wartość to skoczek
        string currentPiece;
        string sign;

        bool move = false; // false - poprzednia nie zapisana, true - poprzednia zapisana figura moze się przemieścić 
        bool WhiteOnMove = true; //true = białe mogą sie ruszyc, false czarne mogą się ruszyć 
        int old_x = 0, old_y = 0;
        string old_sign;
        //bool PreviousPieceTrue = false;

        double timeLeftWhite;
        double timeLeftBlack;
        bool WhiteMove = true;

        List<string> heavyBlackPieces = new List<string>()
        {
            "t",
            "j",
            "n",
            "w",
            "l",
            "n",
            "j",
            "t",
            "o"
        };

        List<string> heavyWhitePieces = new List<string>()
        {

            "r",
            "h",
            "b",
            "q",
            "k",
            "b",
            "h",
            "r",
            "p"
        };

        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }

        private void populateGrid()
        {
            int buttonSize = panel1.Width / 8;

            //upewnienie się że mamy kwadrat
            panel1.Height = panel1.Width;

            //tworzenie
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //tworzenie konkretnego przycisku
                    btnGrid[i, j] = new Button();

                    //nadawanie mu odpowiedniego rozmiaru
                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;
                    btnGrid[i, j].Enabled = false;

                    //ustawienie czcionki dla pól
                    btnGrid[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    btnGrid[i, j].Font = new Font("Chess", 24, FontStyle.Bold);

                    //dodawanie eventu na click
                    //btnGrid[i, j].MouseEnter += Grid_Button_Click;
                    btnGrid[i, j].Click
                        += Grid_Button_Click;
                    //btnGrid[i, j].Click += MovePiece;


                    //kolorawanie pól
                    if ((i + j) % 2 != 0) //nieparzyste = DarkGray
                        btnGrid[i, j].BackColor = Color.DarkGray;

                    //dodawanie przycisku do panelu
                    panel1.Controls.Add(btnGrid[i, j]);

                    //ustawienie przycisku w dobrym miejscu
                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);

                    //nadawanie tekstu do lepszej orientacji
                    //btnGrid[i, j].Text = i + " " + j;
                    btnGrid[i, j].Tag = new Point(i, j);
                }
            }
        }




        private void Grid_Button_Click(object sender, EventArgs e)
        {

            //pobieranie x i y
            Button clickedButton = (Button)sender;
            Point location = (Point)clickedButton.Tag;

            int x = location.X;
            int y = location.Y;

            currentPiece = btnGrid[x, y].Text; //pobierz do sign figure z przycisku na który kliknąłeś
            sign = currentPiece;


            Cell currentCell = myBoard.theGrid[x, y];
            myBoard.theGrid[currentCell.RowNumber, currentCell.ColNumber].SavedPiece = true;

            if (WhiteOnMove) //jeżeli białe na ruchu to
            {
                if (move == false)
                {
                    for (int z = 0; z < heavyWhitePieces.Count; z++) //przeszukaj liste heaveWhitePieces z dodanym pioneczkiem
                    {
                        if (sign == heavyWhitePieces[z]) //jezeli figura na którą 
                        {
                            // jeżeli naciśniety guzik ma SavedPiece == true to ustaw move = true
                            if (myBoard.theGrid[x, y].SavedPiece)
                            {
                                currentPiece = btnGrid[x, y].Text;
                                sign = currentPiece;
                                move = true;
                                old_sign = sign;
                                old_x = x;
                                old_y = y;
                            }
                            else
                            {
                                move = false;
                            }
                            break;
                        }
                    }
                }
                else
                {
                    MovePiece(move, currentCell);
                    move = false;
                }

                //czyszczenie planszy
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (String.IsNullOrEmpty(myBoard.theGrid[i, j].Piece))
                        {
                            myBoard.theGrid[i, j].CurrentlyOccupied = false;
                            myBoard.theGrid[i, j].SavedPiece = false;
                            btnGrid[i, j].Enabled = false;
                        }
                        //if (myBoard.theGrid[i, j].LegalNextMove == true)
                        //{
                        //    btnGrid[i, j].Enabled = true;
                        //}

                        myBoard.theGrid[i, j].LegalNextMove = false;
                    }
                }

                //ustaw legalne ruchy
                if (WhiteMove == true) // MEGA WAŻNE 
                    myBoard.MarkNetxLegalMoves(currentCell, currentPiece);

                //upadte textu na przyciskach
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if ((i + j) % 2 != 0) //nieparzyste = DarkGray
                            btnGrid[i, j].BackColor = Color.DarkGray;
                        else //parzyste = DarkGray
                            btnGrid[i, j].BackColor = Color.LightGray;

                        if (myBoard.theGrid[i, j].SavedPiece == false)
                            btnGrid[i, j].Text = String.Empty;

                        //else if(myBoard.theGrid[i, j].Curren tlyOccupied == false)
                        //    btnGrid[i, j].Text = "";
                        if (myBoard.theGrid[i, j].LegalNextMove == true) //zaznaczanie dostępnych ruchów
                        {
                            if (WhiteOnMove == true)
                            {
                                btnGrid[i, j].Enabled = true;
                                btnGrid[i, j].BackColor = Color.Gray;
                            }
                        }
                        //else if (myBoard.theGrid[i, j].CurrentlyOccupied == true)  //zaznaczanie pozycji figury
                        //{
                        //    btnGrid[i, j].ForeColor = Color.White;
                        //    //btnGrid[i, j].Text = sign;
                        //    //btnGrid[i, j].BackColor = Color.Gray;
                        //}
                        if (myBoard.theGrid[i, j].SavedPiece == true)  // zaznaczania zapisanych figur
                        {
                            if (heavyWhitePieces.Contains(btnGrid[i, j].Text))
                            {
                                btnGrid[i, j].ForeColor = Color.White;
                                //btnGrid[i, j].BackColor = Color.Red;
                                //btnGrid[i, j].Text = sign;
                            }

                        }
                    }
                }

            }

            else //analogicznie dla czarnych
            {
                if (move == false)
                {
                    for (int z = 0; z < heavyBlackPieces.Count; z++)
                    {
                        if (sign == heavyBlackPieces[z])
                        {

                            //jeżeli coś stoi na polu to pobierz znak a nie zastępuj podstawowym skoczkiem
                            if (myBoard.theGrid[x, y].SavedPiece)
                            {
                                currentPiece = btnGrid[x, y].Text;
                                sign = currentPiece;
                                move = true;
                                old_sign = sign;
                                old_x = x;
                                old_y = y;
                                //MessageBox.Show(old_sign + "ez");
                            }
                            else
                            {
                                move = false;
                            }

                            break;
                        }
                    }
                }
                else
                {
                    MovePiece(move, currentCell);
                    move = false;
                }

                //czyszczenie planszy
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (String.IsNullOrEmpty(myBoard.theGrid[i, j].Piece))
                        {
                            myBoard.theGrid[i, j].CurrentlyOccupied = false;
                            myBoard.theGrid[i, j].SavedPiece = false;
                            btnGrid[i, j].Enabled = false;
                        }
                    }
                }

                //ustaw legalne ruchy
                if (WhiteMove == false) // MEGA WAŻNE ROZKMINIŁEM TO
                    myBoard.MarkNetxLegalMoves(currentCell, currentPiece);

                //upadte textu na przyciskach

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if ((i + j) % 2 != 0) //nieparzyste = DarkGray
                            btnGrid[i, j].BackColor = Color.DarkGray;
                        else //parzyste = DarkGray
                            btnGrid[i, j].BackColor = Color.LightGray;

                        if (myBoard.theGrid[i, j].SavedPiece == false)
                            btnGrid[i, j].Text = String.Empty;
                        //else if(myBoard.theGrid[i, j].Curren tlyOccupied == false)
                        //    btnGrid[i, j].Text = "";
                        if (myBoard.theGrid[i, j].LegalNextMove == true) //zaznaczanie dostępnych ruchów
                        {
                            if (WhiteOnMove == false)
                            {
                                btnGrid[i, j].Enabled = true;
                                btnGrid[i, j].BackColor = Color.Gray;
                            }
                        }
                        //else if (myBoard.theGrid[i, j].CurrentlyOccupied == true)  //zaznaczanie pozycji figury
                        //{
                        //    btnGrid[i, j].ForeColor = Color.Black;
                        //    //btnGrid[i, j].BackColor = Color.Gray;
                        //}
                        if (myBoard.theGrid[i, j].SavedPiece == true)  // zaznaczania zapisanych figur
                        {
                            if (heavyBlackPieces.Contains(btnGrid[i, j].Text))
                            {
                                btnGrid[i, j].ForeColor = Color.Black;
                                //btnGrid[i, j].BackColor = Color.Blue;
                                //btnGrid[i, j].Text = sign;
                            }
                        }
                    }
                }

            }


        }
        // rusz figurą   
        void MovePiece(bool move, Cell currentCell)
        {
            if (myBoard.theGrid[currentCell.RowNumber, currentCell.ColNumber].LegalNextMove == true)
            {
                //przesuń i ustaw właściwości
                myBoard.theGrid[currentCell.RowNumber, currentCell.ColNumber].CurrentlyOccupied = true;
                myBoard.theGrid[currentCell.RowNumber, currentCell.ColNumber].SavedPiece = true;
                myBoard.theGrid[old_x, old_y].LegalNextMove = false;

                if (myBoard.theGrid[old_x, old_y].Piece.Equals("p") && currentCell.ColNumber == 0)
                {
                    btnGrid[currentCell.RowNumber, currentCell.ColNumber].Text = "q";
                    myBoard.theGrid[currentCell.RowNumber, currentCell.ColNumber].Piece = "q";
                    MessageBox.Show("Promocja pionka");
                }
                else if (myBoard.theGrid[old_x, old_y].Piece.Equals("o") && currentCell.ColNumber == 7)
                {
                    btnGrid[currentCell.RowNumber, currentCell.ColNumber].Text = "w";
                    myBoard.theGrid[currentCell.RowNumber, currentCell.ColNumber].Piece = "w";
                    MessageBox.Show("Promocja pionka");
                }
                else
                {
                    btnGrid[currentCell.RowNumber, currentCell.ColNumber].Text = old_sign;
                    myBoard.theGrid[currentCell.RowNumber, currentCell.ColNumber].Piece = old_sign;
                }

                
                if (WhiteOnMove)
                {
                    LastMoveWhiteAft.Text = Letter(currentCell.RowNumber.ToString()) + (8 - currentCell.ColNumber).ToString();//miejsce skąd ruszyła się figura
                    LastMoveWhitePrev.Text = Letter(old_x.ToString()) + (8 - old_y).ToString();//miejsce dokąd ruszyła się figura
                    if (hittedBlackFigures.Text.Length < 8)
                    {
                        hittedBlackFigures.Text += sign;
                    }
                    else
                    {
                        hittedBlackFigures2.Text += sign;
                    }
                    WhiteGoTo.Text = "=>";

                    using (DaneEntities bazadanych = new DaneEntities())
                    {
                        //string s = "Lista ruchów:\n";
                        //s += "Id_partii\t nrRuchu \t Skąd \t Dokąd\n";
                        //foreach (Ruchy r in bazadanych.Ruchy)
                        //    s += "\n " + r.Id_partii + "\t " + r.nr_ruchu + "\t\t " + r.skad + "\t " + r.dokad;
                        //MessageBox.Show(s);
                        // tworzenie nowego rekordu
                        int noweId = bazadanych.Ruchy.Max(r => r.Id) + 1;
                        int idPartii = bazadanych.Partia.Max(Partia => Partia.Id);
                        int noweIdRuchu = licznik++;
                        Ruchy nowaRekord = new Ruchy()
                        {
                            Id = noweId,
                            Id_partii = idPartii,
                            nr_ruchu = noweIdRuchu,
                            skad = LastMoveWhitePrev.Text,
                            dokad = LastMoveWhiteAft.Text
                        };
                        // dodanie rekordu do bazy i zapisanie zmian
                        bazadanych.Ruchy.Add(nowaRekord);
                        bazadanych.SaveChanges();
                        // prezentacja zmodyfikowanych danych
                        string s = "Lista ruchów:\n";
                        s += "Id_partii\t nrRuchu \t Skąd \t Dokąd\n";

                        var obecnaPartia = from r in bazadanych.Ruchy
                                           where r.Id_partii == idPartii
                                           select r;
                        foreach (Ruchy r in obecnaPartia)
                            s += "\n " + r.Id_partii + "\t " + r.nr_ruchu + "\t\t " + r.skad + "\t " + r.dokad;
                        timerWhite.Stop();
                        MessageBox.Show(s);
                        timerWhite.Start();

                    }
                }
                
                if (!WhiteOnMove)
                {
                    LastMoveBlackAft.Text = Letter(currentCell.RowNumber.ToString()) + (8 - currentCell.ColNumber).ToString();//miejsce skąd ruszyła się figura
                    LastMoveBlackPrev.Text = Letter(old_x.ToString()) + (8 - old_y).ToString();//miejsce dokąd ruszyła się figura
                    if (hittedWhiteFigures.Text.Length < 8)
                    {
                        hittedWhiteFigures.Text += sign;
                    } 
                    else
                    {
                        hittedWhiteFigures2.Text += sign;
                    }
                    BlackGoto.Text = "=>";

                    using (DaneEntities bazadanych = new DaneEntities())
                    {
                        //string s = "Lista ruchów:\n";
                        //s += "Id_partii\t nrRuchu \t Skąd \t Dokąd\n";
                        //foreach (Ruchy r in bazadanych.Ruchy)
                        //    s += "\n " + r.Id_partii + "\t " + r.nr_ruchu + "\t\t " + r.skad + "\t " + r.dokad;
                        //MessageBox.Show(s);

                        // tworzenie nowego rekordu
                        int noweId = bazadanych.Ruchy.Max(r => r.Id) + 1;
                        int idPartii = bazadanych.Partia.Max(Partia => Partia.Id);
                        int noweIdRuchu = licznik++;
                        Ruchy nowaRekord = new Ruchy()
                        {
                            Id = noweId,
                            Id_partii = idPartii,
                            nr_ruchu = noweIdRuchu,
                            skad = LastMoveBlackPrev.Text,
                            dokad = LastMoveBlackAft.Text
                        };
                        // dodanie rekordu do bazy i zapisanie zmian
                        bazadanych.Ruchy.Add(nowaRekord);
                        bazadanych.SaveChanges();

                        // prezentacja zmodyfikowanych danych
                        string s = "Lista ruchów:\n";
                        s += "Id_partii\t nrRuchu \t Skąd \t Dokąd\n";
                        var obecnaPartia = from r in bazadanych.Ruchy
                                           where r.Id_partii == idPartii
                                           select r;
                        foreach (Ruchy r in obecnaPartia)
                            s += "\n " + r.Id_partii + "\t " + r.nr_ruchu + "\t\t " + r.skad + "\t " + r.dokad;
                        timerBlack.Stop();
                        MessageBox.Show(s);
                        timerBlack.Start();

                    }
                }


                //usuń poprzednią figure
               
                test.Text += sign;
                btnGrid[old_x, old_y].Text = String.Empty;
                myBoard.theGrid[old_x, old_y].Piece = String.Empty;
                myBoard.theGrid[old_x, old_y].CurrentlyOccupied = false;
                myBoard.theGrid[old_x, old_y].SavedPiece = false;
                myBoard.theGrid[old_x, old_y].LegalNextMove = false;

                //ustaw move na false 
                move = false;
                ChangePlayer();


            }

        }

        private string Letter(string v)
        {
            switch (v)
            {
                case "0":
                    return "A";

                case "1":
                    return "B";

                case "2":
                    return "C";

                case "3":
                    return "D";

                case "4":
                    return "E";

                case "5":
                    return "F";

                case "6":
                    return "G";

                case "7":
                    return "H";

                default:
                    return "X";
            }
        }


        void ChangePlayer()
        {
            if (WhiteOnMove) // zmień ruch białych -> czarnych
            {
                ChangeTime1();
                WhiteOnMove = !WhiteOnMove;
                WhoOnMove.Text = "Ruch czarnych";
            }
            else //czarnych -> białych
            {
                ChangeTime1();
                WhiteOnMove = !WhiteOnMove;
                WhoOnMove.Text = "Ruch białych";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (currentPiece)
            {
                case "Skoczek":
                case "j":
                case "h":
                    sign = "j";
                    break;

                case "Król":
                case "l":
                case "k":
                    sign = "l";
                    break;

                case "Wieża":
                case "t":
                case "r":
                    sign = "t";
                    break;

                case "Goniec":
                case "n":
                    sign = "n";
                    break;

                case "Hetman":
                case "w":
                    sign = "w";
                    break;

                case "Pionek biały":
                case "p":
                    sign = "p";
                    break;

                case "Pionek czarny":
                case "o":
                    sign = "o";
                    break;

                default:
                    sign = "j";
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (myBoard.theGrid[i, j].CurrentlyOccupied == true)
                        myBoard.theGrid[i, j].SavedPiece = true;
                }
            }

        }

        private void startingPosition(object sender, EventArgs e)
        {
            WhoOnMove.Text = "Ruch białych";
            //button2.Enabled = false; - alt; mozna zastosować równolegle do visible
            button2.Visible = false;

            //wyłaczenie zmieniania czasu inkrementacji po naciśnięciu przycisku
            numericUpDown1.Enabled = false;


            //czyszczenie planszy
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    btnGrid[i, j].Enabled = true;
                    btnGrid[i, j].Text = String.Empty;
                    myBoard.theGrid[i, j].Piece = String.Empty;
                    myBoard.theGrid[i, j].CurrentlyOccupied = false;
                    myBoard.theGrid[i, j].SavedPiece = false;
                    myBoard.theGrid[i, j].LegalNextMove = false;
                }
            }

            //działanie czasem
            timeLeftWhite = 50;
            labelTimeWhite.Text = timeLeftWhite.ToString();
            timerWhite.Start();



            timeLeftBlack = 50;
            labelTimeBlack.Text = timeLeftBlack.ToString();

            //ustawienie CZARNYCH PIONECZKÓW
            for (int i = 0; i < 8; i++)
            {
                if (!heavyBlackPieces.Contains(btnGrid[i, 1].Text))
                {
                    btnGrid[i, 1].ForeColor = Color.Black;
                    //btnGrid[i, 1].BackColor = Color.Gray;
                    //btnGrid[i, j].Text = sign;
                }
                myBoard.theGrid[i, 1].CurrentlyOccupied = true;
                myBoard.theGrid[i, 1].SavedPiece = true;
                myBoard.theGrid[i, 1].Piece = "o";
                btnGrid[i, 1].Text = "o";
            }

            //ustawienie CIEŻKICH CZARNYCH FIGUR
            for (int i = 0; i < 8; i++)
            {
                if (!heavyBlackPieces.Contains(btnGrid[i, 0].Text))
                {
                    btnGrid[i, 0].ForeColor = Color.Black;
                    //btnGrid[i, 0].BackColor = Color.Gray;
                    //btnGrid[i, j].Text = sign;
                }
                myBoard.theGrid[i, 0].CurrentlyOccupied = true;
                myBoard.theGrid[i, 0].SavedPiece = true;
                myBoard.theGrid[i, 0].Piece = heavyBlackPieces[i];
                btnGrid[i, 0].Text = heavyBlackPieces[i];
            }

            //----------------------------------------------
            //ustawianie BIAŁYCH FIGUR


            //ustawienie BIAŁYCH PIONECZKÓW
            for (int i = 0; i < 8; i++)
            {
                if (!heavyWhitePieces.Contains(btnGrid[i, 6].Text))
                {
                    btnGrid[i, 6].ForeColor = Color.White;
                    //btnGrid[i, 6].BackColor = Color.Gray;
                    //btnGrid[i, j].Text = sign;
                }
                myBoard.theGrid[i, 6].SavedPiece = true;
                myBoard.theGrid[i, 6].CurrentlyOccupied = true;
                myBoard.theGrid[i, 6].Piece = "p";
                btnGrid[i, 6].Text = "p";
            }

            //ustawianie CIĘŻKICH BIAŁYCH FIGUR
            for (int i = 0; i < 8; i++)
            {
                if (!heavyWhitePieces.Contains(btnGrid[i, 7].Text))
                {

                    btnGrid[i, 7].ForeColor = Color.White;
                    //btnGrid[i, 7].BackColor = Color.Gray;
                    //btnGrid[i, j].Text = sign;
                }
                myBoard.theGrid[i, 7].CurrentlyOccupied = true;
                myBoard.theGrid[i, 7].SavedPiece = true;
                myBoard.theGrid[i, 7].Piece = heavyWhitePieces[i];
                btnGrid[i, 7].Text = heavyWhitePieces[i];

            }

            //btnGrid[2, 3].ForeColor = Color.Red;
            //btnGrid[2, 3].BackColor = Color.Pink;

        }

        //obsługa białego zegara
        private void timerWhite_Tick(object sender, EventArgs e)
        {
            //gdy jest czas
            if (timeLeftWhite > 0)
            {
                timeLeftWhite = timeLeftWhite - 0.1;
                labelTimeWhite.Text = timeLeftWhite.ToString();
            }
            //gdy czas się skończył
            else
            {
                timerWhite.Stop();
                //wyłacz przyciski jeżeli czas spadł ponizej 0
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        btnGrid[i, j].Enabled = false;
                    }
                }
                labelTimeWhite.Text = "KONIEC!";
                MessageBox.Show("Upłynął czas białych, wygrywa czarny", "Koniec gry");
            }
        }

        //obsługa czarnego zegara
        private void timerBlack_Tick(object sender, EventArgs e)
        {
            //gdy jest czas
            if (timeLeftBlack > 0)
            {
                timeLeftBlack = timeLeftBlack - 0.1;
                labelTimeBlack.Text = timeLeftBlack.ToString();
            }
            //gdy czas się skończył
            else
            {
                timerBlack.Stop();
                //wyłacz przyciski jeżeli czas spadł ponizej 0
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < myBoard.Size1; j++)
                    {
                        btnGrid[i, j].Enabled = false;
                    }
                }
                labelTimeBlack.Text = "KONIEC!";
                MessageBox.Show("Upłynął czas czarnych, wygrywa biały", "Koniec gry");
            
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChangeTime1()
        {
            if (WhiteMove)
            {
                timeLeftWhite += Convert.ToDouble(numericUpDown1.Value); //timeLeftWhite - double, numeric.Value - int = trzeba Convert strzelić
                labelTimeWhite.Text = timeLeftWhite.ToString();
                timerWhite.Stop();
                timerBlack.Start();
                WhiteMove = !WhiteMove;
            }
            else
            {

                timeLeftBlack += Convert.ToDouble(numericUpDown1.Value);
                timerBlack.Stop();
                timerWhite.Start();
                WhiteMove = !WhiteMove;
            }
        }
    }
}


//Pytania:
//  1. Czy da się dwa eventy podpiąc do jednego zdarzenia na przycisku, np akutalnie mamy podpięte Grid_Button_Click i czy możemy podpiąc drugą funckje 
//  czy trzeba zrobic funkcje w funkcji?
//          Częściowo rozwiązane
//
//  2. Przesuwanie sie timera z jakiegoś powodu
//
//
//
//Plusy akutalnych rozwiązań:
//  1. Łatwa możliwość dodania inkrementacji zegara
//

//
// Pracowanie nad implementacją mechaniki bicia figur:
//  Przy figurach które mają sprawdzane ruchy za pomocą pętli break o jedną iteracje później
//  1. Legalne ruchy pokazywane jako inny kolor backgroundColor danego buttona
//  2. Jeżeli na legalnym ruchu stała figura -> przestaw aktualną figure = następuje bicie
//  3. Jeżeli nie skorzystano z legalnego ruchu na którym stoi inna figura to ustaw kolor pierwotny pola
//  najprościej, ale mało efektywnie puść pętle która jest odpowiedzialna na nadawanie kolorów
//  
//
//
//
// UPDATY SKOŃCZOENE:
//
// 1. INKREMENTACJA CZASU

// POSTEPY
// - ZROBIENIE PROMOCJI PIONKA (OBWIĄZKOWO NA HETMANA BO TO NAJLEPSZA I NAJSILNIEJSZA OPCJA DO WYBRANIA DLA ZAWODNIKA)
// - NIE MOŻNA ZBIĆ PIONKA
// - ZAIMPLEMENTOWANO BICIE FIGUR CIĘŻKICH
// - ZAIMPLEMENTOWANO BICIE PIONECZKAMI 
//
// CZEGO BRAKUJE 
// - ROSZADA
// - SZACHOWANIE I MATOWANIE
//
//