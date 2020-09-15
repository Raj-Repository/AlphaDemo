using AlphaDemo.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaDemo.Database.InitialData
{
    public static class LoadData
    {
        public static int Initialize(DatabaseContext context)
        {
            if (context.SampleData.Any())
            {
                return context.SampleData.Count();   // DB has been seeded
            }

            List<SampleData> SampleDataCol = new List<SampleData>();
            for (int i = 1; i <= 100; i++)
            {
                String testData = i.ToString();

                if (i % 3 == 0 && i % 5 == 0) testData = "FizzBuzz";
                else if (i % 3 == 0) { testData = "Fizz"; }
                else if (i % 5 == 0) testData = "Buzz";

                context.SampleData.Add(new SampleData { TestData = testData });
                context.SaveChanges();   
            }
            return context.SampleData.Count();
        }
    }
}

        