using Newtonsoft.Json;
using System.Xml.Serialization;

namespace GMSharp
{
    [XmlType("instance")]
    [JsonObject]
    public class Instance
    {
        [XmlAttribute("objName")]
        [JsonProperty("objName")]
        public string ObjectName { get; set; }

        [XmlAttribute("x")]
        [JsonProperty("x")]
        public int X { get; set; }

        [XmlAttribute("y")]
        [JsonProperty("y")]
        public int Y { get; set; }

        [XmlAttribute("name")]
        [JsonProperty("name")]
        public string Name { get; set; }

        [XmlAttribute("locked")]
        [JsonProperty("locked")]
        public int IsLocked { get; set; }

        [XmlAttribute("code")]
        [JsonProperty("code")]
        public string Code { get; set; }

        [XmlAttribute("scaleX")]
        [JsonProperty("scaleX")]
        public double XScale { get; set; }

        [XmlAttribute("scaleY")]
        [JsonProperty("scaleY")]
        public double YScale { get; set; }

        [XmlAttribute("colour")]
        [JsonProperty("colour")]
        public uint Colour { get; set; }

        [XmlAttribute("rotation")]
        [JsonProperty("rotation")]
        public double Rotation { get; set; }

        public Instance Clone()
        {
            var newInstance = new Instance();

            newInstance.ObjectName = ObjectName;
            newInstance.X = X;
            newInstance.Y = Y;
            newInstance.Name = Name;
            newInstance.IsLocked = IsLocked;
            newInstance.Code = Code;
            newInstance.XScale = XScale;
            newInstance.YScale = YScale;
            newInstance.Colour = Colour;
            newInstance.Rotation = Rotation;

            return newInstance;
        }
    }
}
