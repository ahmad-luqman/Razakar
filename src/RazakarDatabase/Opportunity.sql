CREATE TABLE [dbo].[Opportunity]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [OrganizationName] VARCHAR(MAX) NULL, 
    [Date] DATETIME NULL, 
    [Time] DATETIME NULL, 
    [Duration] DECIMAL(5, 2) NULL, 
    [Details] VARCHAR(MAX) NULL
)
