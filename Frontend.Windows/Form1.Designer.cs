namespace Frontend.Windows
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
            lblDisplay = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnResult = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnPotencia = new Button();
            btnCloseParenthesis = new Button();
            btnOpenParenthesis = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnClear = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnDelete = new Button();
            btnMultiple = new Button();
            btnDivide = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDisplay
            // 
            lblDisplay.BackColor = Color.Green;
            lblDisplay.Dock = DockStyle.Top;
            lblDisplay.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplay.ForeColor = Color.White;
            lblDisplay.Location = new Point(0, 0);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(555, 55);
            lblDisplay.TabIndex = 1;
            lblDisplay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.Controls.Add(btnResult, 3, 3);
            tableLayoutPanel1.Controls.Add(btnDot, 2, 3);
            tableLayoutPanel1.Controls.Add(btn0, 0, 3);
            tableLayoutPanel1.Controls.Add(btnPotencia, 5, 2);
            tableLayoutPanel1.Controls.Add(btnCloseParenthesis, 4, 2);
            tableLayoutPanel1.Controls.Add(btnOpenParenthesis, 3, 2);
            tableLayoutPanel1.Controls.Add(btn3, 2, 2);
            tableLayoutPanel1.Controls.Add(btn2, 1, 2);
            tableLayoutPanel1.Controls.Add(btn1, 0, 2);
            tableLayoutPanel1.Controls.Add(btnClear, 5, 1);
            tableLayoutPanel1.Controls.Add(btnMinus, 4, 1);
            tableLayoutPanel1.Controls.Add(btnPlus, 3, 1);
            tableLayoutPanel1.Controls.Add(btn6, 2, 1);
            tableLayoutPanel1.Controls.Add(btn5, 1, 1);
            tableLayoutPanel1.Controls.Add(btn4, 0, 1);
            tableLayoutPanel1.Controls.Add(btnDelete, 5, 0);
            tableLayoutPanel1.Controls.Add(btnMultiple, 4, 0);
            tableLayoutPanel1.Controls.Add(btnDivide, 3, 0);
            tableLayoutPanel1.Controls.Add(btn9, 2, 0);
            tableLayoutPanel1.Controls.Add(btn8, 1, 0);
            tableLayoutPanel1.Controls.Add(btn7, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(555, 307);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.DarkOrange;
            tableLayoutPanel1.SetColumnSpan(btnResult, 4);
            btnResult.Dock = DockStyle.Fill;
            btnResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResult.Location = new Point(240, 231);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(312, 73);
            btnResult.TabIndex = 20;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.Gainsboro;
            btnDot.Dock = DockStyle.Fill;
            btnDot.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(161, 231);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(73, 73);
            btnDot.TabIndex = 19;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Gainsboro;
            tableLayoutPanel1.SetColumnSpan(btn0, 2);
            btn0.Dock = DockStyle.Fill;
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(3, 231);
            btn0.Name = "btn0";
            btn0.Size = new Size(152, 73);
            btn0.TabIndex = 18;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnPotencia
            // 
            btnPotencia.BackColor = Color.DarkOrange;
            tableLayoutPanel1.SetColumnSpan(btnPotencia, 2);
            btnPotencia.Dock = DockStyle.Fill;
            btnPotencia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPotencia.Location = new Point(398, 155);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(154, 70);
            btnPotencia.TabIndex = 17;
            btnPotencia.Text = "^";
            btnPotencia.UseVisualStyleBackColor = false;
            btnPotencia.Click += btnPotencia_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.DarkOrange;
            btnCloseParenthesis.Dock = DockStyle.Fill;
            btnCloseParenthesis.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseParenthesis.Location = new Point(319, 155);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(73, 70);
            btnCloseParenthesis.TabIndex = 16;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.DarkOrange;
            btnOpenParenthesis.Dock = DockStyle.Fill;
            btnOpenParenthesis.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenParenthesis.Location = new Point(240, 155);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(73, 70);
            btnOpenParenthesis.TabIndex = 15;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Gainsboro;
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(161, 155);
            btn3.Name = "btn3";
            btn3.Size = new Size(73, 70);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gainsboro;
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(82, 155);
            btn2.Name = "btn2";
            btn2.Size = new Size(73, 70);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gainsboro;
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(3, 155);
            btn1.Name = "btn1";
            btn1.Size = new Size(73, 70);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkOrange;
            tableLayoutPanel1.SetColumnSpan(btnClear, 2);
            btnClear.Dock = DockStyle.Fill;
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(398, 79);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(154, 70);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.DarkOrange;
            btnMinus.Dock = DockStyle.Fill;
            btnMinus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(319, 79);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(73, 70);
            btnMinus.TabIndex = 10;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.DarkOrange;
            btnPlus.Dock = DockStyle.Fill;
            btnPlus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(240, 79);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(73, 70);
            btnPlus.TabIndex = 9;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(161, 79);
            btn6.Name = "btn6";
            btn6.Size = new Size(73, 70);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(82, 79);
            btn5.Name = "btn5";
            btn5.Size = new Size(73, 70);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Gainsboro;
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(3, 79);
            btn4.Name = "btn4";
            btn4.Size = new Size(73, 70);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkOrange;
            tableLayoutPanel1.SetColumnSpan(btnDelete, 2);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(398, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 70);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMultiple
            // 
            btnMultiple.BackColor = Color.DarkOrange;
            btnMultiple.Dock = DockStyle.Fill;
            btnMultiple.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiple.Location = new Point(319, 3);
            btnMultiple.Name = "btnMultiple";
            btnMultiple.Size = new Size(73, 70);
            btnMultiple.TabIndex = 4;
            btnMultiple.Text = "*";
            btnMultiple.UseVisualStyleBackColor = false;
            btnMultiple.Click += btnMultiple_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.DarkOrange;
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(240, 3);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(73, 70);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(161, 3);
            btn9.Name = "btn9";
            btn9.Size = new Size(73, 70);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(82, 3);
            btn8.Name = "btn8";
            btn8.Size = new Size(73, 70);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(3, 3);
            btn7.Name = "btn7";
            btn7.Size = new Size(73, 70);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(555, 362);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblDisplay);
            Name = "Form1";
            Text = "Functions Evaluator ";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblDisplay;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnMultiple;
        private Button btnDivide;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnDelete;
        private Button btnMinus;
        private Button btnPlus;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnClear;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnCloseParenthesis;
        private Button btnOpenParenthesis;
        private Button btnDot;
        private Button btn0;
        private Button btnPotencia;
        private Button btnResult;
    }
}
