--Drop all tables
drop table CATEGORIES cascade constraints;
drop table CLIENTS cascade constraints;
drop table EQUIPMENT cascade constraints;
drop table RENTALITEMS cascade constraints;
drop table RENTALS cascade constraints;

-- Categories Table
CREATE TABLE Categories (
    CategoryID CHAR(2),
    Name VARCHAR(255) NOT NULL,
    Description VARCHAR(255) NOT NULL,
    CONSTRAINT pk_catgories PRIMARY KEY (CategoryID)
);

-- Equipment Table
CREATE TABLE Equipment (
    EquipmentID NUMERIC(4),
    Name VARCHAR(255) NOT NULL,
    Serial_Number VARCHAR(255) NOT NULL,
    Description VARCHAR(255) NOT NULL,
    Rate NUMERIC(6,2) NOT NULL,
    CategoryID CHAR(2),
    CONSTRAINT pk_equipment PRIMARY KEY (EquipmentID),
    CONSTRAINT fk_equipment_categories FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Clients Table
CREATE TABLE Clients (
    ClientID NUMERIC(6),
    First_Name VARCHAR(255) NOT NULL,
    Second_Name VARCHAR(255) NOT NULL,
    Mobile_Number VARCHAR(255) NOT NULL,
    Email_Address VARCHAR(255) NOT NULL,
    Client_Status CHAR(1),
    CONSTRAINT pk_clients PRIMARY KEY (ClientID)
);

-- Rentals Table
CREATE TABLE Rentals (
    RentalID NUMERIC(6),
    ClientID NUMERIC(6),
    Collection_Date DATE,
    Return_Date DATE,
    Price NUMERIC(12,2) NOT NULL,
    Status CHAR(1),
    CONSTRAINT pk_rentals PRIMARY KEY (RentalID),
    CONSTRAINT fk_rentals_clients FOREIGN KEY (ClientID) REFERENCES Clients(ClientID)
);

-- RentalItems Table
CREATE TABLE RentalItems (
    RentalID NUMERIC(6),
    EquipmentID NUMERIC(4),
    Actual_Return_Date DATE,
    Price_Per_Eq NUMERIC(12,2) NOT NULL,
    CONSTRAINT pk_rentalitems PRIMARY KEY (RentalID, EquipmentID),
    CONSTRAINT fk_rentalitems_rentals FOREIGN KEY (RentalID) REFERENCES Rentals(RentalID),
    CONSTRAINT fk_rentalitems_equipment FOREIGN KEY (EquipmentID) REFERENCES Equipment(EquipmentID)
);
