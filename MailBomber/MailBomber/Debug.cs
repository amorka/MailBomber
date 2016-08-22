using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBomber
{
    class Debug
    {
        private static Process DebugProc;

        public static void ShowWindow() {

            Task tDebug = new Task(DebugProcMethod);
            tDebug.Start();
        }

        private static void DebugProcMethod() {
            DebugProc = new Process();
            DebugProc.StartInfo.UseShellExecute = false;
            DebugProc.StartInfo.FileName = "debud.exe";
            DebugProc.StartInfo.RedirectStandardInput = true;
            DebugProc.Start();

            
        }

        public static void Write(string s) {

        }

    }
}
