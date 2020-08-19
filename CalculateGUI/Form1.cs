using ClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateGUI
{/// <summary>
/// Form GUI Class
/// </summary>
    public partial class Form1 : Form
    {
        private readonly IOperations Execute;
        double firstNumb = 0;
        double secondNumb = 0;
        string operation = "";
        /// <summary>
        /// Constructor for the form
        /// It takes an instance of the Interface as a parameter
        /// </summary>
        /// <param name="executable"></param>
        public Form1(IOperations executable)
        {
            InitializeComponent();
            this.Execute = executable;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBoxResult.Text == "0" && button.Text != ".")
            {
                textBoxResult.Clear();
            }
            if (textBoxResult.Text.Contains(".") && button.Text ==".")
            {
                return;

            }
            if (button.Text == "+/-")
            {
                double neg = double.Parse(textBoxResult.Text);
                textBoxResult.Text =(neg * -1).ToString();
                return;
            }
            textBoxResult.Text = textBoxResult.Text + button.Text;



        }
        /// <summary>
        /// It clears the text box on click event.
        /// Clears the first number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }
        /// <summary>
        /// Click event for the operators +, -, *, /
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickOperator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            operation = button.Text;
            firstNumb = double.Parse(textBoxResult.Text);
            textBoxResult.Text = "0";
        }
        /// <summary>
        /// It cancels the text box on click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCanc(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            
        }
        /// <summary>
        /// It calls the execute method in the Operations class
        /// Checks the type of operation to be carried out
        /// Performs the operations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            secondNumb = double.Parse(textBoxResult.Text);
           textBoxResult.Text= Execute.Calculate(firstNumb.ToString(), secondNumb.ToString(), operation);
            
        }
    }
}
