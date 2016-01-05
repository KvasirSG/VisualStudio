using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Programming_Case_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            //Name of the window
            Console.Title = "Select Language";

            //launching Language Select.
            Lang_Select();

            //Prevent program from Auto end.
            string select;
            select = Console.ReadLine();
            if (select == "Exit")
            {

            }
            else
            {
                Lang_Select();
            }
        }

        static void Lang_Select()
        {
            //Variables
            String Lang;

            //Code
            Console.Clear();
            //Name of the window
            Console.Title = "Select Language";
            Console.WriteLine("Select Language/Vælg Sprog:");
            Console.Write("1: For Dansk \n2: For English\n");
            Lang = Console.ReadLine();

            //Language selection
            switch (Lang)
            {
                case "":
                    Lang_Select();
                    break;
                case "1":
                    Menu("Dansk");
                    break;
                case "2":
                    Menu("English");
                    break;
            }

        }

        static void Menu(string Lang)
        {
            //Variables
            string Menu;

            //Code
            Console.Clear();
            switch (Lang)
            {
                case "Dansk":
                    //Name of the window
                    Console.Title = "DanskMenu";

                    //write/read
                    Console.Write("1: Kort \n2: Info\n3: Koncerter \n");
                    Menu = Console.ReadLine();
                    switch (Menu)
                    {
                        case "":
                            back("");//brings you back to Language selection.
                            break;
                        case "1":
                            Map("Dansk");
                            break;
                        case "2":
                            Info("Dansk");
                            break;
                        case "3":
                            Concerts("Dansk");
                            break;
                    }
                    break;
                case "English":
                    //Name of the window
                    Console.Title = "EnglishMenu";

                    //write/read
                    Console.WriteLine("1: Map \n2: Info\n3: Concerts");
                    Menu = Console.ReadLine();

                    //Selection of Object.
                    switch (Menu)
                    {
                        case "":
                            back("");//brings you back to Language selection.
                            break;
                        case "1":
                            Map("English");//Open Map. brings you back to the english menu.
                            break;
                        case "2":
                            Info("English");//Open English Info.
                            break;
                        case "3":
                            Concerts("English");//Open English Concerts
                            break;
                    }
                    break;
            }
        }
        //===========================MENU ITEMS====================================
        static void Map(String Lang)
        {
            Process.Start("..\\..\\map.jpg");//going 2 folders back from the .exe and opening the map.jpg
            switch (Lang)
            {
                case "English":
                    back("English");//go back to english Menu
                    break;
                case "Dansk":
                    back("Dansk");//go back to Danish Menu
                    break;
            }
        }
        static void Info(String Lang)
        {
            String Menu;
            Console.Clear();
            switch (Lang)
            {
                case "Dansk":
                    //Name of the window
                    Console.Title = "DanskMenu/Info";

                    //write/read
                    Console.Write("Information: \n\n1: FAQ \n");
                    Menu = Console.ReadLine();
                    switch (Menu)
                    {
                        case "":
                            back("Dansk");
                            break;
                        case "1":
                            FAQ("Dansk");
                            break;
                    }
                    break;
                case "English":
                    //Name of the window
                    Console.Title = "EnglishMenu/Info";

                    //write/read
                    Console.Write("Information: \n\n1: FAQ \n");
                    Menu = Console.ReadLine();
                    switch (Menu)
                    {
                        case "":
                            back("English");
                            break;
                        case "1":
                            FAQ("English");
                            break;
                    }
                    break;
            }
        }
        static void FAQ(String Lang)
        {
            Console.Clear();
            switch (Lang)
            {
                case "Dansk":
                    //Name of the window
                    Console.Title = "DanskMenu/Info/FAQ";

                    //write/read
                    Console.Write("Lavet af \n\nChristian \nMartin \nSensei Kenneth");
                    Console.ReadKey();
                    back("Dansk");
                    break;
                case "English":
                    //Name of the window
                    Console.Title = "EnglishMenu/Info/FAQ";

                    //write/read
                    Console.Write("Created by \n\nChristian \nMartin \nSensei Kenneth");
                    Console.ReadKey();
                    back("English");
                    break;
            }
        }
        static void Concerts(String Lang)
        {
            //Variables

            //Code
            Console.Clear();
            switch (Lang)
            {
                case "Dansk":
                    //Name of the window
                    Console.Title = "DanskMenu/Koncerter";

                    //write/read
                    Console.Write("Koncerter: \n\nLed Zeppelin \nVolbeat \nIron Maiden \nBlack Sabbath");
                    Console.ReadKey();
                    back("Dansk");
                    break;
                case "English":
                    //Name of the window
                    Console.Title = "EnglishMenu/Concerts";

                    //write/read
                    Console.WriteLine("Concerts: \n\nLed Zeppelin \nVolbeat \nIron Maiden \nBlack Sabbath");
                    Console.ReadKey();
                    back("English");
                    break;
            }
        }
        static void back(String Lang)
        {
            //Menu Selection
            switch (Lang)
            {
                case "":
                    Lang_Select();
                    break;
                case "Dansk":
                    Menu("Dansk");
                    break;
                case "English":
                    Menu("English");
                    break;
            }
        }
    }
}