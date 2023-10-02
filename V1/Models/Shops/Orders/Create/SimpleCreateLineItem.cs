﻿using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Orders.Create
{
    public class SimpleCreateLineItem : LineItem, IOrderCreationLineItem
    {
        [JsonProperty("print_areas")]
        public SimplePrintArea PrintAreas { get; set; }

        [JsonProperty("blueprint_id")]
        public string BlueprintId { get; set; }

        [JsonProperty("print_details")]
        public PrintDetails PrintDetails { get; set; }
    }
}
