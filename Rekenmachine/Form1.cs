using System;
using System.Windows.Forms;

namespace Rekenmachine
{
	public partial class Form1 : Form
	{
		char operation;					//char for operation
		string input = string.Empty;	//string storing user input
		string operand1 = string.Empty; //string storing first operand/input number
		string operand2 = string.Empty; //string storing second operand/input number
		double result = 0.0;            //calculated result

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) //btnNum1
		{
			this.txtInput.Text = "";
			input += "1";
			this.txtInput.Text += input;
		}

		private void btnNum2_Click(object sender, EventArgs e)
		{
			this.txtInput.Text = "";
			input += "2";
			this.txtInput.Text += input;
		}
		private void btnNum3_Click(object sender, EventArgs e)
		{
			this.txtInput.Text = "";
			input += "3";
			this.txtInput.Text += input;
		}

		private void btnNum4_Click(object sender, EventArgs e)
		{
			this.txtInput.Text = "";
			input += "4";
			this.txtInput.Text += input;
		}

		private void btnNum5_Click(object sender, EventArgs e)
		{
			this.txtInput.Text = "";
			input += "5";
			this.txtInput.Text += input;
		}

		private void btnNum6_Click(object sender, EventArgs e)
		{
			this.txtInput.Text = "";
			input += "6";
			this.txtInput.Text += input;
		}

		private void button9_Click(object sender, EventArgs e) //btnNum7
		{
			this.txtInput.Text = "";
			input += "7";
			this.txtInput.Text += input;
		}

		private void btnNum8_Click(object sender, EventArgs e)
		{
			this.txtInput.Text = "";
			input += "8";
			this.txtInput.Text += input;
		}

		private void btnNum9_Click(object sender, EventArgs e)
		{
			this.txtInput.Text = "";
			input += "9";
			this.txtInput.Text += input;
		}

		private void btnNum0_Click(object sender, EventArgs e)
		{
			txtInput.Text = txtInput.Text += "0";
		}

		private void btnDecimal_Click(object sender, EventArgs e)
		{
			this.txtInput.Text = "";
			input += ".";
			this.txtInput.Text += input;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			operand1 = input;
			operation = '+';
			input = string.Empty;
		}

		private void btnSubtract_Click(object sender, EventArgs e)
		{
			operand1 = input;
			operation = '-';
			input = string.Empty;
		}

		private void btnMultiply_Click(object sender, EventArgs e)
		{
			operand1 = input;
			operation = '*';
			input = string.Empty;
		}

		private void btnDivide_Click(object sender, EventArgs e)
		{
			operand1 = input;
			operation = '/';
			input = string.Empty;
		}

		private void btnEqual_Click(object sender, EventArgs e)
		{
			operand2 = input;
			double num1, num2;
            double.TryParse(operand1, out num1);
			double.TryParse(operand2, out num2);

			this.txtInput.Text = "";
			this.input = string.Empty;
			this.operand1 = string.Empty;
			this.operand2 = string.Empty;

			if (operation == '+')
			{
				result = num1 + num2;
				txtInput.Text = result.ToString();
            }
			else if (operation == '-')
			{
				result = num1 - num2;
				txtInput.Text = result.ToString();
			}
			else if (operation == '*')
			{
				result = num1 * num2;
				txtInput.Text = result.ToString();
			}
			else if (operation == '/')
			{
				if (num2 != 0)
				{
					result = num1 / num2;
					txtInput.Text = result.ToString();

				}
				else
                {
					txtInput.Text = "cannot devide by 0";
                }
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			this.txtInput.Text = "";
			this.input = string.Empty;
			this.operand1 = string.Empty;
			this.operand2 = string.Empty;
		}

		private void btnPercentage_Click(object sender, EventArgs e)
		{

		}

		private void btnEuro_Click(object sender, EventArgs e)
		{
			decimal decResult = (decimal)result;
			this.txtInput.Text = "";
			txtInput.Text = txtInput.Text += "€" + decResult;   //iets doen om resultaat te printen met $xx,yy  (https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#currency-format-specifier-c)

		}

		private void txtInput_TextChanged(object sender, EventArgs e)
		{

		}
	}
}