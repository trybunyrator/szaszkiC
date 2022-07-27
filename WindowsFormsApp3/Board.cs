using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Board : Form1
    {
       
        //rozmiar szachownicy - u nas będzie 8x8
        public int Size1 { get; set; }
        // tablica 2d typu Cell
        public Cell[,] theGrid { get; set; }

        //konstruktor
        public Board(int s)
        {
            //rozmiar tablicy
            Size1 = s;

            //stworzenie tablicy 2d typu Cell
            theGrid = new Cell[Size1, Size1];

            for (int i = 0; i < Size1; i++)
            {
                for (int j = 0; j < Size1; j++)
                {
                    //wypełnanie stworzonej tablicy komórkami
                    theGrid[i, j] = new Cell(i, j);
                    theGrid[i, j].SavedPiece = false;
                }
            }
        }

        // legalne ruchy
        public void MarkNetxLegalMoves(Cell currentCell, string chessPiece)
        {
            List<string> heavyBlackPieces1 = new List<string>()
            {
                "t",
                "j",
                "n",
                "w",
                "l",
                "o",
                "k" // nie można bic białego króla - nie działa
            };

            List<string> heavyWhitePieces1 = new List<string>()
            {

                "r",
                "h",
                "b",
                "q",
                "k",
                "p",
                "l" // nie można bić czarnego króla - nie działa
            };

            //wyczysc poprzednie legalne ruchy
            for (int i = 0; i < Size1; i++)
            {
                for (int j = 0; j < Size1; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    theGrid[i, j].CurrentlyOccupied = false;
                }
            }

            //znajdz nowe legalne
            switch (chessPiece)
            {
                // czarny skoczek 
                case "j":
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColNumber + 1) == true)
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber + 2, currentCell.ColNumber + 1].Piece))
                            theGrid[currentCell.RowNumber + 2, currentCell.ColNumber + 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColNumber - 1) == true)
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber + 2, currentCell.ColNumber - 1].Piece))
                            theGrid[currentCell.RowNumber + 2, currentCell.ColNumber - 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColNumber + 1) == true)
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber - 2, currentCell.ColNumber + 1].Piece))
                            theGrid[currentCell.RowNumber - 2, currentCell.ColNumber + 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColNumber - 1) == true)
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber - 2, currentCell.ColNumber - 1].Piece))
                            theGrid[currentCell.RowNumber - 2, currentCell.ColNumber - 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColNumber + 2) == true)
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 2].Piece))
                            theGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 2].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColNumber - 2) == true)
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber + 1, currentCell.ColNumber - 2].Piece))
                            theGrid[currentCell.RowNumber + 1, currentCell.ColNumber - 2].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColNumber + 2) == true)
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 2].Piece))
                            theGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 2].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColNumber - 2) == true)
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber - 1, currentCell.ColNumber - 2].Piece))
                            theGrid[currentCell.RowNumber - 1, currentCell.ColNumber - 2].LegalNextMove = true;
                    break;

                // biały skoczek
                case "h":
                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColNumber + 1) == true)
                        if( !heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber + 2, currentCell.ColNumber + 1].Piece))
                            theGrid[currentCell.RowNumber + 2, currentCell.ColNumber + 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber + 2, currentCell.ColNumber - 1) == true)
                        if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber + 2, currentCell.ColNumber - 1].Piece))
                            theGrid[currentCell.RowNumber + 2, currentCell.ColNumber - 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColNumber + 1) == true)
                        if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber - 2, currentCell.ColNumber + 1].Piece))
                            theGrid[currentCell.RowNumber - 2, currentCell.ColNumber + 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColNumber - 1) == true)
                        if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber - 2, currentCell.ColNumber - 1].Piece))
                            theGrid[currentCell.RowNumber - 2, currentCell.ColNumber - 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColNumber + 2) == true)
                        if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 2].Piece))
                            theGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 2].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColNumber - 2) == true)
                        if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber + 1, currentCell.ColNumber - 2].Piece))
                            theGrid[currentCell.RowNumber + 1, currentCell.ColNumber - 2].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColNumber + 2) == true)
                        if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 2].Piece))
                            theGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 2].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColNumber - 2) == true)
                        if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber - 1, currentCell.ColNumber - 2].Piece))
                            theGrid[currentCell.RowNumber - 1, currentCell.ColNumber - 2].LegalNextMove = true;
                    break;



                // czarny król
                case "l":
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColNumber + 1)) // dół prawo
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 1].Piece))
                            theGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColNumber)) // dół
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber + 1, currentCell.ColNumber].Piece))
                            theGrid[currentCell.RowNumber + 1, currentCell.ColNumber].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColNumber - 1)) //dół lewo
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber + 1, currentCell.ColNumber - 1].Piece))
                            theGrid[currentCell.RowNumber + 1, currentCell.ColNumber - 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber, currentCell.ColNumber - 1)) //lewo
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber, currentCell.ColNumber - 1].Piece))
                            theGrid[currentCell.RowNumber, currentCell.ColNumber - 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColNumber - 1)) //góra lewo
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber - 1, currentCell.ColNumber - 1].Piece))
                            theGrid[currentCell.RowNumber - 1, currentCell.ColNumber - 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColNumber)) // góra
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber - 1, currentCell.ColNumber].Piece))
                            theGrid[currentCell.RowNumber - 1, currentCell.ColNumber].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColNumber + 1)) //góra prawo
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 1].Piece))
                            theGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber, currentCell.ColNumber + 1)) //prawo
                        if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber, currentCell.ColNumber + 1].Piece))
                            theGrid[currentCell.RowNumber, currentCell.ColNumber + 1].LegalNextMove = true;

                    break;
                
                // biały król
                case "k":
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColNumber + 1)) // dół prawo
                        if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 1].Piece))
                            theGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColNumber)) // dół
                        if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber + 1, currentCell.ColNumber].Piece))
                            theGrid[currentCell.RowNumber + 1, currentCell.ColNumber].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColNumber - 1)) //dół lewo
                        if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber + 1, currentCell.ColNumber - 1].Piece))
                            theGrid[currentCell.RowNumber + 1, currentCell.ColNumber - 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber, currentCell.ColNumber - 1)) //lewo
                        if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber, currentCell.ColNumber - 1].Piece))
                            theGrid[currentCell.RowNumber, currentCell.ColNumber - 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColNumber - 1)) //góra lewo
                        if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber - 1, currentCell.ColNumber - 1].Piece))
                            theGrid[currentCell.RowNumber - 1, currentCell.ColNumber - 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColNumber)) // góra
                        if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber - 1, currentCell.ColNumber].Piece))
                            theGrid[currentCell.RowNumber - 1, currentCell.ColNumber].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColNumber + 1)) //góra prawo
                        if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 1].Piece))
                            theGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 1].LegalNextMove = true;

                    if (isSafe(currentCell.RowNumber, currentCell.ColNumber + 1)) //prawo
                        if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber, currentCell.ColNumber + 1].Piece))
                             theGrid[currentCell.RowNumber, currentCell.ColNumber + 1].LegalNextMove = true;

                    break;

                // czarna wieża 
                case "t":
                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColNumber)) //pionowo w dół
                            if (theGrid[currentCell.RowNumber + i, currentCell.ColNumber].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber + i, currentCell.ColNumber].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber + i, currentCell.ColNumber].Piece))
                                        theGrid[currentCell.RowNumber + i, currentCell.ColNumber].LegalNextMove = true;
                                }
                                break;
                            }
                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColNumber)) //pionowo w góre
                            if (theGrid[currentCell.RowNumber - i, currentCell.ColNumber].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber - i, currentCell.ColNumber].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber - i, currentCell.ColNumber].Piece))
                                        theGrid[currentCell.RowNumber - i, currentCell.ColNumber].LegalNextMove = true;
                                }
                                break;
                            }
                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber, currentCell.ColNumber + i)) //poziomo w prawo
                            if (theGrid[currentCell.RowNumber, currentCell.ColNumber + i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber, currentCell.ColNumber + i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber, currentCell.ColNumber + i].Piece))
                                        theGrid[currentCell.RowNumber, currentCell.ColNumber + i].LegalNextMove = true;
                                }
                                break;
                            }
                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber, currentCell.ColNumber - i)) //poziomo w lewo
                            if (theGrid[currentCell.RowNumber, currentCell.ColNumber - i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber, currentCell.ColNumber - i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber, currentCell.ColNumber - i].Piece))
                                        theGrid[currentCell.RowNumber, currentCell.ColNumber - i].LegalNextMove = true;
                                }
                                break;
                            }

                        else
                            break;
                    }

                    break;

                // biała wieża
                case "r":
                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColNumber)) //pionowo w dół
                            if (theGrid[currentCell.RowNumber + i, currentCell.ColNumber].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber + i, currentCell.ColNumber].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber + i, currentCell.ColNumber].Piece))
                                        theGrid[currentCell.RowNumber + i, currentCell.ColNumber].LegalNextMove = true;
                                }
                                break;
                            }
                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColNumber)) //pionowo w góre
                            if (theGrid[currentCell.RowNumber - i, currentCell.ColNumber].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber - i, currentCell.ColNumber].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber - i, currentCell.ColNumber].Piece))
                                        theGrid[currentCell.RowNumber - i, currentCell.ColNumber].LegalNextMove = true;
                                }
                                break;
                            }
                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber, currentCell.ColNumber + i)) //poziomo w prawo
                            if (theGrid[currentCell.RowNumber, currentCell.ColNumber + i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber, currentCell.ColNumber + i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber, currentCell.ColNumber + i].Piece))
                                        theGrid[currentCell.RowNumber, currentCell.ColNumber + i].LegalNextMove = true;
                                }
                                break;
                            }
                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber, currentCell.ColNumber - i)) //poziomo w lewo
                            if (theGrid[currentCell.RowNumber, currentCell.ColNumber - i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber, currentCell.ColNumber - i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber, currentCell.ColNumber - i].Piece))
                                        theGrid[currentCell.RowNumber, currentCell.ColNumber - i].LegalNextMove = true;
                                }
                                break;
                            }
                                 
                        else
                            break;
                    }

                    break;

                // czarny goniec
                case "n":
                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColNumber + i)) //prawo dół
                            if (theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                                }
                                break;
                            }
                        else
                            break;


                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColNumber - i)) //lewo góra
                            if (theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                                }
                                break;
                            }

                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColNumber - i)) //lewo dół
                            if (theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                                }
                                break;
                            }

                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColNumber + i)) //prawo góra
                            if (theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                                }
                                break;
                            }

                        else
                            break;
                    }

                    break;


                // biały goniec 
                case "b":
                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColNumber + i) ) //prawo dół
                            if (theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].LegalNextMove = true;
                            else
                            {
                               if(czy_byla_figura==false)
                               {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                               }
                               break;
                            }
                        else
                            break;

                        
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColNumber - i) ) //lewo góra
                            if (theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].LegalNextMove = true;
                            else
                            {
                                if(czy_byla_figura == false)
                                {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                                }
                                break;
                            }
                                
                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColNumber - i) ) //lewo dół
                            if (theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].LegalNextMove = true;
                            else
                            {
                                if(czy_byla_figura == false)
                                {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                                }
                                break;
                            }
                               
                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColNumber + i) ) //prawo góra
                            if (theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                                }
                                break;
                            }
                                
                        else
                            break;
                    }

                    break;

                // czarny hetman
                case "w":
                    //hetman = wieza + goniec
                    // kod jest złożeniem ruchów wieży i gońca więc może występować nadmiarowość - do sprawdzenia

                    //część wieży:
                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColNumber)) //pionowo w dół
                            if (theGrid[currentCell.RowNumber + i, currentCell.ColNumber].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber + i, currentCell.ColNumber].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber + i, currentCell.ColNumber].Piece))
                                        theGrid[currentCell.RowNumber + i, currentCell.ColNumber].LegalNextMove = true;
                                }
                                break;
                            }
                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColNumber)) //pionowo w góre
                            if (theGrid[currentCell.RowNumber - i, currentCell.ColNumber].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber - i, currentCell.ColNumber].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber - i, currentCell.ColNumber].Piece))
                                        theGrid[currentCell.RowNumber - i, currentCell.ColNumber].LegalNextMove = true;
                                }
                                break;
                            }
                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber, currentCell.ColNumber + i)) //poziomo w prawo
                            if (theGrid[currentCell.RowNumber, currentCell.ColNumber + i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber, currentCell.ColNumber + i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber, currentCell.ColNumber + i].Piece))
                                        theGrid[currentCell.RowNumber, currentCell.ColNumber + i].LegalNextMove = true;
                                }
                                break;
                            }
                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber, currentCell.ColNumber - i)) //poziomo w lewo
                            if (theGrid[currentCell.RowNumber, currentCell.ColNumber - i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber, currentCell.ColNumber - i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber, currentCell.ColNumber - i].Piece))
                                        theGrid[currentCell.RowNumber, currentCell.ColNumber - i].LegalNextMove = true;
                                }
                                break;
                            }

                        else
                            break;
                    }

                    //część gońca
                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColNumber + i)) //prawo dół
                            if (theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                                }
                                break;
                            }
                        else
                            break;


                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColNumber - i)) //lewo góra
                            if (theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                                }
                                break;
                            }

                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColNumber - i)) //lewo dół
                            if (theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                                }
                                break;
                            }

                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColNumber + i)) //prawo góra
                            if (theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                                }
                                break;
                            }

                        else
                            break;
                    }

                    break;


                // biały hetman
                case "q":
                    //hetman = wieza + goniec
                    // kod jest złożeniem ruchów wieży i gońca więc może występować nadmiarowość - do sprawdzenia

                    //część wieży:
                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColNumber)) //pionowo w dół
                            if (theGrid[currentCell.RowNumber + i, currentCell.ColNumber].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber + i, currentCell.ColNumber].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber + i, currentCell.ColNumber].Piece))
                                        theGrid[currentCell.RowNumber + i, currentCell.ColNumber].LegalNextMove = true;
                                }
                                break;
                            }
                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColNumber)) //pionowo w góre
                            if (theGrid[currentCell.RowNumber - i, currentCell.ColNumber].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber - i, currentCell.ColNumber].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber - i, currentCell.ColNumber].Piece))
                                        theGrid[currentCell.RowNumber - i, currentCell.ColNumber].LegalNextMove = true;
                                }
                                break;
                            }
                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber, currentCell.ColNumber + i)) //poziomo w prawo
                            if (theGrid[currentCell.RowNumber, currentCell.ColNumber + i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber, currentCell.ColNumber + i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber, currentCell.ColNumber + i].Piece))
                                        theGrid[currentCell.RowNumber, currentCell.ColNumber + i].LegalNextMove = true;
                                }
                                break;
                            }
                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber, currentCell.ColNumber - i)) //poziomo w lewo
                            if (theGrid[currentCell.RowNumber, currentCell.ColNumber - i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber, currentCell.ColNumber - i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber, currentCell.ColNumber - i].Piece))
                                        theGrid[currentCell.RowNumber, currentCell.ColNumber - i].LegalNextMove = true;
                                }
                                break;
                            }

                        else
                            break;
                    }


                    //część gońca
                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColNumber + i)) //prawo dół
                            if (theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber + i, currentCell.ColNumber + i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                                }
                                break;
                            }
                        else
                            break;


                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColNumber - i)) //lewo góra
                            if (theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber - i, currentCell.ColNumber - i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                                }
                                break;
                            }

                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColNumber - i)) //lewo dół
                            if (theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber + i, currentCell.ColNumber - i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                                }
                                break;
                            }

                        else
                            break;
                    }

                    for (int i = 1; i < theGrid.Length; i++)
                    {
                        bool czy_byla_figura = false;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColNumber + i)) //prawo góra
                            if (theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].SavedPiece == false && czy_byla_figura == false)
                                theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].LegalNextMove = true;
                            else
                            {
                                if (czy_byla_figura == false)
                                {
                                    if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].Piece))
                                    {
                                        theGrid[currentCell.RowNumber - i, currentCell.ColNumber + i].LegalNextMove = true;
                                        czy_byla_figura = true;
                                    }
                                }
                                break;
                            }

                        else
                            break;
                    }

                    break;

                case "Pionek biały":
                case "p":
                    if (isSafe(currentCell.RowNumber, currentCell.ColNumber - 1)) // góra
                        if (theGrid[currentCell.RowNumber, currentCell.ColNumber - 1].SavedPiece == false)
                        {
                            if(currentCell.ColNumber == 6)
                                if (theGrid[currentCell.RowNumber, currentCell.ColNumber - 2].SavedPiece == false)
                                    theGrid[currentCell.RowNumber, currentCell.ColNumber - 2].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColNumber - 1].LegalNextMove = true;
                        }
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColNumber - 1)) // bicie pionków 
                    {
                        if(theGrid[currentCell.RowNumber - 1, currentCell.ColNumber - 1].SavedPiece == true) // jeżeli po skosie coś stoi to możesz bić 
                            if(!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber - 1, currentCell.ColNumber - 1].Piece))
                                theGrid[currentCell.RowNumber - 1, currentCell.ColNumber - 1].LegalNextMove = true;
                    }

                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColNumber - 1) ) // bicie pionków 
                    {
                        if(theGrid[currentCell.RowNumber + 1, currentCell.ColNumber - 1].SavedPiece == true)
                            if (!heavyWhitePieces1.Contains(theGrid[currentCell.RowNumber + 1, currentCell.ColNumber - 1].Piece))
                                theGrid[currentCell.RowNumber + 1, currentCell.ColNumber - 1].LegalNextMove = true;
                    }
                    break;

                case "Pionek czarny":
                case "o":
                    if (isSafe(currentCell.RowNumber, currentCell.ColNumber + 1)) // góra
                        if (theGrid[currentCell.RowNumber, currentCell.ColNumber + 1].SavedPiece == false)
                        {
                            if (currentCell.ColNumber == 1)
                                if (theGrid[currentCell.RowNumber, currentCell.ColNumber + 2].SavedPiece == false)

                                    theGrid[currentCell.RowNumber, currentCell.ColNumber + 2].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColNumber + 1].LegalNextMove = true;
                        }

                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColNumber + 1)) // bicie pionków 
                    {
                        if (theGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 1].SavedPiece == true) // jeżeli po skosie coś stoi to możesz bić 
                            if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 1].Piece))
                                theGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 1].LegalNextMove = true;
                    }

                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColNumber + 1)) // bicie pionków 
                    {
                        if (theGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 1].SavedPiece == true)
                            if (!heavyBlackPieces1.Contains(theGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 1].Piece))
                                theGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 1].LegalNextMove = true;
                    }
                    break;

                default:
                    break;

            }
            theGrid[currentCell.RowNumber, currentCell.ColNumber].CurrentlyOccupied = true;
        }

        private bool isSafe(int x, int y)
        {
            if (x < 0 || x >= Size1 || y < 0 || y >= Size1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

}

// czarne figury nie działają - już działają <3 

// do zrobienia bicie pioneczków 
// nie można zbić wrogiego króla