namespace My_First_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//We use a if statement to make sure thge text boxes have numbers in them
            if (double.TryParse(textBox1.Text, out double num1) && //Here we get the number from Text Box 1. 
                double.TryParse(textBox2.Text, out double num2))   //Here we get the number from Text Box 2
            {
                label1.Text = "+"; //I have a label in-between the two text boxes to show the user what they pressed
                double result = num1 + num2;//here we perform the math of both text boxes while also putting the solution into a variable
                label2.Text = "Result: " + result.ToString();//Here we create a text to output into the label 2 text by also transfering the result variable into string
            }
            else//incase the inputed text is not a number a message pops up to put a real number
            {
                MessageBox.Show("Please enter valid numbers!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//most of this is repeated from the addition but changed into a subtraction function
            if (double.TryParse(textBox1.Text, out double num1) &&
                double.TryParse(textBox2.Text, out double num2))
            {
                label1.Text = "-";
                double result = num1 - num2;
                label2.Text = "Result: " + result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//another reapeat of the addition and subtraction but changed to multiplication
            if (double.TryParse(textBox1.Text, out double num1) &&
                double.TryParse(textBox2.Text, out double num2))
            {
                label1.Text = "x";
                double result = num1 * num2;
                label2.Text = "Result: " + result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {//This is a repeat but with an added safety check!
            if (double.TryParse(textBox1.Text, out double num1) &&
                double.TryParse(textBox2.Text, out double num2))
            {
                double result = num1 / num2;
                if (num2 != 0)//I added a 0 check because no number can be divided by "0". If it passes then it can continue
                {
                    label1.Text = "/";
                    
                    label2.Text = "Result: " + result.ToString();
                }
                else
                {
                    label2.Text = "Cannot divide by zero!";//Tells the user to fix the issue
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers!");
            }
        }
    }
}
