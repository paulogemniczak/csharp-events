namespace AdvancedTopics_Events
{
    internal class VideoEncoder
    {
        // 1 - Define a delegate
        public delegate void VideoEcondedEventHandler(object source, EventArgs args);

        // 2 - Define an event based on that delegate
        public event VideoEcondedEventHandler? VideoEconded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding...");
            Thread.Sleep(3000);

            OnVideoEconded();
        }

        // 3 - Raise the event
        protected virtual void OnVideoEconded()
        {
            if (VideoEconded != null)
            {
                VideoEconded(this, EventArgs.Empty);
            }
        }
    }
}
