/// <file>
/// Authors: Rotem Dresler . ID: 209207398. 
///          Izhak keidar . ID: 066016155.
///          
/// Date:    07/09/2022.
/// </file>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform_Game
{
    internal class Location
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public Location()
        {
            Row = 0;
            Col = 0;
        }
        public Location(int aRow, int aCol)
        {
            Row = aRow;
            Col = aCol;
        }
        public Location(Location a)
        {
            this.Col = a.Col;
            this.Row = a.Row;
        }
    }
}
