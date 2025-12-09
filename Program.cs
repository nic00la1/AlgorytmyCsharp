// ======== Egzamin INF.04 ========
// Sortowaie bąbelkowe
// Sortowaie przez wstawianie
// Sortowaie przez wybieranie
// Wyszukiwanie binarne --> na 100% się pojawi (tablica musi być posortowana, w innym przypadku nie zadziała)


// ======== Matura z Informatyki ========
// Sortowanie szybkie --> na  (jeśli opisówka)

// ================ Sortowanie Bąbelkowe ===============

/*
int[] t = {3, 2 ,4 , 1, 5, 6};

void BubbleSort(int[] t) 
{
    for (int i = 0; i < t.Length - 1; i++) 
    {
        for (int j = 0; j < t.Length - 1 - i; j++)
         {
            if (t[j] > t[j + 1]) {
                Console.WriteLine($"Następuje zamiana miejscami liczb {t[j]} oraz {t[j + 1]} ");

                // Stara wersja
                int temp = t[j];
                t[j] = t[j + 1];
                t[j + 1] = temp;
                // (t[j], t[j + 1] = (t[j + 1], t[j])); // nowa możliwość (w pythonie też)
            }
         }

         Console.WriteLine($"Tablica po {i + 1} próbie");
         for (int j = 0; j < t.Length; j++)
         {
            Console.Write(t[j] + " ");
         }
         Console.Write('\n');
    }
}

BubbleSort(t);
*/

// ================ Sortowanie przez wstawianie ===============

void InsertSort(int[] t)
{
    for (int i = 1; i < t.Length; i++)
    {
        int klucz = t[i];
        int j = i - 1;

        while (j >= 0 && klucz < t[j]) 
        {
            
        }
    }
}
