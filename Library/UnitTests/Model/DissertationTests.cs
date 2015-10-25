using System;
using Model;
using NUnit.Framework;

namespace UnitTests.Model
{

    public class DissertationTest
    {
        /// <summary>
        /// Тест на проверку на отрицательное значение страниц.
        /// </summary>
        /// <param name="count">Количество страниц в Диссертации</param>
        [Test]
        [TestCase(1, TestName = "Тестирование при Count = 1.PositiveValue")]
        [TestCase(2, TestName = "Тестирование при Count = 2.PositiveValue")]
        [TestCase(5, TestName = "Тестирование при Count = 5.PositiveValue")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при Count = -1.NegativeValue")]
        [TestCase(-22, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при Count = -22.NegativeValue")]
        [TestCase(-55, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при Count = -55.NegativeValue")]

        public void NumberOfPages(int count)
        {
            var dissertation = new Dissertation();
            dissertation.pages = count;
        }

        /// <summary>
        /// Тест на проверку превышение текущей даты.
        /// </summary>
        /// <param name="year">Год издания диссертации</param>
        [Test]
        [TestCase(2015, TestName = "Тестирование при Year =  2015.PositiveValue")]
        [TestCase(2003, TestName = "Тестирование при Year =  2003.PositiveValue")]
        [TestCase(2020, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при Year = 2020.NegativeValue")]
        [TestCase(2030, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при Year = 2030.NegativeValue")]
        [TestCase(4000, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при Year = 4000.NegativeValue")]
        public void YearOfManufacture(int year)
        {
            var dissertation = new Dissertation();
            dissertation.Year = year;
        }

        /// <summary>
        /// Тест метода GetDescription() для статьи диссертации.
        /// </summary>
        [Test]
        public void GetDescriptionTest()
        {
            var expected = "Белозеров, И. В.Религиозная политика Золотой Орды на Руси в XIII—XIV вв. канд. ист. наук М  Диссертация.2002 215";
            var dissertation = new Dissertation()
            {
                Author = "Белозеров, И. В.",
                ThesisTitle = "Религиозная политика Золотой Орды на Руси в XIII—XIV вв.",
                PlaceOfPublication = "М",
                Publisher = "Диссертация.",
                ScientificDegrees = "канд. ист. наук",
                ImprintYear = 2002,
                NumberOfpages = 215
            };
            var actual = dissertation.GetDescription();
             Assert.AreEqual(expected, actual);
        }
    }
}

