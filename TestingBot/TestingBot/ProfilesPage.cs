using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingBot
{
    public partial class ProfilesPage : UserControl
    {
        UserInformation.UserInfo NewUser = new UserInformation.UserInfo();

        private static ProfilesPage _instance;
        private static ProfilesPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfilesPage();
                return _instance;
            }
        }
        public ProfilesPage()
        {
            InitializeComponent();
        }

        private void ProfilesPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NewUser.FullName = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            NewUser.Email = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            NewUser.Phone = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            NewUser.Address = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            NewUser.City = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            NewUser.Zip = textBox6.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("CA");
            NewUser.State = comboBox1.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            NewUser.CCNumber = textBox7.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Add("1");
            NewUser.CCMonth = comboBox2.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Add("2018");
            NewUser.CCYear = comboBox3.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            NewUser.CVV = textBox8.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            NewUser.ProfileName = textBox9.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UserInformation.DBinsert();
            NewUser.DBInsert();
        }
        
    }
    
    
}
