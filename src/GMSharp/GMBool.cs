using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace GMSharp
{
    public struct  GMBool : IXmlSerializable
    {
        public bool Value { get; set; }

        public GMBool(bool value)
        {
            Value = value;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            var intValue = int.Parse(reader.ReadContentAsString());

            if (intValue < 0)
            {
                Value = true;
            }
            else
            {
                Value = false;
            }

            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            if (Value == false)
            {
                writer.WriteString("-1".ToString());
            }
            else
            {
                writer.WriteString("0".ToString());
            }

            writer.WriteEndElement();
        }

        public static implicit operator bool(GMBool gmb) => gmb.Value;

        public static implicit operator GMBool(bool b) => new GMBool(b);
    }
}
