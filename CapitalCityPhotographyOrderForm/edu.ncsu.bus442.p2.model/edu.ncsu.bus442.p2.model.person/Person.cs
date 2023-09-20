#region Import in all namespaces required for the project (custom namespaces included)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

#region Define this namespace as model.person (person part of M part of MVC)

namespace edu.ncsu.bus442.p2.model.person
{

    #region Define this class as Person (parent of Employee), containing a firstName, middleInitial, and a lastName

    public class Person
    {

        #region Define the global variables

        /// <summary>
        /// This is the person's first name
        /// </summary>
        private string firstName;
        /// <summary>
        /// This is the person's middle initial (may be null)
        /// </summary>
        private char middleInitial;
        /// <summary>
        /// This is the person's last name
        /// </summary>
        private string lastName;

        #endregion

        #region Define the constructor with the fields for the class

        /// <summary>
        /// Sets all the fields for the class (using setters) and constructs the Person object
        /// </summary>
        /// <param name="firstName">The first name for the person</param>
        /// <param name="middleInitial">The middle initial for the person</param>
        /// <param name="lastName">The last name for the person</param>
        public Person(string firstName, char middleInitial, string lastName)
        {

            #region Use setters to set each parameter as a field

            this.setFirstName(firstName);
            this.setMiddleInitial(middleInitial);
            this.setLastName(lastName);

            #endregion

        }

        #endregion

        #region Define the setters/getters for the class

        #region All firstName setters/getters

        /// <summary>
        /// Returns the first name for the person
        /// </summary>
        /// <returns>Returns the first name for the person</returns>
        public string getFirstName()
        {
            return firstName;
        }

        /// <summary>
        /// Sets the first name for the person (from the parameter)
        /// </summary>
        /// <param name="firstName">The first name to set for the person</param>
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        #endregion

        #region All middleInitial setters/getters

        /// <summary>
        /// Returns the middle initial for the person
        /// </summary>
        /// <returns>Returns the middle initial for the person</returns>
        public char getMiddleInitial()
        {
            return middleInitial;
        }

        /// <summary>
        /// Sets the middle initial for the person (from the parameter), if it is a space, it is set as null (space is used instead of an empty char in I/O Conversion)
        /// </summary>
        /// <param name="middleInitial">The middle initial to set for the person</param>
        public void setMiddleInitial(char middleInitial)
        {
            if(middleInitial == ' ')
                return;
            else
                this.middleInitial = middleInitial;
        }

        #endregion

        #region All lastName setters/getters

        /// <summary>
        /// Returns the last name for the person
        /// </summary>
        /// <returns>Returns the last name for the person</returns>
        public string getLastName()
        {
            return lastName;
        }

        /// <summary>
        /// Sets the last name for the person (from the parameter)
        /// </summary>
        /// <param name="lastName">The last name to set for the person</param>
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        #endregion

        #endregion

    }

    #endregion

}

#endregion