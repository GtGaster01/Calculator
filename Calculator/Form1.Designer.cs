namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnEqual = new Button();
            btnDot = new Button();
            btnZero = new Button();
            btnPower = new Button();
            btnAdd = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnSubtract = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnMultiply = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnDivide = new Button();
            btnBackspace = new Button();
            btnClear = new Button();
            btnSqrt = new Button();
            btnOpenBrckt = new Button();
            btnCloseBrckt = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Consolas", 32F, FontStyle.Bold);
            txtDisplay.Location = new Point(15, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ScrollBars = ScrollBars.Both;
            txtDisplay.Size = new Size(420, 66);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.LightGray;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnEqual, 3, 4);
            tableLayoutPanel1.Controls.Add(btnDot, 2, 4);
            tableLayoutPanel1.Controls.Add(btnZero, 1, 4);
            tableLayoutPanel1.Controls.Add(btnPower, 0, 4);
            tableLayoutPanel1.Controls.Add(btnAdd, 3, 3);
            tableLayoutPanel1.Controls.Add(btnThree, 2, 3);
            tableLayoutPanel1.Controls.Add(btnTwo, 1, 3);
            tableLayoutPanel1.Controls.Add(btnOne, 0, 3);
            tableLayoutPanel1.Controls.Add(btnSubtract, 3, 2);
            tableLayoutPanel1.Controls.Add(btnSix, 2, 2);
            tableLayoutPanel1.Controls.Add(btnFive, 1, 2);
            tableLayoutPanel1.Controls.Add(btnFour, 0, 2);
            tableLayoutPanel1.Controls.Add(btnMultiply, 3, 1);
            tableLayoutPanel1.Controls.Add(btnNine, 2, 1);
            tableLayoutPanel1.Controls.Add(btnEight, 1, 1);
            tableLayoutPanel1.Controls.Add(btnSeven, 0, 1);
            tableLayoutPanel1.Controls.Add(btnDivide, 3, 0);
            tableLayoutPanel1.Controls.Add(btnBackspace, 1, 0);
            tableLayoutPanel1.Controls.Add(btnClear, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSqrt, 2, 0);
            tableLayoutPanel1.Location = new Point(12, 119);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(420, 411);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.MediumSpringGreen;
            btnEqual.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEqual.Location = new Point(318, 331);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(99, 76);
            btnEqual.TabIndex = 21;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.Turquoise;
            btnDot.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDot.Location = new Point(213, 331);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(99, 76);
            btnDot.TabIndex = 20;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.LightGray;
            btnZero.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnZero.ForeColor = Color.Black;
            btnZero.Location = new Point(108, 331);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(99, 76);
            btnZero.TabIndex = 19;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnPower
            // 
            btnPower.BackColor = Color.Turquoise;
            btnPower.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPower.Location = new Point(3, 331);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(99, 76);
            btnPower.TabIndex = 18;
            btnPower.Text = "^";
            btnPower.UseVisualStyleBackColor = false;
            btnPower.Click += btnPower_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Turquoise;
            btnAdd.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(318, 249);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 76);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.LightGray;
            btnThree.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnThree.ForeColor = Color.Black;
            btnThree.Location = new Point(213, 249);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(99, 76);
            btnThree.TabIndex = 16;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btnThree_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.LightGray;
            btnTwo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTwo.ForeColor = Color.Black;
            btnTwo.Location = new Point(108, 249);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(99, 76);
            btnTwo.TabIndex = 15;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.LightGray;
            btnOne.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOne.ForeColor = Color.Black;
            btnOne.Location = new Point(3, 249);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(99, 76);
            btnOne.TabIndex = 14;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnOne_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.Turquoise;
            btnSubtract.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSubtract.ForeColor = SystemColors.ControlText;
            btnSubtract.Location = new Point(318, 167);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(99, 76);
            btnSubtract.TabIndex = 13;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = Color.LightGray;
            btnSix.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSix.ForeColor = Color.Black;
            btnSix.Location = new Point(213, 167);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(99, 76);
            btnSix.TabIndex = 12;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btnSix_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = Color.LightGray;
            btnFive.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFive.ForeColor = Color.Black;
            btnFive.Location = new Point(108, 167);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(99, 76);
            btnFive.TabIndex = 11;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.LightGray;
            btnFour.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFour.ForeColor = Color.Black;
            btnFour.Location = new Point(3, 167);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(99, 76);
            btnFour.TabIndex = 10;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btnFour_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.Turquoise;
            btnMultiply.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMultiply.ForeColor = SystemColors.ControlText;
            btnMultiply.Location = new Point(318, 85);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(99, 76);
            btnMultiply.TabIndex = 9;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = Color.LightGray;
            btnNine.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnNine.ForeColor = Color.Black;
            btnNine.Location = new Point(213, 85);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(99, 76);
            btnNine.TabIndex = 8;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btnNine_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = Color.LightGray;
            btnEight.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEight.ForeColor = Color.Black;
            btnEight.Location = new Point(108, 85);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(99, 76);
            btnEight.TabIndex = 7;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += btnEight_Click;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = Color.LightGray;
            btnSeven.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSeven.ForeColor = Color.Black;
            btnSeven.Location = new Point(3, 85);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(99, 76);
            btnSeven.TabIndex = 6;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.Turquoise;
            btnDivide.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDivide.ForeColor = SystemColors.ControlText;
            btnDivide.Location = new Point(318, 3);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(99, 76);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = Color.IndianRed;
            btnBackspace.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBackspace.Location = new Point(108, 3);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(99, 76);
            btnBackspace.TabIndex = 3;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = false;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnClear.Location = new Point(3, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 76);
            btnClear.TabIndex = 2;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.Turquoise;
            btnSqrt.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSqrt.Location = new Point(213, 3);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(99, 76);
            btnSqrt.TabIndex = 22;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnOpenBrckt
            // 
            btnOpenBrckt.BackColor = Color.White;
            btnOpenBrckt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOpenBrckt.Location = new Point(117, 84);
            btnOpenBrckt.Name = "btnOpenBrckt";
            btnOpenBrckt.Size = new Size(102, 32);
            btnOpenBrckt.TabIndex = 2;
            btnOpenBrckt.Text = "(";
            btnOpenBrckt.UseVisualStyleBackColor = false;
            // 
            // btnCloseBrckt
            // 
            btnCloseBrckt.BackColor = Color.White;
            btnCloseBrckt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCloseBrckt.Location = new Point(225, 84);
            btnCloseBrckt.Name = "btnCloseBrckt";
            btnCloseBrckt.Size = new Size(102, 32);
            btnCloseBrckt.TabIndex = 3;
            btnCloseBrckt.Text = ")";
            btnCloseBrckt.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AcceptButton = btnEqual;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 221, 221);
            ClientSize = new Size(441, 538);
            Controls.Add(btnCloseBrckt);
            Controls.Add(btnOpenBrckt);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtDisplay);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnClear;
        private Button btnEqual;
        private Button btnDot;
        private Button btnZero;
        private Button btnPower;
        private Button btnAdd;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnSubtract;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnMultiply;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnDivide;
        private Button btnBackspace;
        private Button btnSqrt;
        private Button btnOpenBrckt;
        private Button btnCloseBrckt;
    }
}
