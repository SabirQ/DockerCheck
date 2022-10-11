using RabbitMQ.Client;

const string queue_name = "code-queue";
var factor = new ConnectionFactory
{
    HostName = "localhost",
    Uri = new Uri("amqp://guest:guest@localhost:5672")
};

using var connection=factor.CreateConnection();
using var channel = connection.CreateModel();
channel.QueueDeclare(queue_name,durable:true,exclusive:false,autoDelete:false,arguments:null);


