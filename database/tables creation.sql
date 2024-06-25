create database Warehouse_management

-- Create the Tables
use Warehouse_management;
CREATE TABLE Departments (
    department_id INT PRIMARY KEY IDENTITY(1,1),
    department_name VARCHAR(100) NOT NULL
);

use Warehouse_management;
CREATE TABLE Items (
    item_id INT PRIMARY KEY IDENTITY(1,1),
    item_code VARCHAR(20) NOT NULL,
    item_name VARCHAR(100) NOT NULL,
    item_type VARCHAR(50),
    unit VARCHAR(20),
    reorder_level INT,
    department_id INT,
    FOREIGN KEY (department_id) REFERENCES Departments(department_id)
);

use Warehouse_management;
CREATE TABLE Users (
    user_id INT PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(50) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL,
    full_name VARCHAR(100)
);

use Warehouse_management;
CREATE TABLE Warehouses ( 
warehouse_id INT PRIMARY KEY IDENTITY(1,1), 
warehouse_name VARCHAR(100) NOT NULL );

use Warehouse_management;
CREATE TABLE Inventory (
    inventory_id INT PRIMARY KEY IDENTITY(1,1),
    warehouse_id INT,
    item_id INT,
    quantity INT,
    FOREIGN KEY (warehouse_id) REFERENCES Warehouses(warehouse_id),
    FOREIGN KEY (item_id) REFERENCES Items(item_id)
);

use Warehouse_management;
CREATE TABLE Reasons ( 
reason_id INT PRIMARY KEY IDENTITY(1,1),
reason_description VARCHAR(255) NOT NULL );

use Warehouse_management;
CREATE TABLE Depreciations (
    depreciation_id INT PRIMARY KEY IDENTITY(1,1),
    item_id INT,
    warehouse_id INT,
    quantity INT,
    reason_id INT,
    depreciation_date DATE,
    FOREIGN KEY (item_id) REFERENCES Items(item_id),
    FOREIGN KEY (warehouse_id) REFERENCES Warehouses(warehouse_id),
    FOREIGN KEY (reason_id) REFERENCES Reasons(reason_id)
);

use Warehouse_management;
CREATE TABLE Transactions (
    transaction_id INT PRIMARY KEY IDENTITY(1,1),
    transaction_date DATE NOT NULL,
    warehouse_id INT,
    item_id INT,
    quantity INT,
    transaction_type VARCHAR(20), -- يمكن أن تكون (إضافة، صرف، مرتجع داخلي، مرتجع للمورد، إهلاك)
    recipient VARCHAR(100), -- جهة الصرف
    return_type VARCHAR(20), -- يمكن أن تكون (داخلي، للمورد)
    return_code VARCHAR(20),
    depreciation_id INT,
    reason_id INT,
    user_id INT,
    FOREIGN KEY (warehouse_id) REFERENCES Warehouses(warehouse_id),
    FOREIGN KEY (item_id) REFERENCES Items(item_id),
    FOREIGN KEY (reason_id) REFERENCES Reasons(reason_id),
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (depreciation_id) REFERENCES Depreciations(depreciation_id)
);
