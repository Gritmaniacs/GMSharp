using System.Xml.Serialization;

namespace GMSharp
{
    [XmlType("sprite")]
    public class Sprite
    {
        [XmlElement("type")]
        public int Type { get; set; }

        [XmlElement("xorig")]
        public int OriginX { get; set; }

        [XmlElement("yorigin")]
        public int OriginY { get; set; }

        // TODO
        // public int colkind { get; set; }

        // TODO
        // public int coltolerance { get; set; }

        // TODO
        // public int sepmasks { get; set; }

        // TODO 
        // public int bboxmode { get; set; }

        [XmlElement("bbox_left")]
        public int BoundingBoxLeft { get; set; }

        [XmlElement("bbox_right")]
        public int BoundingBoxRight { get; set; }

        [XmlElement("bbox_top")]
        public int BoundingBoxTop { get; set; }

        [XmlElement("bbox_bottom")]
        public int BoundingBoxBottom { get; set; }

        public GMBool HTile { get; set; }

        public GMBool VTile { get; set; }

        // TODO:
        // public ?[] TextureGoups

        [XmlElement("For3D")]
        public GMBool IsFor3D { get; set; }

        [XmlElement("width")]
        public int Width { get; set; }

        [XmlElement("height")]
        public int Height { get; set; }

        [XmlArray("frames")]
        [XmlArrayItem("frame", typeof(SpriteFrame))]
        public SpriteFrame[] Frames { get; set; }
    }
}
