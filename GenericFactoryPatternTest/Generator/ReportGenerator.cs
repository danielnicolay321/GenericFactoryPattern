using GenericFactoryPatternTest.Interfaces;
using GenericFactoryPatternTest.Models;
using System;

namespace GenericFactoryPatternTest.Generator
{
    public class ReportGenerator : IActivity
    {
        public T ReturnModel<T>(int id, string docname)
        {
            return (T)Convert.ChangeType(CreateModel(id, docname), typeof(T));

        }


        private ReportGeneratorModel CreateModel(int id, string docname)
        {
            return new ReportGeneratorModel
            {
                Id = id,
                DocName = docname
            };
        }
    }
}
