using System;

namespace ITB2203Application.Model;

public class Event
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateOnly Date { get; set; }
    public string Location { get; set; }
    public int SpeakerId { get; set; }
}
