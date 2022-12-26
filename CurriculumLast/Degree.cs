using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumLast
{
    public class Degree : ForCourseAndDegree, IDegree
    {
        //public int Code { get; set; }
        //public string Title { get; set; }
        public int CreditsRequired { get; set; }
        public int SpecialCoursesRequired { get; set; }
        public string OtherCondition { get; set; }

        public Degree(int code, string title, int creditsRequired, 
            int specialCoursesRequired, string otherCondition = null)
        {
            Code = code;
            Title = title;
            CreditsRequired = creditsRequired;
            SpecialCoursesRequired = specialCoursesRequired;

            OtherCondition = otherCondition;
        }

        public static Degree GetDegree(int code)
        {
            foreach (Degree degree in StaticBase.ListDegrees)
                if (degree.Code == code) return degree;
            return null;

        }

        public override void Change(int change)
        {
            //int change = int.Parse(Console.ReadLine());
            switch (change)
            {
                case 1:
                    this.SpecialCoursesRequired = int.Parse(Console.ReadLine());
                    break;

                case 2:
                    this.CreditsRequired = int.Parse(Console.ReadLine());
                    break;

                case 3:
                    this.OtherCondition = Console.ReadLine();
                    break;

                default:
                    break;
            }
        }
    

        public override string ToString()
        {
            return "[---------------\n" +
                $"\tКод: {Code}\n" +
                $"\tНазвагие {Title}\n" +
                $"\tНужное количество кредитов: {CreditsRequired}\n" +
                $"\tМнимальное кол-во спецкурсов {SpecialCoursesRequired}\n" +
                $"\tДополнительное условие: {OtherCondition}\n" +
                    "---------------]";
        }

        public static void PrintAll()
        {
            foreach (Degree degree in StaticBase.ListDegrees)
                Console.WriteLine(degree);
        }
    }
}
