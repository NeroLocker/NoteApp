using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс, реализующий методы сохранения и загрузки проекта
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Хранит путь до файла сохранения
        /// </summary>
        private static readonly string _pathToFile = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes";

        /// <summary>
        /// Сохраняет объект проекта в файл
        /// </summary>
        /// <param name="data"></param>
        public static void SaveToFile(Project data)
        {
            using (StreamWriter file = File.CreateText(_pathToFile))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }

        /// <summary>
        /// Загружает объект проекта из файла
        /// </summary>
        /// <returns></returns>
        public static Project LoadFromFile()
        {
            try
            {
                using (StreamReader file = File.OpenText(_pathToFile))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (Project) serializer.Deserialize(file, typeof(Project));
                }
            }
            catch (FileNotFoundException)
            {
                Project project = new Project();
                ProjectManager.SaveToFile(project);

                using (StreamReader file = File.OpenText(_pathToFile))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (Project) serializer.Deserialize(file, typeof(Project));
                }
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp");

                Project project = new Project();
                ProjectManager.SaveToFile(project);

                using (StreamReader file = File.OpenText(_pathToFile))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (Project)serializer.Deserialize(file, typeof(Project));
                }
            }          
        }
    }
}
