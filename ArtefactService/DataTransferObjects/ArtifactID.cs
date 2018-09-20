using System.Xml.Schema;
using System.Xml.Serialization;

namespace ArtefactService.DataTransferObjects
{
    [XmlType("artifactID", Namespace = "http://xmlns.xxx.xx/yy/artifact/comm")]
    public class ArtifactId
    {
        [XmlElement("id", Form = XmlSchemaForm.Unqualified)]
        public string Id { get; set; }
    }
}
