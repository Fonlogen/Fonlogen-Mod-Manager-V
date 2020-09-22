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
using Microsoft.VisualBasic.FileIO;
using FileSystem = Microsoft.VisualBasic.FileIO.FileSystem;

namespace Fonlogen_Mod_Manager
{
    public partial class DeleteProfile : Form
    {

        string profile;

        public DeleteProfile()
        {
            InitializeComponent();
        }

        public DeleteProfile(string profile)
        {
            InitializeComponent();
            this.profile = profile;
        }

        private void DeleteProfile_Load(object sender, EventArgs e)
        {
            label1.Text = profile;
        }

        private void renameProfile_btn_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to delete the \"" + profile + "\" profile? You cannot undo this action! All mods contained in it will be completly deleted without recover options!", "Delete profile", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            {
                FileSystem.DeleteDirectory(Application.StartupPath + "/Profiles/" + profile, DeleteDirectoryOption.DeleteAllContents);
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
