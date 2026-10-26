CREATE TABLE Matieres (
    IdMatiere INT IDENTITY(1,1) PRIMARY KEY,
    NomMatiere NVARCHAR(100) NOT NULL,
    Coefficient INT NOT NULL DEFAULT 1
);
