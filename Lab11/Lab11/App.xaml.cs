using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

using DAL.Operations;

namespace Lab11
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

        private System.Threading.Mutex mutex;
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Boolean createdNew;
            String mutName = "CRUD_APP";
            mutex = new System.Threading.Mutex(true, mutName,out createdNew);

            if (!createdNew)
            {
                this.Shutdown();
            }
            GeneralOperations.CreateDb();
        }
    }
}
