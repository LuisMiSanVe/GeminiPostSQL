using AiPostgreWinForms.Properties;
using Newtonsoft.Json;
using Npgsql;
using RestSharp;
using System.Data;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace AiPostgreWinForms
{
    public partial class FrmAiPostgre : Form
    {
        // Gemini API Data
        public static string endpoint = "https://generativelanguage.googleapis.com"; // Resource
        public static string uri = "/v1beta/models/gemini-1.5-flash-latest:generateContent?key="; // Model URI
        public static string apikey = ""; // API Key

        // Database Data
        public static string database = "";

        public FrmAiPostgre()
        {
            InitializeComponent();
        }

        private void FrmAiPostgre_Load(object sender, EventArgs e)
        {
            // Load saved API Key if remembered is checked
            if (File.Exists("apisettings.conf"))
            {
                ckbx_remember.Checked = true;
                tx_apikey.Text = File.ReadAllText("apisettings.conf");
                apikey = tx_apikey.Text;
            }

            // Load latest saved DB settings
            if (File.Exists("dbsettings.conf"))
            {
                string dbsettings = File.ReadAllText("dbsettings.conf");
                string[] settings = dbsettings.Split(';');
                tx_ip.Text = settings[0].Substring(settings[0].IndexOf("=") + 1);
                txt_db.Text = settings[3].Substring(settings[3].IndexOf("=") + 1);
                txt_user.Text = settings[1].Substring(settings[1].IndexOf("=") + 1);
                txt_pass.Text = settings[2].Substring(settings[2].IndexOf("=") + 1);
                database = dbsettings;
            }
            // Load text hints
            tb_userrequest.ForeColor = Color.Gray;
            tb_userrequest.Text = "Request...";
        }

        private void llbl_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Opens default browser with the Github profile
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = "https://github.com/LuisMiSanVe", UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error happened while trying to open your default browser: " + ex.Message, "Error while opening your default internet browser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_showquery_Click(object sender, EventArgs e)
        {
            if (tb_aiquery.Visible)
            {
                tb_aiquery.Visible = false;
                btn_tweak.Visible = false;
                btn_showquery.BackgroundImage = il_showimages.Images[0];
                tt_hover.SetToolTip(btn_showquery, "Show the generated query");
            }
            else
            {
                tb_aiquery.Visible = true;
                btn_tweak.Visible = true;
                btn_showquery.BackgroundImage = il_showimages.Images[1];
                tt_hover.SetToolTip(btn_showquery, "Hide the generated query");
            }
        }

        private void btn_keysettings_Click(object sender, EventArgs e)
        {
            // Displays the selected settings
            gb_key.Visible = true;
            gb_database.Visible = false;

            // Disables the functionality of the rest of the program
            btn_dbsettings.Enabled = false;
            btn_showquery.Enabled = false;
            btn_send.Enabled = false;
            tb_aiquery.Enabled = false;
            tb_userrequest.Enabled = false;
            dgv_airesult.Enabled = false;
            llbl_github.Enabled = false;
            btn_tweak.Enabled = false;
        }

        private void btn_dbsettings_Click(object sender, EventArgs e)
        {
            // Displays the selected settings
            gb_key.Visible = false;
            gb_database.Visible = true;

            // Disables the functionality of the rest of the program
            btn_keysettings.Enabled = false;
            btn_showquery.Enabled = false;
            btn_send.Enabled = false;
            tb_aiquery.Enabled = false;
            tb_userrequest.Enabled = false;
            dgv_airesult.Enabled = false;
            llbl_github.Enabled = false;
            btn_tweak.Enabled = false;
        }

        private void btn_saveapi_Click(object sender, EventArgs e)
        {
            if (Regex.Match(tx_apikey.Text, "^AIza[0-9A-Za-z_-]{35}$").Success)
            {
                // Saves the value and closes the settings
                apikey = tx_apikey.Text;
                if (ckbx_remember.Checked)
                    File.WriteAllText("apisettings.conf", apikey);

                gb_key.Visible = false;

                // Enables the functionality of the rest of the program
                btn_dbsettings.Enabled = true;
                btn_showquery.Enabled = true;
                btn_send.Enabled = true;
                tb_aiquery.Enabled = true;
                tb_userrequest.Enabled = true;
                dgv_airesult.Enabled = true;
                llbl_github.Enabled = true;
                btn_tweak.Enabled = true;
            }
            else
                MessageBox.Show("The API Key provided doesn't match with a Google API Key.", "API Key doesn't match the format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_savedb_Click(object sender, EventArgs e)
        {
            if (tx_ip.Text != "" && txt_user.Text != "" && txt_pass.Text != "" && txt_db.Text != "")
            {
                // Saves the value and closes the settings
                database = "Host=" + tx_ip.Text + ";Username=" + txt_user.Text + ";Password=" + txt_pass.Text + ";Database=" + txt_db.Text;
                // Verify the db
                var connection = new NpgsqlConnection(database);
                try
                {
                    // Try to open the connection, if it fails, it displays a message, else, closes the connection and saves
                    connection.Open();
                    connection.Close();

                    File.WriteAllText("dbsettings.conf", database);
                    gb_database.Visible = false;

                    // Enables the functionality of the rest of the program
                    btn_keysettings.Enabled = true;
                    btn_showquery.Enabled = true;
                    btn_send.Enabled = true;
                    tb_aiquery.Enabled = true;
                    tb_userrequest.Enabled = true;
                    dgv_airesult.Enabled = true;
                    llbl_github.Enabled = true;
                    btn_tweak.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("The PostgreSQL Server can't be reached, it's possible some of the provided data is wrong.", "Can't connect to PostgeSQL Server", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ckbx_remember_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbx_remember.Checked)
            {
                MessageBox.Show("The API Key will be stored in your device and could be seen by unwanted people.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                File.WriteAllText("apisettings.conf", tx_apikey.Text);
            }
            else
                File.Delete("apisettings.conf");
        }

        private void ckbx_showApi_Click(object sender, EventArgs e)
        {
            togglePassword(ckbx_showApi, tx_apikey);
        }

        private void togglePassword(CheckBox chk, TextBox txb)
        {
            if (chk.Checked)
                txb.PasswordChar = '\0';
            else
                txb.PasswordChar = '*';
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {   // You can't use it unless you have something written
                if (tb_userrequest.Text != "" && tb_userrequest.ForeColor != Color.Gray)
                {
                    // Enables the loading screen
                    gb_loading.Size = new Size(891, 709);
                    gb_loading.Location = new Point(-10, -40);
                    gb_loading.Visible = true;
                    lbl_loadstatus.Text = "Mapping...";
                    var thread = new Thread(() =>
                    {
                        // Connects to the database
                        var connection = new NpgsqlConnection(database);

                        if (connection != null)
                        {
                            connection.Open();

                            // OBTAIN DB
                            // Get the quantity of tables and columns for the loading bar
                            var tableQuantity = new NpgsqlCommand("SELECT (" +
                                                                  "SELECT COUNT(*) FROM information_schema.tables " +
                                                                  "WHERE table_type = 'BASE TABLE' AND table_name NOT LIKE 'pg_%' AND table_name NOT LIKE 'sql_%') +" +
                                                                  "(SELECT COUNT(*) FROM information_schema.columns " +
                                                                  "WHERE table_schema NOT LIKE 'pg_%' AND table_name NOT LIKE 'sql_%')", connection).ExecuteReader();
                            while (tableQuantity.Read())
                            {
                                pb_loading.Invoke((MethodInvoker)(() =>
                                {
                                    pb_loading.Maximum = tableQuantity.GetInt32(0);
                                }));
                            }
                            tableQuantity.Close();
                            // Tables
                            var tablesDB = new NpgsqlCommand("SELECT CONCAT(table_schema, '.', table_name) AS full_table_name " +
                                                             "FROM information_schema.tables WHERE table_type = 'BASE TABLE' AND table_name NOT LIKE 'pg_%' AND table_name NOT LIKE 'sql_%' " +
                                                             "ORDER BY full_table_name;", connection).ExecuteReader();
                            // Table           Column(Type)
                            Dictionary<string, List<string>> tables = new Dictionary<string, List<string>>();

                            while (tablesDB.Read())
                            {
                                if (!tables.ContainsKey(tablesDB.GetString(0)))
                                {
                                    //         Name                   Columns
                                    tables.Add(tablesDB.GetString(0), null);
                                    // Fills the loading bar
                                    pb_loading.Invoke((MethodInvoker)(() =>
                                    {
                                        if (pb_loading.Value < pb_loading.Maximum)
                                            pb_loading.Value++;
                                    }));
                                }
                            }
                            tablesDB.Close();
                            // Columns
                            foreach (string tableName in tables.Keys)
                            {
                                var columnsDB = new NpgsqlCommand("SELECT c.column_name, c.data_type, CASE WHEN tc.constraint_type = 'PRIMARY KEY' THEN 'PK' WHEN tc.constraint_type = 'FOREIGN KEY' THEN 'FK' ELSE '' END AS key_type " +
                                                                  "FROM information_schema.columns c " +
                                                                  "LEFT JOIN information_schema.key_column_usage kcu ON c.table_schema = kcu.table_schema AND c.table_name = kcu.table_name AND c.column_name = kcu.column_name " +
                                                                  "LEFT JOIN information_schema.table_constraints tc ON kcu.constraint_name = tc.constraint_name AND kcu.table_schema = tc.table_schema AND kcu.table_name = tc.table_name " +
                                                                  "WHERE c.table_schema = '" + tableName.Substring(0, tableName.IndexOf('.')) + "' AND c.table_name = '" + tableName.Remove(0, tableName.IndexOf('.') + 1) + "'" +
                                                                  "ORDER BY c.column_name;", connection).ExecuteReader();

                                List<string> columns = new List<string>();

                                while (columnsDB.Read())
                                {
                                    string columnInfo = columnsDB.GetString(0) + "(" + columnsDB.GetString(1) + ")";
                                    if (!columnsDB.GetString(2).Equals(""))
                                        columnInfo = columnsDB.GetString(0) + "(" + columnsDB.GetString(1) + ") (" + columnsDB.GetString(2) + ")";

                                    if (!columns.Contains(columnInfo))
                                    {   //      Name(Type)(Key)
                                        columns.Add(columnInfo);

                                        tables[tableName] = columns;
                                        // Fills the loading bar
                                        pb_loading.Invoke((MethodInvoker)(() =>
                                        {
                                            if (pb_loading.Value < pb_loading.Maximum)
                                                pb_loading.Value++;
                                        }));
                                    }
                                }
                                columnsDB.Close();
                            }
                            // Finish the loading bar
                            pb_loading.Invoke((MethodInvoker)(() =>
                            {
                                int difference = pb_loading.Maximum - pb_loading.Value;
                                pb_loading.Value += difference;
                            }));

                            var opcions = new JsonSerializerOptions
                            {
                                WriteIndented = true // JSON format
                            };

                            string json = System.Text.Json.JsonSerializer.Serialize(tables, opcions);

                            // Creates context to modify AI's behavior
                            string context = "You're a database assistant, I'll send you requests and you'll return a PostgeSQL query to do my request and if what I request can't be found on the database, tell me, but don't use more words. " +
                                             "This is the database: " +
                                             json +
                                             "\nAnd this is my request: ";

                            // I create the request
                            var Client = new RestClient(endpoint);
                            var request = new RestRequest(uri + apikey, Method.Post);
                            request.AddHeader("Content-Type", "application/json");

                            var body = new AIRequest();
                            body.contents = new Content[] { new Content() { parts = new Part[] { new Part() { text = context + tb_userrequest.Text } } } };

                            var jsonstring = JsonConvert.SerializeObject(body);

                            request.AddJsonBody(jsonstring);
                            // Sends the request to the service
                            string generatedSql = "";
                            lbl_loadstatus.Invoke((MethodInvoker)(() =>
                            {
                                lbl_loadstatus.Text = "Generating...";
                            }));
                            try
                            {
                                var response = Client.Post(request);
                                var resp = JsonDocument.Parse(response.Content);
                                // It extracts the AI's response from the 'Text' field                                                                                             and I remove the SQL Code style the AI adds
                                generatedSql = resp.RootElement.GetProperty("candidates")[0].GetProperty("content").GetProperty("parts")[0].GetProperty("text").GetString().Replace("```sql", "").Replace("```", "");
                                tb_aiquery.Text = generatedSql;
                            }
                            catch (HttpRequestException ex)
                            {
                                MessageBox.Show("The provided Gemini API Key has failed to access the endpoint, make sure the API Key or Service is functional", "API Key failed (" + ex.StatusCode + ")", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                gb_key.Invoke((MethodInvoker)(() =>
                                {
                                    btn_keysettings_Click(null, null);
                                }));
                            }
                            // Disables the loading screen
                            gb_loading.Invoke((MethodInvoker)(() =>
                            {
                                gb_loading.Visible = false;
                                gb_loading.Size = new Size(1, 1);
                                gb_loading.Location = new Point(0, 0);
                            }));
                            try
                            {
                                if (generatedSql != "")
                                {
                                    var resultBBDD = new NpgsqlCommand(generatedSql, connection).ExecuteReader();
                                    DataTable dt = new DataTable();
                                    dt.Load(resultBBDD);

                                    // Loads the result in the UI Thread
                                    dgv_airesult.Invoke((MethodInvoker)(() =>
                                    {
                                        dgv_airesult.DataSource = dt;
                                    }));
                                }

                                connection.Close();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("An error was thrown while running the generated query (" + generatedSql + ")", "The query failed to run in the PostgreSQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if (!btn_tweak.Visible)
                                    btn_showquery.Invoke((MethodInvoker)(() =>
                                    {
                                        btn_showquery_Click(sender, e);
                                    }));
                            }
                        }
                    });
                    thread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error happened while trying to get response of Gemini AI or PostgreSQL Server: " + ex.Message, "Error while getting response", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbx_dbpass_Click(object sender, EventArgs e)
        {
            togglePassword(chbx_dbpass, txt_pass);
        }

        private void tb_userrequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_send_Click(sender, e);
        }

        private void btn_tweak_Click(object sender, EventArgs e)
        {
            if (tb_aiquery.Text != "")
            {
                var connection = new NpgsqlConnection(database);

                if (connection != null)
                {
                    connection.Open();
                    try
                    {
                        var resultBBDD = new NpgsqlCommand(tb_aiquery.Text, connection).ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(resultBBDD);

                        // Loads the result
                        dgv_airesult.DataSource = dt;

                        connection.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error was thrown while running the query (" + tb_aiquery.Text + ")", "The query failed to run in the PostgreSQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_tweak_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_tweak_Click(sender, e);
        }

        private void tb_userrequest_Enter(object sender, EventArgs e)
        {
            if (tb_userrequest.ForeColor == Color.Gray)
            {
                tb_userrequest.ForeColor = Color.Black;
                tb_userrequest.Text = "";
            }
        }

        private void tb_userrequest_Leave(object sender, EventArgs e)
        {
            if (tb_userrequest.Text == "")
            {
                tb_userrequest.ForeColor = Color.Gray;
                tb_userrequest.Text = "Request...";
            }
        }

        private void btn_dbback_Click(object sender, EventArgs e)
        {
            gb_database.Visible = false;

            // Enables the functionality of the rest of the program
            btn_keysettings.Enabled = true;
            btn_showquery.Enabled = true;
            btn_send.Enabled = true;
            tb_aiquery.Enabled = true;
            tb_userrequest.Enabled = true;
            dgv_airesult.Enabled = true;
            llbl_github.Enabled = true;
            btn_tweak.Enabled = true;
        }

        private void btn_keyback_Click(object sender, EventArgs e)
        {
            gb_key.Visible = false;

            // Enables the functionality of the rest of the program
            btn_dbsettings.Enabled = true;
            btn_showquery.Enabled = true;
            btn_send.Enabled = true;
            tb_aiquery.Enabled = true;
            tb_userrequest.Enabled = true;
            dgv_airesult.Enabled = true;
            llbl_github.Enabled = true;
            btn_tweak.Enabled = true;
        }

        private void FrmAiPostgre_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If the user tries to close the program while it's loading...
            if (gb_loading.Visible == true)
            {   // Checks for verification
                string tokenwaste = "";
                if (lbl_loadstatus.Text.Contains("Generating..."))
                    tokenwaste = "(You'll waste the used Tokens!)";
                var result = MessageBox.Show("The program is in the " + lbl_loadstatus.Text.Replace("...", "") + " process, you do want to exit? " + tokenwaste, "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
