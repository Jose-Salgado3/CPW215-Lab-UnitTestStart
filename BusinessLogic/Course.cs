using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        public Course()
        {
            CourseName = "CPW 215";
        }

        public Course(string courseName)
        {
            CourseName = courseName;
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName
        {
            //Not super comfortable with these but trying to get used to it
            get => CourseName;

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                    CourseName = CourseName;
            }
        }


        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits
        {
            get => NumberOfCredits;
           
            set
            {
                if (value >= 0 || value <= 30)
                {
                    NumberOfCredits = value;
                }
                else
                    throw new ArgumentException();
            }
        }
        
    }
}
