﻿using System;
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

        public int iNumStep = -1;
        public static Graphics graph = null;
        public CA automation;        
        int stepCnt = 0;
        private void startButton_Click(object sender, EventArgs e)
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
            automation.animate(iNumStep,0);
            stepCnt += iNumStep;
            stepCntLabel.Text = Convert.ToString(stepCnt);
        }

        private void StepButton_Click(object sender, EventArgs e)
        {
            automation.animate(1,0);
            stepCnt++;
            stepCntLabel.Text = Convert.ToString(stepCnt);
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
            graph = panel1.CreateGraphics();
            automation = new CA(20, 20, 20, graph);
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
            try
            {
                automation.randomize(Convert.ToInt32(RandomCellsInput.Text));
            }   
            catch
            {
                RandomCellsInput.Text = "ERROR";
                return;
            }
            StepButton.Enabled = true;
            startButton.Enabled = true;
            automation.gphCtrl.refreshWindow(ref graph);
        }           

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            var cur_ms_pos = MousePosition;
            cur_ms_pos = panel1.PointToClient(cur_ms_pos);            
            automation.gphCtrl.Pos2Cell(cur_ms_pos,ref graph);
        }

        private void initButton2_Click(object sender, EventArgs e)
        {
            automation.gphCtrl.refreshWindow(ref graph, true);
            StepButton.Enabled = true;
            startButton.Enabled = true;
        }
    }
}