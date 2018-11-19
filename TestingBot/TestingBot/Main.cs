using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace TestingBot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createTasks1.Visible = true;
            profilesPage1.Visible = false;
        }

        private void helloWorldLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void debugInstructionsLabel_Click(object sender, EventArgs e)
        {

        }
        UserInformation.UserInfo NewUser = new UserInformation.UserInfo();
        private void Main_Load(object sender, EventArgs e)
        {
            profilesPage1.Visible = false;
            createTasks1.Visible = false;

            //UserInformation.UserInfo NewUser = new UserInformation.UserInfo();

            List<UserInformation.UserInfo> Profiles = NewUser.DBResults();
            for(int i = 0; i < Profiles.Count(); i++)
            {
                
                if(Profiles[i].FullName == null)
                {
                    comboBox4.Items.Add(i);
                }
                else
                {
                    comboBox4.Items.Add(Profiles[i].FullName);
                }
            }
            

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            profilesPage1.Visible = true;
            createTasks1.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void createTasks1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AutomationScript NewTask = new AutomationScript();
            NewTask.Item = comboBox1.Text;
            NewTask.Color = comboBox2.Text;
            NewTask.Size = comboBox3.Text;
            NewTask.ProfileName = comboBox4.Text;
        }
    }
}

