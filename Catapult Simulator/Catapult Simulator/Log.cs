using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Catapult_Simulator
{
    public partial class Launch_Outcome : Form
    {
        public Launch_Outcome()
        {
            InitializeComponent();
        }

        public Launch_Outcome(string fullLog)
        {
            InitializeComponent();
            richTextBox.Text = fullLog; // Put the history into the text box
        }
    }
}
