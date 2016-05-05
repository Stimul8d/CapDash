using Humanizer;
using System;

namespace CapDash.Models
{
    public class HomeModel
    {
        public string Title { get; }
        public string MinResponseTime { get; }
        public string MaxResponseTime { get; }
        public string TotalResponseTime { get; }

        public string AverageTimeToFirstByte { get; }

        public HomeModel(int numberOfUsers, int minResponseTime, 
            int maxResponseTime, int totalResponseTime)
        {
            Title = $"Last Run - {numberOfUsers} / 5000";
            MinResponseTime = $"Min \n {TimeSpan.FromMilliseconds(minResponseTime).Humanize(precision:2)}";
            MaxResponseTime = $"Max \n {TimeSpan.FromMilliseconds(maxResponseTime).Humanize(precision:2)}";
            TotalResponseTime = $"Total \n {TimeSpan.FromMilliseconds(totalResponseTime).Humanize(precision:2)}";
        }
    }
}