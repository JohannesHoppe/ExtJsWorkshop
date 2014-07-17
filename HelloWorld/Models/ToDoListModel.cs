using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class ToDoListModel
    {
        public static IEnumerable GetAllToDos()
        {
            return new object[]
                {
                    new object[] { 1, "ToDo #1", "Descr", true, new DateTime(2014, 7, 17) },
                    new object[] { 2, "ToDo #2", "Descr", false, new DateTime(2014, 7, 18) },
                    new object[] { 3, "ToDo #3", "Descr", false, new DateTime(2014, 7, 19) },
                    new object[] { 4, "ToDo #4", "Descr", false, new DateTime(2014, 7, 20) },
                    new object[] { 5, "ToDo #5", "Descr", false, new DateTime(2014, 7, 21) },
                };
        }
    }
}