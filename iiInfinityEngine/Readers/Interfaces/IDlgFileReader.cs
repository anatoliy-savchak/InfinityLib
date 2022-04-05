using System.IO;
using iiInfinityEngine.Core.Files;

namespace iiInfinityEngine.Core.Readers.Interfaces
{
    interface IDlgFileReader
    {
        DlgFile Read(string filename);
        DlgFile Read(Stream s);
    }
}