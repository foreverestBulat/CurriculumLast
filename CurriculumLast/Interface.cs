using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumLast
{
    public interface IStudent
    {
        public int ApplicationNumber { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public interface IDegree
    {
        public int CreditsRequired { get; set; }
        public int SpecialCoursesRequired { get; set; }
        public string OtherCondition { get; set; }
    }

    public interface ICourse
    {
        public bool IsSpecial { get; set; }
        public int LectureHours { get; set; }
        public int PractiseHours { get; set; }
        public bool HasExam { get; set; }
        public bool HasCoursePaper { get; set; }
        public List<int> Prerequisities { get; set; }
    }

    public interface ICode
    {
        public int Code { get; set; }
    }

    public interface ITitle
    {
        public string Title { get; set; }
    }

    public interface IFields : ICode, ITitle { }

    public class CodeClass : ICode
    {
        public int Code { get; set; }
    }

    public class Fields : CodeClass, ITitle
    {
        public string Title { get; set; }
    }

    public class ForCourseAndDegree : Fields
    {
        public virtual void Change(int change) { }
    }



    //public class Methods
    //{
    //    public virtual void Prints(List<Course> courses) { }
    //    public virtual void Prints(List<Degree> degrees) { }
    //    public virtual void Exchange() { }
    //}
}
