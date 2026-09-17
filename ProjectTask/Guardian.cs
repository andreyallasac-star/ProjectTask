using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask
{
    internal class Guardian:Person
    {
        public int Id { get; set; }
        public string Relationship { get; set; }
        public Guardian()
        {
            
        }

        public Guardian(int id, string gFname, string gMname, string gLname, string gRelationship, string address, string gContact)
        {
            Id = id;
            FirstName = gFname;
            MiddleName = gMname;
            LastName = gLname;
            Relationship = gRelationship;
            ContactNumber = gContact;
            Address = address;
        }

        public override string DisplayInfo()
        {
            return
                $"\nGuardian Name: {LastName}, {FirstName} {MiddleName}" +
                $"\nGuardian Contact: {ContactNumber}" +
                $"\nAddress: {Address}" +
                $"\nRelationship: {Relationship}";
        }
    }
}
