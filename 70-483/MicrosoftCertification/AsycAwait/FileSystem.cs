using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AsycAwait
{
   public  class FileSystem {
       static void FileMethod() {
           var dir = System.IO.Directory.GetCurrentDirectory();
            var file = System.IO.Path.Combine(dir, "file.txt");

            var content = "Hi how are you";

           // write
            System.IO.File.WriteAllText(file, content);

            //read
            var read = System.IO.File.ReadAllText(file);
            Trace.Assert(read.Equals(content));
       }
   }
}