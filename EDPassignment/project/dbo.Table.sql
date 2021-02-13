CREATE TABLE [dbo].[testing] (
    [facilityID]   INT             NOT NULL,
    [facilityName] NCHAR (50)      NULL,
    [sport]        NCHAR (20)      NULL,
    [date]         NCHAR (10)      NULL,
    [duration]     NCHAR (10)      NULL,
    [price]        NUMERIC (10, 2) NULL,
    PRIMARY KEY CLUSTERED ([facilityID] ASC)
);