namespace TestSecrets.Api
{
    public class SampleService
    {
        public SampleService(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey { get; }
    }
}