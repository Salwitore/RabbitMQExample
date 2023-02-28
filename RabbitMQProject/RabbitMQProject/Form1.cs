using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace RabbitMQProject
{
    public partial class Form1 : Form
    {
        private bool _isConnectionOpen;

        private bool isConnectionOpen
        {
            get => _isConnectionOpen;
            set
            {
                _isConnectionOpen = value;
                ConnectionStateChanged();
            }
        }

        private IConnection connection;

        private IModel _channel;
        private IModel channel => _channel ?? (_channel = CreateOrGetChannel());

        public Form1()
        {
            
            InitializeComponent();
            Init();
        }

        private void buttonConnectClick(object sender, EventArgs e)
        {
            if (!isConnectionOpen || connection == null)
            {
                connection = GetConnection();
            }
            else
            {
                connection.Close();
            }
            isConnectionOpen = connection.IsOpen;

        }

        private void buttonDeclareQueueClick(object sender, EventArgs e)
        {
            channel.QueueDeclare(txtDeclareQueueName.Text, false, false, false);
            AddLog($"Queue Created Name: {txtDeclareQueueName.Text}");
        }

        private void buttonDeclareExchangeClick(object sender, EventArgs e)
        {
            channel.ExchangeDeclare(txtDeclareExchangeName.Text, cmbBoxDeclareExchangeType.Text);
            AddLog($"Exchange created witch Name: {txtDeclareExchangeName.Text}, Type: {cmbBoxDeclareExchangeType.Text}");
        }

        private void buttonBindQueueClick(object sender, EventArgs e)
        {
            channel.QueueBind(txtDeclareQueueName.Text, txtDeclareExchangeName.Text, txtBindRoutingKey.Text);
        }

        private void buttonPublishClick(object sender, EventArgs e)
        {

            var message = txtMessage.Text;

            for (int i = 0; i < numericRepeatCount.Value; i++)
            {
                if (useCounter.Checked)
                {
                    message = $"[{i + 1}] - {txtMessage.Text}";
                }

                WriteDataToExchange(txtExchangeName.Text, txtRoutingKey.Text, txtMessage.Text);
            }
        }

        private IModel CreateOrGetChannel()
        {
            return connection.CreateModel();
        }

        private IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                Uri = new Uri(txtConnectionString.Text, UriKind.RelativeOrAbsolute)
            };

            return factory.CreateConnection();
        }

        private void WriteDataToExchange(string exchangeName, string routingKey , object data)
        {
            var dataArr = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));

            channel.BasicPublish(exchangeName , routingKey,null,dataArr);
        }

        private void ConnectionStateChanged()
        {
            btnConnect.Text = isConnectionOpen ? "Disconnect" : "Connect";

            UpdateConnectionStatus();
        }

        private void UpdateConnectionStatus()
        {
            string state = $"{(isConnectionOpen ? "" : "Not ")}Connected";
            lblConnectionStatus.Text = $"Connection State: {state}";
            AddLog($"Connection state is {state}");
        }

        public void AddLog(string logStr)
        {
            logStr = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {logStr}";
            txtLog.AppendText($"{logStr}\n");

            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        public void Init()
        {
            cmbBoxDeclareExchangeType.Items.Add("direct");
            cmbBoxDeclareExchangeType.Items.Add("fanout");
            cmbBoxDeclareExchangeType.Items.Add("headers");
            cmbBoxDeclareExchangeType.Items.Add("topic");

            cmbBoxBindDeclareExchangeType.Items.Add("dirrect");
            cmbBoxBindDeclareExchangeType.Items.Add("fanout");
            cmbBoxBindDeclareExchangeType.Items.Add("headers");
            cmbBoxBindDeclareExchangeType.Items.Add("topic");

            cmbBoxBindDeclareExchangeType.SelectedIndex = cmbBoxDeclareExchangeType.SelectedIndex = 0;
        }
    }
}