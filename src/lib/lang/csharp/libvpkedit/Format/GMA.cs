using System.Runtime.InteropServices;

namespace libvpkedit.Format
{
    internal static unsafe partial class Extern
    {
        [DllImport("libvpkeditc")]
        public static extern void* vpkedit_gma_open([MarshalAs(UnmanagedType.LPStr)] string path);

        [DllImport("libvpkeditc")]
        public static extern void* vpkedit_gma_open_with_options([MarshalAs(UnmanagedType.LPStr)] string path, PackFileOptions options);
    }

    public class GMA : PackFile
    {
        private protected unsafe GMA(void* handle) : base(handle) {}

        public new static GMA? Open(string path)
        {
            unsafe
            {
                var handle = Extern.vpkedit_gma_open(path);
                return handle == null ? null : new GMA(handle);
            }
        }

        public new static GMA? Open(string path, PackFileOptions options)
        {
            unsafe
            {
                var handle = Extern.vpkedit_gma_open_with_options(path, options);
                return handle == null ? null : new GMA(handle);
            }
        }
    }
}
