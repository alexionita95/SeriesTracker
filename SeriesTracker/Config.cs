namespace SeriesTracker
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class Config
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("seriesPath")]
        public string SeriesPath { get; set; }

        [JsonProperty("torrentSwPath")]
        public string TorrentSwPath { get; set; }

        [JsonProperty("filter")]
        public List<string> Filter { get; set; }

        [JsonProperty("resolution")]
        public string Resolution { get; set; }
        [JsonProperty("playerPath")]
        public string PlayerPath { get; set; }

        public static Config LoadFromFile(string path)
        {
            if (File.Exists("config.json"))
            {
                StreamReader streamReader = new StreamReader("config.json");
                string json = streamReader.ReadToEnd();
                streamReader.Close();
                return FromJson(json);
                
            }
            return null;
        }
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Formatting = Formatting.Indented,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
        public static Config FromJson(string json) => JsonConvert.DeserializeObject<Config>(json, Settings);
        public static string ToJson(Config self) => JsonConvert.SerializeObject(self, Settings);
    }
}
