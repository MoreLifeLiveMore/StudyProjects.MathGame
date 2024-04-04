using static System.Formats.Asn1.AsnWriter;
using System;
using MathGame;

Menu menu = new Menu();

var date = DateTime.UtcNow.DayOfWeek;

string name = Helpers.GetName();

menu.ShowMenu(name,date);
