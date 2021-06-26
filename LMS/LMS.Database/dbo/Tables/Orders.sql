CREATE TABLE [dbo].[Orders] (
    [Order_Id]   INT          NOT NULL,
    [Order_Name] VARCHAR (30) NOT NULL,
    [Order_Date] DATE         NOT NULL,
    PRIMARY KEY CLUSTERED ([Order_Id] ASC)
);

