#region Import in all namespaces required for the project (custom namespaces included)

using edu.ncsu.bus442.p2.model.person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

#region Define this namespace as model.product (product part of M part of MVC)

namespace edu.ncsu.bus442.p2.model.product
{

    #region Define this class as Package (child of Product), containing a type and numSale

    public class Package : Product
    {
        #region Define the global variable

        /// <summary>
        /// This is the package type
        /// </summary>
        private string type;

        #endregion

        #region Define the constructor for the class

        /// <summary>
        /// Sets the fields for this class/base class as the parameters
        /// </summary>
        /// <param name="type">The type of package for this Package object</param>
        /// <param name="numSale">The number of sales to set for this Product object</param>
        public Package(string type, int numSale) : base(numSale)
        {
            #region Use a setter to set the field

            this.setType(type);

            #endregion
        }

        #endregion

        #region Define the setters/getters for the fields of the class

        #region All type setters/getters

        /// <summary>
        /// Returns the package type for this Package
        /// </summary>
        /// <returns>Returns the package type for this Package</returns>
        public string getType()
        {
            return type;
        }

        /// <summary>
        /// Sets the package type for this Package
        /// </summary>
        /// <param name="type">The package type for this Package to set as</param>
        public void setType(string type)
        {
            this.type = type;
        }

        #endregion

        #endregion

    }

    #endregion

}

#endregion