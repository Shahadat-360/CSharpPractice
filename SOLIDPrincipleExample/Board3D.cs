using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleExample
{
    public class Board3D
    {
        public int[,,] grid3D;
        public void SetItem(int x, int y, int z,int value)
        {
            grid3D[x,y,z] = value;
        }
        public void RemoveItem(int x, int y, int z)
        {
            grid3D[x, y, z] = 0;
        }
    }
}
