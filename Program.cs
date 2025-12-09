// ======== Egzamin INF.04 ========
// Sortowaie bąbelkowe
// Sortowaie przez wstawianie
// Sortowaie przez wybieranie
// Wyszukiwanie binarne --> na 100% się pojawi (tablica musi być posortowana, w innym przypadku nie zadziała)


// ======== Matura z Informatyki ========
// Sortowanie szybkie --> na  (jeśli opisówka)

// ================ Sortowanie Bąbelkowe ===============


int[] t = {3, 2 ,4 , 1, 7, 6};


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

// BubbleSort(t);


// ================ Sortowanie przez wstawianie ===============

/*
void InsertSort(int[] t)
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

InsertSort(t);
*/

// Console.WriteLine("Tablica początkowa: ");
// Console.WriteLine(string.Join(" ", t));
// Console.WriteLine();

// SelectionSort(t);

void SelectionSort(int[] t)
{
    for (int i = 0; i < t.Length - 1; i++)
    {
        int minIndex = i;

        for (int j = i + 1; j < t.Length; j++) 
        {
            if(t[j] < t[minIndex]) 
            {
                minIndex = j;
            }
        }

        Console.WriteLine($"Zamieniamy miejscami {t[minIndex]} z {t[i]}");

        int temp = t[minIndex];
        t[minIndex] = t[i];
        t[i] = temp;

        // pokazanie całej tablicy w jednej linii
        Console.WriteLine(string.Join(" ", t));
    }
}

// ============= Wyszukiwanie liniowe - 1 pętla (1 warunek, 1 pętla) =============

/*
int LinearSearch(int[] t, int szukana) 
{
    for (int i = 0; i < t.Length; i++) 
    {
        if (t[i] == szukana) 
        {
            Console.WriteLine($"Znaleziono element w indeksie {i}");
            return i;
        }
    }

    return -1;
}

LinearSearch(t, 1);
*/
// ============= Wyszukiwanie binarne =============
// BubbleSort(t);

int BinarySearch(int[] t, int szukana) {
    int lewy = 0;
    int prawy = t.Length - 1;

    while(lewy <= prawy) {
        int srodek = (lewy + prawy) / 2;

        if(t[srodek] == szukana) 
        {
            Console.WriteLine($"Znaleziono naszą szukaną w indeksie {srodek}");
            return srodek;
        }

        if (t[srodek] < szukana) 
            lewy = srodek + 1;
        else 
            prawy = srodek - 1;
    }

    return -1;
}

// BubbleSort(t);
// BinarySearch(t, 7);

class Sprzedaz 
{
    private static int liczba = 0;
    public int Id {get; set;}
    public string Data {get; set;} = "";
    public string Produkt {get; set;} = "";
    public int Ilosc {get; set;}
    public double CenaJednostkowa {get;set;}

    public Sprzedaz() {
        Id = ++liczba;
    }

    public void ShowData() 
    {
        Console.WriteLine($"ID: {Id}, Produkt: {Produkt}, Data: {Data}, ");
    }
}

class Program 
{
    public static void Main(string[] args) 
    {
        List<Sprzedaz> sprzedaze = new List<Sprzedaz>();
        using(StreamReader stream = new StreamReader("sprzedaz_300.csv")) 
        {
            // Pominięcie jednej linijki (nazwa naszych kolumn)
            string line = stream.ReadLine();

            // Pętla, do momentu aż nie zwróci
            while((line = stream.ReadLine()) != null) 
            {
                // Dzielimy to na części
                string[] parts = line.Split(',');

                // Zamieniamy kropkę na przecinek, by działał nam Double
                parts[3] = parts[3].Replace('.', ',');

                // Dodajemy do tablicy sprzedaży
                sprzedaze.Add(new Sprzedaz 
                {
                    Data = parts[0],
                    Produkt = parts[1],
                    Ilosc = int.Parse(parts[2]),
                    CenaJednostkowa = double.Parse(parts[3])
                });
            }

            for (int i = 0; i < 5; i++) 
            {
                sprzedaze[i].ShowData();
            }
        }
    }
}


