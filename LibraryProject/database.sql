CREATE DATABASE LibraryDb;
GO

USE LibraryDb;
GO

CREATE TABLE Categories(
    CategoryId INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100)
);

CREATE TABLE Books(
    BookId INT IDENTITY(1,1) PRIMARY KEY,
    BookTitle NVARCHAR(200),
    BookAuthor NVARCHAR(200),
    CategoryId INT,
    StockTotal INT,
    StockAvailable INT,
    CreatedAt DATETIME
);

CREATE TABLE Members(
    MemberId INT IDENTITY(1,1) PRIMARY KEY,
    MemberFullName NVARCHAR(200),
    MemberEmail NVARCHAR(200),
    MemberPhone NVARCHAR(50)
);

CREATE TABLE Loans(
    LoanId INT IDENTITY(1,1) PRIMARY KEY,
    BookId INT,
    MemberId INT,
    LoanDate DATETIME,
    DueDate DATETIME,
    ReturnDate DATETIME,
    Status NVARCHAR(50)
);