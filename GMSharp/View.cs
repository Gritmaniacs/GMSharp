using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace GMSharp
{
    [XmlType("view")]
    public class View
    {
        [XmlAttribute("visible")]
        public int IsVisible { get; set; }

        [XmlAttribute("objName")]
        public string ObjectName { get; set; }

        [XmlAttribute("xview")]
        public int X { get; set; }

        [XmlAttribute("yview")]
        public int Y { get; set; }

        [XmlAttribute("wview")]
        public int Width { get; set; }

        [XmlAttribute("hview")]
        public int Height { get; set; }

        [XmlAttribute("xport")]
        public int ViewportX { get; set; }

        [XmlAttribute("yport")]
        public int ViewportY { get; set; }

        [XmlAttribute("wport")]
        public int ViewportWidth { get; set; }

        [XmlAttribute("hport")]
        public int ViewportHeight { get; set; }

        [XmlAttribute("hborder")]
        public int HorizontalBorder { get; set; }

        [XmlAttribute("vborder")]
        public int VerticalBorder { get; set; }

        [XmlAttribute("hspeed")]
        public int HorizontalSpeed { get; set; }

        [XmlAttribute("vspeed")]
        public int VerticalSpeed { get; set; }
    }
}
