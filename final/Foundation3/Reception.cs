public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() +
               $"Type: Reception\nRSVP at: {_rsvpEmail}\n";
    }

    public override string GetShortDescription()
    {
        return $"Reception: {_title} on {_date}";
    }
}