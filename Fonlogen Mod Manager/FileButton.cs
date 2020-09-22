using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fonlogen_Mod_Manager
{
    public partial class FileButton : Form
    {

        int file_id;
        string file_name;
        string file_path;
        string file_extension;
        string file_name_with_extension;
        public bool isGameFile;
        public bool isDirectory;

        public FileButton()
        {
            InitializeComponent();
        }

        public FileButton(int id, string fileName, string filePath, bool gameFile, bool directory)
        {
            InitializeComponent();
            this.file_id = id;
            this.file_name = Path.GetFileNameWithoutExtension(filePath);
            this.file_extension = (Path.GetExtension(filePath).Replace(".", ""));
            this.file_path = filePath;
            this.isGameFile = gameFile;
            this.isDirectory = directory;
        }

        private void FileButton_Load(object sender, EventArgs e)
        {
            file_toolTip.SetToolTip(fileName_lbl, file_path);
            gameFile_tooltip.SetToolTip(isGameFilePB, "Make sure to backup these files before modifing them. You have to reinstall the whole game if you want play online mode!");
            file_toolTip.SetToolTip(fb_panel, file_path);
            directory_tooltip.SetToolTip(isDirectoryPB, "This is a directory");
            if (!isDirectory)
            {
                file_name_with_extension = file_name + "." + file_extension;
                fileName_lbl.Text = file_name_with_extension;
            } else
            {
                file_name_with_extension = file_name + "/";
                fileName_lbl.Text = file_name_with_extension;
            }
            if (isGameFile)
                isGameFilePB.Show();
            if (isDirectory)
                isDirectoryPB.Show();
        }

        private void fb_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void open_dir_in_file_explorer()
        {
            string file_dir = file_path;
            file_dir = file_dir.Replace(@"\" + file_name_with_extension, "");
            Process.Start(file_dir);
        }

        private void fileName_lbl_Click(object sender, EventArgs e)
        {
            open_dir_in_file_explorer();
        }

        private void fb_panel_Click(object sender, EventArgs e)
        {
            open_dir_in_file_explorer();
        }

        private void isDirectoryPB_Click(object sender, EventArgs e)
        {

        }

        private void isGameFilePB_Click(object sender, EventArgs e)
        {

        }

        private void fb_panel_MouseHover(object sender, EventArgs e)
        {
            fb_panel.BackColor = Color.LightBlue;
        }

        private void fb_panel_MouseLeave(object sender, EventArgs e)
        {
            fb_panel.BackColor = Color.White;
        }

        private void fileName_lbl_MouseHover(object sender, EventArgs e)
        {
            fb_panel.BackColor = Color.LightBlue;
        }

        private void fileName_lbl_MouseLeave(object sender, EventArgs e)
        {
            fb_panel.BackColor = Color.White;
        }

        private void isDirectoryPB_MouseHover(object sender, EventArgs e)
        {
            fb_panel.BackColor = Color.LightBlue;
        }

        private void isDirectoryPB_MouseLeave(object sender, EventArgs e)
        {
            fb_panel.BackColor = Color.White;
        }

        private void isGameFilePB_MouseHover(object sender, EventArgs e)
        {
            fb_panel.BackColor = Color.LightBlue;
        }

        private void isGameFilePB_MouseLeave(object sender, EventArgs e)
        {
            fb_panel.BackColor = Color.White;
        }
    }
}
