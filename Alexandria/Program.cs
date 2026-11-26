using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Alexandria
{
    internal static class Program
    {
    [STAThread]
    static void Main()
        {
          Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);
          using (logarUsuario login = new logarUsuario())
          {
            if (login.ShowDialog() == DialogResult.OK)
             {
               Application.Run(new Inicio());
             }
            }
        }
    }
}