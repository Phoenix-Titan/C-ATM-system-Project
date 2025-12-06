CREATE TABLE AccountBalance (
    id INT NOT NULL PRIMARY KEY IDENTITY,
    fk_User INT NOT NULL,
    USD_AccountBalance DECIMAL(18, 2) NOT NULL DEFAULT 0.00,
    LRD_AccountBalance DECIMAL(18, 2) NOT NULL DEFAULT 0.00,
    updatedAT DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    
    CONSTRAINT FK_AccountBalance_User
        FOREIGN KEY (fk_User) 
        REFERENCES Users(id)
);
INSERT INTO AccountBalance (fk_User, USD_AccountBalance, LRD_AccountBalance) VALUES
(1, 10000.50, 285000.00), -- Samuel Barker
(2, 500.75, 95000.50),  -- Maria Garcia
(3, 10000.00, 1900000.00), -- Ethan Smith (Higher balance example)
(4, 25.10, 4770.00),    -- Olivia Wang
(5, 750.00, 142500.00),  -- Liam Brown
(6, 3200.45, 608085.00),  -- Sophia Lee
(7, 10.99, 2088.10),    -- Noah Martinez (Lower balance example)
(8, 987.65, 187653.50),  -- Ava Taylor
(9, 1200.00, 228000.00),  -- Jackson Wilson
(10, 450.20, 85538.00);  -- Chloe Anderson