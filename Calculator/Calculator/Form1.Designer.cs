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
            this.btn_Plus.Location = new System.Drawing.Point(63, 38);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(50, 50);
            this.btn_Plus.TabIndex = 3;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.calculation);
            // 
            // btn_Minus
            // 
            this.btn_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Minus.Location = new System.Drawing.Point(118, 38);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(50, 50);
            this.btn_Minus.TabIndex = 4;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.calculation);
            // 
            // btn_Multiply
            // 
            this.btn_Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Multiply.Location = new System.Drawing.Point(63, 90);
            this.btn_Multiply.Name = "btn_Multiply";
            this.btn_Multiply.Size = new System.Drawing.Size(50, 50);
            this.btn_Multiply.TabIndex = 5;
            this.btn_Multiply.Text = "*";
            this.btn_Multiply.UseVisualStyleBackColor = true;
            this.btn_Multiply.Click += new System.EventHandler(this.calculation);
            // 
            // btn_Divide
            // 
            this.btn_Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Divide.Location = new System.Drawing.Point(118, 90);
            this.btn_Divide.Name = "btn_Divide";
            this.btn_Divide.Size = new System.Drawing.Size(50, 50);
            this.btn_Divide.TabIndex = 6;
            this.btn_Divide.Text = "/";
            this.btn_Divide.UseVisualStyleBackColor = true;
            this.btn_Divide.Click += new System.EventHandler(this.calculation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 162);
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
    }
}

