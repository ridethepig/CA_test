using System;
using System.Collections.Generic;
using System.Drawing;
namespace CA_test
{
    public class CA
    {
        public graphControl gphCtrl;
        //public List<Tuple<int, int>> StartCells = new List<Tuple<int, int>>();
        Random randomizer = new Random();
        public Graphics graph;
        private short[,] statusTemp;
        public CA(int size_x,int size_y,int blockSize,Graphics graph)
        {
            gphCtrl = new graphControl(size_x, size_y, blockSize);
            this.graph = graph;
            statusTemp = new short[size_x+1, size_y+1];
        }

        public void randomize(int num)
        {            
            for (int i = 0; i < num; i++)
            {
                //randomizer = new Random();
                int x = randomizer.Next(1, gphCtrl.size_x);
                int y = randomizer.Next(1, gphCtrl.size_y);               
                gphCtrl.l_cells[x][y].setStat(1);
            }            
        }

        private void Core(int startx, int starty, int rangex, int rangey)
        {
            //This is prepared for MultiThread
            //Default: startx = 1;rangex = gphCtrl.l_cells.Count-1
            statusTemp.Initialize();
            for (int i = startx; i < rangex; i++)
            {
                for (int j = starty; j < rangey; j++)
                {
                    int iNumNeighbors = gphCtrl.getNeighbor(i, j);
                    if (iNumNeighbors == 3)
                    {
                        //gphCtrl.l_cells[i][j].setStat(1);
                        statusTemp[i, j] = 1;
                    }
                    else if (!(iNumNeighbors == 2))
                    {
                        //gphCtrl.l_cells[i][j].setStat(0);
                        statusTemp[i, j] = 0;
                    }
                    else
                    {
                        statusTemp[i, j] = gphCtrl.l_cells[i][j].status;
                    }
                }
            }
            for (int i = startx; i < rangex; i++)
                for (int j = starty; j < rangey; j++)
                    gphCtrl.l_cells[i][j].setStat(statusTemp[i, j]);
        }
        public void animate(int steps,int thds)
        {
            for (int i = 1; i <= steps; i++)
            {
                Core(1, 1, gphCtrl.size_x + 1, gphCtrl.size_y + 1);
            }
            gphCtrl.refreshWindow(ref graph);
        }
    }
}