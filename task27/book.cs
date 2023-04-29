using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib.book
{
    public class book
    { 
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public int Price { get; set; }
        public static int idd;
        public string Code { get { _code = string.Concat(Name.Split().Select(s => s.Substring(0, 1)))+book.idd;  return _code; } set { value = _code; } }
        private string _code;
        

        public book (string name)
        {
            Name = name;
        }
        public book(string name,string aname):this(name:name)
        {
            AuthorName = aname;
        }
        public book(string name, string aname,int Pagecount) : this(name: name,aname:aname)
        {
            PageCount = Pagecount;
        }
        public book(string name, string aname, int Pagecount,int price) : this(name: name, aname: aname,Pagecount: Pagecount)
        {
           Price= price;  
        }
        public book(string name, string aname, int Pagecount, int price,string code) : this(name: name, aname: aname, Pagecount: Pagecount,price:price)
        {
            Code = code;
        }



    }
}
