using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphinsInterface
{
    internal class FileTwo : IBinaryFile, ITextfile

    {
        void IBinaryFile.ReadFile() => Console.WriteLine("read binary file");
        void ITextfile.ReadFile() => Console.WriteLine("read text file");
        public void WriteBinaryFile()
        {
            throw new NotImplementedException();
        }

        void ITextfile.WriteTextFile()
        {
            throw new NotImplementedException();
        }
    }
}
