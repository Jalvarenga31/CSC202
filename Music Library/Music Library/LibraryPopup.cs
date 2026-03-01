using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Music_Library.MusicLibrary;

namespace Music_Library
{
    public partial class LibraryPopup : Form
    {
        public LibraryPopup()
        {
            InitializeComponent();
        }

        private BindingList<Song> _songs;

        public LibraryPopup(BindingList<Song> musicLibrary)
        {
            InitializeComponent();
            _songs = musicLibrary;
            dgvPopup.DataSource = _songs;
        }

        private void LibraryPopup_Load(object sender, EventArgs e)
        {

        }
    }
}
