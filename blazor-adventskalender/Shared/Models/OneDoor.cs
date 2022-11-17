using System;

namespace blazor_adventskalender.Shared.Models
{
    public class OneDoor
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int Day
        {
            get
            {
                return Date.Day;
            }
        }
    }
}
