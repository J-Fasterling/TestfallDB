CREATE TABLE [dbo].Testfaelle
(
	[nr] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NVARCHAR(50) NULL, 
    [vorbedingung] NVARCHAR(255) NULL, 
    [erwartetes Resultat] NVARCHAR(255) NULL, 
    [ergebnis] NVARCHAR(50) NULL
)
