using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjrFormula_1.Controllers
{
    internal class PilotCarController
    {
        #region INSERT
        static public void InsertPilotCar(PilotCar car)
        {
            F1_2022Entities context = new F1_2022Entities();
            PilotCar e = new PilotCar(); //{ name = "Aston Martin Aramco Cognizant Formula One Team" };
            context.PilotCars.Add(e);
            context.SaveChanges();

            Console.WriteLine("A Equipe" + e.ToString() + " foi inserida com sucesso!!!");

            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        #endregion

        #region CONSULT
        static public void PrintListPilotCar()
        {


            using (var context = new F1_2022Entities())
            {
                var team = context.PilotCars.ToList();
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
        //static public void SelectPilotCar(string n)
        //{

        //    Team search = new F1_2022Entities().PilotCars.FirstOrDefault(b => b.name == n);

        //    if (search != null)
        //    {
        //        Console.WriteLine(search.ToString());
        //    }
        //    else
        //        Console.WriteLine("\n Equipe não encontrado");


        //    Console.WriteLine("\nPressione ENTER para continuar");
        //    Console.ReadKey();
        //    Console.Clear();

        //}
        #endregion

        #region UPDATE
        static public void UpdatePilotCar(PilotCar pilotcar)
        {
            using (var context = new F1_2022Entities())
            {
                context.Entry(pilotcar).State = EntityState.Modified;
                context.PilotCars.AddOrUpdate(pilotcar);
                context.SaveChanges();
            }
        }
        #endregion

        #region REMOVE
        static public void RemovePilotCar(PilotCar pilotcar)
        {
            using (var context = new F1_2022Entities())
            {
                context.Entry(pilotcar).State = EntityState.Deleted;
                context.PilotCars.Remove(pilotcar);
                context.SaveChanges();
            }
        }
        #endregion

    }
}
