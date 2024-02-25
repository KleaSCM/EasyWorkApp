using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EasyWorkApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Handle clicks on menu items to open corresponding websites
        private void eCSNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenWebsite("https://ecsn.gov.au/ESS/");
        }

        private void CV_CHECK_Click(object sender, EventArgs e)
        {
            OpenWebsite("https://marraworraworra.sharepoint.com/sites/MWWACCDP/SitePages/LearningTeamHome.aspx");
        }

        private void ESS_REPORTING_Click(object sender, EventArgs e)
        {
            OpenWebsite("https://reports.employment.gov.au/PORTAL/Reports");
        }

        private void QLIK_REPORTING_Click(object sender, EventArgs e)
        {
            OpenWebsite("https://pmc.dynamic.reports.employment.gov.au/bi/hub/my/favorites");
        }

        private void CM_SHAREPOINT_Click(object sender, EventArgs e)
        {
            OpenWebsite("https://marraworraworra.sharepoint.com/sites/CaseManagement/SitePages/Employee-onboarding-team-home.aspx");
        }

        private void CM_BOOK_Click(object sender, EventArgs e)
        {
            OpenWebsite("https://marraworraworra.sharepoint.com/:x:/r/sites/MWWACCDP/_layouts/15/Doc.aspx?sourcedoc=%7B8BCFEDC0-976F-4A6A-B3D5-594EE4471BCC%7D&file=CaseManagmentBook.xlsx&action=default&mobileredirect=true");
        }

        private void PPS_SHAREPOINT_Click(object sender, EventArgs e)
        {
            OpenWebsite("https://marraworraworra.sharepoint.com/sites/EmploymentPPS/SitePages/ProjectHome.aspx");
        }

        private void PPS_BOOK_Click(object sender, EventArgs e)
        {
            OpenWebsite("https://marraworraworra.sharepoint.com/:x:/r/sites/MWWACCDP/_layouts/15/Doc.aspx?sourcedoc=%7BB9347306-62A6-419D-B552-24182984EA3A%7D&file=PPSBook.xlsx&action=default&mobileredirect=true");
        }

        private void MWWAC_DATASETS_Click(object sender, EventArgs e)
        {
            OpenWebsite("https://marraworraworra.sharepoint.com/sites/MWWACCDP/SitePages/LearningTeamHome.aspx");
        }

        // Method to open a website in the default web browser
        private void OpenWebsite(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening website: " + ex.Message);
            }
        }

        // Handle clicks on application buttons
        private void button_1_Click(object sender, EventArgs e)
        {
            OpenApplication("mspaint");
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            OpenApplication("winword");
        }


        private void button_3_Click(object sender, EventArgs e)
        {
            OpenApplication("excel");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            OpenApplication("powerpnt");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            OpenApplication("notepad");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            OpenApplication("notepad");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            OpenApplication("notepad");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            OpenApplication("notepad");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            OpenApplication("outlook.exe");
        }

        private void button_10_Click(object sender, EventArgs e)
        {
            OpenApplication("notepad");
        }

        private void button_11_Click(object sender, EventArgs e)
        {
            OpenApplication("Code");
        }



        private void button_12_Click(object sender, EventArgs e)
        {
            OpenApplication("powershell.exe");
        }

        // Method to open an application
        private void OpenApplication(string command)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = command,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening application: " + ex.Message);
            }
        }

        // Placeholder event handler methods
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Placeholder for future functionality
        }

        private void GroupBox_2_Enter(object sender, EventArgs e)
        {
            // Placeholder for future functionality
        }

        private void GroupBox_3_Enter(object sender, EventArgs e)
        {
            // Placeholder for future functionality
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Logic specific to text changes in textBox1, if any
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.SelectedText))
            {
                Clipboard.SetText(textBox1.SelectedText);
            }
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textBox1.SelectedText = Clipboard.GetText();
            }
        }
    }
}





