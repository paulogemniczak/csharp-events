﻿namespace AdvancedTopics_Events
{
    internal class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: Sending an email... {e.Video?.Title}");
        }
    }
}