using System.ComponentModel;
using System.Text.Json;
using System.IO;

namespace Music_Library
{
    public partial class MusicLibrary : Form
    {
        public MusicLibrary()
        {//When the form first loads, we want to set up our UI and data bindings. Mainly we set up our combo boxes with placeholder text and options,
         //and we bind our DataGridView to our music library list.
            InitializeComponent();
            txtTitle.PlaceholderText = "Title";//This is shows gray text when the box is empty, giving users a hint about what to enter.
            txtArtist.PlaceholderText = "Artist";
            txtAlbum.PlaceholderText = "Album";
            cmbGenre.Items.Add("Genre");//The first item is a non-selectable placeholder, so we can check if the user has made a valid selection.
            cmbGenre.Items.Add("Rock");//Here we add our actual genre options that users can select from.
            cmbGenre.Items.Add("Pop");
            cmbGenre.Items.Add("Jazz");
            cmbGenre.Items.Add("Electronic");
            cmbGenre.SelectedIndex = 0;
            cmbGenre.ForeColor = Color.Gray;
            dgvLibrary.DataSource = musicLibrary;
            comboSort.Items.Add("Title");
            comboSort.Items.Add("Artist");
            comboSort.Items.Add("Album");
            comboSort.Items.Add("Genre");
            comboSort.SelectedIndex = 0; // Default to Title
        }
        Random rng = new Random();//We create a Random variable for future use in other functions

        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {//just a text color change for when the user selects a genre, so they can easily see if they've made a valid selection or not
            if (cmbGenre.SelectedIndex > 0)
                cmbGenre.ForeColor = Color.Black;
            else
                cmbGenre.ForeColor = Color.Gray;
        }

        public class Song
        {//We grab the text inputted by the user and store it
            public string Title { get; set; }
            public string Artist { get; set; }
            public string Album { get; set; }
            public string Genre { get; set; }
        }

        BindingList<Song> musicLibrary = new BindingList<Song>();//This is our main data structure for storing songs

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbGenre.SelectedIndex <= 0)//safety check to make sure the user has selected a valid genre before we add the song to our library
            {
                MessageBox.Show("Please select a valid genre.");
                return;
            }
            musicLibrary.Add(new Song//We create a new Song object with the user's input and add it to our music library list
            {
                Title = txtTitle.Text,
                Artist = txtArtist.Text,
                Album = txtAlbum.Text,
                Genre = cmbGenre.Text
            });
            ClearInputs();//Clear the input fields after adding the song
        }

        private void btnSort_Click(object sender, EventArgs e)
        {//Here we sort the music using if statements to determine which property to sort by based on the user's selection in the combo box. We use LINQ's OrderBy to create a new sorted list
            List<Song> sorted;
            string choice = comboSort.SelectedItem.ToString();

            if (choice == "Artist") sorted = musicLibrary.OrderBy(s => s.Artist).ToList();
            else if (choice == "Album") sorted = musicLibrary.OrderBy(s => s.Album).ToList();
            else if (choice == "Genre") sorted = musicLibrary.OrderBy(s => s.Genre).ToList();
            else sorted = musicLibrary.OrderBy(s => s.Title).ToList();
            musicLibrary.Clear();
            foreach (var s in sorted) musicLibrary.Add(s);
            musicLibrary.ResetBindings();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {//here we shuffle the music library using the Fisher-Yates algorithm.
         //We first convert our BindingList to a regular List so we can shuffle it, then we clear our original list and add the shuffled songs back in,
         //finally we reset the bindings to update the DataGridView.
            if (musicLibrary.Count < 2) return;
            List<Song> shuffledList = musicLibrary.ToList();
            int n = shuffledList.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Song value = shuffledList[k];
                shuffledList[k] = shuffledList[n];
                shuffledList[n] = value;
            }
            dgvLibrary.DataSource = null;
            musicLibrary.Clear();
            foreach (var s in shuffledList)
            {
                musicLibrary.Add(s);
            }
            dgvLibrary.DataSource = musicLibrary;
        }
        private void ClearInputs()
        {//This function clears out the text boxes and can be called and we set the genre back to 0
            txtTitle.Clear();
            txtArtist.Clear();
            txtAlbum.Clear();
            if (cmbGenre.Items.Count > 0)
            {
                cmbGenre.SelectedIndex = 0;
                cmbGenre.ForeColor = Color.Gray;
            }
            txtTitle.Focus();
        }
        private void btnPopOut_Click_1(object sender, EventArgs e)
        {//This button creates a new instance of the LibraryPopup form
            LibraryPopup popup = new LibraryPopup(musicLibrary);
            popup.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {//When the user clicks the save button, we call our SaveLibrary function to write the current state of our music library to a file in JSON format.
            SaveLibrary();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {//When the user clicks the load button, we call our LoadLibrary function to read the music library from the file and update our BindingList and DataGridView accordingly.
            LoadLibrary();
        }

        private void SaveLibrary()
        {//Here we save the music library to a file
            string filePath = "music_library.json";
            string jsonString = JsonSerializer.Serialize(musicLibrary);
            File.WriteAllText(filePath, jsonString);
        }

        private void LoadLibrary()
        {//Here we load the music library from a file, we check if the file exists first to avoid errors
            string filePath = "music_library.json";
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                List<Song> savedSongs = JsonSerializer.Deserialize<List<Song>>(jsonString);
                musicLibrary.Clear();
                foreach (var song in savedSongs)
                {
                    musicLibrary.Add(song);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {//This function allows the user to delete a selected song from the library. For safety we ask the user if they're sure
            if (dgvLibrary.CurrentRow != null)
            {
                int selectedIndex = dgvLibrary.CurrentRow.Index;
                var result = MessageBox.Show("Are you sure you want to delete this song?",
                                            "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    musicLibrary.RemoveAt(selectedIndex);
                    SaveLibrary();
                }
            }
            else
            {
                MessageBox.Show("Please select a song in the list to delete.");
            }
        }
    }
}
