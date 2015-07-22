CREATE TABLE [dbo].[d_type_device]
(
	[Id] INT NOT NULL IDENTITY, 
    [code] VARCHAR(50) NOT NULL, 
    [name] VARCHAR(150) NULL, 
    CONSTRAINT [PK_d_type_device] PRIMARY KEY ([Id])
)
