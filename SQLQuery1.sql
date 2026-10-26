CREATE TABLE Etudiants (
    IdEtudiant INT IDENTITY(1,1) PRIMARY KEY,
    Nom NVARCHAR(100) NOT NULL,
    Prenom NVARCHAR(100) NOT NULL,
    DateNaissance DATE,
    Groupe NVARCHAR(50)
);
