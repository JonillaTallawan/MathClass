namespace Module11Project
{
    partial class frmMath
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
            this.btnByte = new System.Windows.Forms.Button();
            this.btnShort = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnLong = new System.Windows.Forms.Button();
            this.btnFloat = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLeftOperand = new System.Windows.Forms.Label();
            this.lblRightOperand = new System.Windows.Forms.Label();
            this.tbxLeftOperand = new System.Windows.Forms.TextBox();
            this.tbxRightOperand = new System.Windows.Forms.TextBox();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtnSubtract = new System.Windows.Forms.RadioButton();
            this.rbtnMultiply = new System.Windows.Forms.RadioButton();
            this.rbtnDivide = new System.Windows.Forms.RadioButton();
            this.rbtnModulus = new System.Windows.Forms.RadioButton();
            this.gbxMathFunctions = new System.Windows.Forms.GroupBox();
            this.lbLMessage = new System.Windows.Forms.Label();
            this.gbxMathFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnByte
            // 
            this.btnByte.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnByte.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnByte.Location = new System.Drawing.Point(27, 498);
            this.btnByte.Name = "btnByte";
            this.btnByte.Size = new System.Drawing.Size(105, 41);
            this.btnByte.TabIndex = 0;
            this.btnByte.Text = "&Byte";
            this.btnByte.UseVisualStyleBackColor = false;
            this.btnByte.Click += new System.EventHandler(this.btnByte_Click);
            // 
            // btnShort
            // 
            this.btnShort.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnShort.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnShort.Location = new System.Drawing.Point(148, 498);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(105, 41);
            this.btnShort.TabIndex = 1;
            this.btnShort.Text = "&Short";
            this.btnShort.UseVisualStyleBackColor = false;
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // btnInt
            // 
            this.btnInt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnInt.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnInt.Location = new System.Drawing.Point(269, 498);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(105, 41);
            this.btnInt.TabIndex = 2;
            this.btnInt.Text = "&Int";
            this.btnInt.UseVisualStyleBackColor = false;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnLong
            // 
            this.btnLong.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLong.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnLong.Location = new System.Drawing.Point(390, 497);
            this.btnLong.Name = "btnLong";
            this.btnLong.Size = new System.Drawing.Size(105, 41);
            this.btnLong.TabIndex = 3;
            this.btnLong.Text = "&Long";
            this.btnLong.UseVisualStyleBackColor = false;
            this.btnLong.Click += new System.EventHandler(this.btnLong_Click);
            // 
            // btnFloat
            // 
            this.btnFloat.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFloat.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnFloat.Location = new System.Drawing.Point(80, 546);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(105, 41);
            this.btnFloat.TabIndex = 4;
            this.btnFloat.Text = "&Float";
            this.btnFloat.UseVisualStyleBackColor = false;
            this.btnFloat.Click += new System.EventHandler(this.btnFloat_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDouble.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnDouble.Location = new System.Drawing.Point(209, 546);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(105, 41);
            this.btnDouble.TabIndex = 5;
            this.btnDouble.Text = "&Double";
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDecimal.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnDecimal.Location = new System.Drawing.Point(338, 546);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(105, 41);
            this.btnDecimal.TabIndex = 6;
            this.btnDecimal.Text = "De&cimal";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnClear.Location = new System.Drawing.Point(13, 634);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 41);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnExit.Location = new System.Drawing.Point(405, 634);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 41);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLeftOperand
            // 
            this.lblLeftOperand.AutoSize = true;
            this.lblLeftOperand.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblLeftOperand.Location = new System.Drawing.Point(36, 24);
            this.lblLeftOperand.Name = "lblLeftOperand";
            this.lblLeftOperand.Size = new System.Drawing.Size(142, 27);
            this.lblLeftOperand.TabIndex = 9;
            this.lblLeftOperand.Text = "Left Operand";
            // 
            // lblRightOperand
            // 
            this.lblRightOperand.AutoSize = true;
            this.lblRightOperand.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblRightOperand.Location = new System.Drawing.Point(36, 65);
            this.lblRightOperand.Name = "lblRightOperand";
            this.lblRightOperand.Size = new System.Drawing.Size(153, 27);
            this.lblRightOperand.TabIndex = 10;
            this.lblRightOperand.Text = "Right Operand";
            // 
            // tbxLeftOperand
            // 
            this.tbxLeftOperand.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbxLeftOperand.Location = new System.Drawing.Point(229, 24);
            this.tbxLeftOperand.Name = "tbxLeftOperand";
            this.tbxLeftOperand.Size = new System.Drawing.Size(221, 34);
            this.tbxLeftOperand.TabIndex = 11;
            // 
            // tbxRightOperand
            // 
            this.tbxRightOperand.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbxRightOperand.Location = new System.Drawing.Point(230, 65);
            this.tbxRightOperand.Name = "tbxRightOperand";
            this.tbxRightOperand.Size = new System.Drawing.Size(221, 34);
            this.tbxRightOperand.TabIndex = 12;
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdd.Location = new System.Drawing.Point(82, 21);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(41, 24);
            this.rbtnAdd.TabIndex = 13;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "+";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rbtnSubtract
            // 
            this.rbtnSubtract.AutoSize = true;
            this.rbtnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSubtract.Location = new System.Drawing.Point(157, 21);
            this.rbtnSubtract.Name = "rbtnSubtract";
            this.rbtnSubtract.Size = new System.Drawing.Size(37, 24);
            this.rbtnSubtract.TabIndex = 14;
            this.rbtnSubtract.TabStop = true;
            this.rbtnSubtract.Text = "-";
            this.rbtnSubtract.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiply
            // 
            this.rbtnMultiply.AutoSize = true;
            this.rbtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMultiply.Location = new System.Drawing.Point(229, 21);
            this.rbtnMultiply.Name = "rbtnMultiply";
            this.rbtnMultiply.Size = new System.Drawing.Size(37, 24);
            this.rbtnMultiply.TabIndex = 15;
            this.rbtnMultiply.TabStop = true;
            this.rbtnMultiply.Text = "*";
            this.rbtnMultiply.UseVisualStyleBackColor = true;
            // 
            // rbtnDivide
            // 
            this.rbtnDivide.AutoSize = true;
            this.rbtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDivide.Location = new System.Drawing.Point(301, 21);
            this.rbtnDivide.Name = "rbtnDivide";
            this.rbtnDivide.Size = new System.Drawing.Size(36, 24);
            this.rbtnDivide.TabIndex = 16;
            this.rbtnDivide.TabStop = true;
            this.rbtnDivide.Text = "/";
            this.rbtnDivide.UseVisualStyleBackColor = true;
            // 
            // rbtnModulus
            // 
            this.rbtnModulus.AutoSize = true;
            this.rbtnModulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnModulus.Location = new System.Drawing.Point(372, 21);
            this.rbtnModulus.Name = "rbtnModulus";
            this.rbtnModulus.Size = new System.Drawing.Size(46, 24);
            this.rbtnModulus.TabIndex = 17;
            this.rbtnModulus.TabStop = true;
            this.rbtnModulus.Text = "%";
            this.rbtnModulus.UseVisualStyleBackColor = true;
            // 
            // gbxMathFunctions
            // 
            this.gbxMathFunctions.Controls.Add(this.rbtnModulus);
            this.gbxMathFunctions.Controls.Add(this.rbtnDivide);
            this.gbxMathFunctions.Controls.Add(this.rbtnMultiply);
            this.gbxMathFunctions.Controls.Add(this.rbtnSubtract);
            this.gbxMathFunctions.Controls.Add(this.rbtnAdd);
            this.gbxMathFunctions.Location = new System.Drawing.Point(14, 125);
            this.gbxMathFunctions.Name = "gbxMathFunctions";
            this.gbxMathFunctions.Size = new System.Drawing.Size(495, 50);
            this.gbxMathFunctions.TabIndex = 18;
            this.gbxMathFunctions.TabStop = false;
            // 
            // lbLMessage
            // 
            this.lbLMessage.BackColor = System.Drawing.Color.LightYellow;
            this.lbLMessage.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLMessage.Location = new System.Drawing.Point(13, 196);
            this.lbLMessage.Name = "lbLMessage";
            this.lbLMessage.Size = new System.Drawing.Size(497, 264);
            this.lbLMessage.TabIndex = 19;
            this.lbLMessage.Text = "Click A Button";
            this.lbLMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(522, 696);
            this.Controls.Add(this.lbLMessage);
            this.Controls.Add(this.gbxMathFunctions);
            this.Controls.Add(this.tbxRightOperand);
            this.Controls.Add(this.tbxLeftOperand);
            this.Controls.Add(this.lblRightOperand);
            this.Controls.Add(this.lblLeftOperand);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.btnLong);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.btnByte);
            this.Name = "frmMath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Beginning Math Class";
            this.gbxMathFunctions.ResumeLayout(false);
            this.gbxMathFunctions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnByte;
        private System.Windows.Forms.Button btnShort;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnLong;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLeftOperand;
        private System.Windows.Forms.Label lblRightOperand;
        private System.Windows.Forms.TextBox tbxLeftOperand;
        private System.Windows.Forms.TextBox tbxRightOperand;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtnSubtract;
        private System.Windows.Forms.RadioButton rbtnMultiply;
        private System.Windows.Forms.RadioButton rbtnDivide;
        private System.Windows.Forms.RadioButton rbtnModulus;
        private System.Windows.Forms.GroupBox gbxMathFunctions;
        private System.Windows.Forms.Label lbLMessage;
    }
}

