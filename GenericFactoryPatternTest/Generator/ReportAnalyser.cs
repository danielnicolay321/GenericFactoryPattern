using GenericFactoryPatternTest.Interfaces;
using GenericFactoryPatternTest.Models;
using System;

namespace GenericFactoryPatternTest.Generator
{
    public class ReportAnalyser
    {
        public T ReturnModel<T>()
        {
            return (T)Convert.ChangeType(CreateModel(), typeof(T));

        }
        private ReportGeneratorModel CreateModel()
        {
            return new ReportGeneratorModel
            {
                Id = 1,
                DocName = "Doc Name Test"
            };
        }
    }
}

