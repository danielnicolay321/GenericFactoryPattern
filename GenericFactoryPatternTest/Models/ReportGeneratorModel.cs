namespace GenericFactoryPatternTest.Models
{
    public class ReportGeneratorModel
    {
        //constructor
        public ReportGeneratorModel()
        { }

        public ReportGeneratorModel(int id, string docName)
        {
            this.Id = id;
            this.DocName = docName;
        }

        public int Id { get; set; }
        public string DocName { get; set; }
    }
}
