using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MultiEdition : IReferences

    {
        /// <summary>
        /// Список для количества страниц.
        /// </summary>
        private readonly List<int> _tomPagesCount = new List<int>();
        /// <summary>
        /// Автор.
        /// </summary>
        public string Author { set; get; }
       /// <summary>
       /// Редактор.
       /// </summary>
        public string Editor { set; get; }
        /// <summary>
        /// Название.
        /// </summary> 
        public string Name { set; get; }
        /// <summary>
        /// Тип публикации.
        /// </summary>
        public string TypeOfPublication { set; get; }
        /// <summary>
        /// Издательство.
        /// </summary>
        public string PublishingHouse { set; get; }
        /// <summary>
        /// Место публикации.
        /// </summary>
        public string PlaceOfPublication { set; get; }
        /// <summary>
        /// Год публикации.
        /// </summary>
        public int ImprintYear;
        /// <summary>
        /// Количество страниц в томе.
        /// </summary>
        public List<int> TomPagesCount { get { return _tomPagesCount; } } 
        /// <summary>
        /// Количество томов.
        /// </summary>
        public int CountOfVolume { get; set; }
     
       /// <summary>
       /// Проверка на отрицательность года издания.
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
        /// Информация о томе на экран.
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return TypeOfPublication + "[Текст] : в" + CountOfVolume + "т. / " + Author + "; [вступ. ст., подгот. текста и коммент." + Editor + ";  —" + PublishingHouse + ". (" + Name + ")."; //+ "T1 : " + TomPagesCount[0] + " стр" + " T2 : "+ TomPagesCount[1] + " стр" ;
        }
    }
}

