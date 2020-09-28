// GTA V Mod Manager by Fonlogen - Please give credits if you compile and distribute!

﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fonlogen_Mod_Manager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        List<string> Files = new List<string>();
        List<string> ProfilesPath = new List<string>();
        List<string> Profiles = new List<string>();

        public static string current_profile = Properties.Settings.Default.default_profile;
        public static string game_directory = Properties.Settings.Default.game_directory;
        public static string current_profile_directory = Application.StartupPath + @"\Profiles\" + current_profile + @"\";
        public static string profiles_directory = Application.StartupPath + @"\Profiles\";
        public static string current_filelist_directory = game_directory;


        private int view_file = 0;


        private void update_fileList_dir(string new_filelist_dir)
        {
            current_filelist_directory = new_filelist_dir;
            filelist_dir_txt.Text = new_filelist_dir;
        }

        public void getFiles(string directory)
        {
            fileList.Controls.Clear();
            Files.Clear();
            int y_axis = 0;
            int fc = 0;
            foreach (string file in Directory.EnumerateDirectories(directory, "*"))
            {
                fc++;
                string fl = file;
                fl = file.Replace(directory, "");
                Console.WriteLine(directory);
                {
                    Files.Add(file + "%");
                    Console.WriteLine(file + "%");
                    FileButton fileButton = new FileButton(fc, fl, file, isOriginalGameFile(fl + "%"), true);
                    fileButton.TopLevel = false;
                    fileList.Controls.Add(fileButton);
                    fileButton.Location = new Point(0, y_axis);
                    y_axis += 31;
                    fileButton.Visible = true;
                }
            }
            foreach (string file in Directory.EnumerateFiles(directory, "*"))
            {
                fc++;
                string fl = file;
                fl = file.Replace(directory, "");
                {
                    Files.Add(file);
                    Console.WriteLine(file);
                    FileButton fileButton = new FileButton(fc, fl, file, isOriginalGameFile(fl), false);
                    fileButton.TopLevel = false;
                    fileList.Controls.Add(fileButton);
                    fileButton.Location = new Point(0, y_axis);
                    y_axis += 31;
                    fileButton.Visible = true;
                }
            }
            label1.Text = "Total files counter: " + fc;
        }

        private void update_current_profile(string new_profile)
        {
            current_profile = new_profile;
            current_profile_directory = Application.StartupPath + "/Profiles/" + new_profile;
            this.Text = "Grand Theft Auto V Mod Manager - " + new_profile;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            profileList.Text = current_profile;
            this.Text = "Grand Theft Auto V Mod Manager - " + current_profile;
            fileList.AutoScroll = true;
            getFiles(game_directory);
            filelist_dir_txt.Text = game_directory;
            getProfileList();
        }

        public void getProfileList()
        {
            profileList.Items.Clear();
            getProfiles();
            for(int i = 0; i < Profiles.Count(); i++)
                profileList.Items.Add(Profiles[i]);
        }

        public void getProfiles()
        {
            ProfilesPath.Clear();
            Profiles.Clear();
            foreach(string profile in Directory.EnumerateDirectories(profiles_directory, "*"))
            {
                ProfilesPath.Add(profile);
                Profiles.Add(profile.Replace(profiles_directory, ""));
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private bool isOriginalGameFile(string file)
        {
            string[] readText = File.ReadAllLines(Application.StartupPath + "/original_game_files.txt");

            if (readText.Contains<string>(file))
                return true;
            else
                return false;
        }

        public void move_all_mods_to_profile()
        {
            string[] readText = File.ReadAllLines(Application.StartupPath + "/original_game_files.txt");

            for(int i = 0; i < Files.Count; i++)
            {
                string tmp = Files[i];
                tmp = tmp.Replace(game_directory, "");
                Console.WriteLine("TMP - " + tmp);
                foreach (string line in readText)
                {
                    
                    Console.WriteLine(line + " - " + tmp);

                    if (!readText.Contains<string>(tmp))
                    {
                        if (tmp.Contains("%"))
                        {
                            Console.WriteLine("LINE - TMP: " + line + " - " + tmp + "%");
                            string nfi = Files[i];
                            string ofi = Files[i];
                            ofi = ofi.Replace("%", "");
                            nfi = nfi.Replace(game_directory, "");
                            nfi = nfi.Replace("%", "");
                            FileSystem.MoveDirectory(ofi, Application.StartupPath + "/Profiles/" + current_profile + "/" + nfi);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("LINE - TMP: " + line + " - " + tmp);
                            string nfi = Files[i];
                            string ofi = Files[i];
                            nfi = nfi.Replace(game_directory, "");
                            FileSystem.MoveFile(Files[i], Application.StartupPath + "/Profiles/" + current_profile + "/" + nfi);
                            break;
                        }
                    }
                }
            }
            getFiles(game_directory);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete all mods? This action cannot be undo!\nIf you want play online without deleting mods, try the \"Move all mods to profile folder\" option instead.", "Delete all mods", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                delete_all_mods();
                getFiles(game_directory);
            }
        }

        private void delete_all_mods()
        {
            string[] readText = File.ReadAllLines(Application.StartupPath + "/original_game_files.txt");

            for (int i = 0; i < Files.Count; i++)
            {
                string tmp = Files[i];
                tmp = tmp.Replace(game_directory, "");
                foreach (string line in readText)
                {

                    Console.WriteLine(line + " - " + tmp);

                    if (!readText.Contains<string>(tmp))
                    {
                        if (tmp.Contains("%"))
                        {
                            Console.WriteLine("LINE - TMP: " + line + " - " + tmp + "%");
                            string nfi = Files[i];
                            string ofi = Files[i];
                            ofi = ofi.Replace("%", "");
                            nfi = nfi.Replace(game_directory, "");
                            nfi = nfi.Replace("%", "");
                            FileSystem.DeleteDirectory(ofi, DeleteDirectoryOption.DeleteAllContents);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("LINE - TMP: " + line + " - " + tmp);
                            string nfi = Files[i];
                            string ofi = Files[i];
                            nfi = nfi.Replace(game_directory, "");
                            FileSystem.DeleteFile(Files[i]);
                            break;
                        }
                    }
                }
            }
            getFiles(game_directory);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            move_all_mods_to_profile();
        }

        private void profileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_current_profile(profileList.SelectedItem.ToString());
        }

        private void profileList_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            move_all_mods_to_game();
        }

        private void move_all_mods_to_game()
        {
            foreach (string mod_folder in Directory.EnumerateDirectories(current_profile_directory, "*"))
            {
                string nfi = mod_folder;
                nfi = nfi.Replace(current_profile_directory, "");
                FileSystem.MoveDirectory(mod_folder, game_directory + nfi);
            }
            foreach (string mod_file in Directory.EnumerateFiles(current_profile_directory, "*"))
            {
                string nfi = mod_file;
                nfi = nfi.Replace(current_profile_directory, "");
                FileSystem.MoveFile(mod_file, game_directory + nfi);
            }
            getFiles(game_directory);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            switch (view_file)
            {
                case 0:
                    getFiles(current_profile_directory);
                    view_file++;
                    view_file_btn.Text = "View game folder";
                    filelist_dir_txt.Text = current_profile_directory;
                    lbl_actual_view.Text = "Viewing \"" + current_profile + "\" profile folder";
                    break;
                case 1:
                    getFiles(game_directory);
                    view_file--;
                    view_file_btn.Text = "View profile folder";
                    filelist_dir_txt.Text = game_directory;
                    lbl_actual_view.Text = "Viewing game folder";
                    break;
            }
            
        }

        private void rename_profile_settings_show()
        {
            profile_settings_pan.Controls.Clear();
            ProfileRename profileRename = new ProfileRename(current_profile);
            profileRename.TopLevel = false;
            profile_settings_pan.Controls.Add(profileRename);
            profileRename.Location = new Point(0,0);
            profileRename.Visible = true;
        }

        private void create_profile_settings_show()
        {
            profile_settings_pan.Controls.Clear();
            CreateProfile createProfile = new CreateProfile();
            createProfile.TopLevel = false;
            profile_settings_pan.Controls.Add(createProfile);
            createProfile.Location = new Point(0, 0);
            createProfile.Visible = true;
        }

        private void delete_profile_settings_show()
        {
            profile_settings_pan.Controls.Clear();
            DeleteProfile deleteProfile = new DeleteProfile();
            deleteProfile.TopLevel = false;
            profile_settings_pan.Controls.Add(deleteProfile);
            deleteProfile.Location = new Point(0, 0);
            deleteProfile.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rename_profile_settings_show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            create_profile_settings_show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            create_vanilla_backup_profile();
        }

        private void create_vanilla_backup_profile()
        {
            string[] readText = File.ReadAllLines(Application.StartupPath + "/original_game_files.txt");

            DateTime cdate = new DateTime();
            string new_backup_name = "Vanilla-Backup_" + cdate.ToString("yyyyMMdd_hhmmss");

            FileSystem.CreateDirectory(new_backup_name);
            for (int i = 0; i < Files.Count; i++)
            {
                string tmp = Files[i];
                tmp = tmp.Replace(game_directory, "");
                foreach (string line in readText)
                {

                    Console.WriteLine(line + " - " + tmp);

                    if (readText.Contains<string>(tmp))
                    {
                        if (tmp.Contains("%"))
                        {
                            Console.WriteLine("LINE - TMP: " + line + " - " + tmp + "%");
                            string nfi = Files[i];
                            string ofi = Files[i];
                            ofi = ofi.Replace("%", "");
                            nfi = nfi.Replace(game_directory, "");
                            nfi = nfi.Replace("%", "");
                            FileSystem.CopyDirectory(ofi, profiles_directory + new_backup_name);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("LINE - TMP: " + line + " - " + tmp);
                            string nfi = Files[i];
                            string ofi = Files[i];
                            nfi = nfi.Replace(game_directory, "");
                            FileSystem.CopyFile(Files[i], profiles_directory + new_backup_name);
                            break;
                        }
                    }
                }
            }
            getFiles(game_directory);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            delete_profile_settings_show();
        }
    }

}
