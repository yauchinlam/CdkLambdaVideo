using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;
using Constructs;

namespace Cdklambdavideo
{
    public class CdklambdavideoStack : Stack
    {
        internal CdklambdavideoStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            var functionapp = new DockerImageFunction(this, "MyfirstDockerImageApp", new DockerImageFunctionProps()
            {
                Code = DockerImageCode.FromImageAsset("src", new AssetImageCodeProps()
                {
                    File = "AWSLambda3/Dockerfile",
                }),
            });
        }
    }
}
