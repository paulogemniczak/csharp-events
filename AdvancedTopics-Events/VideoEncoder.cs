namespace AdvancedTopics_Events
{
    internal class VideoEventArgs : EventArgs
    {
        public Video? Video { get; set; }
    }

    internal class VideoEncoder
    {
        public event EventHandler<VideoEventArgs>? VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding...");
            Thread.Sleep(3000);

            OnVideoEconded(video);
        }

        protected virtual void OnVideoEconded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs { Video = video });
            }
        }
    }
}
