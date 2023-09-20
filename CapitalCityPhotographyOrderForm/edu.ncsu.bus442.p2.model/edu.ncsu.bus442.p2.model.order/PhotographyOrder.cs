#region Import in all namespaces required for the project (custom namespaces included)

using edu.ncsu.bus442.p2.model.person;
using edu.ncsu.bus442.p2.model.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

#region Define this namespace as model.order (order part of M part of MVC)

namespace edu.ncsu.bus442.p2.model.order
{

    #region Define this class as PhotographyOrder (child of Order), containing an employee, quantity, and package

    public class PhotographyOrder : Order
    {
        #region Define the global variables

        /// <summary>
        /// The quantity for this photography order
        /// </summary>
        private int quantity;
        /// <summary>
        /// The package for this photography order
        /// </summary>
        private Package package;

        #endregion

        #region Define the constructor with a parameter of employee to initialize the class' field

        /// <summary>
        /// Use setters to set the class fields as the parameters.
        /// </summary>
        /// <param name="package">The package for this photography order.</param>
        /// <param name="quantity">The quantity for this photography order.</param>
        /// <param name="employee">The employee for this order, of type Employee.</param>
        public PhotographyOrder(Package package, int quantity, Employee employee) : base(employee)
        {
            #region Use setters to set the class fields as the parameters.

            this.setPackage(package);
            this.setQuantity(quantity);

            #endregion
        }

        #endregion

        #region Define the setters/getters

        #region All quantity setters/getters

        /// <summary>
        /// Returns the quantity field
        /// </summary>
        /// <returns>The quantity field for the photography order</returns>
        public int getQuantity()
        {
            return quantity;
        }

        /// <summary>
        /// Sets the quantity field as the parameter
        /// </summary>
        /// <param name="quantity">The quantity to set for the photography order</param>
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        #endregion

        #region All package setters/getters

        /// <summary>
        /// Returns the package field
        /// </summary>
        /// <returns>The package field for this photography order</returns>
        public Package getPackage()
        {
            return package;
        }

        /// <summary>
        /// Sets the class field as the parameter
        /// </summary>
        /// <param name="package">The package to set for this photography order</param>
        public void setPackage(Package package)
        {
            this.package = package;
        }

        #endregion

        #endregion

        /// <summary>
        /// This returns a string representation of the object.
        /// Format: [Package Type], [Quantity], [Employee First Name] [Employee Middle Initial (Optional)]. [Employee Last Name]
        /// </summary>
        /// <returns>A string representation of the object according to the format above</returns>
        public override string ToString()
        {
            // If there is a middle initial (it is not null) 
            if(this.getEmployee().getMiddleInitial() != '\0')
                return this.package.getType() + ", " + this.quantity.ToString("N0") + ", " + 
                this.getEmployee().getFirstName() + " " + this.getEmployee().getMiddleInitial().ToString() + ". " + 
                this.getEmployee().getLastName();
            // If there is not middle initial (it is null)
            else
                return this.package.getType() + ", " + this.quantity.ToString("N0") + ", " +
                this.getEmployee().getFirstName() + " " +
                this.getEmployee().getLastName();
        }
    }

    #endregion

}

#endregion