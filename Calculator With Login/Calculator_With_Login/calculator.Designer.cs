namespace Calculator_With_Login
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnMultiplite = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSign = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnInverse = new System.Windows.Forms.Button();
            this.BtnSqr = new System.Windows.Forms.Button();
            this.BtnSqrRoot = new System.Windows.Forms.Button();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEqual
            // 
            this.BtnEqual.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnEqual.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnEqual.Location = new System.Drawing.Point(185, 373);
            this.BtnEqual.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(62, 52);
            this.BtnEqual.TabIndex = 43;
            this.BtnEqual.Text = "＝";
            this.BtnEqual.UseVisualStyleBackColor = false;
            this.BtnEqual.Click += new System.EventHandler(this.Btn_Equal);
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnPlus.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPlus.Location = new System.Drawing.Point(185, 316);
            this.BtnPlus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(62, 52);
            this.BtnPlus.TabIndex = 42;
            this.BtnPlus.Text = "＋";
            this.BtnPlus.UseVisualStyleBackColor = false;
            this.BtnPlus.Click += new System.EventHandler(this.Btn_Operation);
            // 
            // BtnMinus
            // 
            this.BtnMinus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnMinus.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMinus.Location = new System.Drawing.Point(185, 258);
            this.BtnMinus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(62, 52);
            this.BtnMinus.TabIndex = 41;
            this.BtnMinus.Text = "－";
            this.BtnMinus.UseVisualStyleBackColor = false;
            this.BtnMinus.Click += new System.EventHandler(this.Btn_Operation);
            // 
            // BtnMultiplite
            // 
            this.BtnMultiplite.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnMultiplite.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMultiplite.Location = new System.Drawing.Point(185, 201);
            this.BtnMultiplite.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnMultiplite.Name = "BtnMultiplite";
            this.BtnMultiplite.Size = new System.Drawing.Size(62, 52);
            this.BtnMultiplite.TabIndex = 40;
            this.BtnMultiplite.Text = "×";
            this.BtnMultiplite.UseVisualStyleBackColor = false;
            this.BtnMultiplite.Click += new System.EventHandler(this.Btn_Operation);
            // 
            // BtnDivide
            // 
            this.BtnDivide.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnDivide.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDivide.Location = new System.Drawing.Point(185, 144);
            this.BtnDivide.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(62, 52);
            this.BtnDivide.TabIndex = 39;
            this.BtnDivide.Text = "÷";
            this.BtnDivide.UseVisualStyleBackColor = false;
            this.BtnDivide.Click += new System.EventHandler(this.Btn_Operation);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnClear.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnClear.Location = new System.Drawing.Point(37, 143);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(94, 52);
            this.BtnClear.TabIndex = 38;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.Btn_Arithmetic);
            // 
            // BtnSign
            // 
            this.BtnSign.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnSign.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSign.Location = new System.Drawing.Point(136, 144);
            this.BtnSign.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSign.Name = "BtnSign";
            this.BtnSign.Size = new System.Drawing.Size(45, 52);
            this.BtnSign.TabIndex = 37;
            this.BtnSign.Text = "±";
            this.BtnSign.UseVisualStyleBackColor = false;
            this.BtnSign.Click += new System.EventHandler(this.Btn_Arithmetic);
            // 
            // BtnDot
            // 
            this.BtnDot.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDot.Location = new System.Drawing.Point(136, 373);
            this.BtnDot.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(45, 52);
            this.BtnDot.TabIndex = 36;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.Click += new System.EventHandler(this.Btn_Arithmetic);
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn0.Location = new System.Drawing.Point(37, 373);
            this.Btn0.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(94, 52);
            this.Btn0.TabIndex = 26;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn_Number);
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn9.Location = new System.Drawing.Point(136, 201);
            this.Btn9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(45, 52);
            this.Btn9.TabIndex = 35;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn_Number);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn8.Location = new System.Drawing.Point(87, 201);
            this.Btn8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(45, 52);
            this.Btn8.TabIndex = 34;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn_Number);
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn7.Location = new System.Drawing.Point(37, 201);
            this.Btn7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(45, 52);
            this.Btn7.TabIndex = 33;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn_Number);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn6.Location = new System.Drawing.Point(136, 258);
            this.Btn6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(45, 52);
            this.Btn6.TabIndex = 32;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn_Number);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn5.Location = new System.Drawing.Point(87, 258);
            this.Btn5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(45, 52);
            this.Btn5.TabIndex = 31;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn_Number);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn4.Location = new System.Drawing.Point(37, 258);
            this.Btn4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(45, 52);
            this.Btn4.TabIndex = 30;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn_Number);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn3.Location = new System.Drawing.Point(136, 316);
            this.Btn3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(45, 52);
            this.Btn3.TabIndex = 29;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn_Number);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn2.Location = new System.Drawing.Point(87, 316);
            this.Btn2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(45, 52);
            this.Btn2.TabIndex = 28;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn_Number);
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn1.Location = new System.Drawing.Point(37, 316);
            this.Btn1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(45, 52);
            this.Btn1.TabIndex = 27;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn_Number);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(37, 70);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(210, 43);
            this.textBox1.TabIndex = 44;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Checked = true;
            this.standardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.standardToolStripMenuItem.Text = "&Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.scientificToolStripMenuItem.Text = "S&cientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // BtnInverse
            // 
            this.BtnInverse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnInverse.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnInverse.Location = new System.Drawing.Point(86, 89);
            this.BtnInverse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnInverse.Name = "BtnInverse";
            this.BtnInverse.Size = new System.Drawing.Size(45, 52);
            this.BtnInverse.TabIndex = 48;
            this.BtnInverse.Text = "1/x";
            this.BtnInverse.UseVisualStyleBackColor = false;
            this.BtnInverse.Visible = false;
            // 
            // BtnSqr
            // 
            this.BtnSqr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSqr.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSqr.Location = new System.Drawing.Point(136, 89);
            this.BtnSqr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSqr.Name = "BtnSqr";
            this.BtnSqr.Size = new System.Drawing.Size(111, 53);
            this.BtnSqr.TabIndex = 47;
            this.BtnSqr.Text = " x²";
            this.BtnSqr.UseVisualStyleBackColor = false;
            this.BtnSqr.Visible = false;
            // 
            // BtnSqrRoot
            // 
            this.BtnSqrRoot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSqrRoot.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSqrRoot.Location = new System.Drawing.Point(37, 89);
            this.BtnSqrRoot.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSqrRoot.Name = "BtnSqrRoot";
            this.BtnSqrRoot.Size = new System.Drawing.Size(45, 52);
            this.BtnSqrRoot.TabIndex = 46;
            this.BtnSqrRoot.Text = "√";
            this.BtnSqrRoot.UseVisualStyleBackColor = false;
            this.BtnSqrRoot.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 454);
            this.Controls.Add(this.BtnInverse);
            this.Controls.Add(this.BtnSqr);
            this.Controls.Add(this.BtnSqrRoot);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.BtnMultiplite);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSign);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculator";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnMultiplite;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSign;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button BtnInverse;
        private System.Windows.Forms.Button BtnSqr;
        private System.Windows.Forms.Button BtnSqrRoot;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}