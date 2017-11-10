namespace Veldrid.OpenGL.NoAllocEntryList
{
    internal struct NoAllocUpdateTextureCubeEntry
    {
        public readonly HandleTracked<Texture> Texture;
        public readonly HandleTrackedStagingBlock StagingBlock;
        public readonly CubeFace Face;
        public readonly uint X;
        public readonly uint Y;
        public readonly uint Width;
        public readonly uint Height;
        public readonly uint MipLevel;
        public readonly uint ArrayLayer;

        public NoAllocUpdateTextureCubeEntry(
            HandleTracked<Texture> texture,
            HandleTrackedStagingBlock stagingBlock,
            CubeFace face,
            uint x,
            uint y,
            uint width,
            uint height,
            uint mipLevel,
            uint arrayLayer)
        {
            Texture = texture;
            StagingBlock = stagingBlock;
            Face = face;
            X = x;
            Y = y;
            Width = width;
            Height = height;
            MipLevel = mipLevel;
            ArrayLayer = arrayLayer;
        }
    }
}
