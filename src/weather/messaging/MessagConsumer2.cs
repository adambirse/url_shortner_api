using MassTransit;

namespace messaging
{
    public class Message2
    {
        public string Text { get; set; }
    }

    public class MessageConsumer2 :
        IConsumer<Message2>
    {
        readonly ILogger<MessageConsumer> _logger;

        public MessageConsumer2(ILogger<MessageConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<Message2> context)
        {
            _logger.LogInformation("Message2 Consumer Received Text: {Text}", context.Message.Text);

            return Task.CompletedTask;
        }
    }
}