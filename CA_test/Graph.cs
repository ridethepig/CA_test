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
        public int size_x, size_y;
        public int blockSize;
        public List<List<cell>> l_cells;
        
        public graphControl(int size_x,int size_y,int blockSize)
        {
            this.size_x = size_x;
            this.size_y = size_y;
            this.blockSize = blockSize;
            l_cells = new List<List<cell>>();
            calcPixel();
        }

        private void calcPixel()
        {
            for (int i = 0; i < size_x; i++)
            {
                List<cell> cells = new List<cell>();
                for (int j = 0; j < size_y; j++)
                {                    
                    cells.Add(new cell(0, i * blockSize + 1, j * blockSize + 1, blockSize, Color.White));
                }
                l_cells.Add(cells);
            }
        }

        public int getNeighbor(int i, int j)
        {
            return l_cells[i + 1][j].status + l_cells[i + 1][j + 1].status + l_cells[i - 1][j + 1].status + l_cells[i][j + 1].status
                 + l_cells[i - 1][j].status + l_cells[i - 1][j - 1].status + l_cells[i + 1][j - 1].status + l_cells[i][j - 1].status;
        }
        
        public void refreshWindow(ref Graphics graph)
        {
            for (int i = 0; i < size_x; i++)
                for (int j = 0; j < size_y; j++)
                {
                    l_cells[i][j].drawSelf(ref graph);
                }
        }

        public void refreshWindow(ref Graphics graph,bool switcher)
        {

            for (int i = 0; i < size_x; i++)
                for (int j = 0; j < size_y; j++)
                {
                    l_cells[i][j].drawBorder(ref graph);
                }
        }

        public void setCell(ref Graphics graph,int x,int y)
        {
            x--; y--;
            l_cells[x][y].brush = Brushes.Black;
            l_cells[x][y].drawSelf(ref graph);
        }
    }
}