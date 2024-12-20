using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioDF
{
    public class PdfGenerator
    {
        /// <summary>
        /// Genera un archivo PDF usando wkhtmltopdf.exe
        /// </summary>
        /// <param name="url">URL o contenido HTML a convertir</param>
        /// <param name="fileName">Nombre del archivo PDF de salida</param>
        /// <returns>Mensaje de éxito o error</returns>
        public static string GeneratePdf(string url, string fileName)
        {
            try
            {
                // Obtiene la carpeta Descargas
                string downloadsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

                // Ruta del ejecutable wkhtmltopdf
                string wkhtmltopdfPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wkhtmltopdf.exe");

                // Archivo de salida
                string pdfFilePath = Path.Combine(downloadsFolder, fileName);

                // Configuración del proceso
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    UseShellExecute = false,
                    FileName = wkhtmltopdfPath,
                    Arguments = $"{url} \"{pdfFilePath}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(processInfo))
                {
                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        return $"PDF guardado en: {pdfFilePath}";
                    }
                    else
                    {
                        string errorMsg = process.StandardError.ReadToEnd();
                        throw new Exception($"Error al generar el PDF: {errorMsg}");
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Ocurrió un error: {ex.Message}";
            }
        }
    }
}
