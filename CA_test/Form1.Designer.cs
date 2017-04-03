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
            this._label2 = new System.Windows.Forms.Label();
            this._label1 = new System.Windows.Forms.Label();
            this.RandomCellsInput = new System.Windows.Forms.TextBox();
            this.initButton = new System.Windows.Forms.Button();
            this.stepCntLabel = new System.Windows.Forms.Label();
            this.stepInput = new System.Windows.Forms.TextBox();
            this.reStartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StepButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.initButton2 = new System.Windows.Forms.Button();
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
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.initButton2);
            this.panel2.Controls.Add(this._label2);
            this.panel2.Controls.Add(this._label1);
            this.panel2.Controls.Add(this.RandomCellsInput);
            this.panel2.Controls.Add(this.initButton);
            this.panel2.Controls.Add(this.stepCntLabel);
            this.panel2.Controls.Add(this.stepInput);
            this.panel2.Controls.Add(this.reStartButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.StepButton);
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Location = new System.Drawing.Point(419, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 400);
            this.panel2.TabIndex = 1;
            // 
            // _label2
            // 
            this._label2.AutoSize = true;
            this._label2.Font = new System.Drawing.Font("宋体", 10F);
            this._label2.Location = new System.Drawing.Point(83, 27);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(42, 14);
            this._label2.TabIndex = 22;
            this._label2.Text = "Steps";
            // 
            // _label1
            // 
            this._label1.AutoSize = true;
            this._label1.Font = new System.Drawing.Font("宋体", 10F);
            this._label1.Location = new System.Drawing.Point(5, 27);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(70, 14);
            this._label1.TabIndex = 21;
            this._label1.Text = "RandomNum";
            // 
            // RandomCellsInput
            // 
            this.RandomCellsInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RandomCellsInput.Location = new System.Drawing.Point(7, 3);
            this.RandomCellsInput.Name = "RandomCellsInput";
            this.RandomCellsInput.Size = new System.Drawing.Size(72, 21);
            this.RandomCellsInput.TabIndex = 20;
            this.RandomCellsInput.Text = "20";
            // 
            // initButton
            // 
            this.initButton.Location = new System.Drawing.Point(6, 121);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(150, 30);
            this.initButton.TabIndex = 19;
            this.initButton.Text = "Initialize";
            this.initButton.UseVisualStyleBackColor = true;
            this.initButton.Click += new System.EventHandler(this.initButton_Click);
            // 
            // stepCntLabel
            // 
            this.stepCntLabel.AutoSize = true;
            this.stepCntLabel.Location = new System.Drawing.Point(77, 154);
            this.stepCntLabel.Name = "stepCntLabel";
            this.stepCntLabel.Size = new System.Drawing.Size(11, 12);
            this.stepCntLabel.TabIndex = 18;
            this.stepCntLabel.Text = "0";
            // 
            // stepInput
            // 
            this.stepInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.stepInput.Location = new System.Drawing.Point(85, 3);
            this.stepInput.Name = "stepInput";
            this.stepInput.Size = new System.Drawing.Size(68, 21);
            this.stepInput.TabIndex = 17;
            this.stepInput.Text = "100";
            // 
            // reStartButton
            // 
            this.reStartButton.Location = new System.Drawing.Point(6, 338);
            this.reStartButton.Name = "reStartButton";
            this.reStartButton.Size = new System.Drawing.Size(151, 59);
            this.reStartButton.TabIndex = 16;
            this.reStartButton.Text = "Reset";
            this.reStartButton.UseVisualStyleBackColor = true;
            this.reStartButton.Click += new System.EventHandler(this.reStartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "StepCount:";
            // 
            // StepButton
            // 
            this.StepButton.Enabled = false;
            this.StepButton.Location = new System.Drawing.Point(7, 85);
            this.StepButton.Name = "StepButton";
            this.StepButton.Size = new System.Drawing.Size(150, 30);
            this.StepButton.TabIndex = 14;
            this.StepButton.Text = "StepOver";
            this.StepButton.UseVisualStyleBackColor = true;
            this.StepButton.Click += new System.EventHandler(this.StepButton_Click);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(7, 49);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 30);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // initButton2
            // 
            this.initButton2.Location = new System.Drawing.Point(5, 185);
            this.initButton2.Name = "initButton2";
            this.initButton2.Size = new System.Drawing.Size(150, 30);
            this.initButton2.TabIndex = 23;
            this.initButton2.Text = "NoRandomInitialize";
            this.initButton2.UseVisualStyleBackColor = true;
            this.initButton2.Click += new System.EventHandler(this.initButton2_Click);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StepButton;
        private System.Windows.Forms.Button reStartButton;
        private System.Windows.Forms.TextBox stepInput;
        private System.Windows.Forms.Label stepCntLabel;
        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.Label _label2;
        private System.Windows.Forms.Label _label1;
        private System.Windows.Forms.TextBox RandomCellsInput;
        private System.Windows.Forms.Button initButton2;
    }
}

