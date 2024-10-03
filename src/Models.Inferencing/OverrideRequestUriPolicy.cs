using System.ClientModel.Primitives;

namespace Models.Inferencing;

public class OverrideRequestUriPolicy(Uri overrideUri) : PipelinePolicy
{
    public override void Process(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
    {
        ArgumentNullException.ThrowIfNull(message);
        message.Request.Uri = overrideUri;
        ProcessNext(message, pipeline, currentIndex);
    }

    public override async ValueTask ProcessAsync(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
    {
        ArgumentNullException.ThrowIfNull(message);
        message.Request.Uri = overrideUri;
        await ProcessNextAsync(message, pipeline, currentIndex).ConfigureAwait(false);
    }
}