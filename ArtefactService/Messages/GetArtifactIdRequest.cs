using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ArtefactService.Messages
{
    [MessageContract(WrapperName = "getArtifactID", WrapperNamespace = "http://xmlns.xxx.xx/yy/artifact", IsWrapped = true)]
    public class GetArtifactIdRequest
    {
        public GetArtifactIdRequest() { }

        public GetArtifactIdRequest(string eMail)
        {
            EMail = eMail;
        }

        [MessageBodyMember(Namespace = "http://xmlns.xxx.xx/yy/artifact")]
        [XmlElement(ElementName = "email", Form = XmlSchemaForm.Unqualified)]
        public string EMail { get; set; }
    }
}
