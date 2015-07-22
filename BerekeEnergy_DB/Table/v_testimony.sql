CREATE TABLE [dbo].[v_testimony]
(
	[Id] INT NOT NULL IDENTITY, 
    [general_T] DECIMAL(18, 2) NOT NULL, 
    [tt_1] DECIMAL(18, 2) NOT NULL, 
    [tt_cof_1] DECIMAL(18, 2) NOT NULL, 
    [amount_tt_cof_1] DECIMAL(18, 2) NOT NULL, 
    [tt_2] DECIMAL(18, 2) NULL DEFAULT 0, 
    [tt_Cof_2] DECIMAL(18, 2) NULL DEFAULT 0, 
    [amount_tt_cof_2] DECIMAL(18, 2) NULL DEFAULT 0, 
    [tt_3] DECIMAL(18, 2) NULL DEFAULT 0, 
    [tt_cof_3] DECIMAL(18, 2) NULL DEFAULT 0, 
    [amount_tt_cof_3] DECIMAL(18, 2) NULL DEFAULT 0, 
    [tt_4] DECIMAL(18, 2) NULL DEFAULT 0, 
    [tt_cof_4] DECIMAL(18, 2) NULL DEFAULT 0, 
    [amount_tt_cof_4] DECIMAL(18, 2) NULL DEFAULT 0, 
    [total] DECIMAL(18, 2) NOT NULL, 
    [date_of_testimony] DATETIME NOT NULL DEFAULT getdate(), 
    CONSTRAINT [PK_v_testimony] PRIMARY KEY ([Id]) 
)
