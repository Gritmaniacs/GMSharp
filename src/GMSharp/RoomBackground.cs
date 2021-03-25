using System.Xml;
using System.Xml.Serialization;

namespace GMSharp
{
    [XmlType("background")]
    public class RoomBackground
    {
        [XmlAttribute("visible")]
        public int IsVisible { get; set; } = GMBool.False;

        [XmlAttribute("foreground")]
        public int IsForeground { get; set; } = GMBool.False;

        [XmlAttribute("name")]
        public string Name { get; set; } = string.Empty;

        [XmlAttribute("x")]
        public int X { get; set; } = 0;

        [XmlAttribute("y")]
        public int Y { get; set; } = 0;

        [XmlAttribute("htiled")]
        public int IsHorizontallyTiled { get; set; } = GMBool.True;

        [XmlAttribute("vtiled")]
        public int IsVerticallyTiled { get; set; } = GMBool.True;

        [XmlAttribute("hspeed")]
        public int HorizontalSpeed { get; set; } = 0;

        [XmlAttribute("vspeed")]
        public int VerticalSpeed { get; set; } = 0;

        [XmlAttribute("stretch")]
        public int Stretch { get; set; } = GMBool.False;
    }
}
