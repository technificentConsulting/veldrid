namespace Veldrid.OpenGL.NoAllocEntryList
{
    internal struct NoAllocResolveTextureEntry
    {
        public readonly HandleTracked<Texture> Source;
        public readonly HandleTracked<Texture> Destination;

        public NoAllocResolveTextureEntry(HandleTracked<Texture> source, HandleTracked<Texture> destination)
        {
            Source = source;
            Destination = destination;
        }
    }
}