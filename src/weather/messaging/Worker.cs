using messaging;
using MassTransit;

public class Worker : BackgroundService
{
    readonly IBus _bus;

    public Worker(IBus bus)
    {
        _bus = bus;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            Console.WriteLine("Publishing message");

            await _bus.Publish(new Message { Text = $"Message: The time is {DateTimeOffset.Now}" });
            await _bus.Publish(new Message2 { Text = $"Message2: The time is {DateTimeOffset.Now}" });


            await Task.Delay(1000, stoppingToken);
        }
    }
}