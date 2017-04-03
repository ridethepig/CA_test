namespace CA_test
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.StepButton = new System.Windows.Forms.Button();
            this.numLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.reStartButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(402, 402);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reStartButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.StepButton);
            this.panel2.Controls.Add(this.numLabel);
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Location = new System.Drawing.Point(419, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 400);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "StepCount:";
            // 
            // StepButton
            // 
            this.StepButton.Location = new System.Drawing.Point(6, 267);
            this.StepButton.Name = "StepButton";
            this.StepButton.Size = new System.Drawing.Size(150, 30);
            this.StepButton.TabIndex = 14;
            this.StepButton.Text = "StepOver";
            this.StepButton.UseVisualStyleBackColor = true;
            this.StepButton.Click += new System.EventHandler(this.StepButton_Click);
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.numLabel.Location = new System.Drawing.Point(50, 29);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(96, 16);
            this.numLabel.TabIndex = 13;
            this.numLabel.Text = "DEFAULT:100";
            this.numLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 231);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 30);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // reStartButton
            // 
            this.reStartButton.Location = new System.Drawing.Point(6, 338);
            this.reStartButton.Name = "reStartButton";
            this.reStartButton.Size = new System.Drawing.Size(147, 59);
            this.reStartButton.TabIndex = 16;
            this.reStartButton.Text = "ReStart";
            this.reStartButton.UseVisualStyleBackColor = true;
            this.reStartButton.Click += new System.EventHandler(this.reStartButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "细胞自动机实验";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StepButton;
        private System.Windows.Forms.Button reStartButton;
    }
}

