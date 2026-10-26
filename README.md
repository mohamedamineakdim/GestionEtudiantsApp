# GestionEtudiantsApp — Gestion des étudiants

Projet scolaire développé en **C#** avec **Windows Forms** et **SQL Server LocalDB**.

## Contenu

- Formulaires de gestion des étudiants, matières, notes et classements
- Organisation en couches : modèles (`Models`), accès aux données (`DAL`), logique métier (`BLL`) et interface (`UII`)
- Scripts SQL pour les tables `Etudiants`, `Matieres` et `Notes`

## Technologies

C# · Windows Forms · .NET Framework 4.8 · SQL Server LocalDB · Visual Studio

## Ouvrir le projet

1. Ouvrir `GestionEtudiantsApp.slnx` dans une version compatible de Visual Studio.
2. Préparer une base SQL Server LocalDB nommée `GestionEtudiantsDB`.
3. Exécuter les scripts `SQLQuery1.sql`, `SQLQuery2.sql`, puis `SQLQuery3.sql` dans cette base.
4. Vérifier la chaîne de connexion dans `GestionEtudiantsApp.UII/App.config`.
5. Compiler et lancer le projet d'interface `GestionEtudiantsApp.UII`.

**Note :** Ce projet a été réalisé dans le cadre de ma formation en développement informatique. Il présente mes connaissances en C#, Windows Forms et SQL Server. Une configuration locale de la base de données est nécessaire pour l'exécuter.
