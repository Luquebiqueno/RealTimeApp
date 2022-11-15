﻿namespace RealTimeApp.Api.Models
{
    public class ChartModel
    {
        public List<int> Data { get; set; }
        public string Label { get; set; }

        public ChartModel()
        {
            Data= new List<int>();
        }
    }
}
