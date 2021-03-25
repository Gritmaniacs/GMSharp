using System.Xml.Serialization;

namespace GMSharp
{
    public enum SpriteType : int
    {
        [XmlEnum("0")]
        Bitmap = 0,
        [XmlEnum("1")]
        Swf = 1,
        [XmlEnum("2")]
        Spine = 2,
    }
}
