using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;

namespace GMSharp
{
    [XmlType("tile")]
    [JsonObject]
    public class Tile
    {
        [XmlAttribute("bgName")]
        [JsonProperty("bgName")]
        public string BackgroundName { get; set; }

        [XmlAttribute("x")]
        [JsonProperty("x")]
        public int X { get; set; }

        [XmlAttribute("y")]
        [JsonProperty("y")]
        public int Y { get; set; }

        [XmlAttribute("w")]
        [JsonProperty("w")]
        public int Width { get; set; }

        [XmlAttribute("h")]
        [JsonProperty("h")]
        public int Height { get; set; }

        [XmlAttribute("xo")]
        [JsonProperty("xo")]
        public int XOrigin { get; set; }

        [XmlAttribute("yo")]
        [JsonProperty("yo")]
        public int YOrigin { get; set; }

        [XmlAttribute("id")]
        [JsonProperty("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        [JsonProperty("name")]
        public string Name { get; set; }

        [XmlAttribute("depth")]
        [JsonProperty("depth")]
        public int Depth { get; set; }

        [XmlAttribute("locked")]
        [JsonProperty("locked")]
        public int IsLocked { get; set; }

        [XmlAttribute("colour")]
        [JsonProperty("colour")]
        public uint Colour { get; set; }

        [XmlAttribute("scaleX")]
        [JsonProperty("scaleX")]
        public double XScale { get; set; }

        [XmlAttribute("scaleY")]
        [JsonProperty("scaleY")]
        public double YScale { get; set; }

        public Tile Clone()
        {
            var newTile = new Tile();

            newTile.BackgroundName = BackgroundName;
            newTile.X = X;
            newTile.Y = Y;
            newTile.Width = Width;
            newTile.Height = Height;
            newTile.XOrigin = XOrigin;
            newTile.YOrigin = YOrigin;
            newTile.Id = Id;
            newTile.Name = Name;
            newTile.Depth = Depth;
            newTile.IsLocked = IsLocked;
            newTile.Colour = Colour;
            newTile.XScale = XScale;
            newTile.YScale = YScale;

            return newTile;
        }
    }
}
