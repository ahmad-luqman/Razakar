CREATE TABLE [dbo].[Razakar]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(MAX) NULL, 
    [Gender] CHAR NULL, 
    [MaxQualification] VARCHAR(MAX) NULL, 
    [Occupation] VARCHAR(MAX) NOT NULL, 
    [Expertise] VARCHAR(MAX) NULL, 
    [Location] VARCHAR(MAX) NULL, 
    [Email] VARCHAR(MAX) NULL, 
    [PhoneNumber] VARCHAR(MAX) NULL, 
    [Rating] DECIMAL(5, 2) NULL
)
