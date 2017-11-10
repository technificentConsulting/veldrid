namespace Veldrid.OpenGL.NoAllocEntryList
{
    internal struct NoAllocSetPipelineEntry
    {
        public readonly HandleTracked<Pipeline> Pipeline;

        public NoAllocSetPipelineEntry(HandleTracked<Pipeline> pipeline)
        {
            Pipeline = pipeline;
        }
    }
}