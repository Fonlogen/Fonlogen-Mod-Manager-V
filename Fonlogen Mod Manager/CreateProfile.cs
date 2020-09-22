using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fonlogen_Mod_Manager
{
    public partial class CreateProfile : Form
    {
        public CreateProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renameProfile_btn_Click(object sender, EventArgs e)
        {
            FileSystem.MkDir(Main.profiles_directory + textBox1.Text);
            MessageBox.Show("Restart of application is required.", "Restart required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.default_profile = textBox1.Text;
                Properties.Settings.Default.Save();
            }
            Application.Restart();
            Environment.Exit(0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
