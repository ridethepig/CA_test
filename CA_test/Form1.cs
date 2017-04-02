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
        public StringBuilder sNumStep = new StringBuilder();
        public int iNumStep = 100;

        private void numButton1_Click(object sender, EventArgs e)
        {
            sNumStep.Append("1");
            refreshLabel();
        }

        private void numButton2_Click(object sender, EventArgs e)
        {
            sNumStep.Append("2");
            refreshLabel();
        }

        private void numButton3_Click(object sender, EventArgs e)
        {
            sNumStep.Append("3");
            refreshLabel();
        }

        private void numButton4_Click(object sender, EventArgs e)
        {
            sNumStep.Append("4");
            refreshLabel();
        }

        private void numButton5_Click(object sender, EventArgs e)
        {
            sNumStep.Append("5");
            refreshLabel();
        }

        private void numButton6_Click(object sender, EventArgs e)
        {
            sNumStep.Append("6");
            refreshLabel();
        }

        private void numButton7_Click(object sender, EventArgs e)
        {
            sNumStep.Append("7");
            refreshLabel();
        }

        private void numButton8_Click(object sender, EventArgs e)
        {
            sNumStep.Append("8");
            refreshLabel();
        }

        private void numButton9_Click(object sender, EventArgs e)
        {
            sNumStep.Append("9");
            refreshLabel();
        }

        private void numButton0_Click(object sender, EventArgs e)
        {
            sNumStep.Append("0");
            refreshLabel();
        }        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void StepButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pencil = new Pen(Color.Black, 1);
            e.Graphics.DrawRectangle(pencil, 0, 0, panel1.Width - 1, panel1.Height - 1);
            for (int i = 21; i <= 400; i += 20)
            {
                e.Graphics.DrawLine(pencil, 0, i, panel1.Width - 1, i);
                e.Graphics.DrawLine(pencil, i, 0, i, panel1.Height - 1);
            }                                   
            Rectangle rect = new Rectangle(1, 1, 20, 20);
            e.Graphics.FillRectangle(Brushes.Blue, rect);
            pencil.Dispose();
            e.Graphics.Dispose();
        }

        private void numButtonDel_Click(object sender, EventArgs e)
        {
            sNumStep.Remove(sNumStep.Length - 1, sNumStep.Length - 1);
            refreshLabel();
        }

        private void refreshLabel()
        {
            numLabel.Text = sNumStep.ToString();
        }
    }
}