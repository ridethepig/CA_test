using System;
using System.Collections.Generic;
namespace CA_test
{
    class CA
    {
        public graphControl gphCtrl;
        //public List<Tuple<int, int>> StartCells = new List<Tuple<int, int>>();
        Random randomizer;
        public CA(int size_x,int size_y,int blockSize)
        {
            gphCtrl = new graphControl(size_x, size_y, blockSize);            
        }

        public void randomize(int num)
        {
            //StartCells.Clear();
            for (int i = 0; i < num; i++)
            {
                randomizer = new Random();
                int x = randomizer.Next(1, gphCtrl.size_x);
                int y = randomizer.Next(1, gphCtrl.size_y);
               //StartCells.Add(new Tuple<int, int>(x, y));
                gphCtrl.l_cells[x][y].setStat(1);
            }            
        }
        
        private void Core(int startx,int starty,int rangex,int rangey)
        {
            //This is prepared for MultiThread
            //Default: startx = 1;rangex = gphCtrl.l_cells.Count-1
            for (int i = startx; i < rangex; i++)
            {
                for (int j = starty; j < rangey; j++)
                {
                    int iNumNeighbors = gphCtrl.getNeighbor(i, j);
                    if (iNumNeighbors == 3)
                    {
                        gphCtrl.l_cells[i][j].setStat(1);
                    }
                    else if (!(iNumNeighbors == 2))
                    {
                        gphCtrl.l_cells[i][j].setStat(0);
                    }
                }
            }
        }        

        public void animate(int steps,int thds)
        {
            for (int i = 1; i <= steps; i++)
            {
                Core(1, 1, gphCtrl.size_x + 1, gphCtrl.size_y + 1);
            }
        }
    }
}