namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_InputOne = new System.Windows.Forms.TextBox();
            this.tb_InputTwo = new System.Windows.Forms.TextBox();
            this.lbl_Equally = new System.Windows.Forms.Label();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_Multiply = new System.Windows.Forms.Button();
            this.btn_Divide = new System.Windows.Forms.Button();
            this.btn_Pow2X = new System.Windows.Forms.Button();
            this.btn_Square = new System.Windows.Forms.Button();
            this.btn_Sin = new System.Windows.Forms.Button();
            this.btn_Cos = new System.Windows.Forms.Button();
            this.btn_PowerXY = new System.Windows.Forms.Button();
            this.btn_PowerXrevY = new System.Windows.Forms.Button();
            this.btn_LogxY = new System.Windows.Forms.Button();
            this.btn_Arccos = new System.Windows.Forms.Button();
            this.btn_Arcsin = new System.Windows.Forms.Button();
            this.btn_Arctg = new System.Windows.Forms.Button();
            this.btn_Tg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_InputOne
            // 
            this.tb_InputOne.Location = new System.Drawing.Point(12, 12);
            this.tb_InputOne.Name = "tb_InputOne";
            this.tb_InputOne.Size = new System.Drawing.Size(100, 20);
            this.tb_InputOne.TabIndex = 0;
            // 
            // tb_InputTwo
            // 
            this.tb_InputTwo.Location = new System.Drawing.Point(118, 12);
            this.tb_InputTwo.Name = "tb_InputTwo";
            this.tb_InputTwo.Size = new System.Drawing.Size(100, 20);
            this.tb_InputTwo.TabIndex = 1;
            // 
            // lbl_Equally
            // 
            this.lbl_Equally.Location = new System.Drawing.Point(225, 12);
            this.lbl_Equally.Name = "lbl_Equally";
            this.lbl_Equally.Size = new System.Drawing.Size(102, 20);
            this.lbl_Equally.TabIndex = 2;
            // 
            // btn_Plus
            // 
            this.btn_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Plus.Location = new System.Drawing.Point(204, 39);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(90, 30);
            this.btn_Plus.TabIndex = 3;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.calculateForTwoArgument);
            // 
            // btn_Minus
            // 
            this.btn_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Minus.Location = new System.Drawing.Point(300, 39);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(90, 30);
            this.btn_Minus.TabIndex = 4;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.calculateForTwoArgument);
            // 
            // btn_Multiply
            // 
            this.btn_Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Multiply.Location = new System.Drawing.Point(204, 76);
            this.btn_Multiply.Name = "btn_Multiply";
            this.btn_Multiply.Size = new System.Drawing.Size(90, 30);
            this.btn_Multiply.TabIndex = 5;
            this.btn_Multiply.Text = "*";
            this.btn_Multiply.UseVisualStyleBackColor = true;
            this.btn_Multiply.Click += new System.EventHandler(this.calculateForTwoArgument);
            // 
            // btn_Divide
            // 
            this.btn_Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Divide.Location = new System.Drawing.Point(300, 76);
            this.btn_Divide.Name = "btn_Divide";
            this.btn_Divide.Size = new System.Drawing.Size(90, 30);
            this.btn_Divide.TabIndex = 6;
            this.btn_Divide.Text = "/";
            this.btn_Divide.UseVisualStyleBackColor = true;
            this.btn_Divide.Click += new System.EventHandler(this.calculateForTwoArgument);
            // 
            // btn_Pow2X
            // 
            this.btn_Pow2X.Location = new System.Drawing.Point(12, 38);
            this.btn_Pow2X.Name = "btn_Pow2X";
            this.btn_Pow2X.Size = new System.Drawing.Size(90, 30);
            this.btn_Pow2X.TabIndex = 7;
            this.btn_Pow2X.Text = "2^x";
            this.btn_Pow2X.UseVisualStyleBackColor = true;
            this.btn_Pow2X.Click += new System.EventHandler(this.calculateForOneArgument);
            // 
            // btn_Square
            // 
            this.btn_Square.Location = new System.Drawing.Point(108, 38);
            this.btn_Square.Name = "btn_Square";
            this.btn_Square.Size = new System.Drawing.Size(90, 30);
            this.btn_Square.TabIndex = 8;
            this.btn_Square.Text = "x^2";
            this.btn_Square.UseVisualStyleBackColor = true;
            this.btn_Square.Click += new System.EventHandler(this.calculateForOneArgument);
            // 
            // btn_Sin
            // 
            this.btn_Sin.Location = new System.Drawing.Point(12, 77);
            this.btn_Sin.Name = "btn_Sin";
            this.btn_Sin.Size = new System.Drawing.Size(90, 30);
            this.btn_Sin.TabIndex = 9;
            this.btn_Sin.Text = "Sin";
            this.btn_Sin.UseVisualStyleBackColor = true;
            this.btn_Sin.Click += new System.EventHandler(this.calculateForOneArgument);
            // 
            // btn_Cos
            // 
            this.btn_Cos.Location = new System.Drawing.Point(108, 77);
            this.btn_Cos.Name = "btn_Cos";
            this.btn_Cos.Size = new System.Drawing.Size(90, 30);
            this.btn_Cos.TabIndex = 10;
            this.btn_Cos.Text = "Cos";
            this.btn_Cos.UseVisualStyleBackColor = true;
            this.btn_Cos.Click += new System.EventHandler(this.calculateForOneArgument);
            // 
            // btn_PowerXY
            // 
            this.btn_PowerXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_PowerXY.Location = new System.Drawing.Point(204, 112);
            this.btn_PowerXY.Name = "btn_PowerXY";
            this.btn_PowerXY.Size = new System.Drawing.Size(90, 30);
            this.btn_PowerXY.TabIndex = 11;
            this.btn_PowerXY.Text = "x^y";
            this.btn_PowerXY.UseVisualStyleBackColor = true;
            this.btn_PowerXY.Click += new System.EventHandler(this.calculateForTwoArgument);
            // 
            // btn_PowerXrevY
            // 
            this.btn_PowerXrevY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_PowerXrevY.Location = new System.Drawing.Point(300, 112);
            this.btn_PowerXrevY.Name = "btn_PowerXrevY";
            this.btn_PowerXrevY.Size = new System.Drawing.Size(90, 30);
            this.btn_PowerXrevY.TabIndex = 12;
            this.btn_PowerXrevY.Text = "X^(1/Y)";
            this.btn_PowerXrevY.UseVisualStyleBackColor = true;
            this.btn_PowerXrevY.Click += new System.EventHandler(this.calculateForTwoArgument);
            // 
            // btn_LogxY
            // 
            this.btn_LogxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_LogxY.Location = new System.Drawing.Point(204, 148);
            this.btn_LogxY.Name = "btn_LogxY";
            this.btn_LogxY.Size = new System.Drawing.Size(90, 30);
            this.btn_LogxY.TabIndex = 13;
            this.btn_LogxY.Text = "Logx(Y)";
            this.btn_LogxY.UseVisualStyleBackColor = true;
            this.btn_LogxY.Click += new System.EventHandler(this.calculateForTwoArgument);
            // 
            // btn_Arccos
            // 
            this.btn_Arccos.Location = new System.Drawing.Point(108, 148);
            this.btn_Arccos.Name = "btn_Arccos";
            this.btn_Arccos.Size = new System.Drawing.Size(90, 30);
            this.btn_Arccos.TabIndex = 14;
            this.btn_Arccos.Text = "Arccos";
            this.btn_Arccos.UseVisualStyleBackColor = true;
            this.btn_Arccos.Click += new System.EventHandler(this.calculateForOneArgument);
            // 
            // btn_Arcsin
            // 
            this.btn_Arcsin.Location = new System.Drawing.Point(12, 148);
            this.btn_Arcsin.Name = "btn_Arcsin";
            this.btn_Arcsin.Size = new System.Drawing.Size(90, 30);
            this.btn_Arcsin.TabIndex = 15;
            this.btn_Arcsin.Text = "Arcsin";
            this.btn_Arcsin.UseVisualStyleBackColor = true;
            this.btn_Arcsin.Click += new System.EventHandler(this.calculateForOneArgument);
            // 
            // btn_Arctg
            // 
            this.btn_Arctg.Location = new System.Drawing.Point(108, 112);
            this.btn_Arctg.Name = "btn_Arctg";
            this.btn_Arctg.Size = new System.Drawing.Size(90, 30);
            this.btn_Arctg.TabIndex = 16;
            this.btn_Arctg.Text = "Arctg";
            this.btn_Arctg.UseVisualStyleBackColor = true;
            this.btn_Arctg.Click += new System.EventHandler(this.calculateForOneArgument);
            // 
            // btn_Tg
            // 
            this.btn_Tg.Location = new System.Drawing.Point(12, 113);
            this.btn_Tg.Name = "btn_Tg";
            this.btn_Tg.Size = new System.Drawing.Size(90, 30);
            this.btn_Tg.TabIndex = 17;
            this.btn_Tg.Text = "Tg";
            this.btn_Tg.UseVisualStyleBackColor = true;
            this.btn_Tg.Click += new System.EventHandler(this.calculateForOneArgument);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 271);
            this.Controls.Add(this.btn_Tg);
            this.Controls.Add(this.btn_Arctg);
            this.Controls.Add(this.btn_Arcsin);
            this.Controls.Add(this.btn_Arccos);
            this.Controls.Add(this.btn_LogxY);
            this.Controls.Add(this.btn_PowerXrevY);
            this.Controls.Add(this.btn_PowerXY);
            this.Controls.Add(this.btn_Cos);
            this.Controls.Add(this.btn_Sin);
            this.Controls.Add(this.btn_Square);
            this.Controls.Add(this.btn_Pow2X);
            this.Controls.Add(this.btn_Divide);
            this.Controls.Add(this.btn_Multiply);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.btn_Plus);
            this.Controls.Add(this.lbl_Equally);
            this.Controls.Add(this.tb_InputTwo);
            this.Controls.Add(this.tb_InputOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_InputOne;
        private System.Windows.Forms.TextBox tb_InputTwo;
        private System.Windows.Forms.Label lbl_Equally;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Multiply;
        private System.Windows.Forms.Button btn_Divide;
        private System.Windows.Forms.Button btn_Pow2X;
        private System.Windows.Forms.Button btn_Square;
        private System.Windows.Forms.Button btn_Sin;
        private System.Windows.Forms.Button btn_Cos;
        private System.Windows.Forms.Button btn_PowerXY;
        private System.Windows.Forms.Button btn_PowerXrevY;
        private System.Windows.Forms.Button btn_LogxY;
        private System.Windows.Forms.Button btn_Arccos;
        private System.Windows.Forms.Button btn_Arcsin;
        private System.Windows.Forms.Button btn_Arctg;
        private System.Windows.Forms.Button btn_Tg;
    }
}

