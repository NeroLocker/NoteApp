using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectTest
    {        
        [Test(Description = "Позитивный тест геттера NotesCollection")]
        public void TestNotesCollectionGet_CorrectValue()
        {
            var expected = new List<Note>();
            expected.Add(new Note("default name", "default content", NoteCategory.Other));

            var project = new Project();
            project.NotesCollection.Add(new Note("default name", "default content", NoteCategory.Other));
            var actual = project.NotesCollection;

            Assert.AreEqual(expected[0].Name, actual[0].Name);
            Assert.AreEqual(expected[0].Content, actual[0].Content);
            Assert.AreEqual(expected[0].Category, actual[0].Category);
            Assert.AreEqual(expected[0].DateOfCreation, actual[0].DateOfCreation);
            Assert.AreEqual(expected[0].DateOfLastEdit, actual[0].DateOfLastEdit);
        }
    }
}
