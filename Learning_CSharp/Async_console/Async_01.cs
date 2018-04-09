using System;
using System.Threading;
using System.Threading.Tasks;

public class Async_01
{
    public async Task<string> ShowTodaysInfo()
    {
        var leisureHours = await GetLeisureHours();
        string info = $"Today is {DateTime.Today:D}\nToday's hours of leisure: {leisureHours}";
        return info;
    }

    public async Task<int> GetLeisureHours()
    {
        var today = await Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());

        int leisureHours;
        if (today.StartsWith("S"))
            leisureHours = 16;
        else
            leisureHours = 5;

        return leisureHours;    
    }
}