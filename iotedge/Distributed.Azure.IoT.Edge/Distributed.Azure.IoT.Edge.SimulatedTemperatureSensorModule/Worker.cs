﻿namespace Distributed.Azure.IoT.Edge.SimulatedTemperatureSensorModule
{
    using Dapr.Client;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;

    internal class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly DaprClient _daprClient;
        private readonly string _messagePubSubName;
        private readonly string _messageTopic;

        public Worker(ILogger<Worker> logger, DaprClient daprClient, string messagePubSubName, string messageTopic)
        {
            _daprClient = daprClient ?? throw new ArgumentNullException(nameof(daprClient));
            _messagePubSubName = messagePubSubName ?? throw new ArgumentNullException(nameof(messagePubSubName));
            _messageTopic = messageTopic ?? throw new ArgumentNullException(nameof(messageTopic));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var temperatureMessage = new TemperatureMessage(new TemperaturePressure(GetRandomNumber(0, 100), GetRandomNumber(0, 100)), new TemperaturePressure(GetRandomNumber(0, 100), GetRandomNumber(0, 100)));

                Console.WriteLine($"Sending event to message layer, pubsub name {_messagePubSubName}, topic {_messageTopic}, object {temperatureMessage}");
                await _daprClient.PublishEventAsync(_messagePubSubName, _messageTopic, temperatureMessage, stoppingToken);

                await Task.Delay(2000, stoppingToken);
            }
        }

        private double GetRandomNumber(double minimum, double maximum)
        {
            var random = new Random();
            return (random.NextDouble() * (maximum - minimum)) + minimum;
        }
    }
}