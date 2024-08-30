
CREATE DATABASE ehaDB;

use ehaDB;

CREATE TABLE [dbo].[Users] (
    [userID]   VARCHAR (255) NOT NULL,
    [username] VARCHAR (MAX) NOT NULL,
    [password] VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([userID] ASC),
    CONSTRAINT [FK_Users_Orders] FOREIGN KEY ([userID]) REFERENCES [dbo].[Users] ([userID])
);

CREATE TABLE [dbo].[Products] (
    [ProductID]    VARCHAR (255) NOT NULL,
    [productName]  VARCHAR (255) NOT NULL,
    [Manufacturer] VARCHAR (255) NOT NULL,
    [Price]        DECIMAL (18)  NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([ProductID] ASC),
    CONSTRAINT [FK_Products_Products] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([ProductID])
);

CREATE TABLE [dbo].[Order] (
    [OrderID]       VARCHAR (255) NOT NULL,
    [dateConfirmed] DATE          NOT NULL,
    [status]        VARCHAR (255) NOT NULL,
    [UserID]        VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([OrderID] ASC),
    CONSTRAINT [FK_Order_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([userID])
);

CREATE TABLE [dbo].[orderItems] (
    [orderID]   VARCHAR (255) NOT NULL,
    [productID] VARCHAR (255) NOT NULL,
    [quantity]  INT           NOT NULL,
    CONSTRAINT [PK_orderItems] PRIMARY KEY CLUSTERED ([orderID] ASC, [productID] ASC),
    CONSTRAINT [FK_orderItems_Order] FOREIGN KEY ([orderID]) REFERENCES [dbo].[Order] ([OrderID]),
    CONSTRAINT [FK_orderItems_Products] FOREIGN KEY ([productID]) REFERENCES [dbo].[Products] ([ProductID])
);

INSERT INTO [dbo].[Products] ([ProductID], [productName], [Manufacturer], [Price]) VALUES (1, 'silicon','Peeles Minerals', 43.00);
INSERT INTO [dbo].[Products] ([ProductID], [productName], [Manufacturer], [Price]) VALUES (2, 'nails','Nellas Nails', 62.99);
INSERT INTO [dbo].[Products] ([ProductID], [productName], [Manufacturer], [Price]) VALUES (2, 'crate','Carte from Carl', 54.88);

INSERT INTO [dbo].[users] (userID, username, [password]) VALUES (1, 'Roshie98','panhandle');
INSERT INTO [dbo].[users] (userID, username, [password]) VALUES (2, 'Posch00','OIuyvtUGTV');
INSERT INTO [dbo].[users] (userID, username, [password]) VALUES (3, 'Buuu2OnYou','iyV3GuvIuv6');

INSERT INTO [dbo].[Order] ([OrderID], [dateConfirmed], [status], [userID]) VALUES (1, '2024-02-06','pending', 2);
INSERT INTO [dbo].[Order] ([OrderID], [dateConfirmed], [status], [userID]) VALUES (2, '2024-02-07','pending', 1);
INSERT INTO [dbo].[Order] ([OrderID], [dateConfirmed], [status], [userID]) VALUES (3, '2024-02-16','pending', 3);

INSERT INTO [dbo].[orderItems] ([orderID], [productID], [quantity]) VALUES (2, 3,9);
INSERT INTO [dbo].[orderItems] ([orderID], [productID], [quantity]) VALUES (1, 3,4);
INSERT INTO [dbo].[orderItems] ([orderID], [productID], [quantity]) VALUES (2, 1,2);
