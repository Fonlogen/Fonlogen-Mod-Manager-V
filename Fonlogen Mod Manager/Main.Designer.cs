namespace Fonlogen_Mod_Manager
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opzioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installScriptHookVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installScriptHookVDotNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installOpenIVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installAsiLoaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installOpenCameraRequireAsiloaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installMenyooSPModMenuRequireAsiloaderOpenIVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installNoEditorRestrictionRequireScriptHookVOpenIVAsiLoaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileList = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.profileList = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.filelist_dir_txt = new System.Windows.Forms.TextBox();
            this.view_file_btn = new System.Windows.Forms.Button();
            this.lbl_actual_view = new System.Windows.Forms.Label();
            this.reloadPB = new System.Windows.Forms.PictureBox();
            this.profile_settings_pan = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadPB)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(624, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Delete all mods from game folder";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total file counter: $fc";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.opzioniToolStripMenuItem,
            this.installToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // opzioniToolStripMenuItem
            // 
            this.opzioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.opzioniToolStripMenuItem.Name = "opzioniToolStripMenuItem";
            this.opzioniToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.opzioniToolStripMenuItem.Text = "Options";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // installToolStripMenuItem
            // 
            this.installToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installScriptHookVToolStripMenuItem,
            this.installScriptHookVDotNetToolStripMenuItem,
            this.installOpenIVToolStripMenuItem,
            this.installAsiLoaderToolStripMenuItem,
            this.installOpenCameraRequireAsiloaderToolStripMenuItem,
            this.installMenyooSPModMenuRequireAsiloaderOpenIVToolStripMenuItem,
            this.installNoEditorRestrictionRequireScriptHookVOpenIVAsiLoaderToolStripMenuItem});
            this.installToolStripMenuItem.Name = "installToolStripMenuItem";
            this.installToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.installToolStripMenuItem.Text = "Install";
            // 
            // installScriptHookVToolStripMenuItem
            // 
            this.installScriptHookVToolStripMenuItem.Name = "installScriptHookVToolStripMenuItem";
            this.installScriptHookVToolStripMenuItem.Size = new System.Drawing.Size(444, 22);
            this.installScriptHookVToolStripMenuItem.Text = "Install ScriptHookV";
            // 
            // installScriptHookVDotNetToolStripMenuItem
            // 
            this.installScriptHookVDotNetToolStripMenuItem.Name = "installScriptHookVDotNetToolStripMenuItem";
            this.installScriptHookVDotNetToolStripMenuItem.Size = new System.Drawing.Size(444, 22);
            this.installScriptHookVDotNetToolStripMenuItem.Text = "Install ScriptHookVDotNet";
            // 
            // installOpenIVToolStripMenuItem
            // 
            this.installOpenIVToolStripMenuItem.Name = "installOpenIVToolStripMenuItem";
            this.installOpenIVToolStripMenuItem.Size = new System.Drawing.Size(444, 22);
            this.installOpenIVToolStripMenuItem.Text = "Install OpenIV";
            // 
            // installAsiLoaderToolStripMenuItem
            // 
            this.installAsiLoaderToolStripMenuItem.Name = "installAsiLoaderToolStripMenuItem";
            this.installAsiLoaderToolStripMenuItem.Size = new System.Drawing.Size(444, 22);
            this.installAsiLoaderToolStripMenuItem.Text = "Install AsiLoader [Require OpenIV]";
            // 
            // installOpenCameraRequireAsiloaderToolStripMenuItem
            // 
            this.installOpenCameraRequireAsiloaderToolStripMenuItem.Name = "installOpenCameraRequireAsiloaderToolStripMenuItem";
            this.installOpenCameraRequireAsiloaderToolStripMenuItem.Size = new System.Drawing.Size(444, 22);
            this.installOpenCameraRequireAsiloaderToolStripMenuItem.Text = "Install OpenCamera [Require AsiLoader / OpenIV]";
            // 
            // installMenyooSPModMenuRequireAsiloaderOpenIVToolStripMenuItem
            // 
            this.installMenyooSPModMenuRequireAsiloaderOpenIVToolStripMenuItem.Name = "installMenyooSPModMenuRequireAsiloaderOpenIVToolStripMenuItem";
            this.installMenyooSPModMenuRequireAsiloaderOpenIVToolStripMenuItem.Size = new System.Drawing.Size(444, 22);
            this.installMenyooSPModMenuRequireAsiloaderOpenIVToolStripMenuItem.Text = "Install Menyoo SP Mod Menu [Require AsiLoader / OpenIV]";
            // 
            // installNoEditorRestrictionRequireScriptHookVOpenIVAsiLoaderToolStripMenuItem
            // 
            this.installNoEditorRestrictionRequireScriptHookVOpenIVAsiLoaderToolStripMenuItem.Name = "installNoEditorRestrictionRequireScriptHookVOpenIVAsiLoaderToolStripMenuItem";
            this.installNoEditorRestrictionRequireScriptHookVOpenIVAsiLoaderToolStripMenuItem.Size = new System.Drawing.Size(444, 22);
            this.installNoEditorRestrictionRequireScriptHookVOpenIVAsiLoaderToolStripMenuItem.Text = "Install NoEditorRestriction [Require ScriptHookV / OpenIV / AsiLoader]";
            // 
            // fileList
            // 
            this.fileList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileList.Location = new System.Drawing.Point(0, 42);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(623, 458);
            this.fileList.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(624, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 26);
            this.button3.TabIndex = 6;
            this.button3.Text = "Play Offline";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(624, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 26);
            this.button4.TabIndex = 7;
            this.button4.Text = "Move all mods to profile folder";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(624, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 26);
            this.button5.TabIndex = 8;
            this.button5.Text = "Create new profile";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(624, 54);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(211, 26);
            this.button6.TabIndex = 9;
            this.button6.Text = "Rename profile";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(624, 106);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(211, 26);
            this.button7.TabIndex = 10;
            this.button7.Text = "Delete current profile";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // profileList
            // 
            this.profileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileList.FormattingEnabled = true;
            this.profileList.Location = new System.Drawing.Point(625, 25);
            this.profileList.Name = "profileList";
            this.profileList.Size = new System.Drawing.Size(209, 28);
            this.profileList.TabIndex = 11;
            this.profileList.SelectedIndexChanged += new System.EventHandler(this.profileList_SelectedIndexChanged);
            this.profileList.SelectedValueChanged += new System.EventHandler(this.profileList_SelectedValueChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(624, 374);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(211, 26);
            this.button8.TabIndex = 12;
            this.button8.Text = "Move all mods to game folder";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // filelist_dir_txt
            // 
            this.filelist_dir_txt.BackColor = System.Drawing.Color.White;
            this.filelist_dir_txt.Location = new System.Drawing.Point(0, 22);
            this.filelist_dir_txt.Name = "filelist_dir_txt";
            this.filelist_dir_txt.ReadOnly = true;
            this.filelist_dir_txt.Size = new System.Drawing.Size(405, 20);
            this.filelist_dir_txt.TabIndex = 13;
            // 
            // view_file_btn
            // 
            this.view_file_btn.Location = new System.Drawing.Point(624, 132);
            this.view_file_btn.Name = "view_file_btn";
            this.view_file_btn.Size = new System.Drawing.Size(211, 26);
            this.view_file_btn.TabIndex = 15;
            this.view_file_btn.Text = "View profile folder";
            this.view_file_btn.UseVisualStyleBackColor = true;
            this.view_file_btn.Click += new System.EventHandler(this.button9_Click);
            // 
            // lbl_actual_view
            // 
            this.lbl_actual_view.Location = new System.Drawing.Point(432, 22);
            this.lbl_actual_view.Name = "lbl_actual_view";
            this.lbl_actual_view.Size = new System.Drawing.Size(191, 17);
            this.lbl_actual_view.TabIndex = 16;
            this.lbl_actual_view.Text = "Viewing game folder";
            this.lbl_actual_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reloadPB
            // 
            this.reloadPB.BackgroundImage = global::Fonlogen_Mod_Manager.Properties.Resources.reload_icon_1320184985894541588;
            this.reloadPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reloadPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadPB.Location = new System.Drawing.Point(406, 22);
            this.reloadPB.Name = "reloadPB";
            this.reloadPB.Size = new System.Drawing.Size(20, 20);
            this.reloadPB.TabIndex = 14;
            this.reloadPB.TabStop = false;
            // 
            // profile_settings_pan
            // 
            this.profile_settings_pan.Location = new System.Drawing.Point(624, 180);
            this.profile_settings_pan.Name = "profile_settings_pan";
            this.profile_settings_pan.Size = new System.Drawing.Size(210, 194);
            this.profile_settings_pan.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 26);
            this.button2.TabIndex = 18;
            this.button2.Text = "Create vanilla files backup profile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(835, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.profile_settings_pan);
            this.Controls.Add(this.lbl_actual_view);
            this.Controls.Add(this.view_file_btn);
            this.Controls.Add(this.reloadPB);
            this.Controls.Add(this.filelist_dir_txt);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.profileList);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Grand Theft Auto V Mod Manager - Phrrrhhile 0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opzioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.Panel fileList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installScriptHookVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installScriptHookVDotNetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installOpenIVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installAsiLoaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installOpenCameraRequireAsiloaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installMenyooSPModMenuRequireAsiloaderOpenIVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installNoEditorRestrictionRequireScriptHookVOpenIVAsiLoaderToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox profileList;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox filelist_dir_txt;
        private System.Windows.Forms.PictureBox reloadPB;
        private System.Windows.Forms.Button view_file_btn;
        private System.Windows.Forms.Label lbl_actual_view;
        private System.Windows.Forms.Panel profile_settings_pan;
        private System.Windows.Forms.Button button2;
    }
}

