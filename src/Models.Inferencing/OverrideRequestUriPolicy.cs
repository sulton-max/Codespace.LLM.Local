using Azure.Core;
using Azure.Core.Pipeline;

namespace Models.Inferencing;

internal partial class OverrideRequestUriPolicy(Uri overrideUri) : HttpPipelineSynchronousPolicy
{
    private readonly Uri _overrideUri = overrideUri;

    public override void OnSendingRequest(HttpMessage message)
    {
        message.Request.Uri.Reset(_overrideUri);
    }
}