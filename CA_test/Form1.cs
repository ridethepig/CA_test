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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();           
        }

        public string sStep = string.Empty;
        public int iNumStep = -1;
        public string sNumStep = string.Empty;               

        private void startButton_Click(object sender, EventArgs e)
        {
            if (iNumStep == -1)
            {
                iNumStep = 100;                
            }
            else
            {                
                try
                {
                    iNumStep = Convert.ToInt32(stepInput.Text);
                }
                catch
                {
                    stepInput.Text = "Unexpected Input";
                    return;
                }
            }
        }

        private void StepButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /*Pen pencil = new Pen(Color.Black, 1);
            e.Graphics.DrawRectangle(pencil, 0, 0, panel1.Width - 1, panel1.Height - 1);
            for (int i = 21; i <= 400; i += 20)
            {
                e.Graphics.DrawLine(pencil, 0, i, panel1.Width - 1, i);
                e.Graphics.DrawLine(pencil, i, 0, i, panel1.Height - 1);
            }                                   
            Rectangle rect = new Rectangle(1, 1, 20, 20);
            e.Graphics.FillRectangle(Brushes.Blue, rect);
            pencil.Dispose();
            e.Graphics.Dispose();*/
            CA automation = new CA(20, 20, 20);
            var graph = e.Graphics;
            automation.gphCtrl.refreshWindow(ref graph,true);
            automation.gphCtrl.setCell(ref graph, 1, 1);
        }

        private void reStartButton_Click(object sender, EventArgs e)
        {

        }

        private void stepInput_TextChanged(object sender, EventArgs e)
        {
            iNumStep = 0;
        }
    }
}