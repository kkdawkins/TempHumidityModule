namespace TempHumidModule
{
    public class DataMessage
    {
        // T=39.0H=12.0\nT:39.0H:12.0\nT:39.0H:12.0\nT:39.0H:12.0
        public DataMessage(string raw)
        {

        }

        public string Temperature { get; }

        public string Humidity { get; }
    }
}
