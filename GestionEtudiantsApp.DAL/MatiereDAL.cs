using System.Collections.Generic;
using System.Data.SqlClient;
using GestionEtudiantsApp.Models;

namespace GestionEtudiantsApp.DAL
{
    public class MatiereDAL
    {
        public void Ajouter(Matiere m)
        {
            using (SqlConnection cn = DatabaseHelper.GetConnection())
            {
                string sql = @"INSERT INTO Matieres (NomMatiere, Coefficient)
                               VALUES (@Nom, @Coef)";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@Nom", m.NomMatiere);
                cmd.Parameters.AddWithValue("@Coef", m.Coefficient);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Modifier(Matiere m)
        {
            using (SqlConnection cn = DatabaseHelper.GetConnection())
            {
                string sql = @"UPDATE Matieres
                               SET NomMatiere=@Nom, Coefficient=@Coef
                               WHERE IdMatiere=@Id";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@Nom", m.NomMatiere);
                cmd.Parameters.AddWithValue("@Coef", m.Coefficient);
                cmd.Parameters.AddWithValue("@Id", m.IdMatiere);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Supprimer(int id)
        {
            using (SqlConnection cn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("DELETE FROM Matieres WHERE IdMatiere=@Id", cn);
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Matiere> Lister()
        {
            List<Matiere> liste = new List<Matiere>();
            using (SqlConnection cn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Matieres", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    liste.Add(new Matiere
                    {
                        IdMatiere = (int)dr["IdMatiere"],
                        NomMatiere = dr["NomMatiere"].ToString(),
                        Coefficient = (int)dr["Coefficient"]
                    });
                }
            }
            return liste;
        }
    }
}
