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

    #region Define this class as Employee (child of Person), containing a firstName, middleInitial, lastName, and a numSale

    public class Employee : Person
    {
        #region Define the global variable

        /// <summary>
        /// This is the number of sales for the employee
        /// </summary>
        private int numSale;

        #endregion

        #region Define the constructor for the class

        /// <summary>
        /// Sets all fields for the class/base class from the parameters.
        /// </summary>
        /// <param name="firstName">The first name to set for the employee</param>
        /// <param name="middleInitial">The middle initial to set for the employee</param>
        /// <param name="lastName">The last name to set for the employee</param>
        /// <param name="numSales">The number of sales to set for the employee</param>
        public Employee(string firstName, char middleInitial, string lastName, int numSales) : base(firstName, middleInitial, lastName)
        {
            #region Use a setter to set numSale

            this.setNumSale(numSale);

            #endregion
        }

        #endregion

        #region Define the setters/getters for the class

        #region All numSale setters/getters

        /// <summary>
        /// Returns the number of sales for the employee
        /// </summary>
        /// <returns>Returns the number of sales for the employee</returns>
        public int getNumSale()
        {
            return numSale;
        }

        /// <summary>
        /// Sets the number of sales for the employee
        /// </summary>
        /// <param name="numSale">The number of sales to set for the employee</param>
        public void setNumSale(int numSale)
        {
            this.numSale = numSale;
        }

        #endregion

        #endregion
    }

    #endregion

}

#endregion