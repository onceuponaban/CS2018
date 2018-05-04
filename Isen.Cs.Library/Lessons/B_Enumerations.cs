using System;

namespace Isen.Cs.Library.Lessons
{
    public class B_Enumerations
    {
        public void RunEnumerations()
        {
            // Affichage du label
            Console.WriteLine($"JoursSemaine.Lundi = {JourSemaine.Lundi}");
            // Afficher l'entier sous-jacent
            Console.WriteLine($"JoursSemaine.Lundi = {(int)JourSemaine.Lundi}");
            // int > vers valeur d'enum
            int day4 = 4;
            JourSemaine whoIsday4 = (JourSemaine) day4;
            Console.WriteLine($"day4 = {whoIsday4}");
            // String > valeur d'enum
            string mardi = "Mardi";
            // .Net / C# <= 4
            JourSemaine parsed = (JourSemaine)Enum.Parse(
                typeof(JourSemaine),
                mardi);
            Console.WriteLine($"parsed = {parsed}");
            // .Net Core / .Net > 4
            //JourSemaine parsed2;
            //bool didItWork = Enum.TryParse(mardi, out parsed2);
            //C# 7
            bool didItWork = Enum.TryParse(mardi, out JourSemaine parsed2);
            Console.WriteLine($"parsed2 = {parsed2} / worked ? {didItWork}");
            // Énumérer les labels
            var enumNames = Enum.GetNames(typeof(JourSemaine)); // string []
            var enumValues = Enum.GetValues(typeof(JourSemaine)); // JourSemaine [] sous typé
            foreach (var enumName in enumNames) Console.WriteLine(enumName);
            foreach (JourSemaine enumValue in enumValues) Console.WriteLine((int)enumValue);

            var jour = (JourSemaine)(new Random().Next(0,7));
            DayOfWeek foundDayofWeek;
            switch (jour)
            {
                case JourSemaine.Lundi:
                    foundDayofWeek = DayOfWeek.Monday;
                    break;
                case JourSemaine.Mardi:
                    foundDayofWeek = DayOfWeek.Tuesday;
                    break;
                case JourSemaine.Mercredi:
                    foundDayofWeek = DayOfWeek.Wednesday;
                    break;
                case JourSemaine.Jeudi:
                    foundDayofWeek = DayOfWeek.Thursday;
                    break;
                case JourSemaine.Vendredi:
                    foundDayofWeek = DayOfWeek.Friday;
                    break;
                case JourSemaine.Samedi:
                    foundDayofWeek = DayOfWeek.Saturday;
                    break;
                case JourSemaine.Dimanche:
                default:
                    foundDayofWeek = DayOfWeek.Sunday;
                    break;
            }
            // C# 7 : nameof()
            Console.WriteLine($"{nameof(foundDayofWeek)} =  {foundDayofWeek}");
        }
    }

    public enum JourSemaine
    {
        Lundi = 1,
        Mardi = 2,
        Mercredi = 3,
        Jeudi = 4,
        Vendredi = 5,
        Samedi = 6,
        Dimanche = 7,
    }
}