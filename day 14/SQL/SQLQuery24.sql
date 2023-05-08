create table Client_Master
(
 ClientNo varchar(6) check(ClientNo like 'C%') primary key not null,
 Name varchar(20) not null,
 Address1 varchar(30),
 Address2 varchar(30),
 City varchar(15),
 Pincode numeric(8),
 State varchar(15),
 BalDue numeric(10,2)
 );

create table Product_Master
 (
 ProductNo varchar(6) check(ProductNo like 'P%') primary key not null,
 Description varchar(15) not null,
 ProfitPerc numeric(4,2) not null,
 UnitMeasure varchar(10) not null,
 QtyonHand numeric(8) not null,
 ReorderLvl numeric(8) not null ,
 SellPrice numeric(8,2) check(SellPrice !=0),
 CostPrice numeric(8,2) check(CostPrice !=0)
);

create table Salesman_Master
(
 SalesManno varchar(6) check(SalesManno like 'S%') primary key,
 SalesManname varchar(20) not null,
 Address1 varchar(30) not null,
 Address2 varchar(30) not null,
 City varchar(20),
 Pincode numeric(8),
 State varchar(20),
 Salamt numeric(8,2) check(salamt!=0) not null,
 Tgttoget numeric(6,2) not null,
 Ytdsales numeric(6,2) not null,
 Remarks varchar(60)
);

create table Sales_Order
(
 OrderNo varchar(6) check(OrderNo like 'O%') primary key,
 ClientNo varchar(6) foreign key(ClientNo) references Client_Master(ClientNo),
 OrderDate date,
 DelyAddr varchar(25),
 SalesManNo varchar(6) foreign key(SalesManNo) references Salesman_Master(SalesmanNo),
 DelyType char(1) check(DelyType='P' or DelyType='F'),
 BilledYn char(1) check(BilledYn='Y' or BilledYn='N'),
 DelyDate date,
 OrderStatus varchar(10) check(OrderStatus='In Process' or OrderStatus='Fullfilled' 
 or OrderStatus='Backorder' or OrderStatus='Cancelled')
);

create table Sales_Order_Details
(
 OrderNo varchar(6) foreign key(OrderNo) references Sales_Order(OrderNo),
 ProductNo varchar(6) foreign key(ProductNo) references Product_Master(ProductNo),
 QtyOrdered numeric(8),
 QtyDisp numeric(8),
 ProductRate numeric(10,2),
 primary key(OrderNo,ProductNo)
);

--Client_Master

INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue) VALUES ('C00001', 'Ivan Bayross', 'Mumbai', 400054, 'Maharashtra', 15000);

INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue) VALUES ('C00002', 'Aswini Sai', 'Banglore', 560001, 'Karnataka',5000);

INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue) VALUES ('C00003', 'Dhyan', 'Mumbai', 400054, 'Maharashtra',0);

INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue) VALUES ('C00004', 'Deepu', 'Madras', 780001, 'Tamilnadu', 2000);

INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue) VALUES ('C00005', 'Ananya', 'Thissur', 690558, 'Kerala', 0);

--Product_Master

INSERT INTO Product_Master VALUES ('P00001', 'T-Shirts', 5, 'Piece', 200, 50, 350, 250);

INSERT INTO Product_Master VALUES ('P00002', 'Shirts', 6, 'Piece', 150, 50, 600, 350);

INSERT INTO Product_Master VALUES ('P00003', 'Jeans', 4, 'Piece', 100, 20, 750,500);

INSERT INTO Product_Master VALUES ('P00004', 'Skirts', 5, 'Piece', 70, 30, 850, 250);

INSERT INTO Product_Master VALUES ('P00005', 'Tops', 5, 'Piece', 75, 40, 300, 300);

--Salesman_Master

INSERT INTO Salesman_Master VALUES ('S00001', 'Aman', 'A/14', 'Worli', 'Mumbai', 400002, 'Maharashtra', 3000, 100, 50, 'Good');

INSERT INTO Salesman_Master VALUES ('S00002', 'Ashish', '65', 'Badra', 'Mumbai', 400001, 'Maharashtra', 2000, 200, 40, 'Good');

INSERT INTO Salesman_Master VALUES ('S00003', 'Rahul', 'B/7', 'Jani', 'Mumbai', 400004, 'Maharashtra', 3000, 100, 20, 'Good');

INSERT INTO Salesman_Master VALUES ('S00004', 'Raj', 'A/5', 'Vemam', 'Mumbai', 400005, 'Maharashtra', 1000, 200, 30, 'Good');

INSERT INTO Salesman_Master VALUES ('S00005', 'Abin', 'A/13', 'Keerthika', 'Mumbai', 400007, 'Maharashtra', 4000, 300, 10, 'Good');

--Sales_Order

 INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)

 VALUES('O19001', '12-june-02', 'C00001', 'F', 'N', 'S00001', '20-july-02', 'In Process');

 INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)

 VALUES('O19002', '10-june-04', 'C00002', 'P', 'Y', 'S00002', '27-june-06', 'Cancelled');

 INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)

 VALUES('O19003', '03-april-04', 'C00003', 'F', 'N', 'S00003', '07-Apr-12', 'Fullfilled');

 INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)

 VALUES('O19004', '24-may-03', 'C00004', 'P', 'N', 'S00004', '26-may-05', 'Backorder');

 INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)

 VALUES('O19005', '20-feb-01', 'C00005', 'F', 'Y', 'S00005', '20-june-08', 'In Process');

 --Sales_Order_Details

INSERT INTO Sales_Order_Details (OrderNo, ProductNo, Qtyordered, QtyDisp, ProductRate) VALUES('O19001', 'P00001', 4, 4, 525);

INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19002', 'P00002', 2, 1, 5250);

INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19003', 'P00003', 1, 0, 3150);

INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19004', 'P00004', 4, 5, 8400);

INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19005', 'P00005', 0, 6, 1500);

--1. Display the names of all the clients.

select Name from Client_Master;

--2. Display all the clients who are located in Mumbai.

select * from Client_Master where City='Mumbai';

--3. Display all the products whose selling price is > 2000 and < 5000.

select * from Product_Master where SellPrice>2000 and SellPrice<5000 ;

--4. Display Name, City and State of Clients not in the state of

--Maharashtra.

select Name,City,State from Client_Master where State!='Maharashtra';

--5. Display all the information of client_no C0001 and C0002.

select * from Client_Master where ClientNo in('C00001','C00002');

