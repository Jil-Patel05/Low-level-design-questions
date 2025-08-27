using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Low_Level_Design_questions.VendingMachineDesign
{
    public interface IState
    {
        public void nextState(VendingMachine machine);
    }

    public interface IstateWithCancel : IState
    {
        public void setCancelState(VendingMachine machine);
    }
}