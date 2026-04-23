using System.Collections.Generic;

public class EventService
{
    private List<Event> events = new List<Event>()
    {
        new Event { Id = 1, Name = "Tech Conference", Location = "Madrid", Date = DateTime.Now },
        new Event { Id = 2, Name = "AI Summit", Location = "Barcelona", Date = DateTime.Now.AddDays(5) }
    };

    public List<Event> GetEvents()
    {
        return events;
    }
}