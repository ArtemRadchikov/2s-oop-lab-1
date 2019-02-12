using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab_1
{
    public partial class Form1 : Form
    {

        double Result;
        bool Is_xⁿ;
        double FirstOperand;
        string MemoredValue = "0";
        public bool ResultStatus;

        public Form1()
        {
            InitializeComponent();
        }            

        private void buttonNumber_Clik(object sender, EventArgs e)
        {            
            string InputValue = ((Button)sender).Text;
            if (ResultStatus || textBox1.Text=="0")
            {
                textBox1.Text = InputValue;
                ResultStatus = false;
            }
            else
            {
                try
                {
                    if (textBox1.Text.Length > 20 )
                        throw new Exception("Превышен размер вводимых данных");

                    if (textBox1.Text == "-" && InputValue == "0")
                        throw new Exception("Ввод значения \"0\" не допустим после знака \"-\".");
                    textBox1.Text += InputValue;                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Ошибка ввода");
                }
            }
        }

        private void buttonТegation_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "-";
                    buttonТegation.FlatStyle = FlatStyle.Flat;
                }
                else
                {
                    if(textBox1.Text.First()=='-')
                    {
                        textBox1.Text =new string( textBox1.Text.Skip(1).ToArray());                 
                        buttonТegation.FlatStyle = FlatStyle.Standard;
                    }
                    else
                    {
                        textBox1.Text = "-"+textBox1.Text;
                        buttonТegation.FlatStyle = FlatStyle.Flat;
                    }
                }
            }
            catch(Exception ex)
            {               
                MessageBox.Show(ex.Message,"Ошибка ввода");

            }
        }

        private void button_Dote_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(',') && textBox1.Text.Length<20)
            {
                textBox1.Text += ",";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {                
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "0";
                }
            }
        }



        private void PerformOperation(object sender, EventArgs e)
        {

            try
            {
                Button selected = (Button)sender;
                string OperationName = selected.Text;
                if (!Double.TryParse(textBox1.Text, out double InputValue))
                    throw new Exception("Введены не верные данные");
                               
                switch (OperationName)
                {
                    case "sin":
                        {
                            Result = Math.Sin(InputValue);
                        }
                        break;
                    case "cos":
                        {
                            Result = Math.Cos(InputValue);
                        }
                        break;
                    case "tg":
                        {
                            Result = Math.Tan(InputValue);
                        }
                        break;
                    case "ctg":
                        {
                            Result =1 / Math.Tan(InputValue);
                        }
                        break;
                    case "sec":
                        {
                            Result = 1 / Math.Cos(InputValue);
                        }
                        break;
                    case "csc":
                        {
                            Result =  1 / Math.Sin(InputValue);
                        }
                        break;
                    case "x²":
                        {
                            Result =  Math.Pow(InputValue,2.0);
                        }
                        break;
                    case "x³":
                        {
                            Result =  Math.Pow(InputValue, 3.0);
                        }
                        break;
                    case "√":
                        {
                            if (InputValue <= 0)
                                throw new Exception("Попытка выделения квадратного корня из отрицательного числа.");
                            Result = Math.Sqrt(InputValue);
                        }
                        break;
                    case "∛":
                        {
                            if (InputValue < 0)
                            {
                                Result = (-1) * Math.Pow((-1) * InputValue, 1.0 / 3);
                            }
                            else                            
                                Result = Math.Pow(InputValue, 1.0 / 3.0);
                        }
                        break;
                    case "xⁿ":
                        {
                            FirstOperand = InputValue;
                            Is_xⁿ = true;
                            Result = 0;
                        }
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка вычислений");
                textBox1.Text = "Error";
            }
            finally
            {
                ResultStatus = true;
                if (("" + Result).Length > 20)
                    textBox1.Text = (""+Result).Substring(0,20);
                else
                    textBox1.Text = "" + Result;

            }

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (Is_xⁿ)
            {
                try
                { 
                if (!Double.TryParse(textBox1.Text, out double InputValue))
                    throw new Exception("Введены не верные данные");
                    Result = Math.Pow(FirstOperand, InputValue);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    textBox1.Text = "Error";
                }
                finally
                {
                    ResultStatus = true;
                    if(("" + Result).Length>20)
                        textBox1.Text =(""+ Result).Substring(0,20);
                    else
                        textBox1.Text = "" + Result;
                    Is_xⁿ = false;
                }
            }
        }
        
        private void buttonMemory_Click(object sender, EventArgs e)
        {
            if(ResultStatus)
            {
                MemoredValue = textBox1.Text;
            }
            else
            {
                textBox1.Text = MemoredValue;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
