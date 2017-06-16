using System.Xml;
using System.Xml.Serialization;

namespace GMSharp
{
    [XmlRoot("room")]
    public class Room
    {
        [XmlElement("caption")]
        public string Caption { get; set; }

        [XmlElement("width")]
        public int Width { get; set; }

        [XmlElement("height")]
        public int Height { get; set; }

        [XmlElement("vsnap")]
        public int VerticalSnap { get; set; }

        [XmlElement("hsnap")]
        public int HorizontalSnap { get; set; }

        [XmlElement("isometric")]
        public int IsIsometric { get; set; }

        [XmlElement("speed")]
        public int Speed { get; set; }

        [XmlElement("persistent")]
        public int IsPersistent { get; set; }

        [XmlElement("colour")]
        public int Colour { get; set; }

        [XmlElement("showcolour")]
        public int ShowColour { get; set; }

        [XmlElement("code")]
        public string Code { get; set; }

        [XmlElement("enableViews")]
        public int EnableViews { get; set; }

        [XmlElement("clearViewBackground")]
        public int ClearViewBackground { get; set; }

        [XmlElement("clearDisplayBuffer")]
        public int ClearDisplayBuffer { get; set; }

        [XmlArray("backgrounds")]
        [XmlArrayItem("background", typeof(Background))]
        public Background[] Backgrounds { get; set; }

        [XmlArray("views")]
        [XmlArrayItem("view", typeof(View))]
        public View[] Views { get; set; }

        [XmlArray("instances")]
        [XmlArrayItem("instance", typeof(Instance))]
        public Instance[] Instances { get; set; }

        [XmlArray("tiles")]
        [XmlArrayItem("tile", typeof(Tile))]
        public Tile[] Tiles { get; set; }

        [XmlElement("PhysicsWorld")]
        public int IsPhysicsWorld { get; set; }

        [XmlElement("PhysicsWorldTop")]
        public int PhysicsWorldTop { get; set; }

        [XmlElement("PhysicsWorldLeft")]
        public int PhysicsWorldLeft { get; set; }

        [XmlElement("PhysicsWorldRight")]
        public int PhysicsWorldRight { get; set; }

        [XmlElement("PhysicsWorldBottom")]
        public int PhysicsWorldBottom { get; set; }

        [XmlElement("PhysicsWorldGravityX")]
        public int PhysicsWorldGravityX { get; set; }

        [XmlElement("PhysicsWorldGravityY")]
        public int PhysicsWorldGravityY { get; set; }

        [XmlElement("PhysicsWorldPixToMeters")]
        public double PhysicsWorldPixToMeters { get; set; }
    }
}
