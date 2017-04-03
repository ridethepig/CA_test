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
        public static Graphics graph = null;
        public CA automation = new CA(20, 20, 20, ref graph);
        bool startCnt = false;
        private void startButton_Click(object sender, EventArgs e)
        {
            if (startCnt)
            {
                var dr = MessageBox.Show("Another {0} steps?");
                if (dr == DialogResult.No)
                    return;
                goto lbl1;
            }
            try
            {
                iNumStep = Convert.ToInt32(stepInput.Text);
            }
            catch
            {
                stepInput.Text = "Unexpected Input";
                return;
            }
lbl1:
            automation.animate(iNumStep,0);
            startCnt = true;
        }

        private void StepButton_Click(object sender, EventArgs e)
        {
            automation.animate(1,0);
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
            graph = e.Graphics;                        
            //automation.gphCtrl.setCell(ref graph, 1, 1);
        }

        private void reStartButton_Click(object sender, EventArgs e)
        {
            automation.gphCtrl.clear(ref graph);            
        }

        private void stepInput_TextChanged(object sender, EventArgs e)
        {            
        }

        private void initButton_Click(object sender, EventArgs e)
        {
            automation.gphCtrl.refreshWindow(ref graph, true);
            automation.randomize(15);
            startCnt = false;
            StepButton.Enabled = true;
            startButton.Enabled = true;
        }
    }
}