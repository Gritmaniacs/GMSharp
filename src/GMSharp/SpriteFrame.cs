using System.Xml.Serialization;

namespace GMSharp
{
    [XmlType("frame")]
    public class SpriteFrame
    {
        [XmlAttribute("index")]
        public int Index { get; set; }

        [XmlText]
        public string Filename { get; set; }
    }
}
