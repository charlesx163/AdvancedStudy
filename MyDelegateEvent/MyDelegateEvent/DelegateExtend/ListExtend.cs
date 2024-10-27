using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MyDelegateEvent.DelegateExtend
{
   
    public class ListExtend
    {
        private List<Student> GetStudentList()
        {
            return new List<Student>
            {
                new Student
                {
                    Age = 12,
                    ClassId = 1,
                    Id = 1,
                    Name = "xu"
                },
                new Student
                {
                    Age = 22,
                    ClassId = 2,
                    Id = 2,
                    Name = "xu2"
                },
                new Student
                {
                    Age = 32,
                    ClassId = 3,
                    Id = 3,
                    Name = "xu33"
                }
            };
        }

        public delegate bool ThenDelegate(Student student);

        #region 会写很多种逻辑
        public bool AgeThen(Student student)
        {
            return student.Age > 25;
        }
        public bool LengthThen(Student student)
        {
            return student.Name.Length > 2;
        }
        #endregion
        public void Show()
        {
            List<Student> students = this.GetStudentList();

            #region 无delegate
            //找出年龄大于25的
            //{
            //    List<Student> studentList = new List<Student>();

            //    foreach (var student in students)
            //    {
            //        if (student.Age > 25)
            //        {
            //            studentList.Add(student);
            //        }
            //    }
            //}
            //找出名字长度于2的
            //{
            //    List<Student> studentList = new List<Student>();

            //    foreach (var student in students)
            //    {
            //        if (student.Name.Length > 2)
            //        {
            //            studentList.Add(student);
            //        }
            //    }
            //}
            //找出名字长度于2的，年龄大于25的
            //{
            //    List<Student> studentList = new List<Student>();

            //    foreach (var student in students)
            //    {
            //        if (student.Name.Length > 2 && student.Age>25)
            //        {
            //            studentList.Add(student);
            //        }
            //    }
            //}
            #endregion

            #region delegate

            {
                ThenDelegate method = new ThenDelegate(AgeThen);
                var list = this.GetList(students, method);

                ThenDelegate lengthMethod = new ThenDelegate(LengthThen);
                var listLength = this.GetList(students, lengthMethod);

            }
            #endregion

            #region 匿名delegate

            var listFunc = GetListFunc(students, (student => student.Age > 25));

            #endregion

        }

        /// <summary>
        /// delegate
        /// </summary>
        /// <param name="source"></param>
        /// <param name="thenDelegate"></param>
        /// <returns></returns>
        private List<Student> GetList(List<Student> source, ThenDelegate thenDelegate)
        {
            List<Student> studentList = new List<Student>();

            foreach (var student in source)
            {
                if (thenDelegate(student))
                {
                    studentList.Add(student);
                }
            }
            return studentList;
        }

        /// <summary>
        /// 匿名委托
        /// </summary>
        /// <param name="source"></param>
        /// <param name="thenDelegate"></param>
        /// <returns></returns>
        private List<Student> GetListFunc(List<Student> source, Func<Student,bool> func)
        {
            List<Student> studentList = new List<Student>();

            foreach (var student in source)
            {
                if (func(student))
                {
                    studentList.Add(student);
                }
            }
            return studentList;
        }
    }
}
