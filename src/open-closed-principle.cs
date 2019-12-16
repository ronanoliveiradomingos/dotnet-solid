namespace Solid
{
    public class ReportGeneration
    {
        public string ReportType { get; set; }
        public void GenerateReport(Employee emp)
        {

            if (ReportType == "CRS")
            {
                // Report generation with employee data in Crystal Rport
            }
            if (ReportType == "PDF")
            {
                // Report generation with employee data in PDF.
            }
        }
    }

    // Brilhante!! Sim, você está certo, existem muitas cláusulas "If" e se queremos introduzir 
    // outro novo tipo de relatório como "Excel", é necessário escrever outro "If". 
    // Essa classe deve estar aberta para extensão, mas fechada para modificação. Mas como fazer isso!!
    // Portanto, se você deseja introduzir um novo tipo de relatório, basta herdar o IReportGeneration. 
    // Portanto, o IReportGeneration está aberto para extensão, mas fechado para modificação.

    public class IReportGeneration
    {
        public virtual void GenerateReport(Employee emp)
        {
            // From base
        }
    }

    public class PdfReportGeneration : IReportGeneration
    {
        public override void GenerateReport(Employee emp) {
            // Generate PDF report
        }
}
}