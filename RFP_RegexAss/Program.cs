﻿// See https://aka.ms/new-console-template for more information
using RFP_RegexAss;

Console.WriteLine("User Registration");
Console.WriteLine( );

Pattern patterns = new Pattern();
Console.WriteLine(patterns.validateFirstName("Komal"));
Console.WriteLine(patterns.validateLastName("Vairagade"));
Console.WriteLine(patterns.validateEmail("divyavairagade@gmail.com"));
Console.WriteLine(patterns.validatePhonNo("91 8788254798"));
Console.WriteLine(patterns.validatePassword("Bridge001labz@"));