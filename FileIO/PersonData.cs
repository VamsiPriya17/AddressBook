using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    [Serializable]
    public class PersonData
    {
        public string name { get; set; }
        public int age { get; set; }
        public long phoneNum;
        public string email;
        public string city;
        public string state;
        public string addr;
        public PersonData(string name, int age, long phoneNum, string email, string city, string state, string addr)
        {
            this.name = name;
            this.age = age;
            this.phoneNum = phoneNum;
            this.email = email;
            this.city = city;
            this.state = state;
            this.addr = addr;
        }
        public PersonData()
        {

        }
    }
}
