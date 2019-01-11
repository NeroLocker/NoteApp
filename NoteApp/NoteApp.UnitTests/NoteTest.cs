using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;

        [SetUp]
        public void InitNote()
        {
            _note = new Note("default name", "default content", NoteCategory.Other);
        }


        [Test(Description = "Позитивный тест геттера Name")]
        public void TestNameGet_CorrectValue()
        {
            var expected = "Note";
            _note.Name = expected;
            var actual = _note.Name;

            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное имя");
        }

        //[Test(Description = "Присвоение неправильного Name больше 70 символов")]
        //public void TestNameSet_Longer70Symbols()
        //{
        //    var wrongName =
        //        "Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note";
        //    var note = new Note();

        //    Assert.Throws<ArgumentException>(
        //        () => { note.Name = wrongName; },
        //        "Должно возникать исключение, если Name больше 70 символов"
        //    );
        //}

        //[Test(Description = "Присвоение пустой строки в качестве Name")]
        //public void TestNameSet_EmptyString()
        //{
        //    var wrongName = string.Empty;          
        //    var note = new Note();

        //    Assert.Throws<ArgumentException>(
        //        () => { note.Name = wrongName; },
        //        "Должно возникать исключение, если Name - пустая строка"
        //    );
        //}


        [TestCase("", "Должно возникать исключение, если Name - пустая строка", TestName = "Присвоение пустой строки в качестве Name")]
        [TestCase("Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note-Note",
            "Должно возникать исключение, если Name больше 70 символов", TestName = "Присвоение неправильного Name больше 70 символов")]
        public void TestNameSet_ArgumentException(string wrongName, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _note.Name = wrongName; },
                message);
        }

        [TestCase("", "Должно возникать исключение, если Content - пустая строка", TestName = "Присвоение пустой строки в качестве Content")]
        public void TestContentSet_ArgumentException(string wrongContent, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _note.Content = wrongContent; },
                message);
        }

        [Test(Description = "Позитивный тест геттера Category")]
        public void TestCategoryGet_CorrectValue()
        {
            var expected = NoteCategory.Other;
            _note.Category = expected;

            var actual = _note.Category;

            Assert.AreEqual(expected, actual, "Геттер Category возвращает неправильную категорию");
        }

        [Test(Description = "Позитивный тест геттера DateOfCreation")]
        public void TestDateOfCreationGet_CorrectValue()
        {
            var expected = DateTime.Now;
            _note.DateOfCreation = expected;

            var actual = _note.DateOfCreation;

            Assert.AreEqual(expected, actual, "Геттер DateOfCreation возвращает неправильное время");
        }

        //[Test(Description = "Позитивный тест сеттера DateOfCreation")]
        //public void TestDateOfCreationSet_CorrectValue()
        //{
        //    Assert.DoesNotThrow(
        //        () => { _note.DateOfCreation = DateTime.Now; }
        //    );
        //}

        [Test(Description = "Позитивный тест геттера DateOfLastEdit")]
        public void TestDateOfLastEditGet_CorrectValue()
        {
            var expected = DateTime.Now;
            _note.DateOfCreation = expected;

            var actual = _note.DateOfCreation;

            Assert.AreEqual(expected, actual, "Геттер DateOfCreation возвращает неправильное время");
        }

        //[Test(Description = "Позитивный тест сеттера DateOfLastEdit")]
        //public void TestDateOfLastEditSet_CorrectValue()
        //{
        //    Assert.DoesNotThrow(
        //        () => { _note.DateOfLastEdit = DateTime.Now; }
        //        );
        //}


        [Test(Description = "Тест метода clone()")]
        public void TestNoteClone()
        {
            var expected = _note;
            var actual = (Note)_note.Clone();
            
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Content, actual.Content);
            Assert.AreEqual(expected.Category, actual.Category);
            Assert.AreEqual(expected.DateOfCreation, actual.DateOfCreation);
            Assert.AreEqual(expected.DateOfLastEdit, actual.DateOfLastEdit);
        }

        [TestCase("default name", "default content", NoteCategory.Other,
            TestName = "Тест конструктора")]
        public void TestNoteConstructor(string expectedName, string expectedContent,
            NoteCategory expectedCategory)
        {
            Assert.AreEqual(expectedName, _note.Name);
            Assert.AreEqual(expectedContent, _note.Content);
            Assert.AreEqual(expectedCategory, _note.Category);            
        }
    }
}
