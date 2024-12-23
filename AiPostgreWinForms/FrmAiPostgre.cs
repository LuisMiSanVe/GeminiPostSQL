using AiPostgreWinForms.Properties;
using Newtonsoft.Json;
using Npgsql;
using RestSharp;
using System.Data;
using System.Text.Json;

namespace AiPostgreWinForms
{
    public partial class FrmAiPostgre : Form
    {
        // Gemini API Data
        public static string endpoint = "https://generativelanguage.googleapis.com"; // Resource
        public static string uri = "/v1beta/models/gemini-1.5-flash-latest:generateContent?key="; // Model URI
        public static string apikey = ""; // API Key
        public static int limit = 0;

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
        }

        private void llbl_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = "https://github.com/LuisMiSanVe", UseShellExecute = true });
        }

        private void btn_showquery_Click(object sender, EventArgs e)
        {
            if (tb_aiquery.Visible == false)
            {
                tb_aiquery.Visible = true;
                btn_showquery.BackgroundImage = il_showimages.Images[1];
            }
            else
            {
                tb_aiquery.Visible = false;
                btn_showquery.BackgroundImage = il_showimages.Images[0];
            }
        }

        private void btn_keysettings_Click(object sender, EventArgs e)
        {
            gb_key.Visible = true;
            gb_database.Visible = false;
        }

        private void btn_dbsettings_Click(object sender, EventArgs e)
        {
            gb_key.Visible = false;
            gb_database.Visible = true;
        }

        private void btn_saveapi_Click(object sender, EventArgs e)
        {
            if (tx_apikey.Text != "")
            {
                apikey = tx_apikey.Text;
                gb_key.Visible = false;
            }
        }

        private void btn_savedb_Click(object sender, EventArgs e)
        {
            if (tx_ip.Text != "" && txt_user.Text != "" && txt_pass.Text != "" && txt_db.Text != "")
            {
                database = "Host=" + tx_ip.Text + ";Username=" + txt_user.Text + ";Password=" + txt_pass.Text + ";Database=" + txt_db.Text;

                File.WriteAllText("dbsettings.conf", database);
                gb_database.Visible = false;
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
            {
                File.Delete("apisettings.conf");
            }
        }

        private void ckbx_showApi_Click(object sender, EventArgs e)
        {
            if (ckbx_showApi.Checked)
            {
                tx_apikey.PasswordChar = '\0';
            }
            else
            {
                tx_apikey.PasswordChar = '*';
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            // Connects to the database
            var connection = new NpgsqlConnection(database);

            string result = "";

            if (connection != null)
            {
                connection.Open();

                // OBTAIN DB
                // Tables
                var tablesDB = new NpgsqlCommand("SELECT CONCAT(table_schema, '.', table_name) AS full_table_name " +
                                                 "FROM information_schema.tables WHERE table_type = 'BASE TABLE' AND table_name NOT LIKE 'pg_%' AND table_name NOT LIKE 'sql_%' " +
                                                 "ORDER BY full_table_name;", connection).ExecuteReader();
                // Table           Column(Type)
                Dictionary<string, List<string>> tables = new Dictionary<string, List<string>>();

                while (tablesDB.Read())
                {
                    if (!tables.ContainsKey(tablesDB.GetString(0)))
                        //         Name                   Columns
                        tables.Add(tablesDB.GetString(0), null);
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
                        }
                    }
                    columnsDB.Close();
                }
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
                var response = Client.Post(request);
                var resp = JsonDocument.Parse(response.Content);
                // It extracts the AI's response from the 'Text' field                                                                                             and I remove the SQL Code style the AI adds
                string generatedSql = resp.RootElement.GetProperty("candidates")[0].GetProperty("content").GetProperty("parts")[0].GetProperty("text").GetString().Replace("```sql", "").Replace("```", "");
                try
                {
                    var resultBBDD = new NpgsqlCommand(generatedSql, connection).ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(resultBBDD);

                    dgv_airesult.DataSource = dt;

                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error was thrown while running the generated query");
                    tb_aiquery.Text = generatedSql;
                }
            }
        }
    }
}
