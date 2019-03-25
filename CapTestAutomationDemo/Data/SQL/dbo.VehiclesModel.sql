CREATE TABLE [dbo].[VehiclesModel] (
    [ID]               INT            IDENTITY (1, 1) NOT NULL,
    [Year]             DATETIME2 (7)  NULL,
    [Make]             NVARCHAR (MAX) NULL,
    [CarModel]         NVARCHAR (MAX) NULL,
    [BodyStyle]        NVARCHAR (MAX) NULL,
	[FuelType] NVARCHAR(MAX) NULL, 
    [EngineSize] FLOAT NULL,
    [InsurancePackage] INT NULL,	 
    CONSTRAINT [PK_VehiclesModel] PRIMARY KEY CLUSTERED ([ID] ASC)
);

