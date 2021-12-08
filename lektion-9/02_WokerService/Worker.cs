using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace _02_WokerService
{
    enum State
    {
        idle,
        processing,
        processed
    }


    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private string[] _siteUrls = { "https://google.com", "https://ecutbildning.se" };
        private HttpClient client;
        private State programState = State.idle;
        private List<HttpResponseMessage> responses = new List<HttpResponseMessage>();


        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            client = new HttpClient();

            _logger.LogInformation("The WorkerService has been started.");
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            client.Dispose();


            _logger.LogInformation("The WorkerService has been stopped.");
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                programState = State.processing;

                while (programState == State.processing)
                {
                    foreach (var siteUrl in _siteUrls)
                    {
                        var res = await client.GetAsync(siteUrl);
                        responses.Add(res);

                        if (res.IsSuccessStatusCode)
                            _logger.LogInformation($"Checked at: {DateTimeOffset.Now}. The website {siteUrl} is up and running.");
                        else
                            _logger.LogError($"Checked at: {DateTimeOffset.Now}. The website {siteUrl} is down and not running.");

                        res.Dispose();
                    }

                    programState = State.processed;
                }

                await Task.Delay(10000, stoppingToken);
            }
        }
    }
}
