namespace AiPostgreWinForms
{
    partial class FrmAiPostgre
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAiPostgre));
            btn_keysettings = new Button();
            btn_showquery = new Button();
            btn_send = new Button();
            tb_userrequest = new TextBox();
            tb_aiquery = new TextBox();
            dgv_airesult = new DataGridView();
            lbl_warning = new Label();
            lbl_title = new Label();
            btn_dbsettings = new Button();
            llbl_github = new LinkLabel();
            pcbx_icon = new PictureBox();
            il_showimages = new ImageList(components);
            gb_key = new GroupBox();
            btn_keyback = new Button();
            btn_saveapi = new Button();
            ckbx_showApi = new CheckBox();
            ckbx_remember = new CheckBox();
            lbl_key = new Label();
            tx_apikey = new TextBox();
            gb_database = new GroupBox();
            btn_dbback = new Button();
            lbl_validatedb = new Label();
            chbx_dbpass = new CheckBox();
            btn_savedb = new Button();
            txt_pass = new TextBox();
            lbl_pass = new Label();
            txt_user = new TextBox();
            lbl_user = new Label();
            txt_db = new TextBox();
            lbl_db = new Label();
            tx_ip = new TextBox();
            lbl_ip = new Label();
            tt_hover = new ToolTip(components);
            btn_tweak = new Button();
            gb_loading = new GroupBox();
            pb_loading = new ProgressBar();
            lbl_loadstatus = new Label();
            pcbx_loadinggif = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_airesult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbx_icon).BeginInit();
            gb_key.SuspendLayout();
            gb_database.SuspendLayout();
            gb_loading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbx_loadinggif).BeginInit();
            SuspendLayout();
            // 
            // btn_keysettings
            // 
            btn_keysettings.BackgroundImage = (Image)resources.GetObject("btn_keysettings.BackgroundImage");
            btn_keysettings.BackgroundImageLayout = ImageLayout.Zoom;
            btn_keysettings.FlatAppearance.BorderSize = 0;
            btn_keysettings.FlatStyle = FlatStyle.Flat;
            btn_keysettings.Location = new Point(783, 162);
            btn_keysettings.Margin = new Padding(4, 5, 4, 5);
            btn_keysettings.Name = "btn_keysettings";
            btn_keysettings.Size = new Size(71, 83);
            btn_keysettings.TabIndex = 2;
            tt_hover.SetToolTip(btn_keysettings, "API Key Settings");
            btn_keysettings.UseVisualStyleBackColor = true;
            btn_keysettings.Click += btn_keysettings_Click;
            // 
            // btn_showquery
            // 
            btn_showquery.BackgroundImage = (Image)resources.GetObject("btn_showquery.BackgroundImage");
            btn_showquery.BackgroundImageLayout = ImageLayout.Zoom;
            btn_showquery.FlatAppearance.BorderSize = 0;
            btn_showquery.FlatStyle = FlatStyle.Flat;
            btn_showquery.Location = new Point(783, 255);
            btn_showquery.Margin = new Padding(4, 5, 4, 5);
            btn_showquery.Name = "btn_showquery";
            btn_showquery.Size = new Size(71, 83);
            btn_showquery.TabIndex = 3;
            tt_hover.SetToolTip(btn_showquery, "Show the generated query");
            btn_showquery.UseVisualStyleBackColor = true;
            btn_showquery.Click += btn_showquery_Click;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(703, 560);
            btn_send.Margin = new Padding(4, 5, 4, 5);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(71, 38);
            btn_send.TabIndex = 4;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // tb_userrequest
            // 
            tb_userrequest.Location = new Point(17, 560);
            tb_userrequest.Margin = new Padding(4, 5, 4, 5);
            tb_userrequest.Name = "tb_userrequest";
            tb_userrequest.Size = new Size(675, 31);
            tb_userrequest.TabIndex = 5;
            tb_userrequest.Enter += tb_userrequest_Enter;
            tb_userrequest.KeyDown += tb_userrequest_KeyDown;
            tb_userrequest.Leave += tb_userrequest_Leave;
            // 
            // tb_aiquery
            // 
            tb_aiquery.Location = new Point(17, 512);
            tb_aiquery.Margin = new Padding(4, 5, 4, 5);
            tb_aiquery.Name = "tb_aiquery";
            tb_aiquery.Size = new Size(313, 31);
            tb_aiquery.TabIndex = 6;
            tb_aiquery.Visible = false;
            tb_aiquery.KeyDown += tb_aiquery_KeyDown;
            // 
            // dgv_airesult
            // 
            dgv_airesult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_airesult.Location = new Point(17, 85);
            dgv_airesult.Margin = new Padding(4, 5, 4, 5);
            dgv_airesult.Name = "dgv_airesult";
            dgv_airesult.RowHeadersWidth = 62;
            dgv_airesult.Size = new Size(757, 417);
            dgv_airesult.TabIndex = 7;
            // 
            // lbl_warning
            // 
            lbl_warning.AutoSize = true;
            lbl_warning.ForeColor = Color.Red;
            lbl_warning.Location = new Point(417, 517);
            lbl_warning.Margin = new Padding(4, 0, 4, 0);
            lbl_warning.Name = "lbl_warning";
            lbl_warning.Size = new Size(377, 25);
            lbl_warning.TabIndex = 8;
            lbl_warning.Text = "Remember AI can sometimes make up things!";
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(329, 28);
            lbl_title.Margin = new Padding(4, 0, 4, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(292, 41);
            lbl_title.TabIndex = 9;
            lbl_title.Text = "GeminiPostSQL";
            // 
            // btn_dbsettings
            // 
            btn_dbsettings.BackgroundImage = (Image)resources.GetObject("btn_dbsettings.BackgroundImage");
            btn_dbsettings.BackgroundImageLayout = ImageLayout.Zoom;
            btn_dbsettings.FlatAppearance.BorderSize = 0;
            btn_dbsettings.FlatStyle = FlatStyle.Flat;
            btn_dbsettings.Location = new Point(783, 348);
            btn_dbsettings.Margin = new Padding(4, 5, 4, 5);
            btn_dbsettings.Name = "btn_dbsettings";
            btn_dbsettings.Size = new Size(71, 83);
            btn_dbsettings.TabIndex = 11;
            tt_hover.SetToolTip(btn_dbsettings, "Postgre's Server Settings");
            btn_dbsettings.UseVisualStyleBackColor = true;
            btn_dbsettings.Click += btn_dbsettings_Click;
            // 
            // llbl_github
            // 
            llbl_github.AutoSize = true;
            llbl_github.Font = new Font("Arial", 6.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            llbl_github.Location = new Point(13, 628);
            llbl_github.Margin = new Padding(4, 0, 4, 0);
            llbl_github.Name = "llbl_github";
            llbl_github.Size = new Size(408, 16);
            llbl_github.TabIndex = 12;
            llbl_github.TabStop = true;
            llbl_github.Text = "Developed by LuisMiSanVe and powered by Google's Gemini AI";
            llbl_github.LinkClicked += llbl_github_LinkClicked;
            // 
            // pcbx_icon
            // 
            pcbx_icon.Image = (Image)resources.GetObject("pcbx_icon.Image");
            pcbx_icon.Location = new Point(273, 2);
            pcbx_icon.Margin = new Padding(4, 5, 4, 5);
            pcbx_icon.Name = "pcbx_icon";
            pcbx_icon.Size = new Size(61, 78);
            pcbx_icon.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbx_icon.TabIndex = 14;
            pcbx_icon.TabStop = false;
            // 
            // il_showimages
            // 
            il_showimages.ColorDepth = ColorDepth.Depth32Bit;
            il_showimages.ImageStream = (ImageListStreamer)resources.GetObject("il_showimages.ImageStream");
            il_showimages.TransparentColor = Color.Transparent;
            il_showimages.Images.SetKeyName(0, "show.png");
            il_showimages.Images.SetKeyName(1, "hide.png");
            // 
            // gb_key
            // 
            gb_key.Controls.Add(btn_keyback);
            gb_key.Controls.Add(btn_saveapi);
            gb_key.Controls.Add(ckbx_showApi);
            gb_key.Controls.Add(ckbx_remember);
            gb_key.Controls.Add(lbl_key);
            gb_key.Controls.Add(tx_apikey);
            gb_key.Location = new Point(197, 202);
            gb_key.Margin = new Padding(4, 5, 4, 5);
            gb_key.Name = "gb_key";
            gb_key.Padding = new Padding(4, 5, 4, 5);
            gb_key.Size = new Size(483, 230);
            gb_key.TabIndex = 15;
            gb_key.TabStop = false;
            gb_key.Text = "API Key Settings";
            gb_key.Visible = false;
            // 
            // btn_keyback
            // 
            btn_keyback.Location = new Point(21, 174);
            btn_keyback.Name = "btn_keyback";
            btn_keyback.Size = new Size(112, 34);
            btn_keyback.TabIndex = 6;
            btn_keyback.Text = "Back";
            btn_keyback.UseVisualStyleBackColor = true;
            btn_keyback.Click += btn_keyback_Click;
            // 
            // btn_saveapi
            // 
            btn_saveapi.Location = new Point(359, 170);
            btn_saveapi.Margin = new Padding(4, 5, 4, 5);
            btn_saveapi.Name = "btn_saveapi";
            btn_saveapi.Size = new Size(107, 38);
            btn_saveapi.TabIndex = 5;
            btn_saveapi.Text = "Save";
            btn_saveapi.UseVisualStyleBackColor = true;
            btn_saveapi.Click += btn_saveapi_Click;
            // 
            // ckbx_showApi
            // 
            ckbx_showApi.AutoSize = true;
            ckbx_showApi.Location = new Point(243, 110);
            ckbx_showApi.Margin = new Padding(4, 5, 4, 5);
            ckbx_showApi.Name = "ckbx_showApi";
            ckbx_showApi.Size = new Size(147, 29);
            ckbx_showApi.TabIndex = 4;
            ckbx_showApi.Text = "Show API Key";
            ckbx_showApi.UseVisualStyleBackColor = true;
            ckbx_showApi.Click += ckbx_showApi_Click;
            // 
            // ckbx_remember
            // 
            ckbx_remember.AutoSize = true;
            ckbx_remember.Location = new Point(9, 110);
            ckbx_remember.Margin = new Padding(4, 5, 4, 5);
            ckbx_remember.Name = "ckbx_remember";
            ckbx_remember.Size = new Size(219, 29);
            ckbx_remember.TabIndex = 3;
            ckbx_remember.Text = "Remember the API Key";
            tt_hover.SetToolTip(ckbx_remember, "The API Key will be stored and loaded at the start");
            ckbx_remember.UseVisualStyleBackColor = true;
            ckbx_remember.Click += ckbx_remember_CheckedChanged;
            // 
            // lbl_key
            // 
            lbl_key.AutoSize = true;
            lbl_key.Location = new Point(9, 32);
            lbl_key.Margin = new Padding(4, 0, 4, 0);
            lbl_key.Name = "lbl_key";
            lbl_key.Size = new Size(147, 25);
            lbl_key.TabIndex = 2;
            lbl_key.Text = "Gemini's API key:";
            // 
            // tx_apikey
            // 
            tx_apikey.Location = new Point(9, 62);
            tx_apikey.Margin = new Padding(4, 5, 4, 5);
            tx_apikey.Name = "tx_apikey";
            tx_apikey.PasswordChar = '*';
            tx_apikey.Size = new Size(437, 31);
            tx_apikey.TabIndex = 0;
            // 
            // gb_database
            // 
            gb_database.Controls.Add(btn_dbback);
            gb_database.Controls.Add(lbl_validatedb);
            gb_database.Controls.Add(chbx_dbpass);
            gb_database.Controls.Add(btn_savedb);
            gb_database.Controls.Add(txt_pass);
            gb_database.Controls.Add(lbl_pass);
            gb_database.Controls.Add(txt_user);
            gb_database.Controls.Add(lbl_user);
            gb_database.Controls.Add(txt_db);
            gb_database.Controls.Add(lbl_db);
            gb_database.Controls.Add(tx_ip);
            gb_database.Controls.Add(lbl_ip);
            gb_database.Location = new Point(280, 90);
            gb_database.Margin = new Padding(4, 5, 4, 5);
            gb_database.Name = "gb_database";
            gb_database.Padding = new Padding(4, 5, 4, 5);
            gb_database.Size = new Size(321, 407);
            gb_database.TabIndex = 16;
            gb_database.TabStop = false;
            gb_database.Text = "Postgre's Server Settings";
            gb_database.Visible = false;
            // 
            // btn_dbback
            // 
            btn_dbback.Location = new Point(22, 343);
            btn_dbback.Margin = new Padding(4, 5, 4, 5);
            btn_dbback.Name = "btn_dbback";
            btn_dbback.Size = new Size(107, 38);
            btn_dbback.TabIndex = 11;
            btn_dbback.Text = "Back";
            btn_dbback.UseVisualStyleBackColor = true;
            btn_dbback.Click += btn_dbback_Click;
            // 
            // lbl_validatedb
            // 
            lbl_validatedb.AutoSize = true;
            lbl_validatedb.ForeColor = Color.Red;
            lbl_validatedb.Location = new Point(9, 377);
            lbl_validatedb.Name = "lbl_validatedb";
            lbl_validatedb.Size = new Size(0, 25);
            lbl_validatedb.TabIndex = 10;
            // 
            // chbx_dbpass
            // 
            chbx_dbpass.AutoSize = true;
            chbx_dbpass.Location = new Point(201, 286);
            chbx_dbpass.Name = "chbx_dbpass";
            chbx_dbpass.Size = new Size(82, 29);
            chbx_dbpass.TabIndex = 9;
            chbx_dbpass.Text = "Show";
            chbx_dbpass.UseVisualStyleBackColor = true;
            chbx_dbpass.Click += chbx_dbpass_Click;
            // 
            // btn_savedb
            // 
            btn_savedb.Location = new Point(189, 343);
            btn_savedb.Margin = new Padding(4, 5, 4, 5);
            btn_savedb.Name = "btn_savedb";
            btn_savedb.Size = new Size(107, 38);
            btn_savedb.TabIndex = 8;
            btn_savedb.Text = "Save";
            btn_savedb.UseVisualStyleBackColor = true;
            btn_savedb.Click += btn_savedb_Click;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(9, 282);
            txt_pass.Margin = new Padding(4, 5, 4, 5);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(185, 31);
            txt_pass.TabIndex = 7;
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Location = new Point(9, 252);
            lbl_pass.Margin = new Padding(4, 0, 4, 0);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(91, 25);
            lbl_pass.TabIndex = 6;
            lbl_pass.Text = "Password:";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(9, 208);
            txt_user.Margin = new Padding(4, 5, 4, 5);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(185, 31);
            txt_user.TabIndex = 5;
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Location = new Point(9, 178);
            lbl_user.Margin = new Padding(4, 0, 4, 0);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(51, 25);
            lbl_user.TabIndex = 4;
            lbl_user.Text = "User:";
            // 
            // txt_db
            // 
            txt_db.Location = new Point(9, 135);
            txt_db.Margin = new Padding(4, 5, 4, 5);
            txt_db.Name = "txt_db";
            txt_db.Size = new Size(287, 31);
            txt_db.TabIndex = 3;
            // 
            // lbl_db
            // 
            lbl_db.AutoSize = true;
            lbl_db.Location = new Point(9, 105);
            lbl_db.Margin = new Padding(4, 0, 4, 0);
            lbl_db.Name = "lbl_db";
            lbl_db.Size = new Size(90, 25);
            lbl_db.TabIndex = 2;
            lbl_db.Text = "Database:";
            // 
            // tx_ip
            // 
            tx_ip.Location = new Point(9, 62);
            tx_ip.Margin = new Padding(4, 5, 4, 5);
            tx_ip.Name = "tx_ip";
            tx_ip.Size = new Size(287, 31);
            tx_ip.TabIndex = 1;
            // 
            // lbl_ip
            // 
            lbl_ip.AutoSize = true;
            lbl_ip.Location = new Point(9, 32);
            lbl_ip.Margin = new Padding(4, 0, 4, 0);
            lbl_ip.Name = "lbl_ip";
            lbl_ip.Size = new Size(103, 25);
            lbl_ip.TabIndex = 0;
            lbl_ip.Text = "IP and Port:";
            // 
            // btn_tweak
            // 
            btn_tweak.Location = new Point(338, 508);
            btn_tweak.Margin = new Padding(4, 5, 4, 5);
            btn_tweak.Name = "btn_tweak";
            btn_tweak.Size = new Size(71, 38);
            btn_tweak.TabIndex = 17;
            btn_tweak.Text = "Run";
            btn_tweak.UseVisualStyleBackColor = true;
            btn_tweak.Visible = false;
            btn_tweak.Click += btn_tweak_Click;
            // 
            // gb_loading
            // 
            gb_loading.BackColor = Color.White;
            gb_loading.Controls.Add(pb_loading);
            gb_loading.Controls.Add(lbl_loadstatus);
            gb_loading.Controls.Add(pcbx_loadinggif);
            gb_loading.Location = new Point(0, 0);
            gb_loading.Name = "gb_loading";
            gb_loading.Size = new Size(1, 1);
            gb_loading.TabIndex = 18;
            gb_loading.TabStop = false;
            gb_loading.Text = "Loading";
            gb_loading.Visible = false;
            // 
            // pb_loading
            // 
            pb_loading.Location = new Point(0, 669);
            pb_loading.Name = "pb_loading";
            pb_loading.Size = new Size(881, 30);
            pb_loading.TabIndex = 2;
            // 
            // lbl_loadstatus
            // 
            lbl_loadstatus.AutoSize = true;
            lbl_loadstatus.ForeColor = SystemColors.ControlText;
            lbl_loadstatus.Location = new Point(744, 628);
            lbl_loadstatus.Name = "lbl_loadstatus";
            lbl_loadstatus.Size = new Size(88, 25);
            lbl_loadstatus.TabIndex = 1;
            lbl_loadstatus.Text = "Loading...";
            // 
            // pcbx_loadinggif
            // 
            pcbx_loadinggif.BackgroundImageLayout = ImageLayout.Stretch;
            pcbx_loadinggif.Image = (Image)resources.GetObject("pcbx_loadinggif.Image");
            pcbx_loadinggif.Location = new Point(173, 82);
            pcbx_loadinggif.Name = "pcbx_loadinggif";
            pcbx_loadinggif.Size = new Size(548, 607);
            pcbx_loadinggif.TabIndex = 0;
            pcbx_loadinggif.TabStop = false;
            // 
            // FrmAiPostgre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 653);
            Controls.Add(gb_loading);
            Controls.Add(gb_database);
            Controls.Add(gb_key);
            Controls.Add(pcbx_icon);
            Controls.Add(llbl_github);
            Controls.Add(btn_dbsettings);
            Controls.Add(lbl_warning);
            Controls.Add(tb_aiquery);
            Controls.Add(tb_userrequest);
            Controls.Add(btn_send);
            Controls.Add(btn_showquery);
            Controls.Add(btn_keysettings);
            Controls.Add(lbl_title);
            Controls.Add(dgv_airesult);
            Controls.Add(btn_tweak);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmAiPostgre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GeminiPostSQL - AI PostgreSQL Assistant";
            FormClosing += FrmAiPostgre_FormClosing;
            Load += FrmAiPostgre_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_airesult).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbx_icon).EndInit();
            gb_key.ResumeLayout(false);
            gb_key.PerformLayout();
            gb_database.ResumeLayout(false);
            gb_database.PerformLayout();
            gb_loading.ResumeLayout(false);
            gb_loading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbx_loadinggif).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_keysettings;
        private Button btn_showquery;
        private Button btn_send;
        private TextBox tb_userrequest;
        private TextBox tb_aiquery;
        private DataGridView dgv_airesult;
        private Label lbl_warning;
        private Label lbl_title;
        private Button btn_dbsettings;
        private LinkLabel llbl_github;
        private PictureBox pcbx_icon;
        private ImageList il_showimages;
        private GroupBox gb_key;
        private GroupBox gb_database;
        private Button btn_saveapi;
        private CheckBox ckbx_showApi;
        private CheckBox ckbx_remember;
        private Label lbl_key;
        private TextBox tx_apikey;
        private Button btn_savedb;
        private TextBox txt_pass;
        private Label lbl_pass;
        private TextBox txt_user;
        private Label lbl_user;
        private TextBox txt_db;
        private Label lbl_db;
        private TextBox tx_ip;
        private Label lbl_ip;
        private ToolTip tt_hover;
        private CheckBox chbx_dbpass;
        private Button btn_tweak;
        private GroupBox gb_loading;
        private PictureBox pcbx_loadinggif;
        private Label lbl_validatedb;
        private Button btn_dbback;
        private Button btn_keyback;
        private Label lbl_loadstatus;
        private ProgressBar pb_loading;
    }
}
