using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4_OS
{
    public class Catalog:TreeNode
    {
        public string Name { get; set; }
        public List<Object> listObj;

        public Catalog(string catName)
            :base(catName)
        {
            Name=catName;
            listObj=new List<object>();
        }

        public static string FullName
        {
            get { return typeof(Catalog).FullName; }
        }

        public void AddElem(Object elem)
        {
            listObj.Add(elem);
        }

        public void RemoveElem(Object elem) 
        {
            listObj.Remove(elem);
        }
    }
}
