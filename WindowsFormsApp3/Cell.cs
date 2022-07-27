using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Cell
    {
        public int RowNumber { get; set; }
        public int ColNumber { get; set; }

        //obecne pole
        public bool CurrentlyOccupied { get; set; }
        
        //zapisane pole
        public bool SavedPiece { get; set; }

        //legalne posunięcia
        public bool LegalNextMove { get; set; }

        public string Piece { get; set; }

        //public Cell()
        //{

        //}

        public Cell(int x, int y)
        {
            RowNumber = x;
            ColNumber = y;
        }

        
    }
}
