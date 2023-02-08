using AdvancedTopics_Events;

Video video = new() { Title = "teste.mp4" };
VideoEncoder encoder = new();
MailService mailService = new();
MessageService messageService = new();

encoder.VideoEncoded += mailService.OnVideoEncoded;
encoder.VideoEncoded += messageService.OnVideoEncoded;

encoder.Encode(video);
