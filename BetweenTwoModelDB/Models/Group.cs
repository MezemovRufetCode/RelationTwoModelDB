using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetweenTwoModelDB.Models
{
    public class Group
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        public int GroupStCount { get; set; }
        public List<Student> Students { get; set; }
    }
}
