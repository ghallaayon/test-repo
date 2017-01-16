using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicEnroll
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int testVariable;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            string str = "string";


        }
    }

    static class AnotherClass
    {
        static private string testFunction(string testString)
        {
            string hiThere = "Hi There";
            int extraVariable = 23;
            return "hi";
        }
    }
}
