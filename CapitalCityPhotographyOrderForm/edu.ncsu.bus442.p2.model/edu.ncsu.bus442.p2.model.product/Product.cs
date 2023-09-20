#region Import in all namespaces required for the project (custom namespaces included)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

#region Define this namespace as model.product (product part of M part of MVC)

namespace edu.ncsu.bus442.p2.model.product
{

    #region Define this class as Product (parent of Package), containing a numSale

    public class Product
    {
        #region Define the global variable

        /// <summary>
        /// This is the number of sales for the product
        /// </summary>
        private int numSale;

        #endregion

        #region Define the constructor for the class

        /// <summary>
        /// Sets the field for the class as the parameter
        /// </summary>
        /// <param name="numSale">The number of sales to set for this Product object</param>
        public Product(int numSale)
        {
            #region Use a setter to set the field

            this.setNumSale(numSale);

            #endregion
        }

        #endregion

        #region Define the setters/getters for the fields of the class

        #region All numSale setters/getters

        /// <summary>
        /// Returns the number of sales for this product
        /// </summary>
        /// <returns>Returns the number of sales for this product</returns>
        public int getNumSale()
        {
            return numSale;
        }

        /// <summary>
        /// Sets the number of sales for this product
        /// </summary>
        /// <param name="numSale">The number of sales for this product to set as</param>
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