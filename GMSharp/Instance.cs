using System.Xml.Serialization;

namespace GMSharp
{
    [XmlType("instance")]
    public class Instance
    {
        [XmlAttribute("objName")]
        public string ObjectName { get; set; }

        [XmlAttribute("x")]
        public int X { get; set; }

        [XmlAttribute("y")]
        public int Y { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("locked")]
        public int IsLocked { get; set; }

        [XmlAttribute("code")]
        public string Code { get; set; }

        [XmlAttribute("scaleX")]
        public double XScale { get; set; }

        [XmlAttribute("scaleY")]
        public double YScale { get; set; }

        [XmlAttribute("colour")]
        public uint Colour { get; set; }

        [XmlAttribute("rotation")]
        public double Rotation { get; set; }

        public Instance Clone()
        {
            var newInstance = new Instance();

            newInstance.ObjectName = ObjectName;
            newInstance.X = X;
            newInstance.Y = Y;
            newInstance.Name = Name;
            newInstance.IsLocked = IsLocked;
            newInstance.Code = Code;
            newInstance.XScale = XScale;
            newInstance.YScale = YScale;
            newInstance.Colour = Colour;
            newInstance.Rotation = Rotation;

            return newInstance;
        }
    }
}
