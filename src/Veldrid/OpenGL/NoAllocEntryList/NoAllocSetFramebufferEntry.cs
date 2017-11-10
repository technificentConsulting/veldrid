namespace Veldrid.OpenGL.NoAllocEntryList
{
    internal struct NoAllocSetFramebufferEntry
    {
        public readonly HandleTracked<Framebuffer> Framebuffer;

        public NoAllocSetFramebufferEntry(HandleTracked<Framebuffer> fb)
        {
            Framebuffer = fb;
        }
    }
}