public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Event: {_title}\nDescription: {_description}\nDate: {_date} Time: {_time}\nLocation: {_address.GetFullAddress()}\n";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails() + "Type: General Event\n";
    }

    public virtual string GetShortDescription()
    {
        return $"General Event: {_title} on {_date}";
    }
}
