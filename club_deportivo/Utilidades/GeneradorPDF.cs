using PdfSharp.Drawing; // from PDFsharp library
using PdfSharp.Pdf;     // from PDFsharp library
using System;
using System.Drawing;
using System.IO;
using System.Xml.Linq;

namespace club_deportivo.Utilidades
{
    public static class GeneradorPDF
    {
        // Usamos la biblioteca PDFsharp (ejemplo) para generar el PDF
        public static void GenerarCarnetPDF(string rutaArchivo, string nombre, string apellido, string nroCarnet)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Carnet de Socio";

            // Crear una página (por ejemplo, tamaño estándar de carnet)
            // Un carnet típico es aproximadamente 85.6mm x 53.98mm (CR-80), 
            // que es alrededor de 242x153 puntos (a 72dpi).
            PdfPage page = document.AddPage();
            page.Width = XUnit.FromMillimeter(85.6);
            page.Height = XUnit.FromMillimeter(54);

            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Definir estilos de fuente
            XFont fontTitulo = new XFont("Arial", 14, XFontStyleEx.Regular);
            XFont fontTexto = new XFont("Arial", 10, XFontStyleEx.Regular);
            XFont fontNumCarnet = new XFont("Arial", 12, XFontStyleEx.Bold);

            // Dibujar el fondo del carnet (simple rectángulo)
            gfx.DrawRectangle(XPens.DarkBlue, XBrushes.LightBlue, 0, 0, page.Width, page.Height);
            gfx.DrawString("CLUB DEPORTIVO", fontTitulo, XBrushes.DarkBlue,
                new XRect(0, 5, page.Width, 20), XStringFormats.TopCenter);

            // Dibujar los datos del Socio
            gfx.DrawString("SOCIO ACTIVO", fontTexto, XBrushes.DarkBlue,
                new XRect(5, 20, page.Width - 10, 10), XStringFormats.TopLeft);

            gfx.DrawString("Nombre:", fontTexto, XBrushes.Black, 5, 30);
            gfx.DrawString($"{nombre} {apellido}", fontNumCarnet, XBrushes.Black, 50, 30);

            gfx.DrawString("N° Socio:", fontTexto, XBrushes.Black, 5, 45);
            gfx.DrawString(nroCarnet, fontNumCarnet, XBrushes.Red, 55, 45); // Destacar el número de carnet

            // Guardar el documento
            document.Save(rutaArchivo);
        }
    }
}