using System.Diagnostics;
using LibreriaPDF;

namespace EscritorioDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // Llama al método de la clase PdfGenerator
                string result = PdfGenerator.GeneratePdf("https://www.google.cl/", "mipdf_v3.pdf");
                MessageBox.Show(result, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //***********************************************************************************************
            //string path = AppDomain.CurrentDomain.BaseDirectory + "wkhtmltopdf.exe";

            //// Obtiene la ruta de la carpeta Descargas
            //string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

            //// Nombre del archivo PDF
            //string pdfFileName = Path.Combine(downloadsFolder, "mipdf.pdf");

            //string HTMl = "miHtml.html";

            //// Configuración del proceso
            //ProcessStartInfo processInfo = new ProcessStartInfo
            //{
            //    UseShellExecute = false,
            //    FileName = path,
            //    Arguments = $"{HTMl}  \"{pdfFileName}\"",
            //    RedirectStandardOutput = true,
            //    RedirectStandardError = true,
            //    CreateNoWindow = true
            //};

            //try
            //{
            //    using (Process process = Process.Start(processInfo))
            //    {
            //        process.WaitForExit();

            //        if (process.ExitCode == 0)
            //        {
            //            MessageBox.Show($"PDF guardado en: {pdfFileName}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            string error = process.StandardError.ReadToEnd();
            //            MessageBox.Show($"Error al generar el PDF:\n{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //***********************************************************************************************

            //ProcessStartInfo oProcessStarInfo = new ProcessStartInfo();
            //oProcessStarInfo.UseShellExecute = false;
            //oProcessStarInfo.FileName = path;
            //oProcessStarInfo.Arguments = "https://www.google.cl/ mipdf.pdf";

            //using (Process oProcess = Process.Start(oProcessStarInfo))
            //{
            //    oProcess.WaitForExit();
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                // Llama al método de la clase PdfGenerator desde la biblioteca
                string result = PdfGeneratorLibrary.GeneratePdf("https://www.google.cl/", "mipdf_v4.pdf");
                MessageBox.Show(result, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
