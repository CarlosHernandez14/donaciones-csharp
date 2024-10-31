using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Diagnostics;

namespace DonacionesCreadores.dao
{
    public class GenericDao<T>
    {
        private readonly string filePath;
        private readonly JsonSerializerOptions options;

        public GenericDao(string filePath)
        {
            this.filePath = filePath;
            this.options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };
        }

        // Método para cargar los datos de un archivo .json
        public List<T> Cargar()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonData = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<List<T>>(jsonData, options);
                }
                return new List<T>();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error al obtener los archivos de la base de datos" + e.Message);
                return new List<T>();
            }
        }

        // Método para guardar la lista en un archivo .json
        public void Guardar(List<T> lista)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(lista, options);
                File.WriteAllText(filePath, jsonData);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error al guardar los archivos en la base de datos");
                throw new IOException(e.Message);
            }
        }
    }
}
