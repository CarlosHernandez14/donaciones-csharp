using DonacionesCreadores.clases;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ClosedXML.Excel;

namespace DonacionesCreadores.dao
{
    public class DataExport
    {

        // Método para generar el reporte PDF
        public static void GenerarReportePDF(List<CreadorContenido> creadores)
        {
            // Crear un FolderBrowserDialog para que el usuario seleccione el directorio
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecciona el directorio donde quieres guardar el reporte";
                folderDialog.ShowNewFolderButton = true;

                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    string folderPath = folderDialog.SelectedPath;
                    string filePath = Path.Combine(folderPath, "ReporteCreadoresContenido.pdf");

                    try
                    {
                        // Crear el documento PDF
                        Document pdfDoc = new Document(PageSize.A4);
                        PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));

                        pdfDoc.Open();
                        // Agregar un título al documento
                        pdfDoc.Add(new Paragraph("Reporte de Creadores de Contenido"));
                        pdfDoc.Add(new Paragraph("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy")));
                        pdfDoc.Add(new Paragraph("\n\n"));

                        // Recorrer la lista de creadores de contenido y agregar la información
                        foreach (CreadorContenido creador in creadores)
                        {
                            pdfDoc.Add(new Paragraph("Nombre: " + creador.Nombre));
                            pdfDoc.Add(new Paragraph("Email: " + creador.Correo));
                            pdfDoc.Add(new Paragraph("Cuenta Bloqueada: " + (creador.CuentaBloqueada ? "Sí" : "No")));
                            pdfDoc.Add(new Paragraph("Partner: " + (creador.Partner ? "Sí" : "No")));
                            pdfDoc.Add(new Paragraph("Número de Suscriptores: " + creador.Suscriptores.Count));
                            pdfDoc.Add(new Paragraph("Número de Contenidos: " + creador.Contenidos.Count));

                            // Detalles de los contenidos
                            if (creador.Contenidos.Count > 0)
                            {
                                pdfDoc.Add(new Paragraph("Contenidos:"));
                                foreach (var contenido in creador.Contenidos)
                                {
                                    pdfDoc.Add(new Paragraph("  - Título: " + contenido.Titulo));
                                    pdfDoc.Add(new Paragraph("    Descripción: " + contenido.Descripcion));
                                }
                            }
                            pdfDoc.Add(new Paragraph("\n"));
                        }

                        pdfDoc.Close();
                        MessageBox.Show("El reporte ha sido generado correctamente en: " + filePath);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error al generar el reporte PDF: " + ex.Message);
                        // Propagamos la excepción
                        throw new Exception("Error al generar el reporte PDF: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó un directorio válido.");
                }
            }
        }

        // Método para generar el reporte en Excel de los creadores con más donaciones
        public static void GenerarReporteExcelTopDonaciones(List<CreadorContenido> creadores)
        {
            // Crear un FolderBrowserDialog para que el usuario seleccione el directorio
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecciona el directorio donde quieres guardar el reporte Excel";
                folderDialog.ShowNewFolderButton = true;

                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    string folderPath = folderDialog.SelectedPath;
                    string filePath = Path.Combine(folderPath, "TopCreadoresDonaciones.xlsx");

                    try
                    {
                        // Calcular las donaciones totales por cada creador
                        var donacionesCreador = creadores
                            .Select(creador => new
                            {
                                Creador = creador,
                                TotalDonaciones = creador.Contenidos.Sum(contenido => contenido.Donaciones)
                            })
                            .OrderByDescending(c => c.TotalDonaciones) // Ordenar por donaciones de mayor a menor
                            .Take(10) // Tomar el top 10
                            .ToList();
                        
                        //Debug.WriteLine("Donaciones por creador:");
                        //foreach (var item in donacionesCreador)
                        //{
                        //    Debug.WriteLine(item.Creador.Nombre + ": " + item.TotalDonaciones);
                        //}

                        // Crear un nuevo workbook para Excel
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Top Creadores Donaciones");

                            // Encabezados de las columnas
                            worksheet.Cell(1, 1).Value = "Posición";
                            worksheet.Cell(1, 2).Value = "Nombre del Creador";
                            worksheet.Cell(1, 3).Value = "Email";
                            worksheet.Cell(1, 4).Value = "Total de Donaciones";

                            // Agregar los datos de los creadores
                            int fila = 2;
                            int posicion = 1;
                            foreach (var item in donacionesCreador)
                            {
                                worksheet.Cell(fila, 1).Value = posicion;
                                worksheet.Cell(fila, 2).Value = item.Creador.Nombre;
                                worksheet.Cell(fila, 3).Value = item.Creador.Correo;
                                worksheet.Cell(fila, 4).Value = item.TotalDonaciones;

                                fila++;
                                posicion++;
                            }

                            // Guardar el archivo Excel en el path seleccionado
                            workbook.SaveAs(filePath);
                        }

                        MessageBox.Show("El reporte Excel ha sido generado correctamente en: " + filePath);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error al generar el reporte Excel: " + ex.Message);
                        // propaga la excepción
                        throw new Exception("Error al generar el reporte Excel: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó un directorio válido.");
                }
            }
        }
    }
}
