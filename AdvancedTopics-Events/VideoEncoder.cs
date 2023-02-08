namespace AdvancedTopics_Events
{
    internal class VideoEventArgs : EventArgs
    {
        public Video? Video { get; set; }
    }

    internal class VideoEncoder
    {
        // 1 - Define a delegate
        public delegate void VideoEcondedEventHandler(object source, VideoEventArgs args);

        // 2 - Define an event based on that delegate
        public event VideoEcondedEventHandler? VideoEconded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding...");
            Thread.Sleep(3000);

            OnVideoEconded(video);
        }

        // 3 - Raise the event
        protected virtual void OnVideoEconded(Video video)
        {
            if (VideoEconded != null)
            {
                VideoEconded(this, new VideoEventArgs { Video = video });
            }
        }
    }
}
