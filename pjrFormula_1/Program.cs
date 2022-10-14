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

        #region PRINT LIST
        
        public static void PrintListTeam() { TeamController.PrintListTeam(); }
        public static void PrintListCar() { CarController.PrintListCar(); }
        public static void PrintListPilor() { PilotController.PrintListPilot(); }
        public static void PrintListPilotCar() {PilotCarController.PrintListPilotCar(); }

        #endregion

        #region SELECT

        public static void SelectTeam()
        {
            Console.WriteLine(" Digite o nome da equipe");
            string nome = Console.ReadLine();

            TeamController.SelectTeam(nome);
        }

        public static void SelectPilot()
        {
            Console.WriteLine(" Digite o nome do Piloto");
            string nome=Console.ReadLine();

            PilotController.SelectPilot(nome);  
        }
              
        public static void SelectCar()
        {
            Console.WriteLine(" Digite o codigo de registro do carro");
            int codigo =int.Parse(Console.ReadLine());

            CarController.SelectCar(codigo);
        }

        public static void SelectPilotCar()
        {
            Console.WriteLine(" Em manutenção");

            Console.ReadKey();
        }
        #endregion

        #region UPDATE
        
        public static void UpdateTeam()
        {
            Console.WriteLine(" Digite o nome da equipe");
            string nome = Console.ReadLine();

            Console.WriteLine(" Digite o novo nome da equipe");
            string novoNome = Console.ReadLine();

            TeamController.UpdateTeam(nome,novoNome);
        }

        public static void UpdatePilot()
        {
            Console.WriteLine(" Digite o nome do piloto");
            string nome = Console.ReadLine();

            Console.WriteLine(" Digite o novo nome do piloto");
            string novoNome = Console.ReadLine();

            PilotController.UpdatePilot(nome,novoNome);
        }
        
        public static void UpdateCar()
        {
            int opc = 0;
            Console.WriteLine(" Digite o codigo da equipe");
            int cod = int.Parse(Console.ReadLine());

            var car = CarController.SelectCar(cod);

            switch (opc)
            {
                case 0:break;
                    case 1:
                    Console.WriteLine(" Digite o novo modelo ");
                    car.model = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine(" Digite a novo ano");
                    car.year = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine(" Digite a unidade");
                    car.unit = int.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine(" Digite o codigo da nova equipe");
                    car.id_team = int.Parse(Console.ReadLine());
                    break;
            }

            CarController.UpdateCar(car);

        }

        public static void UpdatePilotCar()
        {
            int opc = 0;
            Console.WriteLine(" Digite o codigo do evento");
            int cod = int.Parse(Console.ReadLine());

            var pc = PilotCarController.SelectCar(car);
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
