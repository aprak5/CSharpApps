#region Import all namespaces to use

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

#region This namespace is the VC part of the MVC model

namespace edu.ncsu.bus442.p2.viewcontroller
{

    #region The MainFormController class controls the setup/flow of the Forms

    internal static class MainFormController
    {
        #region Main() defines the code to run on startup for the Application

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            #region Set Application layout

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            #endregion

        }

        #endregion
    }

    #endregion

}

#endregion