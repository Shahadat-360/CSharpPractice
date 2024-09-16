using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleExample
{
    public class Board
    {
        public int[,] grid;
        public void SetItem(int x, int y,int value)
        {
            grid[x,y] = value;  
        }
        public void RemoveItem(int x, int y)
        {
            grid[x, y] = 0;
        }
    }
}
