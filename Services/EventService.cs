public class EventService
{
    public List<Event> Events = new List<Event>()
    {
        new Event { Id = 1, Name = "Tech Conference", Location = "Madrid", Date = DateTime.Now },
        new Event { Id = 2, Name = "AI Summit", Location = "Barcelona", Date = DateTime.Now.AddDays(10) }
    };

    public List<Event> GetEvents() => Events;
}