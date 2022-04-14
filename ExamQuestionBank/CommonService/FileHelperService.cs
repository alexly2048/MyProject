using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace CommonService
{
    public class FileHelperService
    {
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern SafeFileHandle CreateFile(string lpFileName,
            uint dwDesireAccess,
            uint dwShareMode,
            IntPtr lpSecurityAttributes,
            uint dwCreationDisposition,
            uint dwFlagsAndAttributes,
            IntPtr hTemplateFile);

        #region STATUS DEFINED
        private const uint GENERIC_READ = 0x80000000;
        private const uint GENERIC_WRITE = 0X40000000;
        private const uint FILE_SHARE_READ = 0x00000001;
        private const uint FILE_SHARE_WRITE = 0x00000002;
        private const uint CREATE_ALWAYS = 2;
        private const uint CREATE_NEW = 1;
        private const uint OPEN_EXISTING = 3;
        private const uint FILE_FLAG_NO_BUFFERING = 0x20000000;
        private const uint FILE_FLAG_WRITE_THROUGH = 0x80000000;
        #endregion

        public bool CopyFile(string sourcePath, string targetPath, int bufferSize)
        {
            SafeFileHandle reader = CreateFile(sourcePath,
                                        GENERIC_READ,
                                        FILE_SHARE_READ,
                                        IntPtr.Zero,
                                        OPEN_EXISTING,
                                        FILE_FLAG_WRITE_THROUGH,
                                        IntPtr.Zero);
            SafeFileHandle writer = CreateFile(targetPath,
                                        GENERIC_WRITE,
                                        FILE_SHARE_READ,
                                        IntPtr.Zero,
                                        CREATE_ALWAYS,
                                        FILE_FLAG_WRITE_THROUGH,
                                        IntPtr.Zero);
            int buffer = 1024 * 1024 * bufferSize;
            var fsr = new FileStream(reader, FileAccess.Read);
            var fsw = new FileStream(writer, FileAccess.Write);

            var br = new BinaryReader(fsr);
            var bw = new BinaryWriter(fsw);
            var buffers = new byte[buffer];
            while (fsr.Position < fsr.Length)
            {
                int count = br.Read(buffers, 0, bufferSize);
                bw.Write(buffers, 0, count);
            }

            br.Close();
            bw.Close();
            fsr.Close();
            fsw.Close();
            return true;
        }

        
    }
}
