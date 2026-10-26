CREATE TABLE Notes (
    IdNote INT IDENTITY(1,1) PRIMARY KEY,
    IdEtudiant INT NOT NULL,
    IdMatiere INT NOT NULL,
    Note DECIMAL(4,2) CHECK (Note BETWEEN 0 AND 20),
    Session NVARCHAR(20) DEFAULT 'Normale',
    CONSTRAINT FK_Notes_Etudiants FOREIGN KEY (IdEtudiant)
        REFERENCES Etudiants(IdEtudiant),
    CONSTRAINT FK_Notes_Matieres FOREIGN KEY (IdMatiere)
        REFERENCES Matieres(IdMatiere)
);
