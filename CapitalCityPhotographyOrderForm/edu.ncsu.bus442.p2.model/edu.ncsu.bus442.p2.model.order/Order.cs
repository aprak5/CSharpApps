#region Import in all namespaces required for the project (custom namespaces included)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using edu.ncsu.bus442.p2.model.person;

#endregion

#region Define this namespace as model.order (order part of M part of MVC)

namespace edu.ncsu.bus442.p2.model.order
{
    #region Define this class as Order (parent of PhotographyOrder), containing an employee

    public class Order
    {
        #region Define the global variable

        /// <summary>
        /// The employee who completes this order
        /// </summary>
        private Employee employee;

        #endregion

        #region Define the constructor with a parameter of employee to initialize the class' field

        /// <summary>
        /// Uses a setter to set the class field employee as the parameter employee.
        /// </summary>
        /// <param name="employee">The employee for this order, of type Employee.</param>
        public Order(Employee employee)
        {
            #region Uses a setter to set the class field employee as the parameter employee.

            this.setEmployee(employee);

            #endregion
        }

        #endregion

        #region Define the getter/setters (as public)

        #region All employee getter/setters

        /// <summary>
        /// Returns the employee field for this order
        /// </summary>
        /// <returns>The employee field</returns>
        public Employee getEmployee()
        {
            return employee;
        }

        /// <summary>
        /// sets the employee field for this order
        /// </summary>
        /// <param name="employee">The employee field to set</param>
        public void setEmployee(Employee employee)
        {
            this.employee = employee;
        }

        #endregion

        #endregion
    }

    #endregion
}

#endregion