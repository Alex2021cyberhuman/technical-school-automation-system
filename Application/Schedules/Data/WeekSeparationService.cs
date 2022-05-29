namespace Application.Schedules.Data;

public class WeekSeparationService
{
    private readonly DateTime _numeratorWeekSunday;
    
    public WeekSeparationService(IConfiguration configuration)
    {
        _numeratorWeekSunday = configuration.GetSection("WeekSeparation:NumeratorWeekSunday").Get<DateTime>();
    }

    public WeeksSeparationType GetCurrentWeekSeparation(DateTime dateTime)
    {
        var daysToSunday = (int) dateTime.DayOfWeek;
        if (daysToSunday == 0) {
            daysToSunday = 0;
        }
        else 
        {
            daysToSunday = 7 - daysToSunday;
        }
        dateTime = dateTime.Date.AddDays(daysToSunday);	
        var difference = dateTime - _numeratorWeekSunday;
        var differenceInWeeks = difference.Days / 7;
        var isNumerator = differenceInWeeks % 2 == 0;
        return isNumerator ? WeeksSeparationType.Numerator : WeeksSeparationType.Divisor;
    }
}