


use PizzaStoreDB;
GO
--Pizza--
create schema Pizza;
create table Pizza.Pizza
(
	 PizzaId int not null identity
	,CrustId int null
	,SizeId int null
	,OrderId int null
	,Name nvarchar(50) not null
	,ModifiedDate Datetime2(0) not NULL
	,Active bit not null
);
create table Pizza.Crust
(
	 CrustId int not null IDENTITY
	,Name nvarchar(50) not null
	,ModifiedDate Datetime2(0) not NULL
	,Active bit not null
	,CrustPrice decimal not NULL
);

create table Pizza.Size
(
	 SizeId int not null IDENTITY
	,Name nvarchar(50) not null
	,ModifiedDate Datetime2(0) not NULL
	,Active bit not null
	,SizePrice decimal not NULL
);

create table Pizza.Topping
(
	ToppingId int not null identity --primary key --tinyint, smallint, int, bigint
	,Name nvarchar(50) not null --char, varchar, nchar, nvarchar
	,ModifiedDate Datetime2(0) not null --date, time, datetime
	,Active bit not null --default(1)
	,ToppingPrice decimal not null
);

create table Pizza.PizzaTopping
(
	PizzaToppingId int not null identity
	,PizzaId int not null
	,ToppingId int not null
);

--Orders--
create schema Orders;

create table Orders.Orders
(
	 OrderId int not null identity
	,StoreLocationId int null
	,CustomerId int null
	,Name nvarchar(50) not null
	,ModifiedDate Datetime2(0) not NULL
	,Active bit not null
);

--StoreLocation--
create schema StoreLocation;

create table StoreLocation.StoreLocation
(
	 StoreLocationId int not null identity
	,Name nvarchar(50) not null
	,ModifiedDate Datetime2(0) not NULL
	,Active bit not null
	,LocationAddress nvarchar(50) not null 
);

--Customer--
create schema Customer;

create table Customer.Customer
(
	 CustomerId int not null identity
	,StoreLocationId int null
	,Name nvarchar(50) not null
	,LastName nvarchar(50) not null
	,Email nvarchar(50) not null
	,CompanyName nvarchar(50) not null
	,Address1 nvarchar(50) not null
	,Address2 nvarchar(50) not null
    ,City nvarchar(50) not null
	,Stat nvarchar(50) not null
	,Zip  nvarchar(50) not null
	,Country nvarchar(50) not null
	,ModifiedDate Datetime2(0) not NULL
	,Active bit not null
);

--primary key--
alter table Pizza.Pizza
	add constraint PK_Pizza_PizzaId primary key clustered (PizzaId);

alter table Pizza.Crust
    add constraint PK_Crust_CrustId primary key clustered (CrustId);

alter table Pizza.Size
    add constraint PK_Size_SizeId primary key clustered (SizeId);

alter table Pizza.PizzaTopping
	add constraint PK_PizzaTopping_PizzaToppingId primary key clustered (PizzaToppingId);

alter table Pizza.Topping
	add constraint PK_Topping_ToppingId primary key clustered (ToppingId);

--Orders primary key
alter table  Orders.Orders
	add constraint PK_Orders_OrderId primary key clustered (OrderId);
--StoreLocation primary key
alter table  StoreLocation.StoreLocation
	add constraint PK_StoreLocation_StoreLocationId primary key clustered (StoreLocationId);
--customer primary key
alter table   Customer.Customer
	add constraint PK_Customer_CustomerId primary key clustered (CustomerId);

--Foreign Key Pizza

alter table Pizza.Pizza
	add constraint FK_Pizza_CrustId foreign key (CrustId) references Pizza.Crust(CrustId) on update cascade;

alter table Pizza.Pizza
	add constraint FK_Pizza_SizeId foreign key (SizeId) references Pizza.Size(SizeId) on update cascade;

alter table Pizza.Pizza
	add constraint FK_Pizza_OrderId foreign key (OrderId) references  Orders.Orders(OrderId) on update cascade;

alter table Pizza.PizzaTopping
	add constraint FK_PizzaTopping_PizzaId foreign key (PizzaId) references Pizza.Pizza(PizzaId) on update cascade;

alter table Pizza.PizzaTopping
	add constraint FK_PizzaTopping_ToppingId foreign key (ToppingId) references Pizza.Topping(ToppingId) on update cascade;

--Foreign Key orders
alter table Orders.Orders
	add constraint FK_Orders_StoreLocationId foreign key (StoreLocationId) references StoreLocation.StoreLocation(StoreLocationId) on update cascade;

alter table Orders.Orders
	add constraint FK_Orders_CustomerId foreign key (CustomerId ) references Customer.Customer(CustomerId) on update cascade;

--Foreign Key customers  ---problem on this position
alter table  Customer.Customer
	add constraint FK_Customer_StoreLocationId foreign key (StoreLocationId ) references StoreLocation.StoreLocation(StoreLocationId) on update cascade;
--Foreign Key storeLocation