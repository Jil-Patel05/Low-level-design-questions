using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Low_Level_Design_questions.VendingMachineDesign
{
    public class VendingMachine
    {
        private List<Shelf> shelfs = new List<Shelf>();
        private double princeOfCurrentItem = 0;
        private IState curerntState;
        private Product selectedProduct;
        private int selectedQuantity;
        public static VendingMachine instance;
        public static Object obj = new object();
        private VendingMachine()
        {

        }

        public static VendingMachine getInstance()
        {
            if (instance == null)
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new VendingMachine();
                    }
                }
            }
            return instance;
        }

        public void initializeMachine()
        {
            this.curerntState = new IdleState();
        }
        public void setCurrentState(IState state)
        {
            this.curerntState = state;
        }

        public void addShelfs(Shelf shelf)
        {
            shelfs.Add(shelf);
        }

        private bool isIdPresentInShelf(string id)
        {
            Shelf? sh = shelfs.FirstOrDefault(elm => elm.shelfId == id);
            return sh != null;
        }

        public void startButtonClicked()
        {
            try
            {
                if (this.curerntState is IdleState)
                {
                    // Change the UI logic
                    this.curerntState.nextState(this);
                }
                else
                {
                    throw new Exception("Function doesn't come under this state");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void enteredId(string id, int quantity)
        {
            if (this.curerntState is SelectState)
            {
                if (this.isIdPresentInShelf(id))
                {
                    Shelf? sh = shelfs.FirstOrDefault(elm => elm.shelfId == id);
                    if (sh.product.isEnoughtQuantity(quantity))
                    {
                        this.selectedProduct = sh.product;
                        this.selectedQuantity = quantity;
                        princeOfCurrentItem = (double)quantity * sh.product.productPrice;
                        this.curerntState.nextState(this);
                    }
                    else
                    {
                        Console.WriteLine("No present");
                    }
                }
            }
        }

        public void setItems(int number)
        {
            if (this.curerntState is PaymentState)
            {
                this.selectedQuantity = number;
                princeOfCurrentItem = (double)number * this.selectedProduct.productPrice;
            }
        }

        private IPaymentStrategies givePaymentStrategy(PAYMENT_STRATEGIES paymentStrategy)
        {
            switch (paymentStrategy)
            {
                case PAYMENT_STRATEGIES.CREDIT_CARD_PAYMENT:
                    return new CreditCardPayment();
                case PAYMENT_STRATEGIES.DEBIT_CARD_PAYMENT:
                    return new DebitCardPayment();
                case PAYMENT_STRATEGIES.UPI_PAYMENT:
                    return new UpiPayment();
                default:
                    return new UpiPayment();
            }
        }

        private void dispatchItem()
        {
            if (this.curerntState is DispatachItemState)
            {
                // Dispatch event from machine
                this.curerntState.nextState(this);
            }
        }

        private void performRefundActivity()
        {
            if (this.curerntState is RefundState)
            {
                // Fetch user account details
                this.curerntState.nextState(this);
            }
        }

        private void inventoryManagement()
        {
            try
            {
                if (this.curerntState is ManagementState)
                {
                    this.selectedProduct.setProductQuantity(this.selectedQuantity);
                    this.curerntState.nextState(this);
                    this.dispatchItem();
                }
            }
            catch (Exception ex)
            {
                this.setCurrentState(new RefundState());
                this.performRefundActivity();
            }
        }

        public void purchaseProduct(PAYMENT_STRATEGIES paymentStrategy)
        {
            if (this.curerntState is PaymentState)
            {
                Payment p = new Payment();
                p.setPayment(givePaymentStrategy(paymentStrategy));
                p.makePayment(this.princeOfCurrentItem);
                this.curerntState.nextState(this);
                this.inventoryManagement();
            }
        }

        private void cancelAllThing()
        {
            if (this.curerntState is CancelState)
            {
                this.curerntState.nextState(this);
            }
        }

        public void cancelButtonClick()
        {
            if (this.curerntState is SelectState || this.curerntState is PaymentState)
            {
                this.setCurrentState(new CancelState());
                // Perform cancel activity here
                this.cancelAllThing();
            }
        }

        public void displayItems()
        {
            foreach (Shelf item in shelfs)
            {
                Console.WriteLine("One product");
                Console.WriteLine(item.shelfId);
                Console.WriteLine(item.product.productName);
                Console.WriteLine(item.product.quantity);
            }
        }
    }
}