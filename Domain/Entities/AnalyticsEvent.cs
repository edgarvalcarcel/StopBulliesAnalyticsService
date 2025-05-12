namespace AnalyticsService.Domain.Entities {
    public class AnalyticsEvent {
        public Guid Id { get; set; }
        public string Service { get; set; }
        public string EventType { get; set; }
        public string Payload { get; set; }
        public DateTime Timestamp { get; set; }
    }
}