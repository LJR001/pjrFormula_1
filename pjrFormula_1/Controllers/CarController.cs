using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjrFormula_1.Controllers
{
    internal class CarController
    {
        #region INSERT
        static public void InsertCar(Car car)
        {
            F1_2022Entities context = new F1_2022Entities();
          //  Car e = new Car(); //{ name = "Aston Martin Aramco Cognizant Formula One Team" };
            context.Cars.Add(car);
            context.SaveChanges();

            Console.WriteLine("O carro " + car.ToString() + " foi inserido com sucesso!!!");

            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        #endregion

        #region CONSULT
        static public void PrintListCar()
        {

            using (var context = new F1_2022Entities())
            {
                var car = context.Cars.ToList();
                if (car.Count > 0)
                {
                    foreach (var item in car)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else
                    Console.WriteLine("A Lista de carros está vazia");
            }

            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        static public Car SelectCar(int car)
        {
            Car search = new Car();
            
            using(var context = new F1_2022Entities())
            {
                search=context.Cars.FirstOrDefault(b => b.id == car);

                if (search != null)
                {
                    Console.WriteLine(search.ToString());
                }
                else
                    Console.WriteLine("\n Carro não encontrado");


                Console.WriteLine("\nPressione ENTER para continuar");
                Console.ReadKey();
                Console.Clear();
                
                
                return search;
            }
        }
        #endregion

        #region UPDATE
        static public void UpdateCar(Car upCar)
        {
            Car car = SelectCar(upCar.id);
            car = upCar;
            using (var context = new F1_2022Entities())
            {
                context.Entry(car).State = EntityState.Modified;
                context.Cars.AddOrUpdate(car);
                context.SaveChanges();
            }
        }
        #endregion

        #region REMOVE
        static public void RemoveCar(int id)
        {
            Car car = new Car() { id = id };

            using (var context = new F1_2022Entities())
            {
                context.Entry(car).State = EntityState.Deleted;
                context.Cars.Remove(car);
                context.SaveChanges();
            }
        }
        #endregion
    }
}
