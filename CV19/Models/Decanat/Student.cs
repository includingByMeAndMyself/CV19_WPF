using System;
using System.Collections.Generic;

namespace CV19.Models.Decanat
{
    public class Student
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public DateTime Birthday { get; set; }

        public double Rating { get; set; }

        public string Descriprion { get; set; }
    }

    public class Group
    {
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }

        public string Descriprion { get; set; }
    }
}
