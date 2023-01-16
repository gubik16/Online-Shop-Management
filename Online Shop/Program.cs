using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ShopService;

namespace Online_Shop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Hosting shop's service
            ShopDataService service = new ShopDataService();
            ServiceHost host = new ServiceHost(service);
            host.Open();

            Application.Run(new Menu());

            //Closing service
            host.Close();
        }
    }
}
