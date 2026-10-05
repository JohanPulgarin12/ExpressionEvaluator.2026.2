namespace Frontend.Windows
{
    partial class CalculatorForm
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
            txtbxOperations = new TextBox();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnOpenParentheses = new Button();
            btnDelete = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnPlus = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnEquals = new Button();
            btnDot = new Button();
            btnZero = new Button();
            btnCloseParentheses = new Button();
            btnMinus = new Button();
            btnClear = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnPow = new Button();
            SuspendLayout();
            // 
            // txtbxOperations
            // 
            txtbxOperations.BackColor = Color.Green;
            txtbxOperations.CausesValidation = false;
            txtbxOperations.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtbxOperations.ForeColor = Color.White;
            txtbxOperations.Location = new Point(12, 21);
            txtbxOperations.Margin = new Padding(8);
            txtbxOperations.Name = "txtbxOperations";
            txtbxOperations.ReadOnly = true;
            txtbxOperations.ShortcutsEnabled = false;
            txtbxOperations.Size = new Size(479, 50);
            txtbxOperations.TabIndex = 0;
            // 
            // btnOne
            // 
            btnOne.BackColor = SystemColors.ButtonHighlight;
            btnOne.BackgroundImageLayout = ImageLayout.None;
            btnOne.Font = new Font("Segoe UI", 24F);
            btnOne.Location = new Point(11, 95);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(75, 75);
            btnOne.TabIndex = 1;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = SystemColors.ButtonHighlight;
            btnTwo.BackgroundImageLayout = ImageLayout.None;
            btnTwo.Font = new Font("Segoe UI", 24F);
            btnTwo.Location = new Point(92, 95);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(75, 75);
            btnTwo.TabIndex = 2;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = SystemColors.ButtonHighlight;
            btnThree.BackgroundImageLayout = ImageLayout.None;
            btnThree.Font = new Font("Segoe UI", 24F);
            btnThree.Location = new Point(173, 95);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(75, 75);
            btnThree.TabIndex = 3;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btnThree_Click;
            // 
            // btnOpenParentheses
            // 
            btnOpenParentheses.BackColor = Color.LightCyan;
            btnOpenParentheses.Font = new Font("Segoe UI", 24F);
            btnOpenParentheses.Location = new Point(254, 95);
            btnOpenParentheses.Name = "btnOpenParentheses";
            btnOpenParentheses.Size = new Size(75, 75);
            btnOpenParentheses.TabIndex = 4;
            btnOpenParentheses.Text = "(";
            btnOpenParentheses.UseVisualStyleBackColor = false;
            btnOpenParentheses.Click += btnOpenParenthesis_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 255, 192);
            btnDelete.Font = new Font("Segoe UI", 24F);
            btnDelete.Location = new Point(416, 95);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 75);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Del";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = SystemColors.ButtonHighlight;
            btnSix.BackgroundImageLayout = ImageLayout.None;
            btnSix.Font = new Font("Segoe UI", 24F);
            btnSix.Location = new Point(173, 176);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(75, 75);
            btnSix.TabIndex = 7;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btnSix_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = SystemColors.ButtonHighlight;
            btnFive.BackgroundImageLayout = ImageLayout.None;
            btnFive.Font = new Font("Segoe UI", 24F);
            btnFive.Location = new Point(92, 176);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(75, 75);
            btnFive.TabIndex = 6;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = SystemColors.ButtonHighlight;
            btnFour.BackgroundImageLayout = ImageLayout.None;
            btnFour.Font = new Font("Segoe UI", 24F);
            btnFour.Location = new Point(11, 176);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(75, 75);
            btnFour.TabIndex = 5;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btnFour_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.LightCyan;
            btnPlus.Font = new Font("Segoe UI", 24F);
            btnPlus.Location = new Point(254, 176);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(75, 75);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = SystemColors.ButtonHighlight;
            btnNine.BackgroundImageLayout = ImageLayout.None;
            btnNine.Font = new Font("Segoe UI", 24F);
            btnNine.Location = new Point(173, 257);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(75, 75);
            btnNine.TabIndex = 12;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btnNine_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = SystemColors.ButtonHighlight;
            btnEight.BackgroundImageLayout = ImageLayout.None;
            btnEight.Font = new Font("Segoe UI", 24F);
            btnEight.Location = new Point(92, 257);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(75, 75);
            btnEight.TabIndex = 11;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += btnEight_Click;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = SystemColors.ButtonHighlight;
            btnSeven.BackgroundImageLayout = ImageLayout.None;
            btnSeven.Font = new Font("Segoe UI", 24F);
            btnSeven.Location = new Point(11, 257);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(75, 75);
            btnSeven.TabIndex = 10;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.Gold;
            btnEquals.Font = new Font("Segoe UI", 24F);
            btnEquals.Location = new Point(254, 338);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(237, 75);
            btnEquals.TabIndex = 18;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.ButtonHighlight;
            btnDot.BackgroundImageLayout = ImageLayout.None;
            btnDot.Font = new Font("Segoe UI", 24F);
            btnDot.Location = new Point(173, 338);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(75, 75);
            btnDot.TabIndex = 16;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = SystemColors.ButtonHighlight;
            btnZero.BackgroundImageLayout = ImageLayout.None;
            btnZero.Font = new Font("Segoe UI", 24F);
            btnZero.Location = new Point(12, 338);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(155, 75);
            btnZero.TabIndex = 15;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnCloseParentheses
            // 
            btnCloseParentheses.BackColor = Color.LightCyan;
            btnCloseParentheses.Font = new Font("Segoe UI", 24F);
            btnCloseParentheses.Location = new Point(335, 95);
            btnCloseParentheses.Name = "btnCloseParentheses";
            btnCloseParentheses.Size = new Size(75, 75);
            btnCloseParentheses.TabIndex = 23;
            btnCloseParentheses.Text = ")";
            btnCloseParentheses.UseVisualStyleBackColor = false;
            btnCloseParentheses.Click += btnCloseParenthesis_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.LightCyan;
            btnMinus.Font = new Font("Segoe UI", 24F);
            btnMinus.Location = new Point(335, 176);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(75, 75);
            btnMinus.TabIndex = 21;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 255, 192);
            btnClear.Font = new Font("Segoe UI", 24F);
            btnClear.Location = new Point(416, 176);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 75);
            btnClear.TabIndex = 20;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.LightCyan;
            btnMultiply.Font = new Font("Segoe UI", 24F);
            btnMultiply.Location = new Point(254, 257);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 75);
            btnMultiply.TabIndex = 19;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.LightCyan;
            btnDivide.Font = new Font("Segoe UI", 24F);
            btnDivide.Location = new Point(335, 257);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 75);
            btnDivide.TabIndex = 24;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.LightCyan;
            btnPow.Font = new Font("Segoe UI", 24F);
            btnPow.Location = new Point(416, 257);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(75, 75);
            btnPow.TabIndex = 25;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 425);
            Controls.Add(btnPow);
            Controls.Add(btnDivide);
            Controls.Add(btnCloseParentheses);
            Controls.Add(btnMinus);
            Controls.Add(btnClear);
            Controls.Add(btnMultiply);
            Controls.Add(btnEquals);
            Controls.Add(btnDot);
            Controls.Add(btnZero);
            Controls.Add(btnPlus);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnDelete);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnOpenParentheses);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(txtbxOperations);
            Name = "CalculatorForm";
            Text = "Expressions Evaluator";
            Load += CalculatorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbxOperations;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnOpenParentheses;
        private Button btnDelete;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnPlus;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnEquals;
        private Button btnDot;
        private Button btnZero;
        private Button btnCloseParentheses;
        private Button btnMinus;
        private Button btnClear;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnPow;
    }
}
