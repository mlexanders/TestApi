using System;
using System.Collections.Generic;


namespace TestApi.Models
{
    public class User
    {
        public User()
        {
            Id = 900;
            Name = "Djohny";
            Login = "looop";
            Password = new Password();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public Password Password { get; set; } 
        public string Token { get; set; }
        public string? Role { get; set; } = "user";
        public List<Note>? Notes { get; set; } // тут коллекция записок или просто поле для записки???
    }

    public class Password
    {
        public Password()
        {
            Id = 12;
            Value = "seef322";
        }


        public int Id { get; set; }
        public string Value { get; set; }
    }

    public class Note
    {
        public string Discription { get; set; }
        public DateTime  Day { get; set; }
        public User User { get; set; }

    }

    public class Day
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public LessonsAndTimes[] LessonsAndTimes { get; set; }
        public string Information { get; set; }
        public Note CurrentUserNote { get; set; }

    }

    public class LessonsAndTimes
    {
        public int Id { get; set; }
        public Lesson Lesson{ get; set; }
        public DateTime Time { get; set; } //
    }

    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }
        public string Information { get; set; }
    }
}
