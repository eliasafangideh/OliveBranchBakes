using System;
using System.Windows.Forms;

namespace OliveBranchBakes
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new ProjectInfoForm());
        }
    }
}