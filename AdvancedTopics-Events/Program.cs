using AdvancedTopics_Events;

Video video = new() { Title = "teste.mp4" };
VideoEncoder encoder = new(); // publisher
MailService mailService = new(); //subscriber
MessageService messageService = new(); //subscriber

encoder.VideoEconded += mailService.OnVideoEncoded;
encoder.VideoEconded += messageService.OnVideoEncoded;

encoder.Encode(video);
