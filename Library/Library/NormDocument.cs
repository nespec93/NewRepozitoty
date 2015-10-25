using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class NormDocument : IReferences
    {
         /// <summary>
         /// Название документа.
         /// </summary>
         public string NameOfDoc { set; get; } 
         /// <summary>
         /// Заглавие документа.
         /// </summary>
         public string TitleOfDoc { set; get; }
         /// <summary>
         /// Информация о докумете.
         /// </summary>
         public string InfoForDoc { set; get; }
         /// <summary>
         /// Год издания.
         /// </summary>
         public int ImprintYear;
         /// <summary>
         /// Год и месяц публикации для газеты.
         /// </summary>
         public string  YearAndMonth;
         /// <summary>
         /// Количество страниц.
         /// </summary>
         public int NumberOfpages;
         /// <summary>
         /// Номер докумета.
         /// </summary>
         public int Number;
        

        /// <summary>
        /// Проверка года издания на отрицательность.
        /// </summary>
        public int Year
        {

            get { return ImprintYear; }
            set
            {
                if (value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Год издание не должен превышать текущий год");
                }
                ImprintYear = value;
            }
        }

         /// <summary>
         /// Проверка количества страниц на отрицательность.
         /// </summary>
         public int pages
        {
            get { return NumberOfpages; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Количество страниц не может быть меньше нуля");
                }
                NumberOfpages = value;
            }
        }

        /// <summary>
        /// Вывод информации о документе на экран.
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {

            return TitleOfDoc + ":" + "от" + InfoForDoc + "//" + NameOfDoc + "–" + ImprintYear + "№" + Number + "(" + YearAndMonth + ")" + NumberOfpages;

           
        }
    }
}

