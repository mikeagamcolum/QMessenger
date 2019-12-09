using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Arithmetic;

namespace Quantum.Qute_Forcer
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                string x = Convert.ToString(KeyGenerator.Run(qsim).Result);
                x = x.Replace("True", "1");
                x = x.Replace("False", "0");
                x = x.Replace(",", "");
                Console.WriteLine("Shared Key: " + x);
            }
        }
    }
}