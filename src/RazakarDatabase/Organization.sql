CREATE TABLE [dbo].[Organization]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(MAX) NULL, 
    [RepName] VARCHAR(MAX) NULL, 
    [Location] VARCHAR(MAX) NULL, 
    [Email] VARCHAR(MAX) NULL, 
    [PhoneNumber] VARCHAR(MAX) NULL, 
    [Rating] DECIMAL(5, 2) NULL
)
