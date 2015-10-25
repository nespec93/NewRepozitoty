using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Tests.Model
{
    [TestFixture]
    internal class NormDocumentTest
    {
        /// <summary>
        /// Тест на проверку корректного номера документа.
        /// </summary>
        /// <param name="number">Номер</param>
        [Test]
        [TestCase(1, TestName = "Тестирование при Number = 1.PositiveValue")]
        [TestCase(2, TestName = "Тестирование при Number = 2.PositiveValue")]
        [TestCase(9, TestName = "Тестирование при Number = 9.PositiveValue")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование при Number = -1.NegativeValue")]
        [TestCase(-2, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование при Number = -2.NegativeValue")]
        [TestCase(-6, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование при Number = -6.NegativeValue")]
        [TestCase(-7, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование при Number = -7.NegativeValue")]
        public void Number(int number)
        {
            var normDocument = new NormDocument();
            normDocument.pages = number;
        }





        /// <summary>
        /// Тест на отрицательное значение номера документа.
        /// </summary>
        /// <param name="number">Номер</param>
        [Test]
        [TestCase(1, TestName = "Тестирование при Number = 1.PositiveValue")]
        [TestCase(2, TestName = "Тестирование при Number = 2.PositiveValue")]
        [TestCase(9, TestName = "Тестирование при Number = 9.PositiveValue")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование при Number = -1.NegativeValue")]
        [TestCase(-2, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование при Number = -2.NegativeValue")]
        [TestCase(-6, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование при Number = -6.NegativeValue")]
        [TestCase(-7, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование при Number = -7.NegativeValue")]
        public void IssueNumberTest(int number)
        {
            var normDocument = new NormDocument();
            normDocument.Number = number;
        }

        /// <summary>
        /// Год издания документа.
        /// </summary>
        /// <param name="year">Год издания нормативного документа </param>
        [Test]
        [TestCase(2015, TestName = "Тестирование при Year = 2015.PositiveValue")]
        [TestCase(2003, TestName = "Тестирование при Year = 2003.PositiveValue")]
        [TestCase(2020, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование при Year = 2020.NegativeValue")]
        [TestCase(2030, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование при Year = 2030.NegativeValue")]
        [TestCase(4000, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование при Year = 4000.NegativeValue")]
        public void YearOfManufacture(int year)
        {
            var normDocument = new NormDocument();
            normDocument.Year = year;
        }

        /// <summary>
        /// Тест метода GetDescription() для нормативоного документа.
        /// </summary>
        [Test]
        public void GetDescriptionTest()
        {
            var expected =
                "Тарасова, Н.Г.Смена парадигм в развитии теории и практики градостроительства/Н.Г. Тарасова//Архитектура и строительство России.- 2007.- 4.- 2 - 4";
            var normDocument = new NormDocument()
            {
                NameOfDoc = "Собрание законодательства. ",
                TitleOfDoc = "О военном положении",
                InfoForDoc = "Федеральный конституционный закон от 30 янв. 2002 г. № 1-ФКЗ",
                ImprintYear = 2002,
                NumberOfpages = 375,
                YearAndMonth = "4 февр.",
                Number = 5
            };

            var actual = normDocument.GetDescription();
            Assert.AreEqual(expected, actual);
        }
    }
}
