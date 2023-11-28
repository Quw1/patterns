using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Examples
{
    // Mainapp test application 
    class MainApp
    {
        public static void Main()
        {
            CentralSupervisor machine_supervisor = new CentralSupervisor();
            Console.WriteLine("Starting machine check-up\n");
            machine_supervisor.PerformSoftwareCheck();
            Console.WriteLine("\n");
            machine_supervisor.PerformHardwareCheck();
            // Wait for user 
            Console.Read();
        }
    }


    // "Subsystem OSSupervisor" 
    class OSSupervisor
    {
        public void CheckOS()
        {
            Console.Write("  -> Operating system status -- ");
            if (true) Console.Write("ONLINE\n");
        }
    }

    // Subsystem FSSSupervisor" 
    class FSSSupervisor
    {
        public void CheckStorage()
        {
            Console.Write("  -> File storage system health -- ");
            if (true) Console.Write("100%\n");
        }
    }


    // Subsystem ShellSupervisor" 
    class ShellSupervisor
    {
        public void CheckShell()
        {
            Console.Write("  -> Shell status -- ");
            if (true) Console.Write("OK\n");
        }
    }
    // Subsystem PeripheralSupervisor" 
    class PeripheralSupervisor
    {
        public void CheckInput()
        {
            Console.Write("  -> Peripheral & input system check -- ");
            if (true) Console.Write("DONE\n");
        }

        public void CheckOutput()
        {
            Console.Write("  -> Peripheral & output status -- ");
            if (true) Console.Write("OK\n");
        }
    }
    // Subsystem PowerSupervisor" 
    class PowerSupervisor
    {
        public void CheckPower()
        {
            Console.Write("  -> Power supply -- ");
            if (true) Console.Write("ENABLED\n");
        }
    }
    // "CentalSupervisor" 
    class CentralSupervisor
    {
        OSSupervisor os_sv;
        FSSSupervisor fss_sv;
        ShellSupervisor shell_sv;
        PeripheralSupervisor peripheral_sv;
        PowerSupervisor power_sv;

        public CentralSupervisor()
        {
            os_sv = new OSSupervisor();
            fss_sv = new FSSSupervisor();
            shell_sv = new ShellSupervisor();
            peripheral_sv = new PeripheralSupervisor();
            power_sv = new PowerSupervisor();
        }

        public void PerformSoftwareCheck()
        {
            Console.WriteLine("Software check");
            os_sv.CheckOS();
            fss_sv.CheckStorage();
            peripheral_sv.CheckInput();

        }

        public void PerformHardwareCheck()
        {
            Console.WriteLine("Hardware check");
            shell_sv.CheckShell();
            peripheral_sv.CheckOutput();
            power_sv.CheckPower();
        }
    }
}