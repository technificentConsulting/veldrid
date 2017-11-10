namespace Veldrid.OpenGL.NoAllocEntryList
{
    internal struct NoAllocSetIndexBufferEntry
    {
        public readonly HandleTracked<IndexBuffer> IndexBuffer;

        public NoAllocSetIndexBufferEntry(HandleTracked<IndexBuffer> ib)
        {
            IndexBuffer = ib;
        }
    }
}