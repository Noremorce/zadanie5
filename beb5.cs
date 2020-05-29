using System;
using System.Collections;
using System.Collections.Generic;

namespace zadanie5
{
    class Program
    {
        public class Student
        {
            public string id;
            public string fio;
            public string group;
            public string birthDate;
        }

        static List<Student> studentList = new List<Student>();

        static void AddStudent(string id, string fio, string group, string birthDate)
        {
            studentList.Add(new Student() { id = id, fio = fio, birthDate = birthDate, group = group });
        }


        static void DelStudent(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id) studentList.RemoveAt(i);
            }
        }

        static void ChangeStudent(string id, string fio, string birthDate, string group)
        {

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                {
                    studentList[i].fio = fio;
                    studentList[i].birthDate = birthDate;
                    studentList[i].group = group;
                }
            }

        }

        static void ShowStudent()
        {

            foreach (var d in studentList)
            {
                Console.WriteLine(d.id + " - " + d.fio + " - " + d.birthDate + " - " + d.group);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Student first = new Student();

            AddStudent("1666", "Пушкина Елизавета Петровна", "01.02.2001", "ASAP");
            AddStudent("1667", "Толстой Дмитрий Анатольевич", "22.10.1991", "ISIP");
            AddStudent("1668", "Момоносов Владимир Владимирович", "10.11.1945", "ACAB");
            ShowStudent();
            ChangeStudent("1667", "Барто Агния Сергеевна", "22.10.1991", "ISIP");
            ShowStudent();
            DelStudent("1666");
            ShowStudent();
        }
    }
}