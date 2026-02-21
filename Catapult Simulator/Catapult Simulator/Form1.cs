using static System.Windows.Forms.DataFormats;

namespace Catapult_Simulator
{
    public partial class Form1 : Form
    {
        // This string will hold the history of all launches, which we will pass to the log form when the user wants to view it. It starts with a header for clarity.
        private string logHistory = "--- Catapult Launch Log ---\n";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Watermelon_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            //Here we a Generate Random Distances (in meters)
            int targetDistance = rand.Next(50, 201);    // Target is between 50 and 200m
            int distanceTraveled = rand.Next(30, 221); // Shot flies between 30 and 220m

            // Here we determine Hit or Miss
            // We'll give a "hit" a margin of error (e.g., within 5 meters)
            int marginOfError = 5;
            int difference = distanceTraveled - targetDistance;
            bool isHit = Math.Abs(difference) <= marginOfError;
            string timestamp = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            //Here we output the results to the user
            string resultMessage = $"Target Distance: {targetDistance}m\n" +
                                   $"Object Traveled: {distanceTraveled}m\n";

            //We check if the shot falls in the margin of error to determine if it's a hit or miss, and construct the appropriate message
            if (isHit)
            {
                resultMessage += "RESULT: Direct Hit! 🎯";
            }
            else
            {
                string direction = difference > 0 ? "over-shot" : "fell short";
                resultMessage += $"RESULT: Missed! You {direction} by {Math.Abs(difference)}m.";
            }

            //Upon every hit of the button we send the results to the log
            label4.Text = resultMessage;
            logHistory += resultMessage + "\n" + $"[{timestamp}] \n" + "\n------------------\n";
        }

        private void Bolder_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            //The bolder will be similar to the watermelon but with a much larger margin of error, as it's heavier and can most likely hit the target
            int targetDistance = rand.Next(50, 200);
            int distanceTraveled = rand.Next(30, 220);

            int marginOfError = 50;
            int difference = distanceTraveled - targetDistance;
            bool isHit = Math.Abs(difference) <= marginOfError;
            string timestamp = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");  
            string resultMessage = $"Target Distance: {targetDistance}m\n" +
                                   $"Object Traveled: {distanceTraveled}m\n";

            if (isHit)
            {
                resultMessage += "RESULT: Direct Hit! 🎯";
            }
            else
            {
                string direction = difference > 0 ? "over-shot" : "fell short";
                resultMessage += $"RESULT: Missed! You {direction} by {Math.Abs(difference)}m.";
            }

            label4.Text = resultMessage;
            logHistory += resultMessage + "\n" + $"[{timestamp}] \n" + "\n------------------\n";
        }

        private void Pie_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            //The pie will be the most unpredictable, as it's light and can be easily affected by wind or other factors, so it will have a very small margin of error
            int targetDistance = rand.Next(50, 200);    
            int distanceTraveled = rand.Next(30, 220); 
            int marginOfError = 2;
            int difference = distanceTraveled - targetDistance;
            bool isHit = Math.Abs(difference) <= marginOfError;
            string timestamp = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            string resultMessage = $"Target Distance: {targetDistance}m\n" +
                                   $"Object Traveled: {distanceTraveled}m\n";

            if (isHit)
            {
                resultMessage += "RESULT: Direct Hit! 🎯";
            }
            else
            {
                string direction = difference > 0 ? "over-shot" : "fell short";
                resultMessage += $"RESULT: Missed! You {direction} by {Math.Abs(difference)}m.";
            }

            label4.Text = resultMessage;
            logHistory += resultMessage + "\n" + $"[{timestamp}] \n" + "\n------------------\n";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //The clear button will clear the current result from the screen, but it will not clear the log history, as that is meant to be a record of all launches
            label4.Text = "";
        }

        private void LogMenu_Click(object sender, EventArgs e)
        {
            //Here we create the log form and pass the current history to it
            Launch_Outcome logWindow = new Launch_Outcome(logHistory);

            //ShowDialog makes it a pop-up that you must close to return to the game
            logWindow.ShowDialog();
        }
    }
}
