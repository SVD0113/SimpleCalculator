namespace SimpleCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnNum1 = new Button();
            txtOutput = new TextBox();
            txtInput = new TextBox();
            btnNum2 = new Button();
            btnNum3 = new Button();
            btnNum4 = new Button();
            btnMultiply = new Button();
            btnCE = new Button();
            btnNum0 = new Button();
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnC = new Button();
            btnPlus = new Button();
            btnNum5 = new Button();
            btnNum9 = new Button();
            btnNum6 = new Button();
            btnMinus = new Button();
            btnDivide = new Button();
            btnSign = new Button();
            btnDelete = new Button();
            btnResult = new Button();
            btnDot = new Button();
            txtTitle = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNum1
            // 
            btnNum1.BackColor = Color.FromArgb(192, 255, 192);
            btnNum1.Font = new Font("맑은 고딕", 15.75F);
            btnNum1.Location = new Point(18, 340);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(90, 45);
            btnNum1.TabIndex = 0;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = false;
            btnNum1.Click += btnNum_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(18, 97);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(377, 40);
            txtOutput.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(18, 143);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(377, 40);
            txtInput.TabIndex = 2;
            // 
            // btnNum2
            // 
            btnNum2.BackColor = Color.FromArgb(192, 255, 192);
            btnNum2.Font = new Font("맑은 고딕", 15.75F);
            btnNum2.Location = new Point(113, 340);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(90, 45);
            btnNum2.TabIndex = 3;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = false;
            btnNum2.Click += btnNum_Click;
            // 
            // btnNum3
            // 
            btnNum3.BackColor = Color.FromArgb(192, 255, 192);
            btnNum3.Font = new Font("맑은 고딕", 15.75F);
            btnNum3.Location = new Point(209, 340);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(90, 45);
            btnNum3.TabIndex = 4;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = false;
            btnNum3.Click += btnNum_Click;
            // 
            // btnNum4
            // 
            btnNum4.BackColor = Color.FromArgb(192, 255, 192);
            btnNum4.Font = new Font("맑은 고딕", 15.75F);
            btnNum4.Location = new Point(18, 290);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(90, 45);
            btnNum4.TabIndex = 5;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = false;
            btnNum4.Click += btnNum_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(192, 255, 192);
            btnMultiply.Font = new Font("맑은 고딕", 15.75F);
            btnMultiply.ForeColor = Color.Blue;
            btnMultiply.Location = new Point(305, 240);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(90, 45);
            btnMultiply.TabIndex = 6;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnOperator_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.FromArgb(192, 255, 192);
            btnCE.Font = new Font("맑은 고딕", 15.75F);
            btnCE.ForeColor = Color.Red;
            btnCE.Location = new Point(18, 189);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(90, 45);
            btnCE.TabIndex = 7;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            // 
            // btnNum0
            // 
            btnNum0.BackColor = Color.FromArgb(192, 255, 192);
            btnNum0.Font = new Font("맑은 고딕", 15.75F);
            btnNum0.Location = new Point(113, 389);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(90, 45);
            btnNum0.TabIndex = 8;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = false;
            btnNum0.Click += btnNum_Click;
            // 
            // btnNum7
            // 
            btnNum7.BackColor = Color.FromArgb(192, 255, 192);
            btnNum7.Font = new Font("맑은 고딕", 15.75F);
            btnNum7.Location = new Point(18, 240);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(90, 45);
            btnNum7.TabIndex = 9;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = false;
            btnNum7.Click += btnNum_Click;
            // 
            // btnNum8
            // 
            btnNum8.BackColor = Color.FromArgb(192, 255, 192);
            btnNum8.Font = new Font("맑은 고딕", 15.75F);
            btnNum8.Location = new Point(113, 240);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(90, 45);
            btnNum8.TabIndex = 10;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = false;
            btnNum8.Click += btnNum_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(192, 255, 192);
            btnC.Font = new Font("맑은 고딕", 15.75F);
            btnC.ForeColor = Color.Red;
            btnC.Location = new Point(113, 189);
            btnC.Name = "btnC";
            btnC.Size = new Size(90, 45);
            btnC.TabIndex = 11;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(192, 255, 192);
            btnPlus.Font = new Font("맑은 고딕", 15.75F);
            btnPlus.ForeColor = Color.Blue;
            btnPlus.Location = new Point(305, 340);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(90, 45);
            btnPlus.TabIndex = 12;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnOperator_Click;
            // 
            // btnNum5
            // 
            btnNum5.BackColor = Color.FromArgb(192, 255, 192);
            btnNum5.Font = new Font("맑은 고딕", 15.75F);
            btnNum5.Location = new Point(113, 290);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(90, 45);
            btnNum5.TabIndex = 13;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = false;
            btnNum5.Click += btnNum_Click;
            // 
            // btnNum9
            // 
            btnNum9.BackColor = Color.FromArgb(192, 255, 192);
            btnNum9.Font = new Font("맑은 고딕", 15.75F);
            btnNum9.Location = new Point(209, 240);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(90, 45);
            btnNum9.TabIndex = 14;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = false;
            btnNum9.Click += btnNum_Click;
            // 
            // btnNum6
            // 
            btnNum6.BackColor = Color.FromArgb(192, 255, 192);
            btnNum6.Font = new Font("맑은 고딕", 15.75F);
            btnNum6.Location = new Point(209, 290);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(90, 45);
            btnNum6.TabIndex = 15;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = false;
            btnNum6.Click += btnNum_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(192, 255, 192);
            btnMinus.Font = new Font("맑은 고딕", 15.75F);
            btnMinus.ForeColor = Color.Blue;
            btnMinus.Location = new Point(305, 290);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(90, 45);
            btnMinus.TabIndex = 16;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnOperator_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(192, 255, 192);
            btnDivide.Font = new Font("맑은 고딕", 15.75F);
            btnDivide.ForeColor = Color.Blue;
            btnDivide.Location = new Point(305, 189);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(90, 45);
            btnDivide.TabIndex = 17;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnOperator_Click;
            // 
            // btnSign
            // 
            btnSign.BackColor = Color.FromArgb(192, 255, 192);
            btnSign.Font = new Font("맑은 고딕", 15.75F);
            btnSign.ForeColor = Color.Red;
            btnSign.Location = new Point(18, 389);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(90, 45);
            btnSign.TabIndex = 18;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 255, 192);
            btnDelete.Font = new Font("맑은 고딕", 15.75F);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(209, 189);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 45);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Del";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(192, 255, 192);
            btnResult.Font = new Font("맑은 고딕", 15.75F);
            btnResult.ForeColor = Color.Red;
            btnResult.Location = new Point(305, 389);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(90, 45);
            btnResult.TabIndex = 20;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click_1;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.FromArgb(192, 255, 192);
            btnDot.Font = new Font("맑은 고딕", 15.75F);
            btnDot.Location = new Point(209, 389);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(90, 45);
            btnDot.TabIndex = 21;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.AppWorkspace;
            txtTitle.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtTitle.Location = new Point(38, 23);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(336, 60);
            txtTitle.TabIndex = 22;
            txtTitle.Text = "Simple Calculator";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(404, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(866, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtTitle);
            Controls.Add(btnDot);
            Controls.Add(btnResult);
            Controls.Add(btnDelete);
            Controls.Add(btnSign);
            Controls.Add(btnDivide);
            Controls.Add(btnMinus);
            Controls.Add(btnNum6);
            Controls.Add(btnNum9);
            Controls.Add(btnNum5);
            Controls.Add(btnPlus);
            Controls.Add(btnC);
            Controls.Add(btnNum8);
            Controls.Add(btnNum7);
            Controls.Add(btnNum0);
            Controls.Add(btnCE);
            Controls.Add(btnMultiply);
            Controls.Add(btnNum4);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(txtInput);
            Controls.Add(txtOutput);
            Controls.Add(btnNum1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += btnOperator_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNum1;
        private TextBox txtOutput;
        private TextBox txtInput;
        private Button btnNum2;
        private Button btnNum3;
        private Button btnNum4;
        private Button btnMultiply;
        private Button btnCE;
        private Button btnNum0;
        private Button btnNum7;
        private Button btnNum8;
        private Button btnC;
        private Button btnPlus;
        private Button btnNum5;
        private Button btnNum9;
        private Button btnNum6;
        private Button btnMinus;
        private Button btnDivide;
        private Button btnSign;
        private Button btnDelete;
        private Button btnResult;
        private Button btnDot;
        private TextBox txtTitle;
        private PictureBox pictureBox1;
    }
}
