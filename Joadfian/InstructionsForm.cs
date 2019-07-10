using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joadfian
{
    public partial class InstructionsForm : Form
    {
        public InstructionsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxInstructions.Text =
                "1. Type the desired word/phrase in the 'Keyword Search' textbox, separating each word/phrase with a comma." +
                Environment.NewLine +
                "2. Click on the 'Search' button to begin searching." +
                Environment.NewLine + Environment.NewLine +
                "After the wait dialogue disappears, the list of job advertisements that matched one or more of the keywords" +
                " will appear on the list view. The 'Most Common Words' result will also appear in its designated textbox.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxInstructions.Text =
                "1. Double click on the job advertisement in the list view." +
                Environment.NewLine + Environment.NewLine +
                "A new window will appear to show the job and company information in separate tabs.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxInstructions.Text =
                "1. Type in the desired word/phrase in the 'Count specific words/phrases' textbox, " +
                "separating each word/phrase with a comma." + Environment.NewLine +
                "2. Click on the 'Count' button to begin searching." +
                "The results will appear in the textbox below.";
        }
    }
}
