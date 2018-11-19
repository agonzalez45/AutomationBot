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
    public partial class CreateTasks : UserControl
    {
        public void ComboBoxNew()
        {
            
        }
        public CreateTasks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ComboBox.ObjectCollection Item
        {
            get { return comboBox4.Items; }
        }
        public void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Add("adsf");
            UserInformation.UserInfo NewUser = new UserInformation.UserInfo();

            List<UserInformation.UserInfo> Profiles = NewUser.DBResults();
            for(int i = 0; i < Profiles.Count(); i++)
            {
                comboBox4.Items.Add(Profiles[i].ProfileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
