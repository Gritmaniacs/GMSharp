using System.Xml.Serialization;

namespace GMSharp
{
    [XmlType("background")]
    public class Background
    {
        [XmlElement("istileset")]
        public int IsTileset { get; set; } = GMBool.False;

        [XmlElement("tilewidth")]
        public int TileWidth { get; set; } = 0;

        [XmlElement("tileheight")]
        public int TileHeight { get; set; } = 0;

        [XmlElement("tilexoff")]
        public int TileXOffset { get; set; } = 0;

        [XmlElement("tileyoff")]
        public int TileYOffset { get; set; } = 0;

        [XmlElement("tilehsep")]
        public int TileHorizontalSeparation { get; set; } = 0;

        [XmlElement("tilevsep")]
        public int TileVerticalSeparation { get; set; } = 0;

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

        [XmlElement("data")]
        public string BitmapFile { get; set; } = string.Empty;
    }
}
