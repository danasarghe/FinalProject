using DataModel;
using System;
using Services.Repository;
using System.Data.Entity;

namespace ShoeStoreFinal
{
    class Program
    {
        //private static readonly StoreContext context;

        //public static StoreContext Context { get; private set; }

        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<StoreContext>());

            StoreContext context = new StoreContext();

            BrandRepository brandRepository = new BrandRepository(context);

            var result1 = brandRepository.Get(5);

            Console.WriteLine(result1.Name);
            ProductRepository productRepository = new ProductRepository(context);
            var result = productRepository.GetAll();
            foreach (var product in result)
            {
                Console.WriteLine(product.Price);
            }
            
            
            

            //var result = brandRepository.GetAll();

            //foreach (var brand in result)
            //{
            //    Console.WriteLine(brand.Name);
            //}
            

            //InsertMultiple
            //QueryingObject();
            //Delete();
            //UpdateModifiedObjects();
            //RetrievingDataWithFind();
            //GetAll();

            Console.ReadKey();

        }
        //        public static void InsertMultiple()
        //        {
        //            var brand = new Brand
        //            {
        //                Brandid = 1,
        //                Name = "Adidas"
        //            };
        //            var brand1 = new Brand
        //            {
        //                Brandid = 1,
        //                Name = "Nike"
        //            };
        //            using (var context = new StoreContext())
        //            {
        //                context.Database.Log = Console.WriteLine;
        //                context.Brands.AddRange(new List<Brand> { brand, brand1 });
        //                context.SaveChanges();
        //            }
        //        }
        //        public static void Insert()
        //        {
        //            var brand = new Brand
        //            {
        //                Brandid = 1,
        //                Name = "Adidas"
        //            };

        //            using (var context = new StoreContext())
        //            {
        //                context.Database.Log = Console.WriteLine;
        //                context.Brands.Add(brand);
        //                context.SaveChanges();
        //            }

        //        }
        //        public static void QueryingObject()
        //        {
        //            using (var context = new StoreContext())
        //            {
        //                context.Database.Log = Console.WriteLine;
        //                var brand = context.Brands.ToList();
        //                foreach (var item in brand)
        //                {
        //                    Console.WriteLine(item.Name);
        //                }

        //            }
        //        }
        //        private static void Delete()
        //        {
        //            using (var context = new StoreContext())
        //            {
        //                context.Database.Log = Console.WriteLine;
        //                var brand = context.Brands.FirstOrDefault();
        //                context.Brands.Remove(brand);
        //                context.SaveChanges();
        //            }
        //        }
        //        private static void DeleteWithKeyVal()
        //        {
        //            var keyval = 1;
        //            using (var context = new StoreContext())
        //            {
        //                context.Database.Log = Console.WriteLine;
        //                var brand = context.Brands.Find(keyval);
        //                context.Brands.Remove(brand);
        //                context.SaveChanges();
        //            }

        //        }
        //        private static void UpdateModifiedObjects()
        //        {
        //            using(var context = new StoreContext())
        //            {
        //                context.Database.Log = Console.WriteLine;
        //                var brand = context.Brands.FirstOrDefault();
        //                brand.Name = "Geox";
        //                context.SaveChanges();
        //            }
        //        }

        //        private static void RetrievingDataWithFind()
        //        {
        //            using(var context=new StoreContext())
        //            {
        //                var keyval = 4;
        //                context.Database.Log = Console.WriteLine;
        //                var brand = context.Brands.Find(keyval);
        //                Console.WriteLine("Find" + brand.Name);


        //            }
        //        }
        //        private static IEnumerable<Brand> GetAll()
        //        {
        //            using(var context= new StoreContext())
        //            {
        //                context.Database.Log = Console.WriteLine;

        //                return context.Set<Brand>().ToList();

        //            }
        //        }
    }
}

//}

