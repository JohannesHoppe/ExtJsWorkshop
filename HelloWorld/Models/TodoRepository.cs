using System;
using System.Collections.Generic;

namespace HelloWorld.Models
{
    public static class TodoRepository
    {
        public static List<Todo> cache;

        static TodoRepository()
        {
            cache = new List<Todo>
                   {
                       new Todo
                       {
                           Id = 1,
                           Title = "ToDo #1",
                           Description = "Descr",
                           Done = true,
                           DueDate = new DateTime(2014, 7, 17)
                       },
                       new Todo
                       {
                           Id = 2,
                           Title = "ToDo #2",
                           Description = "Descr 2",
                           Done = true,
                           DueDate = new DateTime(2014, 7, 17)
                       },
                       new Todo
                       {
                           Id = 3,
                           Title = "ToDo #3",
                           Description = "Descr",
                           Done = true,
                           DueDate = new DateTime(2014, 7, 17)
                       },
                       new Todo
                       {
                           Id = 4,
                           Title = "ToDo #4",
                           Description = "Descr",
                           Done = false,
                           DueDate = new DateTime(2014, 7, 17)
                       },
                   };
        }

        public static IEnumerable<Todo> GetAllToDos()
        {
            return cache;
        }
    }
}