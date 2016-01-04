using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    public class StateMachine
    {
        public enum MACHINE_STATE { State1, State2, State3 }
        public MACHINE_STATE state;

        private List<IState> states = new List<IState>();
        private IState currentState;
        private IState previousState;

        public StateMachine(List<IState> programStates)
        {
            this.states = programStates;
        }

        public IState GetNextState()
        {
            return states[(int)state];
        }

        public void ChangeState(MACHINE_STATE state)
        {
            states[(int)state].Init();
            states[(int)state].Enter();

        }

        public void RevertToPrev()
        {

        }
    }
}
