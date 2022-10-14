using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pjrFormula_1.Controllers;

namespace pjrFormula_1
{
    internal class Program
    {
        #region INSERT

        public static void InsertTeam()
        {            
            Console.WriteLine(" Digite o nome da equipe");
            string team = Console.ReadLine();

            TeamController.InsertTeam(team);

        }
                
        public static void InsertPilot()
        {
            Console.Write(" Digite o nome do piloto: ");
            string pilot = Console.ReadLine();

            PilotController.InsertPilot(pilot); 
        }

        public static void InsertCar()
        {
            Car car = new Car();

            Console.Write(" Digite o modelo do carro: ");
            car.model = Console.ReadLine();

            Console.Write(" Digite o ano do carro: ");
            car.year=int.Parse(Console.ReadLine());

            Console.Write(" Digite a unidade do carro: ");
            car.unit=int.Parse(Console.ReadLine());

            Console.Write(" Digite o id da equipe: ");
            car.id_team = int.Parse(Console.ReadLine());


            CarController.InsertCar(car);

        }

        public static void InsertCarPilot()
        {
            PilotCar pc = new PilotCar();

            Console.Write(" Digite o id do pilot: ");
            pc.id_Pilot = int.Parse(Console.ReadLine());

            Console.Write(" Digite o id do carro: ");
            pc.id_Car = int.Parse(Console.ReadLine());

            Console.Write(" Digite a data do evento: ");
            pc.event_date = DateTime.Parse(Console.ReadLine());

            PilotCarController.InsertPilotCar(pc);
        }

        #endregion


        static void Main(string[] args)
        {
            // Execução CRUD Equipe

            //string nome = "Haas F1 Team";
            //TeamController.InsertTeam(nome);

            //TeamController.PrintListTeam();

            //TeamController.SelectTeam(nome);

            //string novoNome = "Scuderia Ferrari";
            //TeamController.UpdateTeam(nome, novoNome);

            //TeamController.RemoveTeam(novoNome);

            //     -----------------------------------------------------------
            //Execução CRUD Piloto

            // string nome=" Luciano Romano";
            //PilotController.InsertPilot(nome);

            //PilotController.PrintListPilot();
            // PilotController.SelectPilot(nome);

            // string novoNome = "Lewis Hamilton";

            //// PilotController.UpdatePilot(nome, novoNome);
            //PilotController.RemovePilot(novoNome);

            //   ---------------------------------------------------------------

            // Car car = new Car();
            //car.model = "Ferrari F1-75";
            //car.year = 2022;
            //car.unit = 01;
            //car.id_team = 104;
            // CarController.InsertCar(car);

            //CarController.PrintListCar();



            Car car =new Car();
            car.id = 2070;
           car.model = "Ferrari F1-V5";
        
            CarController.UpdateCar(car);



        }
    }
}
