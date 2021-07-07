﻿using System;

namespace If_Else_Yapısı_ve_Ternary_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time >=6 && time<=11)
                Console.WriteLine("Günaydın!");
            else if (time<=18)
                Console.WriteLine("İyi Günler!");
            else
                Console.WriteLine("İyi Geceler!");

            string sonuc = time>=6 && time<=11 ? "Günaydın" : time<=18 ? "İyi Günler" : "İyi Geceler";
            Console.WriteLine(sonuc);
        }
    }
}
