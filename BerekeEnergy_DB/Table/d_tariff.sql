CREATE TABLE [dbo].[d_tariff]
(
	[Id] INT NOT NULL IDENTITY , 
    [tariff_1] DECIMAL(18, 2) NOT NULL, 
    [tariff_2] DECIMAL(18, 2) NULL, 
    [tariff_3] DECIMAL(18, 2) NULL, 
    [tariff_4] DECIMAL(18, 2) NULL, 
    [code] VARCHAR(50) NOT NULL, 
    [name] VARCHAR(150) NULL, 
    CONSTRAINT [PK_d_counter_tariff] PRIMARY KEY ([Id])
)
