CREATE DATABASE MedicalStore

CREATE TABLE medications(
  id INT PRIMARY KEY IDENTITY(1,1),
  name VARCHAR(100) NOT NULL,
  category VARCHAR(100),
  price DECIMAL(10,2) NOT NULL,
  expiry_date DATE,
  supplier_id INT,
  stock_quantity INT,

  CONSTRAINT FK_supp_id FOREIGN KEY (supplier_id) REFERENCES suppliers(id) 

)

CREATE TABLE suppliers(
 id INT PRIMARY KEY IDENTITY(1,1), 
 name VARCHAR(100) NOT NULL,
 contact_person VARCHAR(100),
 phone VARCHAR(100),
 email VARCHAR(100) UNIQUE,
 address VARCHAR(100)
)

CREATE TABLE customers(
   id INT PRIMARY KEY IDENTITY(1,1), 
   name VARCHAR(100) NOT NULL,
   phone VARCHAR(100),
   email VARCHAR(100) UNIQUE,
   address VARCHAR(100)

)

CREATE TABLE sales(
   id INT PRIMARY KEY IDENTITY(1,1), 
   customer_id INT,
   medication_id INT,
   quantity INT,
   sales_date DATETIME DEFAULT GETDATE(),
   total_price DECIMAL(10,2),
   CONSTRAINT FK_cus_id FOREIGN KEY (customer_id) REFERENCES customers(id) ,
   CONSTRAINT FK_med_id FOREIGN KEY (medication_id) REFERENCES medications(id) 
	

)

CREATE TABLE inventory(
    id INT PRIMARY KEY IDENTITY(1,1), 
	medication_id INT,
	supplier_id INT,
	stock_in INT,
	stock_out INT,
	date_added DATETIME DEFAULT GETDATE()
 FOREIGN KEY (medication_id) REFERENCES medications(id),
 FOREIGN KEY (supplier_id) REFERENCES suppliers(id) 

)

--ADD MEDICATION
CREATE PROCEDURE AddMedication
    @name VARCHAR(100),
    @category VARCHAR(100),
    @price DECIMAL(10,2),
    @expiry_date DATE,
    @supplier_id INT,
    @stock_quantity INT

	AS

	BEGIN

	INSERT INTO medications(name, category, price, expiry_date, supplier_id, stock_quantity)
	VALUES (@name,@category,@price,@expiry_date,@supplier_id,@stock_quantity)
    
	END

	EXEC AddMedication 'paracetomol','painkiller',2.50,'2025-10-09','1',100;


	--ADD SUPPLIER
	CREATE PROCEDURE AddSupplier

	@name VARCHAR(100),
    @contact_person VARCHAR(100),
    @phone VARCHAR(100),
    @email VARCHAR(100),
    @address VARCHAR(100)

	AS

	BEGIN

	INSERT INTO suppliers(name,contact_person,phone,email,address)
	VALUES(@name,@contact_person,@phone,@email,@address)

	END

	EXEC AddSupplier 'HealthCorp', 'Alice Johnson', '555-1234', 'alice@healthcorp.com', '123 Main St';

	--ADD CUSTOMER
	
	CREATE PROCEDURE AddCustomer
    @Name VARCHAR(100),
    @Phone VARCHAR(100),
    @Email VARCHAR(100),
    @Address VARCHAR(100)

  AS
BEGIN
    INSERT INTO customers (name, phone, email, address)
    VALUES (@Name, @Phone, @Email, @Address);
END;

EXEC AddCustomer 'John Doe', '555-5678', 'john.doe@example.com', '456 Elm St';


--MEDICATION AND SUPPLIERS LLIST

CREATE PROCEDURE GetMedicationsWithSuppliers
AS
BEGIN
    SELECT m.name AS MedicationName, s.name AS SupplierName
    FROM medications m
    JOIN suppliers s ON m.supplier_id = s.id;
END;

EXEC GetMedicationsWithSuppliers;

--GET THE SALESDATA

CREATE PROCEDURE GetSalesData
AS
BEGIN
    SELECT s.id AS SaleID, c.name AS CustomerName, m.name AS MedicationName, s.quantity, s.total_price
    FROM sales s
    JOIN customers c ON s.customer_id = c.id
    JOIN medications m ON s.medication_id = m.id;
END;

EXEC GetSalesData;


--SALES DETAILS OF CUSTOMER

CREATE PROCEDURE GetSalesByCustomer
    @CustomerName VARCHAR(100)
AS
BEGIN
    SELECT s.id AS SaleID, c.name AS CustomerName, m.name AS MedicationName, s.quantity, s.total_price
    FROM sales s
    JOIN customers c ON s.customer_id = c.id
    JOIN medications m ON s.medication_id = m.id
    WHERE c.name = @CustomerName;
END;
EXEC GetSalesByCustomer 'Alice Smith';


---TOTAL REVENUE OF SEPTEMBER

CREATE PROCEDURE GetTotalRevenueForMonth
    @Month INT,
    @Year INT
AS
BEGIN
    SELECT SUM(total_price) AS TotalRevenue
    FROM sales
    WHERE MONTH(sales_date) = @Month AND YEAR(sales_date) = @Year;
END;

EXEC GetTotalRevenueForMonth 9, 2023;

