using System;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;


namespace Consumer.Console
{
    public class Program
    {
        private static string connectionString = "amqp://guest:guest@localhost:5672";

        private static string queueName;

        private static IConnection connection;
        private static IModel _channel;
        private static IModel channel => _channel ?? (_channel = CreateOrGetChannel());


        static void Main(string[] args)
        {
            queueName = args.Length > 0 ? args[0] : "test_new_queue";

            connection = GetConnection();


            var consumerEvent = new EventingBasicConsumer(channel);

            consumerEvent.Received += (ch, e) =>
            {
                var byteArr = e.Body.ToArray();
                var bodyStr = Encoding.UTF8.GetString(byteArr);

                System.Console.WriteLine($"Recevied Data: {bodyStr}");
            };

            channel.BasicConsume(queueName, true, consumerEvent);

            System.Console.WriteLine($"{queueName} listening... \n\n\n");

            System.Console.ReadLine();

        }


        private static IModel CreateOrGetChannel()
        {
            return connection.CreateModel();
        }

        private static IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                Uri = new Uri(connectionString, UriKind.RelativeOrAbsolute)
            };

            return factory.CreateConnection();
        }
    }
}
