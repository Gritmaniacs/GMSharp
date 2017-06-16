using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace GMSharp
{
    [XmlType("background")]
    public class Background
    {
        [XmlAttribute("visible")]
        public int IsVisible { get; set; }

        [XmlAttribute("foreground")]
        public int IsForeground { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("x")]
        public int X { get; set; }

        [XmlAttribute("y")]
        public int Y { get; set; }

        [XmlAttribute("htiled")]
        public int IsHorizontallyTiled { get; set; }

        [XmlAttribute("vtiled")]
        public int IsVerticallyTiled { get; set; }

        [XmlAttribute("hspeed")]
        public int HorizontalSpeed { get; set; }

        [XmlAttribute("vspeed")]
        public int VerticalSpeed { get; set; }

        [XmlAttribute("stretch")]
        public int Stretch { get; set; }
    }
}
