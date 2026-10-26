using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GestionEtudiantsApp.Models;

namespace GestionEtudiantsApp.DAL
{
    public class EtudiantDAL
    {
        public void Ajouter(Etudiant e)
        {
            using (SqlConnection cn = DatabaseHelper.GetConnection())
            {
                string sql = @"INSERT INTO Etudiants (Nom, Prenom, DateNaissance, Groupe)
                               VALUES (@Nom, @Prenom, @DateNaissance, @Groupe)";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@Nom", e.Nom);
                cmd.Parameters.AddWithValue("@Prenom", e.Prenom);
                cmd.Parameters.AddWithValue("@DateNaissance", e.DateNaissance);
                cmd.Parameters.AddWithValue("@Groupe", e.Groupe);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Modifier(Etudiant e)
        {
            using (SqlConnection cn = DatabaseHelper.GetConnection())
            {
                string sql = @"UPDATE Etudiants 
                               SET Nom=@Nom, Prenom=@Prenom, DateNaissance=@DateNaissance, Groupe=@Groupe
                               WHERE IdEtudiant=@Id";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@Nom", e.Nom);
                cmd.Parameters.AddWithValue("@Prenom", e.Prenom);
                cmd.Parameters.AddWithValue("@DateNaissance", e.DateNaissance);
                cmd.Parameters.AddWithValue("@Groupe", e.Groupe);
                cmd.Parameters.AddWithValue("@Id", e.IdEtudiant);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Supprimer(int id)
        {
            using (SqlConnection cn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Etudiants WHERE IdEtudiant=@Id", cn);
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Etudiant> Lister()
        {
            List<Etudiant> liste = new List<Etudiant>();
            using (SqlConnection cn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Etudiants", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    liste.Add(new Etudiant
                    {
                        IdEtudiant = (int)dr["IdEtudiant"],
                        Nom = dr["Nom"].ToString(),
                        Prenom = dr["Prenom"].ToString(),
                        DateNaissance = (System.DateTime)dr["DateNaissance"],
                        Groupe = dr["Groupe"].ToString()
                    });
                }
            }
            return liste;
        }

        public Etudiant TrouverParId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
