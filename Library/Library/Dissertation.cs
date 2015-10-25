using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model

{
    
    public class Dissertation : IReferences
    {
        /// <summary>
        /// Автор.
        /// </summary>
        public string Author { set; get; }
        
        /// <summary>
        /// Название диссертации.
        /// </summary>
        public string ThesisTitle { set; get; }
        
        /// <summary>
        /// Учёная степень автора.
        /// </summary>
        public string ScientificDegrees { set; get; }
        
        /// <summary>
        /// Место публикации.
        /// </summary>
        public string PlaceOfPublication { set; get; }
        
        /// <summary>
        /// Издательство.
        /// </summary>
        public string Publisher { set; get; }
        
        /// <summary>
        /// Год написания.
        /// </summary>
        public int ImprintYear;
        /// <summary>
        /// Количество страниц.
        /// </summary>
        public int NumberOfpages;
       
        /// <summary>
        /// Проверка года на отрицательность.
        /// </summary>
        public int Year
        {

            get { return ImprintYear; }
            set
            {
                if (value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Дата издания не должна превышать текущую");
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
        /// Вывод информации о диссертации на экран.
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return Author + ThesisTitle + " [Текст] : дис. … " + ScientificDegrees + "—" + PlaceOfPublication + ".," + ImprintYear + "—" + NumberOfpages + "с. —" + Publisher;
        }




    }
}
