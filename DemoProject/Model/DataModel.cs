using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.Model
{
   public class DataModel
    {
        public class StoreDetail
        {
            [JsonProperty("week-no")]
            public string WeekNo { get; set; }

            [JsonProperty("week-date")]
            public string WeekDate { get; set; }

            [JsonProperty("store-name")]
            public string StoreName { get; set; }

            [JsonProperty("store-address")]
            public string StoreAddress { get; set; }

            [JsonProperty("coding-type")]
            public string CodingType { get; set; }

            [JsonProperty("task-state")]
            public string TaskState { get; set; }

            public bool IsVisible
            {
                get
                {
                    if (TaskState == "Not sarted")
                        return true;
                    else
                        return false;
                }
            }
        }

        public class StoreList
        {
            public List<StoreDetail> StoreDetails { get; set; }
        }


    }
}
