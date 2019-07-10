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
using System.Diagnostics;

namespace Joadfian
{
    public partial class AdInfoForm : Form
    {
        private string job_id;
        DataTable adInfoTable;
        List<string> workLocations = new List<string>();

        public AdInfoForm()
        {
            InitializeComponent();
        }

        public AdInfoForm(string job_id)
        {
            InitializeComponent();
            this.job_id = job_id;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            adInfoTable = new DataTable();
            GetJobAdData();
            UpdateTitleBar();
            ShowJobAdData();
        }

        private void GetJobAdData()
        {
            string cs = ConfigurationManager.ConnectionStrings["JobDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd1 = new SqlCommand
                {
                    CommandText = "SELECT job_ad.job_id, job_ad.job_url, job_ad.job_title, " +
                       "job_ad.required_experience, job_ad.job_description, job_ad.min_salary, " +
                       "job_ad.max_salary, company.company_id, company.name, " +
                       "company.industry, company.company_size, company.spoken_language, " +
                       "company.dress_code, company.benefits, company.working_hours, " +
                       "company.contact_number, company.website, company.facebook_page " +
                       "FROM job_ad INNER JOIN company ON job_ad.company_id = company.company_id " +
                       "WHERE job_ad.job_id = @job_id"
                };
                cmd1.Parameters.AddWithValue("@job_id", job_id);
                cmd1.Connection = con;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);

                adapter.Fill(adInfoTable);
                //dataGridView1.DataSource = adInfoTable;

                SqlCommand cmd2 = new SqlCommand
                {
                    CommandText = "SELECT location FROM work_location WHERE job_id = @job_id"
                };
                cmd2.Parameters.AddWithValue("@job_id", job_id);
                cmd2.Connection = con;

                con.Open();
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        workLocations.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void UpdateTitleBar()
        {
            this.Text = "Job Ad: " + adInfoTable.Rows[0]["job_title"].ToString();
        }

        private void ShowJobAdData()
        {
            // Job Info
            urlLabel.Text = adInfoTable.Rows[0]["job_url"].ToString();
            idLabel.Text = adInfoTable.Rows[0]["job_id"].ToString();
            titleLabel.Text = adInfoTable.Rows[0]["job_title"].ToString();
            experienceLabel.Text = adInfoTable.Rows[0]["required_experience"].ToString();
            minSalaryLabel.Text = adInfoTable.Rows[0]["min_salary"].ToString();
            maxSalaryLabel.Text = adInfoTable.Rows[0]["max_salary"].ToString();
            for (int i = 0; i < workLocations.Count; i++)
            {
                if (i != workLocations.Count - 1)
                {
                    locationTextBox.Text += workLocations[i] + Environment.NewLine;
                }
                else
                {
                    locationTextBox.Text += workLocations[i];
                }
            }
            descriptionTextBox.Text = adInfoTable.Rows[0]["job_description"].ToString();

            // Company Info
            cNameLabel.Text = adInfoTable.Rows[0]["name"].ToString();
            wHoursLabel.Text = adInfoTable.Rows[0]["working_hours"].ToString();
            industryLabel.Text = adInfoTable.Rows[0]["industry"].ToString();
            csizeLabel.Text = adInfoTable.Rows[0]["company_size"].ToString();
            languageLabel.Text = adInfoTable.Rows[0]["spoken_language"].ToString();
            dressCodeLabel.Text = adInfoTable.Rows[0]["dress_code"].ToString();
            benefitsTextBox.Text = adInfoTable.Rows[0]["benefits"].ToString();
            contactNumLabel.Text = adInfoTable.Rows[0]["contact_number"].ToString();
            websiteLLabel.Text = adInfoTable.Rows[0]["website"].ToString();
            facebookLLabel.Text = adInfoTable.Rows[0]["facebook_page"].ToString();
        }

        private void urlLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (adInfoTable.Rows[0]["job_url"].ToString() != "n/a")
            {
                Process.Start(adInfoTable.Rows[0]["job_url"].ToString());
            }
        }

        private void websiteLLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (adInfoTable.Rows[0]["website"].ToString() != "n/a")
            {
                Process.Start(adInfoTable.Rows[0]["website"].ToString());
            }
        }

        private void facebookLLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (adInfoTable.Rows[0]["facebook_page"].ToString() != "n/a")
            {
                Process.Start(adInfoTable.Rows[0]["facebook_page"].ToString());
            }
        }
    }
}
