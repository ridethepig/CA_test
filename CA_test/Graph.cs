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
        public int location_x, location_y, size;
        public Rectangle rect, rect_b;

        public cell(int locx,int locy,int size)
        {            
            location_x = locx;
            location_y = locy;
            this.size = size;            
            rect = new Rectangle(locx + 1, locy + 1, size - 1, size - 1);
            rect_b = new Rectangle(locx, locy, size, size);
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
            for (int i = 1; i <= size_x; i++)
            {                
                List<cell> cells = new List<cell>();                
                for (int j = 1; j <= size_y; j++)
                {                    
                    cells.Add(new cell(i * blockSize + 1, j * blockSize + 1, blockSize));
                }                
                l_cells.Add(cells);
            }            
        }

        /*public int getNeighbor(int i, int j)
        {
            return l_cells[i + 1][j].status + l_cells[i + 1][j + 1].status + l_cells[i - 1][j + 1].status + l_cells[i][j + 1].status
                 + l_cells[i - 1][j].status + l_cells[i - 1][j - 1].status + l_cells[i + 1][j - 1].status + l_cells[i][j - 1].status;
        }*/

        public void draw(int i, int j, ref Graphics graph, Brush brush)
        {
            graph.FillRectangle(brush, l_cells[i][j].rect);
        }

        private void draw(int i, int j, ref Graphics graph)
        {
            graph.DrawRectangle(Pens.Black, l_cells[i][j].rect_b);
        }            

        public void Pos2Cell(Point pos,ref Graphics graph)
        {
            int i = pos.X / blockSize;
            int j = pos.Y / blockSize;            
        }
    }
}