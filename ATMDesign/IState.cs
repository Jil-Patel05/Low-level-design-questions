using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Low_Level_Design_questions.ATMDesign
{
    public interface IState
    {
        public void nextState(ATMMachine machine);
    }

    public class IdleState : IState
    {
        public void nextState(ATMMachine machine)
        {
            machine.setCurrentState(new HasCard());
        }
    }
    public class HasCard : IState
    {
        public void nextState(ATMMachine machine)
        {
            machine.setCurrentState(new SelectOperationState());
        }
    }
    public class SelectOperationState : IState
    {
        public void nextState(ATMMachine machine)
        {
            machine.setCurrentState(new ProcessOperationState());

        }
    }
    public class ProcessOperationState : IState
    {
        public void nextState(ATMMachine machine)
        {
            machine.setCurrentState(new DispatchMoney());
        }
    }
    public class DispatchMoney : IState
    {
        public void nextState(ATMMachine machine)
        {
            machine.setCurrentState(new IdleState());
        }
    }
    public class CancelState : IState
    {
        public void nextState(ATMMachine machine)
        {
            machine.setCurrentState(new IdleState());
        }
    }
}