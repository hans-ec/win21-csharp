using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Enums
{
    internal class EnumClassExample
    {
        private static ProcessState processState = ProcessState.NotRunning;

        enum ProcessState
        {
            NotRunning,
            Starting,
            Initializing,
            Idle,
            Running,
            Stopping
        }

        private static void ShowProcessState()
        {
            switch (processState)
            {
                case ProcessState.NotRunning:
                    Console.WriteLine("The machine is stopped.");
                    break;

                case ProcessState.Starting:
                    Console.WriteLine("The machine is starting, please wait...");
                    processState = ProcessState.Initializing;
                    ShowProcessState();
                    break;

                case ProcessState.Initializing:
                    Console.WriteLine("Initializing components, please wait...");
                    processState = ProcessState.Running;
                    ShowProcessState();
                    break;

                case ProcessState.Idle:
                    Console.WriteLine("The machine is currently in stand by mode.");
                    break;

                case ProcessState.Running:
                    Console.WriteLine("The machine is currently running.");
                    processState = ProcessState.Idle;
                    ShowProcessState();
                    break;

                case ProcessState.Stopping:
                    Console.WriteLine("The machine is beeing stopped, please wait...");
                    processState = ProcessState.NotRunning;
                    ShowProcessState();
                    break;
            }
        }


        public static void Start()
        {
            processState = ProcessState.Starting;
            ShowProcessState();
        }

        public static void Stop()
        {
            processState = ProcessState.Stopping;
            ShowProcessState();
        }
    }
}
