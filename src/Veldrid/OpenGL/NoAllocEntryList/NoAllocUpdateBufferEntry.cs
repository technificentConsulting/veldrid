using System;

namespace Veldrid.OpenGL.NoAllocEntryList
{
    internal struct NoAllocUpdateBufferEntry
    {
        public readonly HandleTracked<Buffer> Buffer;
        public readonly uint BufferOffsetInBytes;
        public readonly HandleTrackedStagingBlock StagingBlock;

        public NoAllocUpdateBufferEntry(HandleTracked<Buffer> buffer, uint bufferOffsetInBytes, HandleTrackedStagingBlock stagingBlock)
        {
            Buffer = buffer;
            BufferOffsetInBytes = bufferOffsetInBytes;
            StagingBlock = stagingBlock;
        }
    }
}