namespace Fonlogen_Mod_Manager
{
    partial class FileButton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fileName_lbl = new System.Windows.Forms.Label();
            this.file_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gameFile_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.fb_panel = new System.Windows.Forms.Panel();
            this.isDirectoryPB = new System.Windows.Forms.PictureBox();
            this.isGameFilePB = new System.Windows.Forms.PictureBox();
            this.directory_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.fb_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isDirectoryPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isGameFilePB)).BeginInit();
            this.SuspendLayout();
            // 
            // fileName_lbl
            // 
            this.fileName_lbl.AutoSize = true;
            this.fileName_lbl.Location = new System.Drawing.Point(7, 7);
            this.fileName_lbl.Name = "fileName_lbl";
            this.fileName_lbl.Size = new System.Drawing.Size(67, 16);
            this.fileName_lbl.TabIndex = 1;
            this.fileName_lbl.Text = "FileName";
            this.fileName_lbl.Click += new System.EventHandler(this.fileName_lbl_Click);
            this.fileName_lbl.MouseLeave += new System.EventHandler(this.fileName_lbl_MouseLeave);
            this.fileName_lbl.MouseHover += new System.EventHandler(this.fileName_lbl_MouseHover);
            // 
            // file_toolTip
            // 
            this.file_toolTip.AutoPopDelay = 15000;
            this.file_toolTip.InitialDelay = 500;
            this.file_toolTip.ReshowDelay = 100;
            this.file_toolTip.ShowAlways = true;
            // 
            // gameFile_tooltip
            // 
            this.gameFile_tooltip.AutoPopDelay = 15000;
            this.gameFile_tooltip.InitialDelay = 500;
            this.gameFile_tooltip.ReshowDelay = 100;
            this.gameFile_tooltip.ShowAlways = true;
            this.gameFile_tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.gameFile_tooltip.ToolTipTitle = "This is a original game file.";
            // 
            // fb_panel
            // 
            this.fb_panel.BackColor = System.Drawing.Color.White;
            this.fb_panel.Controls.Add(this.isDirectoryPB);
            this.fb_panel.Controls.Add(this.isGameFilePB);
            this.fb_panel.Controls.Add(this.fileName_lbl);
            this.fb_panel.ForeColor = System.Drawing.Color.Black;
            this.fb_panel.Location = new System.Drawing.Point(0, 0);
            this.fb_panel.Name = "fb_panel";
            this.fb_panel.Size = new System.Drawing.Size(600, 30);
            this.fb_panel.TabIndex = 2;
            this.fb_panel.Click += new System.EventHandler(this.fb_panel_Click);
            this.fb_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.fb_panel_Paint);
            this.fb_panel.MouseLeave += new System.EventHandler(this.fb_panel_MouseLeave);
            this.fb_panel.MouseHover += new System.EventHandler(this.fb_panel_MouseHover);
            // 
            // isDirectoryPB
            // 
            this.isDirectoryPB.BackgroundImage = global::Fonlogen_Mod_Manager.Properties.Resources.folder_131964753094019398;
            this.isDirectoryPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.isDirectoryPB.Location = new System.Drawing.Point(539, 3);
            this.isDirectoryPB.Name = "isDirectoryPB";
            this.isDirectoryPB.Size = new System.Drawing.Size(26, 25);
            this.isDirectoryPB.TabIndex = 2;
            this.isDirectoryPB.TabStop = false;
            this.isDirectoryPB.Visible = false;
            this.isDirectoryPB.Click += new System.EventHandler(this.isDirectoryPB_Click);
            this.isDirectoryPB.MouseLeave += new System.EventHandler(this.isDirectoryPB_MouseLeave);
            this.isDirectoryPB.MouseHover += new System.EventHandler(this.isDirectoryPB_MouseHover);
            // 
            // isGameFilePB
            // 
            this.isGameFilePB.BackgroundImage = global::Fonlogen_Mod_Manager.Properties.Resources.grand_theft_auto_v_icon_20;
            this.isGameFilePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.isGameFilePB.Location = new System.Drawing.Point(568, 3);
            this.isGameFilePB.Name = "isGameFilePB";
            this.isGameFilePB.Size = new System.Drawing.Size(26, 25);
            this.isGameFilePB.TabIndex = 0;
            this.isGameFilePB.TabStop = false;
            this.isGameFilePB.Visible = false;
            this.isGameFilePB.Click += new System.EventHandler(this.isGameFilePB_Click);
            this.isGameFilePB.MouseLeave += new System.EventHandler(this.isGameFilePB_MouseLeave);
            this.isGameFilePB.MouseHover += new System.EventHandler(this.isGameFilePB_MouseHover);
            // 
            // FileButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(599, 30);
            this.Controls.Add(this.fb_panel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FileButton";
            this.Text = "FileButton";
            this.Load += new System.EventHandler(this.FileButton_Load);
            this.fb_panel.ResumeLayout(false);
            this.fb_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isDirectoryPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isGameFilePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox isGameFilePB;
        private System.Windows.Forms.Label fileName_lbl;
        private System.Windows.Forms.ToolTip file_toolTip;
        private System.Windows.Forms.ToolTip gameFile_tooltip;
        private System.Windows.Forms.Panel fb_panel;
        private System.Windows.Forms.PictureBox isDirectoryPB;
        private System.Windows.Forms.ToolTip directory_tooltip;
    }
}