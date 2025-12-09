/*
    Na podstawie tablicy procentów za egzamin zawierające kolejno procenty: 
    [78, 90, 57, 82, 14, 60, 13, 30, 50, 100, 72, 95]
    Stwórz kod, który posortuje kolejno tą tablicę, a następnie przy wybranym
    algorytmie wyszukiwania macie wyszukać na którym indeksie leży 82% w tablicy

    Oceny za wykorzystanie: 
    Sortowanie bąbelkowe + Wyszukiwanie liniowe - 3
    Sortowanie przez wstawianie/przez selekcje + Wyszukiwanie liniowe - 4
    Sortowanie przez wstawianie/przez selekcje + Wyszukiwanie binarne - 5;
*/

// ======== Sortowanie przez wstawianie / przez selekcję + Wyszukiwanie binarne ========

using System; 

namespace Algorytmy 
{
    public class Zadanie 
    {
        public static void InsertSort(int[] t)
        {
            for (int i = 1; i < t.Length; i++)
            {
                int klucz = t[i];
                int j = i - 1;

                while (j >= 0 && klucz < t[j]) 
                {
                    Console.WriteLine($"Przeniesiono {t[j + 1]} na miejsce liczby {t[j]}");
                    t[j + 1] = t[j];
                    j--;
                }

                t[j + 1] = klucz;
                
                Console.WriteLine(string.Join(" ", t));
                Console.WriteLine();
            }
        }

        public static int BinarySearch(int[] t, int szukana) {
            int lewy = 0;
            int prawy = t.Length - 1;

            while(lewy <= prawy) 
            {
                int srodek = (lewy + prawy) / 2;

                if (t[srodek] == szukana) 
                    return srodek;

                if (t[srodek] < szukana)
                    lewy = srodek + 1;
                else 
                    prawy = srodek - 1;
            }

            return -1;
        }
    }
}

