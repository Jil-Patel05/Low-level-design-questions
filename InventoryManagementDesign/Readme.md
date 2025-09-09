Inventory management system:-

Requirements:-

1. We have to manage the multiple products located on different locations
2. User can add or remove products
3. Manage notification of inventory when some product has low quantity left
4. Repleishment strategy

Core Entities:-

1. Product
2. WareHouse -> products, allow operations to add or remove products, Locations
3. InventoryManager -> managing the products
4. Replaishment strategy -> bulkwise

Design patterns:-

1. Singleton
2. ObserverPattern
3. Factory pattern to make products
4. Strategy pattern to set replenishment strategy(May be this can become overengineered)
