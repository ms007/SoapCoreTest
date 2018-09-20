using System.ServiceModel;
using ArtefactService.Messages;

namespace ArtefactService.Contracts
{
    [ServiceContract(Namespace = "http://xmlns.xxx.xx/yy/artifact")]
    public interface IArtifactService
    {
        [OperationContract(Name = "getArtifactID", Action = "getArtifactIDRequest")]
        [FaultContract(typeof(FaultMessage))]
        [return: MessageParameter(Name = "getArtifactIDResponse")]
        GetArtifactIdResponse GetArtifactID(GetArtifactIdRequest request);
    }
}
