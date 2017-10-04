using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class Program
    {
        
      
        

      
        
        static void Main(string[] args)
        {
            Console.Title = "LARZ RULEZ!";





            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            StartupMenu menu = new StartupMenu();
            menu.Show();
        }

       
        
    }
}
