using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Joadfian
{
    public partial class MainForm : Form
    {
        string cmdText;
        WaitDialogue dialogue;
        DataTable jobAdsBackup;
        Dictionary<string, int> wordCountDict = new Dictionary<string, int>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void clearResultTSMI_Click(object sender, EventArgs e)
        {
            keywordTextBox.Clear();
            jobsFoundLabel.Text = "0 jobs found.";
            resultsListView.Items.Clear();
            topHundredWords.Clear();
            specificWordTextBox.Clear();
            specificWordCount.Clear();
        }

        private void instructionsTSMI_Click(object sender, EventArgs e)
        {
            InstructionsForm instructionsPage = new InstructionsForm();
            instructionsPage.Show();
        }

        private void aboutTSMI_Click(object sender, EventArgs e)
        {
            AboutForm aboutProgram = new AboutForm();
            aboutProgram.Show();
        }

        private void exitTSMI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string[] GetKeywords()
        {
            string[] keywords = keywordTextBox.Text.Split(',');
            for (int i = 0; i < keywords.Length; i++)
            {
                keywords[i] = keywords[i].Trim();
            }

            return keywords;
        }

        private string GetSqlCommandText(string[] keywords)
        {
            string cmdText = "SELECT job_id, job_title, job_description FROM job_ad WHERE ";
            for (int i = 0; i < keywords.Length; i++)
            {
                cmdText += "job_title LIKE '%[^A-Za-z]" + keywords[i] 
                    + "[^A-Za-z]%' OR job_description LIKE '%[^A-Za-z]" + keywords[i] + "[^A-Za-z]%' ";
                if (i < keywords.Length - 1)
                {
                    cmdText += "OR ";
                }
            }
            cmdText += "ORDER BY job_id";

            return cmdText;
        }

        private DataTable GetJobAds()
        {
            string cs = ConfigurationManager.ConnectionStrings["JobDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.CommandTimeout = 1800;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        private void DisplaySearchResults(DataTable table)
        {
            resultsListView.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                ListViewItem listitem = new ListViewItem(row[0].ToString());
                listitem.SubItems.Add(row[1].ToString());
                listitem.SubItems.Add(row[2].ToString());
                resultsListView.Items.Add(listitem);
            }

            jobsFoundLabel.Text = resultsListView.Items.Count.ToString() + " jobs found.";
        }

        private void keywordSearchButton_Click(object sender, EventArgs e)
        {
            dialogue = new WaitDialogue();
            dialogue.Show();
            dialogue.label1.Refresh();
            dialogue.label2.Refresh();

            string[] keywords = GetKeywords();
            cmdText = GetSqlCommandText(keywords);
            DataTable jobAds = GetJobAds();
            DisplaySearchResults(jobAds);
            if (jobAdsBackup != null)
            {
                jobAdsBackup.Clear();
            }
            jobAdsBackup = jobAds;

            CountWords();
            DisplayTopHundredWords();

            specificWordCount.Clear();

            dialogue.Close();
        }

        private void resultsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string job_id = resultsListView.SelectedItems[0].Text;
            var jobAdFullInfo = new AdInfoForm(job_id);
            jobAdFullInfo.Show();
        }

        private void CountWords()
        {
            wordCountDict.Clear();

            HashSet<string> jobDescWords = new HashSet<string>();
            char[] delimiterChars = { ' ', ',', ':', ';', '(', ')', '[', ']', '?', '!', '/', '\t', '&', '\n' };

            for (int i = 0; i < jobAdsBackup.Rows.Count; i++)
            {
                string jobDesc = jobAdsBackup.Rows[i]["job_description"].ToString();
                var list = jobDesc.ToLower().Split(delimiterChars).ToList();
                var trimmedList = new List<string>();
                foreach (var word in list)
                {
                    trimmedList.Add(word.TrimEnd('.'));
                }
                for (int j = 0; j < list.Count; j++)
                {
                    jobDescWords.Add(trimmedList[j]);
                }

                UpdateWordCount(jobDescWords);

                jobDescWords.Clear();
            }
        }

        private void UpdateWordCount(HashSet<string> words)
        {
            foreach (string word in words)
            {
                if (wordCountDict.ContainsKey(word))
                {
                    wordCountDict[word] += 1;
                }
                else
                {
                    wordCountDict.Add(word, 1);
                }
            }
        }

        private void DisplayTopHundredWords()
        {
            topHundredWords.Clear();

            // wordsToSkip includes:
            // unneeded characters, prepositions, conjunctions, pronouns, determiners, tenses
            HashSet<string> wordsToSkip = new HashSet<string> {
                "", " ", "-", "#160", "#39", "amp", "nbsp", "rsquo", "\r", "\r\n", "\r\n\r\n\r\n", "1",
                "2", "3", "4", "5", "a", "about", "above", "across", "after", "against", "all", "along",
                "although", "am", "among", "an", "any", "and", "another", "are", "around", "as", "at",
                "be", "because", "before", "behind", "between", "beyond", "both", "but", "by",
                "concerning", "despite", "down", "during", "each", "either", "enough", "even", "every",
                "except", "few", "following", "for", "from", "had", "has", "have", "he", "her", "hers",
                "herself", "him", "himself", "his", "i", "if", "including", "in", "into", "is", "it",
                "its", "itself", "lest", "like", "little", "many", "me", "mine", "most", "much", "my",
                "myself", "near", "neither", "nor", "of", "off", "on", "once", "or", "other", "out",
                "our", "ourselves", "over", "s", "she", "since", "so", "some", "than", "that", "the",
                "their", "theirs", "them", "themselves", "these", "they", "this", "those", "though",
                "till", "to", "towards", "through", "throughout", "under", "unless", "until", "up",
                "upon", "us", "was", "we", "what", "whatever", "when", "whenever", "where", "wherever",
                "whether", "which", "whichever", "while", "will", "who", "whoever", "whom", "whomever",
                "whose", "with", "within", "without", "yet", "you", "your", "yours", "yourself"
            };

            List<KeyValuePair<string, int>> wordsToDisplay = new List<KeyValuePair<string, int>>();

            foreach (string word in wordCountDict.Keys)
            {
                if (!wordsToSkip.Contains(word))
                {
                    // Add the word to wordsToDisplay
                    wordsToDisplay.Add(new KeyValuePair<string, int>(word, wordCountDict[word]));
                }
            }

            int rank = 1;
            foreach (var word in wordsToDisplay.OrderByDescending(x => x.Value).Take(100))
            {
                topHundredWords.Text += rank + ". " + word.Key + " [" + word.Value + " ads found]" + Environment.NewLine;
                rank++;
            }
        }

        private string[] GetWords()
        {
            string[] words = specificWordTextBox.Text.Split(',');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim().ToLower();
            }

            return words;
        }

        private List<KeyValuePair<string, int>> CountMatchingRecords(string[] words)
        {
            var wordCountList = new List<KeyValuePair<string, int>>();

            int matchedRecords = 0;
            foreach (string word in words)
            {
                if (word.Contains(" "))
                {
                    matchedRecords = jobAdsBackup
                        .AsEnumerable().Where(x => x["job_description"].ToString().ToLower().Contains(word)).ToList().Count;
                }
                else
                {
                    if (wordCountDict.ContainsKey(word))
                    {
                        matchedRecords = wordCountDict[word];
                    }
                    else
                    {
                        matchedRecords = jobAdsBackup
                        .AsEnumerable().Where(x => x["job_description"].ToString().ToLower().Contains(word)).ToList().Count;
                    }
                }

                wordCountList.Add(new KeyValuePair<string, int>(word, matchedRecords));
                matchedRecords = 0;
            }

            wordCountList = wordCountList.OrderByDescending(x => x.Value).ToList();

            return wordCountList;
        }

        private void DisplayWordCountResults(List<KeyValuePair<string, int>> list)
        {
            specificWordCount.Text = String.Empty;

            for (int i = 0; i < list.Count; i++)
            {
                specificWordCount.Text += (i + 1) + ". " + list[i].Key + " [" + list[i].Value + " ads found]" 
                    + Environment.NewLine + Environment.NewLine;
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            if (jobAdsBackup != null && wordCountDict != null && specificWordTextBox.Text != "")
            {
                string[] wordsToCount = GetWords();
                DisplayWordCountResults(CountMatchingRecords(wordsToCount));
            }
        }
    }
}
