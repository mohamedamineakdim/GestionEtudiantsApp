using System.Collections.Generic;
using System.Data.SqlClient;
using GestionEtudiantsApp.Models;

namespace GestionEtudiantsApp.DAL
{
    public class NoteDAL
    {
        public void Ajouter(Note n)
        {
            using (SqlConnection cn = DatabaseHelper.GetConnection())
            {
                string sql = @"INSERT INTO Notes (IdEtudiant, IdMatiere, Note, Session)
                               VALUES (@E, @M, @N, @S)";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@E", n.IdEtudiant);
                cmd.Parameters.AddWithValue("@M", n.IdMatiere);
                cmd.Parameters.AddWithValue("@N", n.Valeur);
                cmd.Parameters.AddWithValue("@S", n.Session ?? "Normale");

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Supprimer(int id)
        {
            using (SqlConnection cn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("DELETE FROM Notes WHERE IdNote=@Id", cn);
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Note> Lister()
        {
            List<Note> liste = new List<Note>();

            using (SqlConnection cn = DatabaseHelper.GetConnection())
            {
                string sql = @"
                SELECT n.IdNote, n.IdEtudiant, n.IdMatiere, n.Note, n.Session,
                       e.Prenom + ' ' + e.Nom AS NomEtudiant,
                       m.NomMatiere
                FROM Notes n
                JOIN Etudiants e ON n.IdEtudiant = e.IdEtudiant
                JOIN Matieres m ON n.IdMatiere = m.IdMatiere";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    liste.Add(new Note
                    {
                        IdNote = (int)dr["IdNote"],
                        IdEtudiant = (int)dr["IdEtudiant"],
                        IdMatiere = (int)dr["IdMatiere"],
                        Valeur = (decimal)dr["Note"],
                        Session = dr["Session"].ToString(),
                        NomEtudiant = dr["NomEtudiant"].ToString(),
                        NomMatiere = dr["NomMatiere"].ToString()
                    });
                }
            }
            return liste;
        }
    }
}
