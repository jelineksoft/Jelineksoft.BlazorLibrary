using System;
using System.Collections.Generic;

namespace Jelineksoft.BlazorLibrary.Bags
{
    public class Bag_DateTimeInput
    {
        public Bag_DateTimeInput()
        {
            for (var i = 0; i < (6 * 7); i++)
            {
                Days.Add(new Day());
            }
        }

        public List<Day> Days { get; set; } = new List<Day>(6 * 7);
        public DateTime SelectedDate { get; set; } = DateTime.Now;
        public bool SelectedDateIsNull { get; set; } = false;
        

        public class Day
        {
            public string Description { get; set; } = String.Empty;
            public int Value { get; set; } = 0;
            public bool IsSelected { get; set; } = false;
        }

    }
}