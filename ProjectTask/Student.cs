using System;

namespace ProjectTask
{
    internal class Student:Person
    {
        public string StudentId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ProgramInfo Program { get; set; }
        public Guardian Guardian { get; set; }
        public Requirements Requirements { get; set; }
        public Payment Payment { get; set; }
        public string YearLevel { get; set; }

        public Student()
        {
            
        }

        public Student(string studentId, string firstName, string lastName, string middleName, DateTime dateOfBirth, ProgramInfo prog, Guardian guardian, Requirements reqs, Payment pay, string contact, string address, string yearLevel)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            DateOfBirth = dateOfBirth;
            Address = address;
            Program = prog;
            Guardian = guardian;
            Requirements = reqs;
            Payment = pay;
            YearLevel = yearLevel;
            Address = address;
            ContactNumber = contact;

        }

        public override string DisplayInfo()
        {
            return
                $"Student\n" +
                base.DisplayInfo() +
                $"\nDate of Birth: {DateOfBirth}" +
                $"\nProgram: {Program.ProgramName}" +
                $"\nYear Level: {YearLevel}" +
                $"\n" +
                $"\nGuardian" +
                $"{Guardian.DisplayInfo()}" +
                $"\n" +
                $"\nRequirements Complete: {Requirements.AllSubmitted()}" +
                $"\nPayment Due: {Payment.CalculateBalance(Program.TuitionFee)}";


        }

    }
}
