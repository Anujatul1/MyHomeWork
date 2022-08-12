using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace JsonFileGeneration
{
    internal class Program
    {
        static void Main(string[] args)

        {
            var EPCInfo = new EPCInfo
            {
                Id = "24210000000000121KFIWS4BJ"
            };
            var CRInfo = new CRInfo

            {
                Status = "1",
                StatusComment = "OK",
                DisaggregationMessage = "NO",
                DisaggregationMesssageRecordTime = " ",
                DisaggregationMesssageType = " ",
                DisaggregationMesssageRecallCode = " ",
                Location = "xxx",
                LocationDest = " ",
                Date = DateTime.Parse("2022-08-10"),
                DateTime = new List<DateTimeOffset>() { DateTime.Parse("2022-08-10"), DateTime.Parse("2022-08-10") },
                LocationMessageType = "Packge_in_progress",
                LocationMessageRecallCode = "Aggregation_TPD_StockAPI_QA_CASE_1714",

            };
            var PRInfo = new PRInfo

            {
                Status = "1",
                StatusComment = "OK",
                DisaggregationMessage = "NO",
                DisaggregationMesssageRecordTime = " ",
                DisaggregationMesssageType = " ",
                DisaggregationMesssageRecallCode = " ",
                Location = "xxx",
                LocationDest = " ",
                Date = DateTime.Parse("2022-08-10"),
                DateTime = new List<DateTimeOffset>() { DateTime.Parse("2022-08-10"), DateTime.Parse("2022-08-10") },
                LocationMessageType = "Packge_in_progress",

                LocationMessageRecallCode = "a6e20f78-f7a5-41ba-816d-008ea220677b",

            };
            var UKInfo = new UKInfo

            {
                Status = "0",
                StatusComment = "OK",
                DisaggregationMessage = "NO",
                DisaggregationMesssageRecordTime = " ",
                DisaggregationMesssageType = " ",
                DisaggregationMesssageRecallCode = " ",
                Location = "x",
                LocationDest = " ",
                Date = DateTime.Parse("2022-08-10"),
                DateTime = new List<DateTimeOffset>() { DateTime.Parse("2022-08-10"), DateTime.Parse("2022-08-10") },
                LocationMessageType = "",

                LocationMessageRecallCode = " ",

            };
            var CRInfo1 = new CRInfo1

            {
                Status = "0",
                StatusComment = "OK",
                DisaggregationMessage = "NO",
                DisaggregationMesssageRecordTime = " ",
                DisaggregationMesssageType = " ",
                DisaggregationMesssageRecallCode = " ",
                Location = "x",
                LocationDest = " ",
                Date = DateTime.Parse("2022-08-10"),
                DateTime = new List<DateTimeOffset>() { DateTime.Parse("2022-08-10"), DateTime.Parse("2022-08-10") },
                LocationMessageType = "packing-in_pgoress",

                LocationMessageRecallCode = " Aggregation_TPD_StockAPI_QA_CASE_1714",

            };
            var PRInfo1 = new PRInfo1

            {
                Status = "0",
                StatusComment = "OK",
                DisaggregationMessage = "NO",
                DisaggregationMesssageRecordTime = " ",
                DisaggregationMesssageType = " ",
                DisaggregationMesssageRecallCode = " ",
                Location = "x",
                LocationDest = " ",
                Date = DateTime.Parse("2022-08-10"),
                DateTime = new List<DateTimeOffset>() { DateTime.Parse("2022-08-10"), DateTime.Parse("2022-08-10") },
                LocationMessageType = "packing-in_pgoress",

                LocationMessageRecallCode = "a6e20f78-f7a5-41ba-816d-008ea220677b",

            };
            var UKInfo1 = new UKInfo1

            {
                Status = "0",
                StatusComment = "OK",
                DisaggregationMessage = "NO",
                DisaggregationMesssageRecordTime = " ",
                DisaggregationMesssageType = " ",
                DisaggregationMesssageRecallCode = " ",
                Location = "x",
                LocationDest = " ",
                Date = DateTime.Parse("2022-08-10"),
                DateTime = new List<DateTimeOffset>() { DateTime.Parse("2022-08-10"), DateTime.Parse("2022-08-10") },
                LocationMessageType = "",

                LocationMessageRecallCode = "",

            };

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonConvert.SerializeObject(CRInfo);
            string jsonStr = JsonConvert.SerializeObject(PRInfo);
            string jsonStr1 = JsonConvert.SerializeObject(UKInfo);
            string jsonStr2 = JsonConvert.SerializeObject(CRInfo1);
            string jsonStr3 = JsonConvert.SerializeObject(PRInfo1);
            string jsonStr4 = JsonConvert.SerializeObject(UKInfo1);

            //string jsonString = JsonSerializer.Serialize(PRInfo,options);
            Console.WriteLine(jsonString);
            Console.WriteLine(jsonStr);
            Console.WriteLine(jsonStr1);
            Console.WriteLine(jsonStr2);
            Console.WriteLine(jsonStr3);
            Console.WriteLine(jsonStr4);
        }
    }
    
    public class EPCInfo
    {
        public string Id { get; set; }

    }
   
        public class CRInfo
        {
        public string Status { get; set; }
        public string StatusComment { get; set; }
        public string DisaggregationMessage { get; set; }
        public string DisaggregationMesssageRecordTime { get; set; }
        public string DisaggregationMesssageType { get; set; }
        public string DisaggregationMesssageRecallCode { get; set; }
        public string Location { get; set; }
        public string LocationDest { get; set; }
        public DateTimeOffset Date { get; set; }
        public IList<DateTimeOffset> DateTime { get; set; }
        public string LocationMessageType { get; set; }
        public string LocationMessageRecallCode { get; set; }

    }
    public class PRInfo
     {
        public string Status { get; set; }
        public string StatusComment { get; set; }
        public string DisaggregationMessage { get; set; }
        public string DisaggregationMesssageRecordTime { get; set; }
        public string DisaggregationMesssageType { get; set; }
        public string DisaggregationMesssageRecallCode { get; set; }
        public string Location { get; set; }
        public string LocationDest { get; set; }
        public DateTimeOffset Date { get; set; }
        public IList<DateTimeOffset> DateTime { get; set; }
        public string LocationMessageType { get; set; }
        public string LocationMessageRecallCode { get; set; }

    }
    public class UKInfo
    {
        
        public string Status { get; set; }
        public string StatusComment { get; set; }
        public string DisaggregationMessage { get; set; }
        public string DisaggregationMesssageRecordTime { get; set; }
        public string DisaggregationMesssageType { get; set; }
        public string DisaggregationMesssageRecallCode { get; set; }
        public string Location { get; set; }
        public string LocationDest { get; set; }
        public DateTimeOffset Date { get; set; }
        public IList<DateTimeOffset> DateTime { get; set; }
        public string LocationMessageType { get; set; }
        public string LocationMessageRecallCode { get; set; }
    }
    public class EPC
    {
        public String Id { get; set; }
    }
    public class CRInfo1
    {
        public string Status { get; set; }
        public string StatusComment { get; set; }
        public string DisaggregationMessage { get; set; }
        public string DisaggregationMesssageRecordTime { get; set; }
        public string DisaggregationMesssageType { get; set; }
        public string DisaggregationMesssageRecallCode { get; set; }
        public string Location { get; set; }
        public string LocationDest { get; set; }
        public DateTimeOffset Date { get; set; }
        public IList<DateTimeOffset> DateTime { get; set; }
        public string LocationMessageType { get; set; }
        public string LocationMessageRecallCode { get; set; }

    }
    public class PRInfo1
    {
        public string Status { get; set; }
        public string StatusComment { get; set; }
        public string DisaggregationMessage { get; set; }
        public string DisaggregationMesssageRecordTime { get; set; }
        public string DisaggregationMesssageType { get; set; }
        public string DisaggregationMesssageRecallCode { get; set; }
        public string Location { get; set; }
        public string LocationDest { get; set; }
        public DateTimeOffset Date { get; set; }
        public IList<DateTimeOffset> DateTime { get; set; }
        public string LocationMessageType { get; set; }
        public string LocationMessageRecallCode { get; set; }

    }
    public class UKInfo1
    {
        public string Status { get; set; }
        public string StatusComment { get; set; }
        public string DisaggregationMessage { get; set; }
        public string DisaggregationMesssageRecordTime { get; set; }
        public string DisaggregationMesssageType { get; set; }
        public string DisaggregationMesssageRecallCode { get; set; }
        public string Location { get; set; }
        public string LocationDest { get; set; }
        public DateTimeOffset Date { get; set; }
        public IList<DateTimeOffset> DateTime { get; set; }
        public string LocationMessageType { get; set; }
        public string LocationMessageRecallCode { get; set; }

    }





}



