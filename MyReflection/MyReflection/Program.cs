using MyReflection.Model;
using System;
using System.Diagnostics;

namespace MyReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People { Id = 1, Name = "Charles", Description = "Test" };
            #region
            //Type typePeople = typeof(People);
            //Type typePeopleDto = typeof(PeopleDto);
            //object peopleDto = Activator.CreateInstance(typePeopleDto);
            //foreach (var prop in typePeopleDto.GetProperties())
            //{
            //if (prop.Name.Equals("Id"))
            //{
            //    object value=typePeople.GetProperty(prop.Name).GetValue(people);
            //    prop.SetValue(typePeopleDto, value);
            //}
            //else if (prop.Name.Equals("Name"))
            //{
            //    object value = typePeople.GetProperty(prop.Name).GetValue(people);
            //    prop.SetValue(typePeopleDto, value);
            //}
            //else if(prop.Name.Equals("Description"))
            //{
            //    object value = typePeople.GetProperty(prop.Name).GetValue(people);
            //    prop.SetValue(typePeopleDto, value);
            //}
            //    object value = typePeople.GetProperty(prop.Name).GetValue(people);
            //    prop.SetValue(peopleDto, value);
            //}
            #endregion

            PeopleDto peopleDto = new PeopleDto();
            peopleDto = GenericMethod.Map<PeopleDto, People>(people, peopleDto);
            Console.WriteLine("Hello World!");
        }

    }
}
