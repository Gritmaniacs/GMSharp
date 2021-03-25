using System.Collections.Generic;
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
        [XmlArrayItem("background", typeof(RoomBackground))]
        public RoomBackground[] Backgrounds { get; set; }

        [XmlArray("views")]
        [XmlArrayItem("view", typeof(View))]
        public View[] Views { get; set; }

        [XmlArray("instances")]
        [XmlArrayItem("instance", typeof(Instance))]
        public List<Instance> Instances { get; set; }

        [XmlArray("tiles")]
        [XmlArrayItem("tile", typeof(Tile))]
        public List<Tile> Tiles { get; set; }

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

        public Room()
        {
            Caption = string.Empty;
            Width = 1024;
            Height = 768;
            VerticalSnap = 32;
            HorizontalSnap = 32;
            IsIsometric = GMBool.False;
            Speed = 30;
            IsPersistent = GMBool.False;
            Colour = 12632256;
            ShowColour = GMBool.True;
            Code = string.Empty;
            EnableViews = GMBool.False;
            ClearViewBackground = GMBool.True;
            ClearDisplayBuffer = GMBool.True;

            Backgrounds = new RoomBackground[8];
            Views = new View[8];

            for (int i = 0; i < 8; i++)
            {
                Backgrounds[i] = new RoomBackground();
                Views[i] = new View();
            }

            Instances = new List<Instance>();
            Tiles = new List<Tile>();


            IsPhysicsWorld = GMBool.False;
            PhysicsWorldTop = 0;
            PhysicsWorldLeft = 0;
            PhysicsWorldRight = 1024;
            PhysicsWorldBottom = 768;
            PhysicsWorldGravityX = 0;
            PhysicsWorldGravityY = 10;
            PhysicsWorldPixToMeters = 0.100000001490116;
        }
    }
}
