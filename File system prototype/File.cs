using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4_OS
{
    public class File:TreeNode
    {
        public string Name { get; set; }
        
        public int _size;

        public int iniat_index;

        public static string FullName
        {
            get { return typeof(File).FullName; }
        }
        public File(string fileName,int size) 
            :base(fileName)
        {
            Name = fileName;
            _size = size;
        }

    }
}
