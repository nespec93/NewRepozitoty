using System;
using Model;
using NUnit.Framework;

namespace UnitTests.Model
{
    public class MultiEditionTest
    {
        /// <summary>
        /// Год издания.
        /// </summary>
        /// <param name="Year">Год издания многотомного издания</param>
        [Test]
        [TestCase(2015, TestName = "Тестирование при Year = 2015.PositiveValue")]
        [TestCase(2000, TestName = "Тестирование при Year = 2000.PositiveValue")]
        [TestCase(2020, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при Year = 2020.NegativeValue")]
        [TestCase(2034, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при Year = 2034.NegativeValue")]
        [TestCase(8000, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при Year = 8000.NegativeValue")]
        public void imprintYear(int year)
        {
            var multiEdition = new MultiEdition();
            multiEdition.Year = year;
        }

        /// <summary>
        /// Тест метода GetDescription() для многотомного издания.
        /// </summary>
        [Test]
        public void GetDescriptionTest()
        {
            var expected =
                "Гиппиус, З. Н. 2 Сочинения Золотая проза серебряного века Т. Г. Лаком-книга : Габестро Юрченко М.  2001 415 365 ";
            var multiEdition = new MultiEdition()
            {
                Author = "Гиппиус, З. Н.",
                Editor = "Т. Г. Юрченко",
                Name = "Золотая проза серебряного века",
                ImprintYear = 2001,
                PlaceOfPublication = "М.",
                TypeOfPublication = "Сочинения",
                PublishingHouse = "Лаком-книга : Габестро",
               
            };
           var actual = multiEdition.GetDescription();
           Assert.AreEqual(expected, actual);
        }
    }
}

