using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace TemperatureDetect
{
    public partial class Form1 : Form
    {
        string Topic = "lab";
        delegate void UpdateDataGridViewCallback(string topic, string msg);
        MySqlConnection connection = new MySqlConnection("Server=120.126.145.99;Port=3306" +
            ";Database=arduinoData;Uid=monitor;Pwd=nykd54;Sslmode=none;");   
        delegate void SetTextCallback(string text);

        MqttClient client;
        string clientId;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new MqttClient("120.126.145.99");
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            client = new MqttClient("120.126.145.99");
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);
            client.Subscribe(new string[] { Topic }, new byte[] { 0 });
        }

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);

            SetText(ReceivedMessage);

            string ReceivedTopic = e.Topic.ToLower();                                                  
        }

        private void SetText(string text)
        {
            string[] newtext = text.Split(';');
            if (this.RecText.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.RecText.Text += newtext[0] + "\r\n";
                this.RecText2.Text += newtext[1] + "\r\n";

                connection.Open();
                DateTime myDate = DateTime.Now;
                string myDateString = myDate.ToString("yyyy-MM-dd HH:mm:ss");
                string query = "INSERT INTO DATA (time,temperature,humidity) VALUES ('" +
                        myDateString + "','" + newtext[0] + "','" + newtext[1] + "');";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }           
        }

        private void SelectMySQL(MySqlConnection connection, string tablename, DataGridView datagrid)
        {
            string sql = "SELECT * FROM " + tablename;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            adapter.Fill(table);
            datagrid.DataSource = table;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UpdateDataGridView(string topic, string message)
        {
            if (this.InvokeRequired)
            {
                UpdateDataGridViewCallback d = new UpdateDataGridViewCallback(UpdateDataGridView);
                this.Invoke(d, new object[] { topic, message });
            }
            else
            {
                SelectMySQL(connection, topic, (DataGridView)this.Controls.Find("dataGridView_" + topic, true)[0]);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SelectMySQL(connection, "DATA", dataGridView_sensor);
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            client.Disconnect();
        }
    }
}