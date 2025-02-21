namespace Domain;

public class Activity
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public DateTime Date { get; set; }
    public required string Description { get; set; }
    public required string Category { get; set; }

    // location props
    public required string City { get; set; }
    public required string Venue { get; set; }
}
