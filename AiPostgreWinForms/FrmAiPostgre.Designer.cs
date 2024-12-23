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
            lbl_credits = new Label();
            btn_dbsettings = new Button();
            llbl_github = new LinkLabel();
            pcbx_icon = new PictureBox();
            il_showimages = new ImageList(components);
            gb_key = new GroupBox();
            btn_saveapi = new Button();
            ckbx_showApi = new CheckBox();
            ckbx_remember = new CheckBox();
            lbl_key = new Label();
            tx_apikey = new TextBox();
            gb_database = new GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)dgv_airesult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbx_icon).BeginInit();
            gb_key.SuspendLayout();
            gb_database.SuspendLayout();
            SuspendLayout();
            // 
            // btn_keysettings
            // 
            btn_keysettings.BackgroundImage = (Image)resources.GetObject("btn_keysettings.BackgroundImage");
            btn_keysettings.BackgroundImageLayout = ImageLayout.Zoom;
            btn_keysettings.FlatAppearance.BorderSize = 0;
            btn_keysettings.FlatStyle = FlatStyle.Flat;
            btn_keysettings.Location = new Point(548, 97);
            btn_keysettings.Name = "btn_keysettings";
            btn_keysettings.Size = new Size(50, 50);
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
            btn_showquery.Location = new Point(548, 153);
            btn_showquery.Name = "btn_showquery";
            btn_showquery.Size = new Size(50, 50);
            btn_showquery.TabIndex = 3;
            tt_hover.SetToolTip(btn_showquery, "Show the generated query");
            btn_showquery.UseVisualStyleBackColor = true;
            btn_showquery.Click += btn_showquery_Click;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(492, 336);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(50, 23);
            btn_send.TabIndex = 4;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // tb_userrequest
            // 
            tb_userrequest.Location = new Point(12, 336);
            tb_userrequest.Name = "tb_userrequest";
            tb_userrequest.Size = new Size(474, 23);
            tb_userrequest.TabIndex = 5;
            // 
            // tb_aiquery
            // 
            tb_aiquery.Location = new Point(12, 307);
            tb_aiquery.Name = "tb_aiquery";
            tb_aiquery.Size = new Size(274, 23);
            tb_aiquery.TabIndex = 6;
            tb_aiquery.Visible = false;
            // 
            // dgv_airesult
            // 
            dgv_airesult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_airesult.Location = new Point(12, 51);
            dgv_airesult.Name = "dgv_airesult";
            dgv_airesult.Size = new Size(530, 250);
            dgv_airesult.TabIndex = 7;
            // 
            // lbl_warning
            // 
            lbl_warning.AutoSize = true;
            lbl_warning.ForeColor = Color.Red;
            lbl_warning.Location = new Point(292, 310);
            lbl_warning.Name = "lbl_warning";
            lbl_warning.Size = new Size(250, 15);
            lbl_warning.TabIndex = 8;
            lbl_warning.Text = "Remember AI can sometimes make up things!";
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(230, 17);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(195, 28);
            lbl_title.TabIndex = 9;
            lbl_title.Text = "GeminiPostSQL";
            // 
            // lbl_credits
            // 
            lbl_credits.AutoSize = true;
            lbl_credits.Font = new Font("Arial", 6.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_credits.Location = new Point(12, 371);
            lbl_credits.Name = "lbl_credits";
            lbl_credits.Size = new Size(282, 12);
            lbl_credits.TabIndex = 10;
            lbl_credits.Text = "Program made by                    and powered by Google's Gemini AI";
            // 
            // btn_dbsettings
            // 
            btn_dbsettings.BackgroundImage = (Image)resources.GetObject("btn_dbsettings.BackgroundImage");
            btn_dbsettings.BackgroundImageLayout = ImageLayout.Zoom;
            btn_dbsettings.FlatAppearance.BorderSize = 0;
            btn_dbsettings.FlatStyle = FlatStyle.Flat;
            btn_dbsettings.Location = new Point(548, 209);
            btn_dbsettings.Name = "btn_dbsettings";
            btn_dbsettings.Size = new Size(50, 50);
            btn_dbsettings.TabIndex = 11;
            tt_hover.SetToolTip(btn_dbsettings, "Postgre's Server Settings");
            btn_dbsettings.UseVisualStyleBackColor = true;
            btn_dbsettings.Click += btn_dbsettings_Click;
            // 
            // llbl_github
            // 
            llbl_github.AutoSize = true;
            llbl_github.Font = new Font("Arial", 6.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            llbl_github.Location = new Point(86, 371);
            llbl_github.Name = "llbl_github";
            llbl_github.Size = new Size(59, 12);
            llbl_github.TabIndex = 12;
            llbl_github.TabStop = true;
            llbl_github.Text = "LuisMiSanVe";
            llbl_github.LinkClicked += llbl_github_LinkClicked;
            // 
            // pcbx_icon
            // 
            pcbx_icon.Image = (Image)resources.GetObject("pcbx_icon.Image");
            pcbx_icon.Location = new Point(191, 1);
            pcbx_icon.Name = "pcbx_icon";
            pcbx_icon.Size = new Size(43, 47);
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
            gb_key.Controls.Add(btn_saveapi);
            gb_key.Controls.Add(ckbx_showApi);
            gb_key.Controls.Add(ckbx_remember);
            gb_key.Controls.Add(lbl_key);
            gb_key.Controls.Add(tx_apikey);
            gb_key.Location = new Point(138, 121);
            gb_key.Name = "gb_key";
            gb_key.Size = new Size(338, 138);
            gb_key.TabIndex = 15;
            gb_key.TabStop = false;
            gb_key.Text = "API Key Settings";
            gb_key.Visible = false;
            // 
            // btn_saveapi
            // 
            btn_saveapi.Location = new Point(251, 102);
            btn_saveapi.Name = "btn_saveapi";
            btn_saveapi.Size = new Size(75, 23);
            btn_saveapi.TabIndex = 5;
            btn_saveapi.Text = "Save";
            btn_saveapi.UseVisualStyleBackColor = true;
            btn_saveapi.Click += btn_saveapi_Click;
            // 
            // ckbx_showApi
            // 
            ckbx_showApi.AutoSize = true;
            ckbx_showApi.Location = new Point(170, 66);
            ckbx_showApi.Name = "ckbx_showApi";
            ckbx_showApi.Size = new Size(98, 19);
            ckbx_showApi.TabIndex = 4;
            ckbx_showApi.Text = "Show API Key";
            ckbx_showApi.UseVisualStyleBackColor = true;
            ckbx_showApi.Click += ckbx_showApi_Click;
            // 
            // ckbx_remember
            // 
            ckbx_remember.AutoSize = true;
            ckbx_remember.Location = new Point(6, 66);
            ckbx_remember.Name = "ckbx_remember";
            ckbx_remember.Size = new Size(147, 19);
            ckbx_remember.TabIndex = 3;
            ckbx_remember.Text = "Remember the API Key";
            tt_hover.SetToolTip(ckbx_remember, "The API Key will be stored and loaded at the start");
            ckbx_remember.UseVisualStyleBackColor = true;
            ckbx_remember.Click += ckbx_remember_CheckedChanged;
            // 
            // lbl_key
            // 
            lbl_key.AutoSize = true;
            lbl_key.Location = new Point(6, 19);
            lbl_key.Name = "lbl_key";
            lbl_key.Size = new Size(98, 15);
            lbl_key.TabIndex = 2;
            lbl_key.Text = "Gemini's API key:";
            // 
            // tx_apikey
            // 
            tx_apikey.Location = new Point(6, 37);
            tx_apikey.Name = "tx_apikey";
            tx_apikey.PasswordChar = '*';
            tx_apikey.Size = new Size(307, 23);
            tx_apikey.TabIndex = 0;
            // 
            // gb_database
            // 
            gb_database.Controls.Add(btn_savedb);
            gb_database.Controls.Add(txt_pass);
            gb_database.Controls.Add(lbl_pass);
            gb_database.Controls.Add(txt_user);
            gb_database.Controls.Add(lbl_user);
            gb_database.Controls.Add(txt_db);
            gb_database.Controls.Add(lbl_db);
            gb_database.Controls.Add(tx_ip);
            gb_database.Controls.Add(lbl_ip);
            gb_database.Location = new Point(196, 54);
            gb_database.Name = "gb_database";
            gb_database.Size = new Size(225, 244);
            gb_database.TabIndex = 16;
            gb_database.TabStop = false;
            gb_database.Text = "Postgre's Server Settings";
            gb_database.Visible = false;
            // 
            // btn_savedb
            // 
            btn_savedb.Location = new Point(133, 206);
            btn_savedb.Name = "btn_savedb";
            btn_savedb.Size = new Size(75, 23);
            btn_savedb.TabIndex = 8;
            btn_savedb.Text = "Save";
            btn_savedb.UseVisualStyleBackColor = true;
            btn_savedb.Click += btn_savedb_Click;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(6, 169);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(131, 23);
            txt_pass.TabIndex = 7;
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Location = new Point(6, 151);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(60, 15);
            lbl_pass.TabIndex = 6;
            lbl_pass.Text = "Password:";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(6, 125);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(131, 23);
            txt_user.TabIndex = 5;
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Location = new Point(6, 107);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(33, 15);
            lbl_user.TabIndex = 4;
            lbl_user.Text = "User:";
            // 
            // txt_db
            // 
            txt_db.Location = new Point(6, 81);
            txt_db.Name = "txt_db";
            txt_db.Size = new Size(202, 23);
            txt_db.TabIndex = 3;
            // 
            // lbl_db
            // 
            lbl_db.AutoSize = true;
            lbl_db.Location = new Point(6, 63);
            lbl_db.Name = "lbl_db";
            lbl_db.Size = new Size(58, 15);
            lbl_db.TabIndex = 2;
            lbl_db.Text = "Database:";
            // 
            // tx_ip
            // 
            tx_ip.Location = new Point(6, 37);
            tx_ip.Name = "tx_ip";
            tx_ip.Size = new Size(202, 23);
            tx_ip.TabIndex = 1;
            // 
            // lbl_ip
            // 
            lbl_ip.AutoSize = true;
            lbl_ip.Location = new Point(6, 19);
            lbl_ip.Name = "lbl_ip";
            lbl_ip.Size = new Size(20, 15);
            lbl_ip.TabIndex = 0;
            lbl_ip.Text = "IP:";
            // 
            // FrmAiPostgre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 392);
            Controls.Add(gb_key);
            Controls.Add(pcbx_icon);
            Controls.Add(llbl_github);
            Controls.Add(btn_dbsettings);
            Controls.Add(lbl_credits);
            Controls.Add(lbl_warning);
            Controls.Add(tb_aiquery);
            Controls.Add(tb_userrequest);
            Controls.Add(btn_send);
            Controls.Add(btn_showquery);
            Controls.Add(btn_keysettings);
            Controls.Add(lbl_title);
            Controls.Add(gb_database);
            Controls.Add(dgv_airesult);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAiPostgre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GeminiPostSQL - AI PostgreSQL Assistant";
            Load += FrmAiPostgre_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_airesult).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbx_icon).EndInit();
            gb_key.ResumeLayout(false);
            gb_key.PerformLayout();
            gb_database.ResumeLayout(false);
            gb_database.PerformLayout();
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
        private Label lbl_credits;
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
    }
}
