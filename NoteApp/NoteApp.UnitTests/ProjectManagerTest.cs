using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private readonly string _pathToFile = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes";
        private readonly string _pathToDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp";
        private Project _project;

        [SetUp]
        public void InitProject()
        {
            _project = new Project();
            _project.NotesCollection.Add(new Note("default name", "default content", NoteCategory.Other));
        }

        [TearDown]
        public void DeleteFile()
        {
            if (File.Exists(_pathToFile))
            {
                File.Delete(_pathToFile);
            }
        }

        [Test(Description = "Тест сериализации проекта в файл")]
        public void TestProjectManagerSaveToFile()
        {
            ProjectManager.SaveToFile(_project);
            Assert.True(File.Exists(_pathToFile));
        }

        [Test(Description = "Тест десериализации проекта из файла")]
        public void TestProjectManagerLoadFromFile_CorrectLoad()
        {
            var expectedNoteName = "default name";
            var expectedNoteContent = "default content";
            NoteCategory expectedNoteCategory = NoteCategory.Other;
            var expectedNoteDateOfCreation = DateTime.Now;
            var expectedNoteDateOfLastEdit = DateTime.Now;

            Project project = new Project();
            project.NotesCollection.Add(new Note("default name", "default content", NoteCategory.Other));
            ProjectManager.SaveToFile(project);

            var actual = ProjectManager.LoadFromFile();
            Assert.AreEqual(expectedNoteName, actual.NotesCollection[0].Name);
            Assert.AreEqual(expectedNoteContent, actual.NotesCollection[0].Content);
            Assert.AreEqual(expectedNoteCategory, actual.NotesCollection[0].Category);
            Assert.AreEqual(expectedNoteDateOfCreation, actual.NotesCollection[0].DateOfCreation);
            Assert.AreEqual(expectedNoteDateOfLastEdit, actual.NotesCollection[0].DateOfLastEdit);
        }

        [Test(Description = "Тест десериализации проекта без файла сохранения ")]
        public void TestProjectManagerLoadFromFile_WithoutFile()
        {
            if (File.Exists(_pathToFile))
            {
                File.Delete(_pathToFile);
            }

            var expected = 0;

            var project = ProjectManager.LoadFromFile();
            var actual = project.NotesCollection.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Тест десериализации проекта без директории для файла сохранения")]
        public void TestProjectManagerLoadFromFile_WithoutDirectory()
        {
            if (File.Exists(_pathToDirectory))
            {
                File.Delete(_pathToDirectory);
            }

            var expected = 0;

            var project = ProjectManager.LoadFromFile();
            var actual = project.NotesCollection.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
