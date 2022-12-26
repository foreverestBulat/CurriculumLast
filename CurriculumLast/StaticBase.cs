using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumLast
{
    public static class StaticBase
    {
        public static List<Course> ListCourses = new List<Course> {
        new Course(
                    1,
                    "Объектно-ориентированное програмирование",
                    true,
                    150,
                    200,
                    true,
                    true,
                    new List<int>() { 2, 3 }),

                new Course(
                    2,
                    "Дискретная математика",
                    true,
                    40,
                    20,
                    true,
                    false,
                    null),

                new Course(
                    3,
                    "Математический анализ",
                    true,
                    40,
                    20,
                    true,
                    false,
                    null),

                new Course(
                    4,
                    "Русский язык",
                    false,
                    10,
                    30,
                    true,
                    false,
                    null),

                new Course(
                    5,
                    "Английский язык",
                    false,
                    10,
                    70,
                    true,
                    false,
                    null),

                new Course(
                    6,
                    "Алгебра и геометрия",
                    false,
                    150,
                    200,
                    true,
                    false,
                    null),

                new Course(
                    7,
                    "Физкультура",
                    false,
                    150,
                    200,
                    true,
                    false,
                    null),

                new Course(
                    8,
                    "Веб-разработка",
                    false,
                    5,
                    40,
                    true,
                    false,
                    null),

                new Course(
                    9,
                    "Язык программирования C++",
                    true,
                    30,
                    150,
                    true,
                    true,
                    new List<int>() { 2, 3, 6 }),

                new Course(
                    10,
                    "Язык программирования C#",
                    true,
                    30,
                    150,
                    true,
                    true,
                    new List<int>() { 2, 3, 6 }),

                new Course(
                    11,
                    "Язык программирования Java",
                    true,
                    30,
                    150,
                    true,
                    true,
                    new List<int>() { 2, 3, 6 }),

                new Course(
                    12,
                    "Черчение",
                    false,
                    10,
                    50,
                    true,
                    false,
                    new List<int> { 6 }),

                new Course(
                    13,
                    "История Руси",
                    false,
                    50,
                    10,
                    true,
                    false,
                    null),

                new Course(
                    14,
                    "История до нашей эры",
                    false,
                    50,
                    10,
                    true,
                    false,
                    null),

                new Course(
                    15,
                    "Язык программирования Python",
                    true,
                    20,
                    120,
                    true,
                    true,
                    new List<int>() { 2, 3 })};

        public static List<Degree> ListDegrees = new List<Degree> {
            new Degree(
                1,
                "Интеллектуальные системы",
                70,
                2),
            new Degree(
                2,
                "Прикладная математика",
                60,
                1),
            new Degree(
                3,
                "Психология личной эффективности",
                30,
                0)};
    }
}
