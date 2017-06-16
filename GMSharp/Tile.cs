using System.Xml;
using System.Xml.Serialization;

namespace GMSharp
{
    [XmlType("tile")]
    public class Tile
    {
        [XmlAttribute("bgName")]
        public string BackgroundName { get; set; }

        [XmlAttribute("x")]
        public int X { get; set; }

        [XmlAttribute("y")]
        public int Y { get; set; }

        [XmlAttribute("w")]
        public int Width { get; set; }

        [XmlAttribute("h")]
        public int Height { get; set; }

        [XmlAttribute("xo")]
        public int XOrigin { get; set; }

        [XmlAttribute("yo")]
        public int YOrigin { get; set; }

        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("depth")]
        public int Depth { get; set; }

        [XmlAttribute("locked")]
        public int IsLocked { get; set; }

        [XmlAttribute("colour")]
        public uint Colour { get; set; }

        [XmlAttribute("scaleX")]
        public double XScale { get; set; }

        [XmlAttribute("scaleY")]
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
