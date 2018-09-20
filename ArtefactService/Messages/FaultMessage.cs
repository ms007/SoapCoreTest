using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ArtefactService.Messages
{
    [XmlSchemaProvider("ExportSchema")]
    public class FaultMessage : object, IXmlSerializable
    {
        private static readonly XmlQualifiedName _typeName = new XmlQualifiedName("faultMessage", "http://xmlns.xxx.xx/yy/artifact");

        public XmlNode[] Nodes { get; set; }

        public void ReadXml(XmlReader reader)
        {
            Nodes = XmlSerializableServices.ReadNodes(reader);
        }

        public void WriteXml(XmlWriter writer)
        {
            XmlSerializableServices.WriteNodes(writer, Nodes);
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public static XmlQualifiedName ExportSchema(XmlSchemaSet schemas)
        {
            XmlSerializableServices.AddDefaultSchema(schemas, _typeName);
            return _typeName;
        }
    }
}
