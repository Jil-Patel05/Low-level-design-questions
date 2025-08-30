// ATM
// Requirements - Take money from ATM using card with validations(BASIC + MUST)

// Account -> accountNumber, Money, PIN
// Card -> CardNumber, Account, DEBIT CARD
// ATM Inventory management
// ATM Machine ->

// Some of design patterns here
// 1. Singleton
// 2. Observer -> complex to design(I will implement it)
// 3. State design pattern

// Idle state -> insertCard
// HasCard -> Valid, Select account saving/current, Enter PIN -> validation
// SelectOperation -> Withdraw cash, view the balance
// InventoryManagement -> Manage the money of Card(Observer will be set here) and ATM
// DispatchMoney -> we give money to user
// Cancel State -> HasCard
