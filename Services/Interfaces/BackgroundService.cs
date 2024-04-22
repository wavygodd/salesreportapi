namespace salesreportapi.Services.Interfaces
{
    public class BackgroundService : IHostedService, IDisposable
    {

        private readonly ILogger<BackgroundService> _logger;
        private Timer _timer;

        //private readonly HttpClient _httpClient;
        //private const string BaseUrl = "https://demo.xambapos.nl:6443/api/Public";
        //private const string LoginEndpoint = BaseUrl + "/Login";
        //private const string GetSalesTransactionsEndpoint = BaseUrl + "/GetSalesTransactions";

        public BackgroundService(ILogger<BackgroundService> logger)
        {
            _logger = logger;
            //   _httpClient = httpClient;
        }



        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Background Service to get the sales data is starting.");
            _timer = new Timer(RunTask, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            return Task.CompletedTask;
        }




        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Background Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }




        public void Dispose()
        {
            _timer?.Dispose();
        }


        private void RunTask(object state)
        {
            // Your API call logic here
            _logger.LogInformation("Background Service is working.");
            Console.WriteLine("Background task is running.");
            // Call your external API
            // Put your logic here to fetch sales data from the third-party service,
            // process it, and save it to the database.

            // Example:
            // CallLoginEndpoint();
            // if (LoginSuccessful) {
            //    CallGetSalesTransactionsEndpoint();
            //    ProcessAndSaveDataToDatabase();
            // }
        }
    }
}
