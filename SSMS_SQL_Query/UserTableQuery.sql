CREATE TABLE Users(
	id INT NOT NULL PRIMARY KEY IDENTITY,
	firstname VARCHAR (200) NOT NULL,
	lastname VARCHAR (200) NOT NULL,
	email VARCHAR (100) NOT NULL,
	creditCardNumber VARCHAR (100) NOT NULL,
	pinCode VARCHAR (7) NOT NULL,
	createdAT DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
)

INSERT INTO Users(firstname,lastname,email,creditCardNumber,pinCode) VALUES
('Samuel', 'Barker', 'alex.johnson@example.com', '1234567890123456', '1234'),
('Maria', 'Garcia', 'maria.garcia@test.net', '9876543210987654', '5678'),
('Ethan', 'Smith', 'ethan.smith@sample.org', '1111222233334444', '0001'),
('Olivia', 'Wang', 'olivia.wang@dummy.co', '5555666677778888', '9999'),
('Liam', 'Brown', 'liam.brown@testmail.com', '4321098765432109', '1122'),
('Sophia', 'Lee', 'sophia.lee@fake.com', '6789012345678901', '3344'),
('Noah', 'Martinez', 'noah.martinez@data.net', '2468135790864201', '5566'),
('Ava', 'Taylor', 'ava.taylor@info.org', '1357924680135792', '7788'),
('Jackson', 'Wilson', 'jackson.wilson@demo.co', '0987654321098765', '9012'),
('Chloe', 'Anderson', 'chloe.a@mail.com', '1020304050607080', '3456');