using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRealmSample.Model
{
    public class Student : RealmObject
    {
        [PrimaryKey]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string FullName => $"{Name} {Surname}";
    }
}
