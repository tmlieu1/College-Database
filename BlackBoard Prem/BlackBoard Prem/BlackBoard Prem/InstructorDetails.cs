using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBoard_Prem
{
    public class InstructorDetails
    {
        /*
         * Instructor class that holds an Instructors details (so we don't have to constantly query for it) upon them successfully logging in, thus proving it is them
         * 
         * MEMBERS
         */
        public string InstructorID = "";
        public string InstructorName = "";
        private string DepartmentID = "";
        private string Gender = "";
        private string InstructUsername = "";
        private string InstructPass = "";


        public InstructorDetails()
        {
            this.InstructorID = "";
            this.InstructorName = "";
            this.DepartmentID = "";
            this.Gender = "";
            this.InstructUsername = "";
            this.InstructPass = "";
        }
        public InstructorDetails(string id, string name, string department, string gender, string username, string password)
        {
            this.InstructorID = id;
            this.InstructorName = name;
            this.DepartmentID = department;
            this.Gender = gender;
            this.InstructUsername = username;
            this.InstructPass = password;
        }
        public string getID() { return this.InstructorID; }
        public string getInstructorName() 
        {
            return this.InstructorName;
        }

        public string getDepartmentID()
        {
            return this.DepartmentID;
        }
        public string getGender()
        {
            return this.Gender;
        }
        public string getInstructUsername()
        {
            return this.InstructUsername;
        }
        public string getInstructPassword()
        {
            return this.InstructPass;
        }

        public void setInstructID(string id)
        {
            this.InstructorID = id;
        }
        public void setDepartmentID(string id)
        {
            this.DepartmentID = id;
        }
        public void setName(string name)
        {
            this.InstructorName = name;
        }
        public void setGender(string gender)
        {
            this.Gender = gender;
        }
        public void setUsername(string username)
        {
            this.InstructUsername = username;
        }
        public void setPass(string password)
        {
            this.InstructPass = password;
        }
    }
}
