#region Import in all namespaces required (custom namespaces included)

using edu.ncsu.bus442.p2.model.order;
using edu.ncsu.bus442.p2.model.person;
using edu.ncsu.bus442.p2.model.product;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

#region Define this namespace as model.io (io (input/output) part of M part of MVC)

namespace edu.ncsu.bus442.p2.model.io
{

    #region Define this class as PhotographyOrderIO

    public class PhotographyOrderIO
    {

        #region I(nput) Method

        /// <summary>
        /// Parse each line in the file given via readStream according to the *.csv format (see comments in MainForm openFileDialog).
        /// Note, no try...catch since all unexpected error-handling is done on MainForm 
        /// (for all model classes, in the future, this should be moved to the model classes, with expection generation/passing AND handling)
        /// </summary>
        /// <param name="readStream">The readStream of data to return as a list of photography orders.</param>
        /// <returns>The readStream of data as a list of photography orders</returns>
        public static List<PhotographyOrder> readPhotographyOrders(Stream readStream)
        {
            #region Define/Initialize three lists, the readOrders StreamReader, and a string variable for each line

            List<PhotographyOrder> photographyOrders = new List<PhotographyOrder>();
            List<Package> packages = new List<Package>();
            List<Employee> employees = new List<Employee>();
            StreamReader readOrders = new StreamReader(readStream);
            String line = String.Empty;

            #endregion

            #region For each line, parse it according to the format, checking all cases

            while ((line = readOrders.ReadLine()) != null)
            {
                PhotographyOrder photographyOrder;
                string[] order = line.Split(',');
                Package package = new Package(order[0].Trim(), 0);
                packages.Add(package);
                int quantity = 0;
                if (!int.TryParse(order[1], out quantity) || quantity < 0)
                {
                    MessageBox.Show("Invalid quantity read.", "Error in Reading the File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                string[] names = order[2].Trim().Split(' ');
                Employee employee;
                if (names.Length == 3)
                    employee = new Employee(names[0], names[1].ToCharArray()[0], names[2], 0);
                else
                    employee = new Employee(names[0], ' ', names[1], 0);
                photographyOrder = new PhotographyOrder(package, quantity, employee);
                photographyOrders.Add(photographyOrder);
            }

            #endregion

            #region For every object, make sure the number of sales are correctly initialized

            foreach (PhotographyOrder photographyOrder in photographyOrders)
            {
                foreach(Employee employee in employees)
                {
                    if (photographyOrder.getEmployee().Equals(employee))
                    {
                        employee.setNumSale(employee.getNumSale() + 1);
                    }
                }
                foreach (Package package in packages)
                {
                    if (photographyOrder.getPackage().Equals(package))
                    {
                        package.setNumSale(package.getNumSale() + 1);
                    }
                }
            }

            #endregion

            #region Close the StreamReader and return the list

            readOrders.Close();
            return photographyOrders;

            #endregion
        }

        #endregion

        #region O(utput) Method

        /// <summary>
        /// Write each line in the file given via writeStream according to the *.csv format (see comments in MainForm openFileDialog).
        /// Note, no try...catch since all unexpected error-handling is done on MainForm 
        /// (for all model classes, in the future, this should be moved to the model classes, with expection generation/passing AND handling)
        /// </summary>
        /// <param name="writeStream">The writeStream of data to write orders in.</param>
        /// <param name="orders">The list of photography orders to write in the file.</param>
        public static void writePhotographyOrders(Stream writeStream, List<PhotographyOrder> orders)
        {
            #region Define/Initialize the writeOrders StreamWriter

            StreamWriter writeOrders = new StreamWriter(writeStream);

            #endregion

            #region Write each photographyOrder in the file, line-by-line

            foreach (PhotographyOrder photographyOrder in orders)
            {
                writeOrders.WriteLine(photographyOrder.ToString());
            }

            #endregion

            #region Close the writeOrders StreamWriter

            writeOrders.Close();

            #endregion
        }

        #endregion

    }

    #endregion

}

#endregion