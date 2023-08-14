using System;
using System.Diagnostics;

namespace System.Diagnostics {
    public class ToRestartPC {
      public static void Restarting(bool restart = false) {

            try {  

            if (restart) {
       
                Process.Start("shutdown", "/r /t 60" );
                Console.WriteLine("Restarting in 60 seconds");
      }
   }
            catch(Exception) {

          Console.WriteLine("Something went wrong....");

            }
        }
    }
}
