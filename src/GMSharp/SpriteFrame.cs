using System.Xml.Serialization;

namespace GMSharp
{
    [XmlType("frame")]
    public class SpriteFrame
    {
        [XmlAttribute("index")]
        public int Index { get; set; } = 0;

        [XmlText]
        public string Filename { get; set; } = string.Empty;
    }
}
