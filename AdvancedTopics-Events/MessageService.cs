namespace AdvancedTopics_Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object souce, EventArgs args)
        {
            Console.WriteLine("Sending a text message...");
        }
    }
}