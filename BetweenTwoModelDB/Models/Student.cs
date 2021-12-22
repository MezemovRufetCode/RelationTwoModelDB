using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetweenTwoModelDB.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Score { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
