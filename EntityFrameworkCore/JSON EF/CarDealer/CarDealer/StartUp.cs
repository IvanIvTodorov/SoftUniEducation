using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using CarDealer.Data;
using CarDealer.DTO;
using CarDealer.Models;
using Newtonsoft.Json;

namespace CarDealer
{
    public class StartUp
    {
        static IMapper mapper;

        private static void InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CarDealerProfile>();
            });

            mapper = config.CreateMapper();
        }
        public static void Main(string[] args)
        {
            var db = new CarDealerContext();

            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();

            //var inputSuppliers = File.ReadAllText("../../../Datasets/suppliers.json");
            //ImportSuppliers(db, inputSuppliers);

            //var inputParts = File.ReadAllText("../../../Datasets/parts.json");
            //ImportParts(db, inputParts);

            //var inputCars = File.ReadAllText("../../../Datasets/cars.json");
            //ImportCars(db, inputCars);

            //var inputCustomers = File.ReadAllText("../../../Datasets/customers.json");
            //ImportCustomers(db, inputCustomers);

            //var inputSales = File.ReadAllText("../../../Datasets/sales.json");
            //Console.WriteLine(ImportSales(db, inputSales));


            Console.WriteLine(GetSalesWithAppliedDiscount(db)); 

        }

        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            InitializeAutomapper();

            var dtoSuppliers = JsonConvert.DeserializeObject<IEnumerable<SupliersInputModel>>(inputJson);

            var suppliers = mapper.Map<IEnumerable<Supplier>>(dtoSuppliers);

            context.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count()}.";
        }

        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            InitializeAutomapper();

            var suppliers = context.Suppliers
                .Select(x => x.Id)
                .ToArray();
                

            var dtoParts = JsonConvert.DeserializeObject<IEnumerable<PartInputModel>>(inputJson)
                .Where(p => suppliers.Contains(p.SupplierId))
                .ToArray();

            var parts = mapper.Map<IEnumerable<Part>>(dtoParts);

            context.AddRange(parts);
            context.SaveChanges();
            

            return $"Successfully imported {parts.Count()}.";
        }


        public static string ImportCars(CarDealerContext context, string inputJson)
        {

            var dtoCars = JsonConvert.DeserializeObject<IEnumerable<CarInputModel>>(inputJson);

            var cars = new List<Car>();

            foreach (var car in dtoCars)
            {
                var current = new Car
                {
                    Make = car.Make,
                    Model = car.Model,
                    TravelledDistance = car.TravelledDistance
                };

                foreach (var part in car.PartsId.Distinct())
                {
                    current.PartCars.Add(new PartCar
                    {
                        PartId = part
                    });
                }

                cars.Add(current);
            }

            context.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count()}.";
        }

        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            InitializeAutomapper();

            var dtoCustomers = JsonConvert.DeserializeObject<IEnumerable<CustomerInputModel>>(inputJson);

            var customers = mapper.Map<IEnumerable<Customer>>(dtoCustomers);

            context.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Count()}.";
        }

        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            InitializeAutomapper();

            var dboSales = JsonConvert.DeserializeObject<IEnumerable<SaleInputModel>>(inputJson);

            var sales = mapper.Map<IEnumerable<Sale>>(dboSales);

            context.AddRange(sales);
            context.SaveChanges();


            return $"Successfully imported {sales.Count()}.";
        }

        public static string GetOrderedCustomers(CarDealerContext context)
        {

            var customers = context.Customers
                .Select(c => new
                {
                    c.Name,
                    c.BirthDate,
                    c.IsYoungDriver
                })
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => c.IsYoungDriver)
                .ToArray();

            var jsonSettings = new JsonSerializerSettings();
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.DateFormatString = "dd/MM/yyyy";

            return JsonConvert.SerializeObject(customers, jsonSettings);

        }

        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(c => c.Make == "Toyota")
                .Select(c => new
                {
                    c.Id,
                    c.Make,
                    c.Model,
                    c.TravelledDistance
                })
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TravelledDistance)
                .ToArray();

            return JsonConvert.SerializeObject(cars, Formatting.Indented);

        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliers = context.Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                    PartsCount = s.Parts.Count
                })
                .ToArray();

            return JsonConvert.SerializeObject(suppliers, Formatting.Indented);
        }

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars
                .Select(c => new
                {
                   car = new
                   {
                       c.Make,
                       c.Model,
                       c.TravelledDistance
                   },
                    parts = c.PartCars.Select(pc => new
                    {
                        pc.Part.Name,
                        Price = $"{pc.Part.Price:F2}"
                    })
                })
                .ToArray();


            return JsonConvert.SerializeObject(cars, Formatting.Indented);


        }

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customer = context.Customers
                .Where(c => c.Sales.Count >= 1)
                .Select(c => new
                {
                    fullName = c.Name,
                    boughtCars = c.Sales.Count,
                    spentMoney = c.Sales.Sum(s => s.Car.PartCars.Sum(a => a.Part.Price))
                })
                .OrderByDescending(c => c.spentMoney)
                .ThenByDescending(c => c.boughtCars)
                .ToArray();


            return JsonConvert.SerializeObject(customer, Formatting.Indented);

        }

        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
                .Select(s => new
                {
                    car = new
                    {
                        s.Car.Make,
                        s.Car.Model,
                        s.Car.TravelledDistance
                    },
                    customerName = s.Customer.Name,
                    Discount = $"{s.Discount:F2}",
                    price = $"{s.Car.PartCars.Sum(pc => pc.Part.Price):F2}" ,
                    priceWithDiscount = $"{s.Car.PartCars.Sum(pc => pc.Part.Price) * ((100 - s.Discount) / 100):F2}"
                })
                .Take(10)
                .ToArray();

            return JsonConvert.SerializeObject(sales, Formatting.Indented);
        }
    }
}