using AdvancedTopics_Events;

Video video = new() { Title = "teste.mp4" };
VideoEncoder encoder = new(); // publisher
MailService mailService = new(); //subscriber
MessageService messageService = new(); //subscriber

encoder.VideoEncoded += mailService.OnVideoEncoded;
encoder.VideoEncoded += messageService.OnVideoEncoded;

encoder.Encode(video);
