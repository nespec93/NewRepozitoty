
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace lib
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int _choose = 1;
            int n;
            bool _true;
            do
            {
                Console.WriteLine("Тип издания:");
                Console.WriteLine("1 Диссертация");
                Console.WriteLine("2 Многотомное издание");
                Console.WriteLine("3 Нормативный документ");

                do
                {
                    _true = false;                   

                    n = Convert.ToInt32(Console.ReadLine());
                    if (n > 0)
                    {
                        _true = true;
                    }

                } while (_true == false);
                try
                {
                    IReferences source;
                    switch (n)
                    {
                        case 1:
                            {
                                var dissertation = new Dissertation()
                                {    
                                    Author = "Белозеров, И. В.",
                                    ThesisTitle = "Религиозная политика Золотой Орды на Руси в XIII—XIV вв.",
                                    PlaceOfPublication = "М",
                                    Publisher = " Библиогр.",
                                    ScientificDegrees = "канд. ист. наук",
                                    ImprintYear = 2002,
                                    NumberOfpages = 215
                                };
                                source = dissertation;
                                Console.WriteLine("Aвтор: " + dissertation.Author);
                                Console.WriteLine("Место защиты: " + dissertation.PlaceOfPublication);
                                Console.WriteLine("Название: " + dissertation.ThesisTitle);
                                Console.WriteLine("Год издания:" + dissertation.ImprintYear);
                                Console.WriteLine("Количество страниц: " + dissertation.NumberOfpages);
                                Console.WriteLine("Учёная степень: " + dissertation.ScientificDegrees);
                                Console.WriteLine("Издательство:" + dissertation.Publisher);
                                Console.WriteLine("Информация о диссертации");
                                Console.WriteLine(source.GetDescription());
                                break;
                            }
                        case 2:
                            {
                               
                                var multiEdition = new MultiEdition()
                                {
                                    
                                    Author = "Гиппиус, З. Н.",
                                    Editor = "Т. Г. Юрченко",
                                    Name = "Золотая проза серебряного века",
                                    ImprintYear = 2001,
                                   
                                    

                                    PlaceOfPublication = "М.",
                                    TypeOfPublication = "Сочинения",
                                    PublishingHouse = "Лаком-книга : Габестро",
                                    CountOfVolume = 2,
                                };

                                multiEdition.TomPagesCount.Add(310);
                                multiEdition.TomPagesCount.Add(155);

                                                                
                                source = multiEdition;
                                Console.WriteLine("Автор: " + multiEdition.Author);
                                Console.WriteLine("Редактор: " + multiEdition.Editor);
                                Console.WriteLine("Название: " + multiEdition.Name);
                                Console.WriteLine("Год издания: " + multiEdition.ImprintYear);
                                Console.WriteLine("Количество томов: " + multiEdition.CountOfVolume);
                                Console.WriteLine("Место издания: " + multiEdition.PlaceOfPublication);
                                Console.WriteLine("Тип издания:" + multiEdition.TypeOfPublication);
                                Console.WriteLine("Количество страниц Т1:" + multiEdition.TomPagesCount[0]);
                                Console.WriteLine("Количество страниц Т2:" + multiEdition.TomPagesCount[1]);
                                                    
                                Console.WriteLine("Информация о многотомном издании: ");
                                Console.WriteLine(source.GetDescription());
                                break;
                            }
                    
                          case 3:
                                       
                           
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


                              source = normDocument;                           
                              Console.WriteLine("Заглавие: " + normDocument.TitleOfDoc);
                              Console.WriteLine("Название документа: " + normDocument.NameOfDoc);
                              Console.WriteLine("Сведения о документе: " + normDocument.InfoForDoc);
                              Console.WriteLine("Обозначение вида ресурса: " + normDocument.ImprintYear);
                              Console.WriteLine("Год издания: " + normDocument.NumberOfpages);
                              Console.WriteLine("Место издания:" + normDocument.YearAndMonth);                            
                              Console.WriteLine(source.GetDescription());
                              break;
                          }
                   
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Введен неправильный аргумент! ", e);
                }
          

            } while (_choose != 0);
        }
    }
}

