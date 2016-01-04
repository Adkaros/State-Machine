using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    public class State2 : IState
    {
        public void Init()
        {
            Console.Write(this.ToString() + " - Init()\n");
        }

        public void Enter()
        {
            Console.Write(this.ToString() + " - Enter()\n");
        }

        public void Exit()
        {
            Console.Write(this.ToString() + " - Exit()\n");
        }


        public void Pause()
        {
            Console.Write(this.ToString() + " - Pause()\n");
        }

        public void Resume()
        {
            Console.Write(this.ToString() + " - Resume()\n");
        }
    }
}
