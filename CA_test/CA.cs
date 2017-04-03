using System;
using System.Collections.Generic;
namespace CA_test
{
    class CA
    {
        public graphControl gphCtrl;
        public List<Tuple<int, int>> StartCells = new List<Tuple<int, int>>();
        Random randomizer;
        public CA(int size_x,int size_y,int blockSize)
        {
            gphCtrl = new graphControl(size_x, size_y, blockSize);            
        }
        public void randomize(int num)
        {
            StartCells.Clear();
            for (int i = 0; i < num; i++)
            {
                randomizer = new Random();
                int x = randomizer.Next(1, gphCtrl.size_x);
                int y = randomizer.Next(1, gphCtrl.size_y);
                StartCells.Add(new Tuple<int, int>(x, y));
            }            
        }
    }
}