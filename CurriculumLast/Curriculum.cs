using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CurriculumLast
{
    internal class Curriculum 
    {
        public int Code { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ConfirmationDate { get; set; }
        public Student Student { get; set; }
        public int DegreeCode { get; set; }

        public Curriculum(Student student = null, int degreeCode = 0, int code = 0, DateTime creationDate = new DateTime())
        {
            Student = student;
            DegreeCode = degreeCode;
            Code = code;
            CreationDate = creationDate;
        }

        public void AddNewCourse(int code, string title, bool isSpecial, int lectureHours,
            int practiseHours, bool hasExam, bool hasCoursePaper, List<int> prerequisities)
        {
            Course course = new Course(code, title, isSpecial, lectureHours,
                practiseHours, hasExam, hasCoursePaper, prerequisities);
            StaticBase.ListCourses.Add(course);
        }

        public void DeleteCourse(int code)
        {
            for (int i = 0; i < StaticBase.ListCourses.Count; i++)
                if (StaticBase.ListCourses[i].Code == code)
                    StaticBase.ListCourses.RemoveAt(i);
        }

        public void CheckSelectedCourses(List<int> selectedCourses, int i = 0)
        {
            // Поскольку некоторые курсы содержат дополнительные курсы,
            // то этот метод проверяет есть номера этих доп курсов в выбранных.
            // Если нету, то его добавляет
            // я сделал рекурсию, потому что если сделать циклом, то выйдет ошибка связанная с тем,
            // что список выбранных курсов изменяется, что нельзя делать во время цикла

            if (i >= selectedCourses.Count) return;

            var code = selectedCourses[i];

            if (Course.GetCourse(code).Prerequisities == null)
            {
                CheckSelectedCourses(selectedCourses, ++i);
                return;
            }

            foreach (int numAdditionalCourse in Course.GetCourse(code).Prerequisities)
            {
                if (!selectedCourses.Contains(numAdditionalCourse))
                {
                    Console.WriteLine("--");
                    selectedCourses.Add(numAdditionalCourse);
                }
            }

            CheckSelectedCourses(selectedCourses, ++i);
        }

        public bool LaborIntensityOfCourse(List<int> numbers, int countCredit, int needingCountSpecialCourse)
        {
            int c = 0;
            int lecH = 0;
            int pracH = 0;

            int countSpecialCourse = 0;

            for (int i = 0; i < StaticBase.ListCourses.Count; i++)
            {
                if (numbers.Contains(StaticBase.ListCourses[i].Code))
                {
                    lecH += StaticBase.ListCourses[i].LectureHours;
                    pracH += StaticBase.ListCourses[i].PractiseHours;

                    if (StaticBase.ListCourses[i].HasExam) c++;
                    if (StaticBase.ListCourses[i].HasCoursePaper) c += 2;
                    if (StaticBase.ListCourses[i].IsSpecial) countSpecialCourse++;
                }
            }

            c += (int)(lecH + pracH * 1.25) / 18;

            if (countSpecialCourse >= needingCountSpecialCourse)
            {
                return c >= countCredit;
            }

            Console.WriteLine("Не хватает кол-ва спецкурсов");
            return false;
        }

        public void PrintCourses() => Course.PrintAll();
        public void PrintDegrees() => Degree.PrintAll();

        public void ChangeCourse(int code, int change)
        {
            Course course = Course.GetCourse(code);
            course.Change(change);
        }

        public void ChangeDegree(int code, int change)
        {
            Degree degree = Degree.GetDegree(code);
            degree.Change(change);
        }
    }
}
