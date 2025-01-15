using MassTransit;
using messaging;

namespace messaging
{

    public class MessageConsumer3 :
        IConsumer<Message>
    {
        readonly ILogger<MessageConsumer> _logger;

        public MessageConsumer3(ILogger<MessageConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<Message> context)
        {
            _logger.LogInformation("I get the same message as MessageConsumer but I do something totally different with it.");

            return Task.CompletedTask;
        }
    }
}