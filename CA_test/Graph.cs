using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CA_test
{
    public class cell
    {
        public short status;
        public int location_x, location_y;
        public int size;
        public Brush brush;
        public Rectangle rect, rect_b;

        public cell(short status,int locx,int locy,int size,Color color)
        {
            this.status = status;
                 location_x = locx;
                 location_y = locy;
            this.size = size;
                 brush = new SolidBrush(color);
            rect = new Rectangle(locx + 1, locy + 1, size - 1, size - 1);
            rect_b = new Rectangle(locx, locy, size, size);
        }

        public void drawSelf(ref Graphics graph)
        {
            graph.FillRectangle(brush, rect);
        }

        public void drawBorder(ref Graphics graph)
        {
            graph.DrawRectangle(Pens.Black, rect_b);
        }
    }
    public class graphControl
    {
        int size_x, size_y;
        int blockSize;
        public cell[,] map;
        
        public graphControl(int size_x,int size_y,int blockSize)
        {
            this.size_x = size_x;
            this.size_y = size_y;
            this.blockSize = blockSize;
            this.map = new cell[size_x,size_y];
            calcPixel();
        }

        private void calcPixel()
        {
            for (int i = 0; i < size_x; i++)
                for (int j = 0; j < size_y; j++)
                {
                    map[1, j] = new cell(0, i * blockSize + 1, j * blockSize + 1, blockSize, Color.White);
                }            
        }

        public int getNeighbor(int i, int j)
        {
            return map[i + 1, j].status + map[i + 1, j + 1].status + map[i - 1, j + 1].status + map[i, j + 1].status
                 + map[i - 1, j].status + map[i - 1, j - 1].status + map[i + 1, j - 1].status + map[i, j - 1].status;
        }
    }
}