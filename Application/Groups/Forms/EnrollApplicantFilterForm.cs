namespace Application.Groups.Forms;

public class EnrollApplicantFilterForm
{
    public string? SearchString { get; set; }

    public bool IncludeSelected { get; set; } = true;

    public bool IncludeNotSelected { get; set; } = true;

    public void Reset()
    {
        SearchString = null;
    }
}