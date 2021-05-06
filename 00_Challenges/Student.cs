using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public enum CourseType { CyberSecurity, SoftwareDevelopment, WebDevelopment };
    public enum BadgeType {  };
    public class Student
    {
        public Student () { }

        public Student(string firstName, string lastName, DateTime dateOfBirth, CourseType classTaking, decimal balanceOwed, BadgeType typeOfBadge, bool hasGraduated)
        {
            Firstname = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            ClassTaking = classTaking;
            BalanceOwed = balanceOwed;
            TypeOfBadge = typeOfBadge;
            HasGraduated = hasGraduated;

        }

        public string Firstname { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CourseType ClassTaking { get; set; }
        public decimal BalanceOwed { get; set; }
        public BadgeType TypeOfBadge { get; set; }
        public bool HasGraduated { get; set; }
    }
}
