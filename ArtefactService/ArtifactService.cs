using ArtefactService.Contracts;
using ArtefactService.DataTransferObjects;
using ArtefactService.Messages;

namespace ArtefactService
{
    public class ArtifactService : IArtifactService
    {
        public GetArtifactIdResponse GetArtifactID(GetArtifactIdRequest request)
        {
            //throw new NotImplementedException("test");
            var artifactId = new ArtifactId { Id = request.EMail };
            return new GetArtifactIdResponse(artifactId);
        }
    }
}