using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjrFormula_1.Controllers
{
    internal class PilotController
    {
        #region INSERT
        static public void InsertPilot(string nome)
        {
            F1_2022Entities context = new F1_2022Entities();
            Pilot e = new Pilot() { name = nome};
            context.Pilots.Add(e);
            context.SaveChanges();

            Console.WriteLine("O Piloto " + e.ToString() + " foi inserido com sucesso!!!");

            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        #endregion

        #region CONSULT
        static public void PrintListPilot()
        {

            using (var context = new F1_2022Entities())
            {
                var pilot = context.Pilots.ToList();
                if (pilot.Count > 0)
                {
                    foreach (var item in pilot)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else
                    Console.WriteLine("A Lista de pilotos está vazia");
            }

            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }
                
        static public Pilot SelectPilot(string n)
        {

            Pilot search = new Pilot(); 
                

            using (var context = new F1_2022Entities())
            {
               search=context.Pilots.FirstOrDefault(b => b.name == n);
                if (search != null)
                {
                    Console.WriteLine(search.ToString());
                }
                else
                    Console.WriteLine("\n Piloto não encontrado");


                Console.WriteLine("\nPressione ENTER para continuar");
                Console.ReadKey();
                Console.Clear();

                return search;
            }

        }
        #endregion

        #region UPDATE
        static public void UpdatePilot(string nome,string novoNome)
        {
            Pilot pilot = SelectPilot(nome);
            pilot.name = novoNome;
            using (var context = new F1_2022Entities())
            {
                context.Entry(pilot).State = EntityState.Modified;
               // context.Pilots.AddOrUpdate(pilot);
                context.SaveChanges();
                Console.WriteLine(pilot.ToString());
            }
        }
        #endregion

        #region REMOVE
        static public void RemovePilot(string nome)
        {
            Pilot pilot = new Pilot() { name = nome };

            using (var context = new F1_2022Entities())
            {
                context.Entry(pilot).State = EntityState.Deleted;
                context.Pilots.Remove(pilot);
                context.SaveChanges();
            }
        }
        #endregion

    }
}
