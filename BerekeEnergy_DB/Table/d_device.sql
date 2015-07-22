CREATE TABLE [dbo].[d_device]
(
	[Id] INT NOT NULL IDENTITY , 
    [code] VARCHAR(50) NOT NULL, 
    [name] VARCHAR(150) NULL, 
    [coefficient] INT NOT NULL, 
    [device_id] INT NULL, 
    [tariff_Id] INT NULL, 
    CONSTRAINT [PK_d_counter] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_d_device_d_type_device] FOREIGN KEY ([device_id]) REFERENCES [d_type_device]([Id]),
	CONSTRAINT [FK_d_device_d_tariff] FOREIGN KEY ([tariff_Id]) REFERENCES [d_tariff]([Id])
)
