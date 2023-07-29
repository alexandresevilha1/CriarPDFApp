using System;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CriarPDFApp.Entities
{
    class Usuario
    {
        public string Nome { get; private set; }
        public string Caminho { get; private set; }

        public Usuario(string nome, string caminho) 
        {
            Nome = nome;
            Caminho = caminho;
        }
        
        public void CriarPDF(string nome, string caminho)
        {
            string nomeArquivo = caminho + "\\" + nome + ".PDF"; //Stack para armazenar o endereço para criar o arquivo
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create); //Instancia para criar documentos
            Document doc = new Document(PageSize.A4); // Instancia para criação do arquivo
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF); //Criação do arquivo

            string dados = "";

            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14)); //Instancia para criação do texto
            paragrafo.Add("Parabens " + nome + ", você criou um arquivo PDF"); //Criação do texto

            doc.Open();
            doc.Add(paragrafo);
            doc.Close();
        }
    }
}
