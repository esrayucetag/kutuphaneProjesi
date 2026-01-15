using System;
using System.Windows.Forms;
using kutuphaneProjesi.UI;

namespace kutuphaneProjesi
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
