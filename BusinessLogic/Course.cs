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
        public string InstructorName
        {
            get
            {
                return InstructorName;
            }
            set
            {
                Course c = new Course();
            }
        }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName
        {
            get
            {
                return CourseName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                    CourseName = value;
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits
        {
            get
            {
                return NumberOfCredits;
            }

            set
            {
                if (value > 30 || value < 0)
                {
                    throw new ArgumentException
                        ("Not proper amount of credits");
                }
                    NumberOfCredits = value;
            }
        }
        
    }
}
