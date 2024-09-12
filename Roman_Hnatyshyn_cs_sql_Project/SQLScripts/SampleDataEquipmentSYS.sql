--Deleting from tables--
DELETE FROM RentalItems;
DELETE FROM Rentals;
DELETE FROM Clients;
DELETE FROM Equipment;
DELETE FROM Categories;


--Inserting data into Categories Table--
INSERT INTO Categories (CategoryID, Name, Description) VALUES ('CM', 'Camera', 'Just a camera');
INSERT INTO Categories (CategoryID, Name, Description) VALUES ('LS', 'Lense', 'Just a lense');
INSERT INTO Categories (CategoryID, Name, Description) VALUES ('MC', 'Microphone', 'Just a microphone');

--Inserting data into Equipment Table--
INSERT INTO Equipment (EquipmentID, Name, Serial_Number, Description, Rate, CategoryID) VALUES (1, 'Canon', 'C12345', 'Mirrorless camera', 149.99, 'CM');
INSERT INTO Equipment (EquipmentID, Name, Serial_Number, Description, Rate, CategoryID) VALUES (2, 'Nikon', 'N67890', 'Just a camera', 129.99, 'CM');
INSERT INTO Equipment (EquipmentID, Name, Serial_Number, Description, Rate, CategoryID) VALUES (3, 'Canon', 'C09876', 'Standard zoom lens', 59.99, 'LS');
INSERT INTO Equipment (EquipmentID, Name, Serial_Number, Description, Rate, CategoryID) VALUES (4, 'Sony', 'S12345', 'Telephoto zoom lens', 79.99, 'LS');
INSERT INTO Equipment (EquipmentID, Name, Serial_Number, Description, Rate, CategoryID) VALUES (5, 'Logitech', 'LG12345', 'Microphone for professional audio recording', 99.99, 'MC');
INSERT INTO Equipment (EquipmentID, Name, Serial_Number, Description, Rate, CategoryID) VALUES (6, 'Trust', 'TR03002', 'Gaming microphone', 79.99, 'MC');

--Inserting data into Clients Table--
INSERT INTO Clients (ClientID, First_Name, Second_Name, Mobile_Number, Email_Address, Client_Status) VALUES (1, 'Roman', 'Hnat', '0852882357', 'roma.hnat@gmail.com', 'A');
INSERT INTO Clients (ClientID, First_Name, Second_Name, Mobile_Number, Email_Address, Client_Status) VALUES(2, 'Yunis', 'Bar', '0850850885', 'yunis.bar@gmail.com', 'A');
INSERT INTO Clients (ClientID, First_Name, Second_Name, Mobile_Number, Email_Address, Client_Status) VALUES(3, 'Joe', 'Bloggs', '1234567890', 'joe.bloggs@gmail.com', 'A');

--Inserting data into Rentals Table--
INSERT INTO Rentals (RentalID, ClientID, Collection_Date, Return_Date, Price, Status) VALUES (1, 1, '17-APR-24', '18-APR-24', 99.99, 'C');
INSERT INTO Rentals (RentalID, ClientID, Collection_Date, Return_Date, Price, Status) VALUES(2, 2, '02-MAY-24', '10-MAY-24', 149.99, 'C');
INSERT INTO Rentals (RentalID, ClientID, Collection_Date, Return_Date, Price, Status) VALUES(3, 3, '01-JUN-24', '04-JUN-24', 199.99, 'C');

--Inserting data into RentalItems Table--
INSERT INTO RentalItems (RentalID, EquipmentID, Actual_Return_Date, Price_Per_Eq) VALUES (1, 1, '18-APR-24', 149.99);
INSERT INTO RentalItems (RentalID, EquipmentID, Actual_Return_Date, Price_Per_Eq) VALUES (1, 2, '18-APR-24', 59.99);
INSERT INTO RentalItems (RentalID, EquipmentID, Actual_Return_Date, Price_Per_Eq) VALUES (2, 1, '09-MAY-24', 129.99);
INSERT INTO RentalItems (RentalID, EquipmentID, Actual_Return_Date, Price_Per_Eq) VALUES (3, 3, '04-JUN-24', 99.99);
INSERT INTO RentalItems (RentalID, EquipmentID, Actual_Return_Date, Price_Per_Eq) VALUES (3, 4, '04-JUN-24', 79.99);

COMMIT;