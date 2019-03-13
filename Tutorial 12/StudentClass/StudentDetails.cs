using System;

namespace StudentClass
{
    class StudentDetails
    {
        private string StudentRefrenceNum;
        private string StudentName = "Alexander";
        private string StudentDOB = "20 July 356";
        private string StudentEmail = "a.g@great.gr";
        private string StudentPhoneNum = "3141592653";


        public StudentDetails(string RefNum)
        {
            StudentRefrenceNum = RefNum;
        }

        public StudentDetails(string RefNum, string Name, string DOB, string email, string PhoneNumber)
        {
            StudentRefrenceNum = RefNum;
            StudentName = Name;
            StudentDOB = DOB;
            StudentEmail = email;
            StudentPhoneNum = PhoneNumber;
        }

        public new void ToString()
        {
            Console.WriteLine("Refrence Number: {0}", StudentRefrenceNum);
            Console.WriteLine("Name: {0}", StudentName);
            Console.WriteLine("Date of Birth: {0}", StudentDOB);
            Console.WriteLine("Email: {0}", StudentEmail);
            Console.WriteLine("Phone Number: {0}", StudentPhoneNum);
        }

    }
}
