using System.Xml.Serialization;

namespace GMSharp
{
    public enum CollisionMaskShape : int
    {
        [XmlEnum("0")]
        Precise = 0,
        [XmlEnum("1")]
        Rectangle = 1,
        [XmlEnum("2")]
        Ellipse = 2,
        [XmlEnum("3")]
        Diamond = 3,
    }
}
