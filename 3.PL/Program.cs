using _3.PL.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// Scaffold-DbContext 'Data Source=DESKTOP-PB42K3H\HKLADOI;Initial Catalog=FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041;Persist Security Info=True;User ID=name;Password=123456' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context FpolyDBContext -contextdir Context -DatAnnotations -Force
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmKhachHang());
        }
    }
}
