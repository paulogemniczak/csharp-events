namespace AdvancedTopics_Events
{
    internal class MessageService
    {
        public void OnVideoEncoded(object? souce, VideoEventArgs args)
        {
            Console.WriteLine($"Sending a text message... {args.Video?.Title}");
        }
    }
}