using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_3
{
    internal class Person
    {
        public string CMND { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public Person(){}
        public Person(string cnmd, string hoten, string diachi)
        {
            CMND = cnmd;
            HoTen = hoten;
            DiaChi = diachi;
        }
        public Person(Person person)
        {
            CMND = person.CMND;
            HoTen = person.HoTen;
            DiaChi=person.DiaChi;
        }
    }
}
