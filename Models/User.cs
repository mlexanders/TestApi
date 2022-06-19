﻿using System;
using System.Collections.Generic;


namespace TestApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public Password Password { get; set; } 
        public string Token { get; set; }
        public Role Role { get; set; }
        public List<Note> Notes { get; set; } // тут коллекция записок или просто поле для записки???

        public User()
        {
            Name = "Djohny";
            Login = "looop";
            Password = new Password();
        }
    }

    public enum Role
    {
        USER,
        ADMIN
    }

    public class Password
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public Password()
        {
            Id = 12;
            Value = "seef322QWERTY";
        }
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
