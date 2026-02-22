using System.Xml.Linq;
using System.Windows.Forms;
using System.IO;

namespace Project_Tracker
{
    public partial class Form1 : Form
    {
        //We first create two arrays to hold the project names and their corresponding details.
        string[] projects = new string[0];
        string[] details = new string[0];
        string namesFile = "ProjectNames.txt";
        string combinedFile = "FullData.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //we check if the user has entered values in both text boxes. If not, we throw an exception to prompt the user to fill in the required fields
                if (string.IsNullOrWhiteSpace(txtProjectName.Text) || string.IsNullOrWhiteSpace(txtData.Text))
                {
                    throw new Exception("Please fill in both fields.");
                }

                //Here we resize the arrays to accommodate the new project and its details. We use Array.Resize to increase the size of both arrays by one
                Array.Resize(ref projects, projects.Length + 1);
                Array.Resize(ref details, details.Length + 1);

                //If the input is valid, we add the new project name and its details to the respective arrays at the last index (which is now available after resizing)
                projects[projects.Length - 1] = txtProjectName.Text;
                details[details.Length - 1] = txtData.Text;
                //Here we send the updated arrays to the UpdateDisplay method, which will refresh the ListBox to show the new project and its details. 
                UpdateDisplay();
                ClearInputs();
            }//If there's an error we catch it and display a message
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {//Now we do the opposite of adding a project
            try
            {   //First we grab what part of the list the user wants to delete.
                int selectedIndex = lstProjects.SelectedIndex;
                //Safety if they press the button without selecting a project
                if (selectedIndex == -1)
                {
                    throw new Exception("Please select a project to remove.");
                }

                //Now we take away the selected project from the array.
                for (int i = selectedIndex; i < projects.Length - 1; i++)
                {
                    projects[i] = projects[i + 1];
                    details[i] = details[i + 1];
                }
                //Next we resize the arrays to remove the last element
                Array.Resize(ref projects, projects.Length - 1);
                Array.Resize(ref details, details.Length - 1);
                //Gotta update! We call the UpdateDisplay function again to refresh the ListBox
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateDisplay()
        {//Here we have a loop that goes through the projects and details arrays and adds each project along with its details to the ListBox. We clear the ListBox first to avoid duplicates before adding the updated list of projects.
            lstProjects.Items.Clear();
            for (int i = 0; i < projects.Length; i++)
            {
                lstProjects.Items.Add($"{projects[i]} - ({details[i]})");
            }
        }

        private void ClearInputs()
        {//This is for when after the user hits the add button, we want to clear the text boxes and set the focus back to the project name text box for convenience.
            txtProjectName.Clear();
            txtData.Clear();
            txtProjectName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Here we create a file to save the project names and another file to save the combined data
                File.WriteAllLines(namesFile, projects);

                //Using a loop we read off what's in the array and rewrite it into a text file.
                string[] combinedData = new string[projects.Length];
                for (int i = 0; i < projects.Length; i++)
                {
                    combinedData[i] = $"{projects[i]} | Due: {details[i]}";
                }
                File.WriteAllLines(combinedFile, combinedData);
                //I user feedback message to let them know the data was saved successfully
                MessageBox.Show("Data saved successfully to separate files!", "Success");
            }
            catch (IOException ex)
            {//if something goes wrong with the file writing process, we catch the exception and display an error message to the user.
                MessageBox.Show($"File error: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {//first we look for the combined file.
                if (!File.Exists(combinedFile))
                {
                    throw new FileNotFoundException("No saved data found.");
                }

                //Here we create a new array by reading the text written in the combined file.
                string[] lines = File.ReadAllLines(combinedFile);

                //we count how many lines there are in the file. This will determine how big we need to make our arrays to hold the data.
                projects = new string[lines.Length];
                details = new string[lines.Length];

                for (int i = 0; i < lines.Length; i++)
                {
                    //using a loop we go through each line of the file and split it into the project name and its details
                    string[] parts = lines[i].Split(new string[] { " | Due: " }, StringSplitOptions.None);
                    if (parts.Length == 2)
                    {
                        projects[i] = parts[0];
                        details[i] = parts[1];
                    }
                }

                UpdateDisplay();
                MessageBox.Show("Data loaded into the application!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Load error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
