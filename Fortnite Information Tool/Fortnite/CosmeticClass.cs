using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Fortnite_Information_Tool.Fortnite
{
    public class CosmeticClass
    {
            public class Data
            {
                public string id { get; set; }
                public string name { get; set; }
                public string description { get; set; }
                public Type type { get; set; }
                public Rarity rarity { get; set; }
                public object series { get; set; }
                public Set set { get; set; }
                public Introduction introduction { get; set; }
                public Images images { get; set; }
                public object variants { get; set; }
                public object searchTags { get; set; }
                public List<string> gameplayTags { get; set; }
                public object metaTags { get; set; }
                public string showcaseVideo { get; set; }
                public object dynamicPakId { get; set; }
                public object displayAssetPath { get; set; }
                public object definitionPath { get; set; }
                public string path { get; set; }
                public DateTime added { get; set; }
                public object shopHistory { get; set; }
            }

            public class Images
            {
                public string smallIcon { get; set; }
                public string icon { get; set; }
                public object featured { get; set; }
                public object other { get; set; }
            }

            public class Introduction
            {
                public string chapter { get; set; }
                public string season { get; set; }
                public string text { get; set; }
                public int backendValue { get; set; }
            }

            public class Rarity
            {
                public string value { get; set; }
                public string displayValue { get; set; }
                public string backendValue { get; set; }
            }

            public class Root
            {
                public int status { get; set; }
                public Data data { get; set; }
            }

            public class Set
            {
                public string value { get; set; }
                public string text { get; set; }
                public string backendValue { get; set; }
            }

            public class Type
            {
                public string value { get; set; }
                public string displayValue { get; set; }
                public string backendValue { get; set; }
            }
        }
    }