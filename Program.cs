using System;

namespace Algorytmy 
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Sortowanie przez wstawianie
            int[] tablica = {78, 90, 57, 82, 14, 60, 13, 30, 50, 100, 72, 95};

            Console.WriteLine($"Nieposortowana tablica: {String.Join(" ", tablica)}");

            var zadanie = new Zadanie();

            Zadanie.InsertSort(tablica); 

            Console.WriteLine($"Posortowana tablica: {String.Join(" ", tablica)}");

            // Wyszukiwanie binarne
            int szukana = 90;
            int indeks = Zadanie.BinarySearch(tablica, szukana);

            if (indeks != -1)
                Console.WriteLine($"Element {szukana} znajduje się na indeksie: {indeks}");
            else 
                Console.WriteLine($"Elementu {szukana} nie znaleziono.");
        }
    }
}