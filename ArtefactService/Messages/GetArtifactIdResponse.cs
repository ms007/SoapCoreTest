using System.ServiceModel;
using System.Xml.Serialization;
using ArtefactService.DataTransferObjects;

namespace ArtefactService.Messages
{
    [MessageContract(WrapperName = "getArtifactIDResponse", WrapperNamespace = "http://xmlns.xxx.xx/yy/artifact", IsWrapped = true)]
    //[XmlRoot("getArtifactIDResponse")]
    public class GetArtifactIdResponse
    {
        public GetArtifactIdResponse() { }

        public GetArtifactIdResponse(ArtifactId value)
        {
            ArtifactId = value;
        }

        [MessageBodyMember(Namespace = "http://xmlns.xxx.xx/yy/artifact")]
        [XmlElement(ElementName = "return")]
        public ArtifactId ArtifactId { get; set; }
    }
}
