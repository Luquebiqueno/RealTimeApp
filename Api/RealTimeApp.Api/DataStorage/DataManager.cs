using RealTimeApp.Api.Models;

namespace RealTimeApp.Api.DataStorage
{
    public class DataManager
    {
        public static List<ChartModel> GetData()
        {
            var r = new Random();
            return new List<ChartModel>
            {
                new ChartModel { Data = new List<int>{ r.Next(1, 50) }, Label = "Data1" },
                new ChartModel { Data = new List<int>{ r.Next(1, 50) }, Label = "Data2" },
                new ChartModel { Data = new List<int>{ r.Next(1, 50) }, Label = "Data3" },
                new ChartModel { Data = new List<int>{ r.Next(1, 50) }, Label = "Data4" }
            };
        }
    }
}
