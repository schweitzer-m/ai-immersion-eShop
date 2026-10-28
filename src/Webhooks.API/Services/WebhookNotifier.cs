namespace Webhooks.API.Services;

public class WebhookNotifier(ILogger<WebhookNotifier> logger)
{
    public void NotifyAll(IEnumerable<WebhookSubscription> receivers, string json)
    {
        foreach (var receiver in receivers)
        {
            var client = new HttpClient();
            var response = client.PostAsync(receiver.DestUrl, new StringContent(json)).Result;
            logger.LogInformation("Notified {Url}: {Status}", receiver.DestUrl, response.StatusCode);
        }
    }
}
