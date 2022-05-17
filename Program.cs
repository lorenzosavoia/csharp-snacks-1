// See https://aka.ms/new-console-template for more information
using System.Text;
//costruire una stringa lunga 1000 caratteri
string milleA = new string('a', 1000);

//quando dovete concatenare moltre stringhe, allora utilizzare StringBuilder é molto piú veloce

string lungA = new string('a', 1000);
string lungB = new string('b', 1000);

// concateno le stringhe
string lungAB = lungA + lungB;

// richiamo lo string builder (ricordarsi using system.text)
StringBuilder sb = new StringBuilder();

// stampa solo ul elemento per tipo 1 sola a 1 sola b (in questo caso solo caratteri)
foreach (char c in lungB.Distinct<char>())
{
    Console.WriteLine(c);
}

//Operatore modulo
//il software chiede all'utente di inserire un numero. se il numero inserito é pari, stampa
//il numero, se é dispari, stampa il numero successivo

int num = 20;
//restituisce il valore assoluto della variabile num
Console.WriteLine(Math.Abs(num));
//stampo il numero piú vicino possibile dopo il nuermo dichiarato (in questo caso 12)
Console.WriteLine(Math.BitIncrement(12)); // 12,0000000000002
//stampo il numero piú vicino possibile prima del numero nuermo dichiarato (in questo caso 12)
Console.WriteLine(Math.BitDecrement(12));

//nei numeri reali la distanzsa tra la prima e l'ultima cifra significa non poú superare le 16 posizioni decimali 

//Operatore modulo: il resto della divisione intera
Console.WriteLine(20 % 6);

//array csharp
//Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione 

//array i caratteri
char[] vc;

//array di interi
int[] vi;

//array di bool
bool[] vb;

//array di stringhe
string[] vs;

//array di array
int[][] vii;

//struttura vanno messe fuori dal main
/*
struct Pippo
{
    int a;
    double b;
};

Pippo[] vpippo;
*/

//inizializzazione array di stringhe
string[] vs1 = new string[] { "uno", "due", "tre", "quattro" };

//!!! in tutti i linguaggi abbiamo due funzioni /metedi/operatori estremamanete importanti e utili
//questi sono: map e reduce

//map? applica una funzione a tutti gli elementi di una sequenza e ottiene uns sequenza simile di pari dimensione
//riempita con i risultati della funzione
//!!!! map puó essere eseguita in "PARALLELO" senza perdere di significativitá
// non consce l'ordine in cui la funzione viene applicata
// ai singoli elementi della sequenza
//NB: la funzione applicata si aspetta solo un parametro, l'elemento corrente


//Reduce!! applica 'iterativamente' una funzione a tutti gli elementi di una sequenza
//e torna il risultato finale della funzione
//la funzione applicata si aspetta DUE parametri: l'elemento corrente e il risultato dell'applicazione precedente

//fatto sulle liste ad esempio
/*
 * (1 2 3 4 5 6 7 8 9 10) e applica il + con la reduce =>
 * prima chiamata (+ 1 2) => 3
 * seconda chiamata (+ 3 3) => 6
 * terza chiamata (+ 4 6) => 10
 * quarta chiamata (+ 5 10) => 15
    ...
*/

//voglio contare quante stringhe ci sono nel vettore
Console.WriteLine(vs1.Aggregate(0, (old, current) => old + 1));

//voglio contare la lunghezza totale delle stringhe nel vettore
Console.WriteLine(vs1.Aggregate(0, (old, current) => old + current.Length));

/*
 * (old, current)               => old + current.length
 * PARAMETRI DI CHIAMATA       CORPO DELLA FUNZIONE, ULTIMA SITRUZIONE è IL RETURN (implicito)
 */

//voglio trovare la stringa + lunga
Console.WriteLine(vs1.Aggregate("", (old, current) => (old.Length >= current.Length) ? old : current)); //Usato il ternario
// se partendo da una stringa vuota "" andiamo avanti, ridammi la stringa old se questa è più lunga della current

//Lo utilizzo come se fosse una find
Console.WriteLine(vs1.Aggregate(false, (old, current) => old ? true : (("pippo".CompareTo(current) == 0) ? true : false)));


List<int> li = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine(li.Aggregate(0, (old, current) => old + current));

int[] vArray = new int[10];
Random rng = new Random();
for (int i = 0; i < vArray.Length; i++)
{
    int iToPush = rng.Next(1,100);
    vArray[i] = iToPush;
}
int iSomma = 0;
foreach (int i in vArray)
{
    Console.Write("{0}, ", i);
    iSomma += i;
    
}
Console.WriteLine();

Console.WriteLine("la media é {0}", (iSomma / 10));