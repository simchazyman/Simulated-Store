-- Inserting dummy data into Users table
INSERT INTO Users (Username, Password, Balance) VALUES
('john_doe', 'password123', 100.00),
('jane_smith', 'password456', 150.00),
('alice_jones', 'password789', 200.00),
('bob_brown', 'password000', 250.00);

-- Inserting dummy data into Items table
INSERT INTO Items (ItemName, Price, Quantity) VALUES
('Laptop', 999.99, 10),
('Smartphone', 499.99, 20),
('Tablet', 299.99, 15),
('Headphones', 89.99, 50),
('Smartwatch', 199.99, 30);

-- Inserting dummy data into Purchases table
INSERT INTO Purchases (UserID, ItemID, Quantity, Amount) VALUES
(1, 1, 1, 999.99),  -- John Doe buys 1 Laptop
(2, 2, 2, 999.98),  -- Jane Smith buys 2 Smartphones
(3, 3, 1, 299.99),  -- Alice Jones buys 1 Tablet
(4, 4, 3, 269.97),  -- Bob Brown buys 3 Headphones
(1, 5, 1, 199.99),  -- John Doe buys 1 Smartwatch
(2, 4, 1, 89.99);   -- Jane Smith buys 1 Headphones