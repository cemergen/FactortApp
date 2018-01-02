using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            IReport graphical = p.ReportFactory(ReportType.Graphical);
            IReport table = p.ReportFactory(ReportType.Talbe);
        }


        public enum ReportType
        {
            Talbe,Graphical
        }
        public class GraphicalReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Graphical Report Called");
            }
        }

        public class TableReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Table Report Called");
            }
        }

        public IReport ReportFactory(ReportType type)
        {
            switch (type)
            {
                case ReportType.Talbe: return new TableReport();
                case ReportType.Graphical: return new GraphicalReport();
                default: return null;
            }
        }

        public interface IReport
        {
            void GenerateReport();
        }
    }
}
