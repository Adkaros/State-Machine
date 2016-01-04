using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class Program
    {        

        static void Main(string[] args)
        {
            List<IState> programStates = new List<IState>() { new State1(), new State2() };
            StateMachine stateManager = new StateMachine(programStates);

            stateManager.ChangeState(StateMachine.MACHINE_STATE.State1);

            if (Console.ReadKey().Key == ConsoleKey.E)
                stateManager.ChangeState(StateMachine.MACHINE_STATE.State2);

            Console.Read();
        }
    }
}
