using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text;

namespace Converte_PDF_Texto
{
    public class ConvertePDF
    {
        public string ExtrairTexto_PDF(string caminho)
        {
            using (PdfReader leitor = new PdfReader(caminho))
            {
                StringBuilder texto = new StringBuilder();

                for (int i = 1; i <= leitor.NumberOfPages; i++)
                {
                    texto.Append(PdfTextExtractor.GetTextFromPage(leitor, i));
                }
                return texto.ToString();
            }
        }
    }
}
