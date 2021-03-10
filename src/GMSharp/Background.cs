using System.Xml;
using System.Xml.Serialization;

namespace GMSharp
{
    [XmlType("background")]
    public class Background
    {
        [XmlAttribute("visible")]
        public GMBool IsVisible { get; set; }

        [XmlAttribute("foreground")]
        public GMBool IsForeground { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("x")]
        public int X { get; set; }

        [XmlAttribute("y")]
        public int Y { get; set; }

        [XmlAttribute("htiled")]
        public GMBool IsHorizontallyTiled { get; set; }

        [XmlAttribute("vtiled")]
        public GMBool IsVerticallyTiled { get; set; }

        [XmlAttribute("hspeed")]
        public int HorizontalSpeed { get; set; }

        [XmlAttribute("vspeed")]
        public int VerticalSpeed { get; set; }

        [XmlAttribute("stretch")]
        public GMBool Stretch { get; set; }

        public Background()
        {
            IsVisible = false;
            IsVisible = false;
            Name = string.Empty;
            X = 0;
            Y = 0;
            IsHorizontallyTiled = false;
            IsVerticallyTiled = true;
            HorizontalSpeed = 0;
            VerticalSpeed = 0;
            Stretch = false;
        }
    }
}
