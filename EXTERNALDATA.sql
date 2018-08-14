RCXrcx1212!@!@

CREATE MASTER KEY ENCRYPTION BY PASSWORD = 'rcrc1212!@';


CREATE DATABASE SCOPED CREDENTIAL RCXcredential
WITH IDENTITY = 'RCXadmin',
SECRET = 'rcrc1212!@';

CREATE EXTERNAL DATA SOURCE RCXidentity_datasource
WITH (
	TYPE=RDBMS,
	LOCATION='rcx.database.windows.net',
	DATABASE_NAME='rcxidentity',
	CREDENTIAL = RCXcredential
	);



	CREATE EXTERNAL TABLE [dbo].[AspNetUsers] (
  [Id]                   NVARCHAR (128)   NOT NULL,
    [Email]                NVARCHAR (256)   NULL,
    [EmailConfirmed]       BIT              NOT NULL,
    [PasswordHash]         NVARCHAR (MAX)   NULL,
    [SecurityStamp]        NVARCHAR (MAX)   NULL,
    [PhoneNumber]          NVARCHAR (MAX)   NULL,
    [PhoneNumberConfirmed] BIT              NOT NULL,
    [TwoFactorEnabled]     BIT              NOT NULL,
    [LockoutEndDateUtc]    DATETIME         NULL,
    [LockoutEnabled]       BIT              NOT NULL,
    [AccessFailedCount]    INT              NOT NULL,
    [UserName]             NVARCHAR (256)   NOT NULL,
    [enterprise]           UNIQUEIDENTIFIER NOT NULL,
    [connstring]           NVARCHAR (MAX)   NULL,
    [project]              UNIQUEIDENTIFIER NOT NULL
) WITH ( DATA_SOURCE = RCXidentity_datasource )

	CREATE EXTERNAL TABLE [dbo].[rc_enterprise] (
    [en_id]         UNIQUEIDENTIFIER NOT NULL,
    [en_name]       NVARCHAR (500)   NOT NULL,
    [en_connstring] NVARCHAR (2000)  NOT NULL
) WITH ( DATA_SOURCE = RCXidentity_datasource )