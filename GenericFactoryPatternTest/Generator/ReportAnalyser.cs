using GenericFactoryPatternTest.Interfaces;
using GenericFactoryPatternTest.Models;
using System;

namespace GenericFactoryPatternTest.Generator
{
    public class ReportAnalyser : IActivity
    {
        public T CreateModel<T>()
        {
            return (T)Convert.ChangeType(CreateEmptyModel(), typeof(T));

        }

        private ReportAnalyserModel CreateEmptyModel()
        {
            return new ReportAnalyserModel();
        }
    }
}

