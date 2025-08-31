using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Low_Level_Design_questions.VendingMachineDesign
{
    public enum STATES
    {
        IDLE_STATE,
        SELECT_STATE,
        PAYMENT_STATE,
        MANAGEMENT_STATE,
        DISPATCH_ITEM_STATE,
        CANCEL_STATE,
        REFUND_STATE,
    }
    public class IdleState : IState
    {
        public void nextState(VendingMachine machine)
        {
            machine.setCurrentState(new SelectState());
        }

    }
    public class SelectState : IstateWithCancel
    {
        public void nextState(VendingMachine machine)
        {
            machine.setCurrentState(new PaymentState());
        }

        public void setCancelState(VendingMachine machine)
        {
            machine.setCurrentState(new CancelState());
        }
    }
    public class PaymentState : IstateWithCancel
    {
        public void nextState(VendingMachine machine)
        {
            machine.setCurrentState(new ManagementState());
        }
        public void setCancelState(VendingMachine machine)
        {
            machine.setCurrentState(new CancelState());
        }
    }
    public class ManagementState : IState
    {
        public void nextState(VendingMachine machine)
        {
            machine.setCurrentState(new DispatachItemState());
        }

    }
    public class DispatachItemState : IState
    {
        public void nextState(VendingMachine machine)
        {
            machine.setCurrentState(new IdleState());
        }

    }
    public class CancelState : IState
    {
        public void nextState(VendingMachine machine)
        {
            machine.setCurrentState(new IdleState());
        }

    }
    public class RefundState : IState
    {
        public void nextState(VendingMachine machine)
        {
            machine.setCurrentState(new IdleState());
        }

    }
}