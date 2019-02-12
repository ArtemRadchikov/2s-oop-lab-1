namespace oop_lab_1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonTg = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonCtg = new System.Windows.Forms.Button();
            this.buttonSec = new System.Windows.Forms.Button();
            this.buttonCsc = new System.Windows.Forms.Button();
            this.buttonТegation = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_Dote = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRoot2 = new System.Windows.Forms.Button();
            this.buttonRoot3 = new System.Windows.Forms.Button();
            this.buttonX3 = new System.Windows.Forms.Button();
            this.buttonX2 = new System.Windows.Forms.Button();
            this.buttonxⁿ = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonMemory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(15, 12);
            this.textBox1.MaxLength = 21;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonTg
            // 
            this.buttonTg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTg.Location = new System.Drawing.Point(15, 157);
            this.buttonTg.Name = "buttonTg";
            this.buttonTg.Size = new System.Drawing.Size(60, 40);
            this.buttonTg.TabIndex = 2;
            this.buttonTg.Text = "tg";
            this.buttonTg.UseVisualStyleBackColor = true;
            this.buttonTg.Click += new System.EventHandler(this.PerformOperation);
            // 
            // buttonCos
            // 
            this.buttonCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCos.Location = new System.Drawing.Point(15, 111);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(60, 40);
            this.buttonCos.TabIndex = 3;
            this.buttonCos.Text = "cos";
            this.buttonCos.UseVisualStyleBackColor = true;
            this.buttonCos.Click += new System.EventHandler(this.PerformOperation);
            // 
            // buttonSin
            // 
            this.buttonSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSin.Location = new System.Drawing.Point(15, 65);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(60, 40);
            this.buttonSin.TabIndex = 4;
            this.buttonSin.Text = "sin";
            this.buttonSin.UseVisualStyleBackColor = true;
            this.buttonSin.Click += new System.EventHandler(this.PerformOperation);
            // 
            // buttonCtg
            // 
            this.buttonCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCtg.Location = new System.Drawing.Point(15, 203);
            this.buttonCtg.Name = "buttonCtg";
            this.buttonCtg.Size = new System.Drawing.Size(60, 40);
            this.buttonCtg.TabIndex = 5;
            this.buttonCtg.Text = "ctg";
            this.buttonCtg.UseVisualStyleBackColor = true;
            this.buttonCtg.Click += new System.EventHandler(this.PerformOperation);
            // 
            // buttonSec
            // 
            this.buttonSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSec.Location = new System.Drawing.Point(15, 248);
            this.buttonSec.Name = "buttonSec";
            this.buttonSec.Size = new System.Drawing.Size(60, 40);
            this.buttonSec.TabIndex = 6;
            this.buttonSec.Text = "sec";
            this.buttonSec.UseVisualStyleBackColor = true;
            this.buttonSec.Click += new System.EventHandler(this.PerformOperation);
            // 
            // buttonCsc
            // 
            this.buttonCsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCsc.Location = new System.Drawing.Point(15, 294);
            this.buttonCsc.Name = "buttonCsc";
            this.buttonCsc.Size = new System.Drawing.Size(60, 40);
            this.buttonCsc.TabIndex = 7;
            this.buttonCsc.Text = "csc";
            this.buttonCsc.UseVisualStyleBackColor = true;
            this.buttonCsc.Click += new System.EventHandler(this.PerformOperation);
            // 
            // buttonТegation
            // 
            this.buttonТegation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonТegation.Location = new System.Drawing.Point(81, 295);
            this.buttonТegation.Name = "buttonТegation";
            this.buttonТegation.Size = new System.Drawing.Size(45, 40);
            this.buttonТegation.TabIndex = 23;
            this.buttonТegation.Text = "-";
            this.buttonТegation.UseVisualStyleBackColor = true;
            this.buttonТegation.Click += new System.EventHandler(this.buttonТegation_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(132, 294);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(45, 40);
            this.button0.TabIndex = 22;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonNumber_Clik);
            // 
            // button_Dote
            // 
            this.button_Dote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Dote.Location = new System.Drawing.Point(183, 294);
            this.button_Dote.Name = "button_Dote";
            this.button_Dote.Size = new System.Drawing.Size(45, 40);
            this.button_Dote.TabIndex = 21;
            this.button_Dote.Text = ",";
            this.button_Dote.UseVisualStyleBackColor = true;
            this.button_Dote.Click += new System.EventHandler(this.button_Dote_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(183, 157);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 40);
            this.button9.TabIndex = 20;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonNumber_Clik);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(132, 157);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 40);
            this.button8.TabIndex = 19;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonNumber_Clik);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(81, 157);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 40);
            this.button7.TabIndex = 18;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonNumber_Clik);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(183, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 40);
            this.button6.TabIndex = 16;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonNumber_Clik);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(132, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 40);
            this.button5.TabIndex = 17;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonNumber_Clik);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(81, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 40);
            this.button4.TabIndex = 15;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonNumber_Clik);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(183, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 40);
            this.button3.TabIndex = 14;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonNumber_Clik);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(132, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonNumber_Clik);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(81, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNumber_Clik);
            // 
            // buttonRoot2
            // 
            this.buttonRoot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRoot2.Location = new System.Drawing.Point(81, 66);
            this.buttonRoot2.Name = "buttonRoot2";
            this.buttonRoot2.Size = new System.Drawing.Size(60, 39);
            this.buttonRoot2.TabIndex = 24;
            this.buttonRoot2.Text = "√";
            this.buttonRoot2.UseVisualStyleBackColor = true;
            this.buttonRoot2.Click += new System.EventHandler(this.PerformOperation);
            // 
            // buttonRoot3
            // 
            this.buttonRoot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRoot3.Location = new System.Drawing.Point(147, 66);
            this.buttonRoot3.Name = "buttonRoot3";
            this.buttonRoot3.Size = new System.Drawing.Size(60, 39);
            this.buttonRoot3.TabIndex = 25;
            this.buttonRoot3.Text = "∛";
            this.buttonRoot3.UseVisualStyleBackColor = true;
            this.buttonRoot3.Click += new System.EventHandler(this.PerformOperation);
            // 
            // buttonX3
            // 
            this.buttonX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonX3.Location = new System.Drawing.Point(132, 111);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(45, 40);
            this.buttonX3.TabIndex = 26;
            this.buttonX3.Text = "x³";
            this.buttonX3.UseVisualStyleBackColor = true;
            this.buttonX3.Click += new System.EventHandler(this.PerformOperation);
            // 
            // buttonX2
            // 
            this.buttonX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonX2.Location = new System.Drawing.Point(81, 111);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(45, 40);
            this.buttonX2.TabIndex = 27;
            this.buttonX2.Text = "x²";
            this.buttonX2.UseVisualStyleBackColor = true;
            this.buttonX2.Click += new System.EventHandler(this.PerformOperation);
            // 
            // buttonxⁿ
            // 
            this.buttonxⁿ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonxⁿ.Location = new System.Drawing.Point(183, 111);
            this.buttonxⁿ.Name = "buttonxⁿ";
            this.buttonxⁿ.Size = new System.Drawing.Size(45, 40);
            this.buttonxⁿ.TabIndex = 28;
            this.buttonxⁿ.Text = "xⁿ";
            this.buttonxⁿ.UseVisualStyleBackColor = true;
            this.buttonxⁿ.Click += new System.EventHandler(this.PerformOperation);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEqual.Location = new System.Drawing.Point(234, 203);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(45, 131);
            this.buttonEqual.TabIndex = 29;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Red;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(213, 66);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(66, 40);
            this.buttonClear.TabIndex = 30;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonMemory
            // 
            this.buttonMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMemory.Location = new System.Drawing.Point(234, 111);
            this.buttonMemory.Name = "buttonMemory";
            this.buttonMemory.Size = new System.Drawing.Size(45, 86);
            this.buttonMemory.TabIndex = 31;
            this.buttonMemory.Text = "M";
            this.buttonMemory.UseVisualStyleBackColor = true;
            this.buttonMemory.Click += new System.EventHandler(this.buttonMemory_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(292, 351);
            this.Controls.Add(this.buttonMemory);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonxⁿ);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonRoot3);
            this.Controls.Add(this.buttonRoot2);
            this.Controls.Add(this.buttonТegation);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button_Dote);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCsc);
            this.Controls.Add(this.buttonSec);
            this.Controls.Add(this.buttonCtg);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonTg);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(308, 390);
            this.MinimumSize = new System.Drawing.Size(308, 390);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тригонометрическо-степенной калькулятор для вещественных";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonTg;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonCtg;
        private System.Windows.Forms.Button buttonSec;
        private System.Windows.Forms.Button buttonCsc;
        private System.Windows.Forms.Button buttonТegation;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_Dote;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRoot2;
        private System.Windows.Forms.Button buttonRoot3;
        private System.Windows.Forms.Button buttonX3;
        private System.Windows.Forms.Button buttonX2;
        private System.Windows.Forms.Button buttonxⁿ;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonMemory;
    }
}

