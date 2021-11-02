using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitMqSample
{
    public partial class Form1 : Form
    {
        private IConnection _rabbitMqConnection;
        private IModel _emailChannel;
        private IModel _smsChannel;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnectRabbitMq_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["RabbitMqConnection"].ConnectionString;
            var connectionFactory = new ConnectionFactory();
            connectionFactory.Uri = new Uri(connectionString);
            connectionFactory.AutomaticRecoveryEnabled = true;
            connectionFactory.DispatchConsumersAsync = true;
            _rabbitMqConnection = connectionFactory.CreateConnection("DemoAppClient");
        }

        private void btnCreateExchange_Click(object sender, EventArgs e)
        {
            using(var channel = _rabbitMqConnection.CreateModel())
            {
                channel.ExchangeDeclare("CustomerNotification", ExchangeType.Direct, true, false);
            }
        }

        private void btnCreateQueues_Click(object sender, EventArgs e)
        {
            using (var channel = _rabbitMqConnection.CreateModel())
            {
                channel.QueueDeclare("Email", true, false, false);
                channel.QueueDeclare("Sms", true, false, false);
            }
        }

        private void btnBindQueues_Click(object sender, EventArgs e)
        {
            using (var channel = _rabbitMqConnection.CreateModel())
            {
                channel.QueueBind("Email", "CustomerNotification", "email");
                channel.QueueBind("Sms", "CustomerNotification", "sms");
            }
        }

        private void btnPublishEmail_Click(object sender, EventArgs e)
        {
            using (var channel = _rabbitMqConnection.CreateModel())
            {
                var message = txtPublishEmail.Text;

                var properties = channel.CreateBasicProperties();
                properties.DeliveryMode = 2;
                channel.BasicPublish("CustomerNotification", "email", properties, Encoding.UTF8.GetBytes(message));
            }
        }

        private void btnPublishSms_Click(object sender, EventArgs e)
        {
            using (var channel = _rabbitMqConnection.CreateModel())
            {
                var message = txtPublishSms.Text;

                var properties = channel.CreateBasicProperties();
                properties.DeliveryMode = 2;
                channel.BasicPublish("CustomerNotification", "sms", properties, Encoding.UTF8.GetBytes(message));
            }
        }

        private void btnSubscribeEmailQueue_Click(object sender, EventArgs e)
        {
            _emailChannel = _rabbitMqConnection.CreateModel();
            _emailChannel.BasicQos(0, 1, false);
            var emailChannelConsumer = new AsyncEventingBasicConsumer(_emailChannel);
            emailChannelConsumer.Received += EmailChannelConsumer_Received;
            _emailChannel.BasicConsume("Email", false, emailChannelConsumer);
        }

        private async Task EmailChannelConsumer_Received(object sender, BasicDeliverEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Body.ToArray());
            lstEmailMessages.Invoke((MethodInvoker)(() => lstEmailMessages.Items.Add(message)));

            _emailChannel.BasicAck(e.DeliveryTag, false);
        }

        private void btnSubscribeSmsQueue_Click(object sender, EventArgs e)
        {
            _smsChannel = _rabbitMqConnection.CreateModel();
            _smsChannel.BasicQos(0, 1, false);
            var smsChannelConsumer = new AsyncEventingBasicConsumer(_smsChannel);
            smsChannelConsumer.Received += SmsChannelConsumer_Received; ;
            _smsChannel.BasicConsume("Sms", false, smsChannelConsumer);
        }

        private async Task SmsChannelConsumer_Received(object sender, BasicDeliverEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Body.ToArray());
            lstSmsMessages.Invoke((MethodInvoker)(() => lstSmsMessages.Items.Add(message)));

            _smsChannel.BasicAck(e.DeliveryTag, false);
        }
    }
}
