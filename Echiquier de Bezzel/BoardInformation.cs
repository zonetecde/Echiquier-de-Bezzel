using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echiquier_de_Bezzel
{
    public class BoardInformation
    {
        public BoardInformation(int nbQueen, List<string> positionQueen)
        {
            this.NbQueen = nbQueen;
            this.PositionQueen = positionQueen;
        }

        public int NbQueen { get; set; }
        public List<string> PositionQueen { get; set; }     
    }
}
