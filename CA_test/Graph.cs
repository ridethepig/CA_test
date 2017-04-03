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

        public cell(short status,int locx,int locy,int size)
        {            
                 location_x = locx;
                 location_y = locy;
            this.size = size;
            setStat(status);
            rect = new Rectangle(locx + 1, locy + 1, size - 1, size - 1);
            rect_b = new Rectangle(locx, locy, size, size);
        }

        public cell()
        {
            status = 0;
            brush = null;             
        }

        public void drawSelf(ref Graphics graph)
        {
            graph.FillRectangle(brush, rect);
        }

        public void drawBorder(ref Graphics graph)
        {
            graph.DrawRectangle(Pens.Black, rect_b);
        }
        
        public void setStat(short stat)
        {
            status = stat;
            switch(status)
            {
                case 0:brush = Brushes.White;
                    break;
                case 1:brush = Brushes.Blue;
                    break;
            }
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
            //Please Pay Attention!!!Here I set a border for the cells so that the indexer will not run out
            // Do Not use them and think as if the list start from 1.
            List<cell> tmp_cells = new List<cell>();
            cell tmp_cell = new cell();
            for (int i = 0; i <= size_x + 1; i++)
                tmp_cells.Add(tmp_cell);
            l_cells.Add(tmp_cells);
            for (int i = 1; i <= size_x; i++)
            {                
                List<cell> cells = new List<cell>();
                cells.Add(tmp_cell);
                for (int j = 1; j <= size_y; j++)
                {                    
                    cells.Add(new cell(0, i * blockSize + 1, j * blockSize + 1, blockSize));
                }
                cells.Add(tmp_cell);
                l_cells.Add(cells);
            }
            l_cells.Add(tmp_cells);
        }

        public int getNeighbor(int i, int j)
        {
            return l_cells[i + 1][j].status + l_cells[i + 1][j + 1].status + l_cells[i - 1][j + 1].status + l_cells[i][j + 1].status
                 + l_cells[i - 1][j].status + l_cells[i - 1][j - 1].status + l_cells[i + 1][j - 1].status + l_cells[i][j - 1].status;
        }
        
        public void refreshWindow(ref Graphics graph)
        {
            for (int i = 1; i <= size_x; i++)
                for (int j = 1; j <= size_y; j++)
                {
                    l_cells[i][j].drawSelf(ref graph);
                }
        }

        public void refreshWindow(ref Graphics graph,bool switcher)
        {

            for (int i = 1; i <= size_x; i++)
                for (int j = 1; j <= size_y; j++)
                {
                    l_cells[i][j].drawBorder(ref graph);
                }
        }

        public void setCell(ref Graphics graph,int x,int y)
        {            
            l_cells[x][y].brush = Brushes.Black;
            l_cells[x][y].drawSelf(ref graph);
        }
        
        public void clear(ref Graphics graph)
        {
            for (int i = 1; i <= size_x; i++)
                for (int j = 1; j <= size_y; j++)
                {
                    l_cells[i][j].setStat(0);
                    l_cells[i][j].drawSelf(ref graph);
                }
        }
    }
}