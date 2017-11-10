namespace Veldrid.OpenGL.NoAllocEntryList
{
    internal struct NoAllocSetVertexBufferEntry
    {
        public readonly uint Index;
        public readonly HandleTracked<VertexBuffer> VertexBuffer;

        public NoAllocSetVertexBufferEntry(uint index, HandleTracked<VertexBuffer> vb)
        {
            Index = index;
            VertexBuffer = vb;
        }
    }
}