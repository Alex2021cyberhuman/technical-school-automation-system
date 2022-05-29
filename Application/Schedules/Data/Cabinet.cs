namespace Application.Schedules.Data;

public class Cabinet
{
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;


    public string Code { get; set; } = string.Empty;

    public string Profile { get; set; } = string.Empty;

    public int Floor { get; set; }

    public string Wing { get; set; } = string.Empty;
}