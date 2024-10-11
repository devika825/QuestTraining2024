

CREATE TABLE Accounts (
    AccountID INT PRIMARY KEY IDENTITY(1,1),
    AccountHolderName VARCHAR(100) NOT NULL,
    Address VARCHAR(255),
    PhoneNumber VARCHAR(20),
    AccountType VARCHAR(50) NOT NULL,  -- Savings, Current, etc.
    Balance DECIMAL(18, 2) DEFAULT 0,  -- Starting with a balance of 0
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE()
);

CREATE TABLE Transactions (
    TransactionID BIGINT PRIMARY KEY IDENTITY(1,1),
    FromAccountID INT,
    ToAccountID INT, -- NULL for deposit/withdrawal
    TransactionType VARCHAR(50), -- Deposit, Withdraw, Transfer
    Amount DECIMAL(18, 2),
    TransactionDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (FromAccountID) REFERENCES Accounts(AccountID),
    FOREIGN KEY (ToAccountID) REFERENCES Accounts(AccountID) -- Only for transfers
);

-- Create a new account
INSERT INTO Accounts (AccountHolderName, Address, PhoneNumber, AccountType, Balance)
VALUES ('John Doe', '123 Main St', '555-1234', 'Savings', 500.00);

-- Delete an account if the balance is zero
DELETE FROM Accounts 
WHERE AccountID = 1 AND Balance = 0;

-- Optionally, cascade delete transactions related to the account
DELETE FROM Transactions 
WHERE FromAccountID = 1 OR ToAccountID = 1;


-- Update account details
UPDATE Accounts
SET Address = '456 Elm St', PhoneNumber = '555-5678'
WHERE AccountID = 1;


-- Deposit money into an account
UPDATE Accounts
SET Balance = Balance + 100.00, UpdatedAt = GETDATE()
WHERE AccountID = 1;

-- Log the deposit transaction
INSERT INTO Transactions (FromAccountID, TransactionType, Amount)
VALUES (1, 'Deposit', 100.00);

-- Withdraw money from an account
UPDATE Accounts
SET Balance = Balance - 50.00, UpdatedAt = GETDATE()
WHERE AccountID = 1 AND Balance >= 50.00;

-- Log the withdrawal transaction
INSERT INTO Transactions (FromAccountID, TransactionType, Amount)
VALUES (1, 'Withdraw', 50.00);

-- Transfer money between two accounts
UPDATE Accounts
SET Balance = Balance - 200.00, UpdatedAt = GETDATE()
WHERE AccountID = 1 AND Balance >= 200.00;

UPDATE Accounts
SET Balance = Balance + 200.00, UpdatedAt = GETDATE()
WHERE AccountID = 2;

-- Log the transfer transaction
INSERT INTO Transactions (FromAccountID, ToAccountID, TransactionType, Amount)
VALUES (1, 2, 'Transfer', 200.00);


-- View all transactions for a specific account
SELECT * FROM Transactions
WHERE FromAccountID = 1 OR ToAccountID = 1;

-- View the balance of an account
SELECT Balance 
FROM Accounts
WHERE AccountID = 1;


-- View all accounts
SELECT * FROM Accounts;



