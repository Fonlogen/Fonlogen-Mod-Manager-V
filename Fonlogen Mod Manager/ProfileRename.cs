using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace Fonlogen_Mod_Manager
{
    public partial class ProfileRename : Form
    {

        public static string current_profile_name;

        public ProfileRename()
        {
            InitializeComponent();
        }

        public ProfileRename(string profile)
        {
            InitializeComponent();
            current_profile_name = profile;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Profile_Rename_Load(object sender, EventArgs e)
        {
            lblcurrentname.Text = current_profile_name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renameProfile_btn_Click(object sender, EventArgs e)
        {
            FileSystem.RenameDirectory(Application.StartupPath + "/Profiles/" + current_profile_name, textBox1.Text);
            Application.Restart();
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblcurrentname_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
