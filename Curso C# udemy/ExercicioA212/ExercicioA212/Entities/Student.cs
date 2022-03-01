using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioA212.Entities
{
    class Student
    {
        public int Registration { get; set; }

        public override int GetHashCode()
        {
            return Registration.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;

            return Registration.Equals(other.Registration);
        }
    }
}
