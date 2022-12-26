using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumLast
{
    public class Course : ForCourseAndDegree, ICourse
    {
        //public int Code { get; set; }
        //public string Title { get; set; }
        public bool IsSpecial { get; set; }
        public int LectureHours { get; set; }
        public int PractiseHours { get; set; }
        public bool HasExam { get; set; }
        public bool HasCoursePaper { get; set; }
        public List<int> Prerequisities { get; set; }

        public Course(int code, string title, bool isSpecial, int lectureHours,
            int practiseHours, bool hasExam, bool hasCoursePaper, List<int> prerequisities)
        {
            Code = code;
            Title = title;
            IsSpecial = isSpecial;
            LectureHours = lectureHours;
            PractiseHours = practiseHours;
            HasExam = hasExam;
            HasCoursePaper = hasCoursePaper;
            Prerequisities = prerequisities;
        }

        public override string ToString()
        {
            return "[---------------------\n" +
                $"\tКод: {Code}\n" +
                $"\tНазвание: {Title}\n " +
                $"\tСпецкурс: {IsSpecial}\n " +
                $"\tКоличество часов лекций: {LectureHours}\n " +
                $"\tКоличество часов практик: {PractiseHours}\n " +
                $"\tЭкзамен: {HasExam}\n " +
                $"\tКурсовая работа: {HasCoursePaper}\n" + //Номера дополнительных курсов: {PrintPrerequisities()
                $"\tНомера дополнительных курсов: {PrintPrerequisities()}\n" +
                "---------------------]";
        }

        public static Course GetCourse(int code)
        {
            foreach (Course course in StaticBase.ListCourses)
                if (course.Code == code) return course;
            return null;
        }

        public string PrintPrerequisities()
        {
            if (Prerequisities != null)
            {
                string r = "";
                foreach (int numberCourse in Prerequisities)
                    r += $"{Convert.ToString(numberCourse)} ";

                return r;
            }
            return "[пусто]";
        }

        public static void PrintAll()
        {
            Console.WriteLine("Список курсов: ");
            foreach (Course course in StaticBase.ListCourses)
                Console.WriteLine(course);
        }

        public override void Change(int change)
        {
            switch (change)
            {
                case 1:
                    this.IsSpecial = !this.IsSpecial;
                    break;

                case 2:
                    this.LectureHours = int.Parse(Console.ReadLine());
                    break;

                case 3:
                    this.PractiseHours = int.Parse(Console.ReadLine());
                    break;

                case 4:
                    this.HasExam = !this.HasExam;
                    break;

                case 5:
                    this.HasCoursePaper = !this.HasCoursePaper;
                    break;

                case 6:
                    string str = Console.ReadLine();
                    if (str != "")
                        foreach (string i in str.Split(' '))
                        {
                            if (!this.Prerequisities.Contains(int.Parse(i)))
                                this.Prerequisities.Add(int.Parse(i));
                        }
                    break;

                default:
                    break;
            }
        }
    }
}
