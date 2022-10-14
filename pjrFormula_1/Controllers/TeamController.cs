using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjrFormula_1.Controllers
{
    internal class TeamController
    {
        #region INSERT
        static public void InsertTeam(string nome)
        {
            F1_2022Entities context = new F1_2022Entities();
            Team e = new Team() { name = nome };
            context.Teams.Add(e);
            context.SaveChanges();

            Console.WriteLine("A Equipe"+ e.ToString()+" foi inserida com sucesso!!!");

            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        #endregion

        #region CONSULT
        static public void PrintListTeam()
        {

            using (var context = new F1_2022Entities())
            {
                var team = context.Teams.ToList();
                if (team.Count > 0)
                {
                    foreach (var item in team)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else
                    Console.WriteLine("A Lista de equipes está vazia");
            }

            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        static public Team SelectTeam(string nome)
        {
            Team search = new Team();
            using (var context = new F1_2022Entities())
            {

                search = context.Teams.FirstOrDefault(b => b.name == nome);
                if (search != null)
                {
                    Console.WriteLine(search.ToString());

                }
                else
                    Console.WriteLine("\n Equipe não encontrado");



                Console.WriteLine("\nPressione ENTER para continuar");
                Console.ReadKey();
                Console.Clear();

                return search;
            }
        }
        #endregion

        #region UPDATE
        static public void UpdateTeam(string nome, string novoNome)
        {

            Team team = SelectTeam(nome);
            team.name = novoNome;
            
            using (var context = new F1_2022Entities())
            {
                context.Entry(team).State = EntityState.Modified;
               // context.Teams.Ate(team);
                context.SaveChanges();
                Console.WriteLine(team.ToString());
            }
            //Console.WriteLine(team.ToString());

        }
        #endregion

        #region REMOVE
        static public void RemoveTeam(string nome)
        {
            Team team = new Team() { name = nome };


            using (var context = new F1_2022Entities())
            {
                context.Entry(team).State = EntityState.Deleted;
                context.Teams.Remove(team);
                context.SaveChanges();
            }
        }
        #endregion

    }
}
