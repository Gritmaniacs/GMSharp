using System.Xml.Serialization;

namespace GMSharp
{
    public enum BoundingBoxMode : int
    {
        [XmlEnum("0")]
        Automatic = 0,
        [XmlEnum("1")]
        FullImage = 1,
        [XmlEnum("2")]
        Manual = 2,
    }
}
