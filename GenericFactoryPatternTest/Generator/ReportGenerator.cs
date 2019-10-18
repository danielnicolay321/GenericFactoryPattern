using GenericFactoryPatternTest.Interfaces;
using GenericFactoryPatternTest.Models;
using System;

namespace GenericFactoryPatternTest.Generator
{
    public class ReportGenerator : IActivity
    {
        public T CreateModel<T>()
        {
            return (T)Convert.ChangeType(CreateEmptyModel(), typeof(T));
        }

        private ReportGeneratorModel CreateEmptyModel()
        {
            return new ReportGeneratorModel();
        }


    }
}
