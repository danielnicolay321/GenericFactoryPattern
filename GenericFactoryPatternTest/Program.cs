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
            IActivity objReport = null;
            IActivity objAnalyser = null;

            objReport = FactoryPattern<IActivity, ReportGenerator>.CreateInstance();
            objAnalyser = FactoryPattern<IActivity, ReportAnalyser>.CreateInstance();

            var report = objReport.CreateModel<ReportGeneratorModel>();
            var analyser = objAnalyser.CreateModel<ReportAnalyserModel>();

            Console.WriteLine(report);
            Console.WriteLine(analyser);
        }

        
    }
}
