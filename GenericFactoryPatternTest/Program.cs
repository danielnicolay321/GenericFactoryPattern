using GenericFactoryPatternTest.Factory;
using GenericFactoryPatternTest.Generator;
using GenericFactoryPatternTest.Interfaces;
using GenericFactoryPatternTest.Models;
using System;

namespace GenericFactoryPatternTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IActivity obj = null;

            obj = FactoryPattern<IActivity, ReportGenerator>.CreateInstance();

            var tst = obj.ReturnModel<ReportGeneratorModel>(1990, "maça e cebola");
            Console.WriteLine(tst);
        }

        
    }
}
