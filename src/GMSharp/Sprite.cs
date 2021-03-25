using System.Xml.Serialization;

namespace GMSharp
{
    [XmlType("sprite")]
    public class Sprite
    {
        [XmlElement("type")]
        public SpriteType Type { get; set; } = 0;

        [XmlElement("xorig")]
        public int OriginX { get; set; } = 0;

        [XmlElement("yorigin")]
        public int OriginY { get; set; } = 0;

        [XmlElement("colkind")]
        public CollisionMaskShape CollisionMaskShape { get; set; } = CollisionMaskShape.Rectangle;

        [XmlElement("coltolerance")]
        public int CollisionMaskAlphaTolerance { get; set; } = 0;

        [XmlElement("sepmasks")]
        public int HasSeparateCollisionMask { get; set; } = GMBool.False;

        [XmlElement("bboxmode")]
        public BoundingBoxMode BoundingBoxMode { get; set; } = BoundingBoxMode.Automatic;

        [XmlElement("bbox_left")]
        public int BoundingBoxLeft { get; set; } = 0;

        [XmlElement("bbox_right")]
        public int BoundingBoxRight { get; set; } = 0;

        [XmlElement("bbox_top")]
        public int BoundingBoxTop { get; set; } = 0;

        [XmlElement("bbox_bottom")]
        public int BoundingBoxBottom { get; set; } = 0;

        [XmlElement("HTile")]
        public int IsHorizontallyTiled { get; set; } = GMBool.False;

        [XmlElement("VTile")]
        public int IsVerticallyTiled { get; set; } = GMBool.False;

        // TODO:
        // public ?[] TextureGoups

        [XmlElement("For3D")]
        public int IsFor3D { get; set; } = GMBool.False;

        [XmlElement("width")]
        public int Width { get; set; } = 0;

        [XmlElement("height")]
        public int Height { get; set; } = 0;

        [XmlArray("frames")]
        [XmlArrayItem("frame", typeof(SpriteFrame))]
        public SpriteFrame[] Frames { get; set; } = null;
    }
}
