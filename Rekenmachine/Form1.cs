using System;
using System.Windows.Forms;
using System.Globalization;

namespace Rekenmachine
{
	public partial class Form1 : Form
	{
		char operation;							//char for operation
		string input = string.Empty;            //string storing user input
		string percentageCalc = string.Empty;	//start percentage calc
		string operand1 = string.Empty;			//string storing first operand/input number
		string operand2 = string.Empty;			//string storing second operand/input number
		double result = 0.0;					//calculated result

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) //btnNum1
		{
			txtInput.Text = "";
			input += "1";
			txtInput.Text += input;
		}

		private void btnNum2_Click(object sender, EventArgs e)
		{
			txtInput.Text = "";
			input += "2";
			txtInput.Text += input;
		}
		private void btnNum3_Click(object sender, EventArgs e)
		{
			txtInput.Text = "";
			input += "3";
			txtInput.Text += input;
		}

		private void btnNum4_Click(object sender, EventArgs e)
		{
			txtInput.Text = "";
			input += "4";
			txtInput.Text += input;
		}

		private void btnNum5_Click(object sender, EventArgs e)
		{
			txtInput.Text = "";
			input += "5";
			txtInput.Text += input;
		}

		private void btnNum6_Click(object sender, EventArgs e)
		{
			txtInput.Text = "";
			input += "6";
			txtInput.Text += input;
		}

		private void button9_Click(object sender, EventArgs e) //btnNum7
		{
			txtInput.Text = "";
			input += "7";
			txtInput.Text += input;
		}

		private void btnNum8_Click(object sender, EventArgs e)
		{
			txtInput.Text = "";
			input += "8";
			txtInput.Text += input;
		}

		private void btnNum9_Click(object sender, EventArgs e)
		{
			txtInput.Text = "";
			input += "9";
			txtInput.Text += input;
		}

		private void btnNum0_Click(object sender, EventArgs e)
		{
			txtInput.Text = "";
			input += "0";
			txtInput.Text += input;
			//txtInput.Text = txtInput.Text += "0";
		}

		private void btnDecimal_Click(object sender, EventArgs e)
		{
			txtInput.Text = "";
			input += ".";
			txtInput.Text += input;
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

		private void btnPercentage_Click(object sender, EventArgs e)
		{
			//divide by 100, aka move decimal 2 spots to the left, 120%=1.2  50%=0.5 etc

			txtInput.Text = "";
			input += "%";
			txtInput.Text += input;


		}

		private void btnEqual_Click(object sender, EventArgs e)
		{

			if (input.Contains("%"))
			{

				string inputP = input.TrimEnd('%');
				double.TryParse(inputP, out double percentage);
				double result = Math.Round(percentage / 100, 2);
				txtInput.Text = result.ToString();

			}

			else
			{
				operand2 = input;
				double num1, num2;
				double.TryParse(operand1, out num1);
				double.TryParse(operand2, out num2);

				txtInput.Text = "";
				input = string.Empty;
				operand1 = string.Empty;
				operand2 = string.Empty;

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
			

			
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtInput.Text = "";
			input = string.Empty;
			operand1 = string.Empty;
			operand2 = string.Empty;

		}

		private void btnEuro_Click(object sender, EventArgs e)
		{
			var culture = CultureInfo.CreateSpecificCulture("nl-NL");
			decimal decResult = (decimal)result;
			this.txtInput.Text = "";
			//txtInput.Text = txtInput.Text += "€" + decResult.ToString("N"); 
			txtInput.Text = decResult.ToString("C", culture);

		}

		private void txtInput_TextChanged(object sender, EventArgs e)
		{

		}
	}
}