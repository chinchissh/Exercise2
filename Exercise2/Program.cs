﻿using System;

namespace Exercise2//Лабораторная работа по Мищенко №5(задание2)
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Check();
        }
        public class Book
        {
            public string Title { get; set; }
        }
        public static void Check()
        {
            var book = new Book();
            book.Title = "Structure and interpretation of computer programs";
            Console.WriteLine(book.Title);
        }
    }
}
