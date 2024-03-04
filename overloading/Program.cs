using overloading;

Magazyn m = new("magazyn");
m.stan.Add(new Produkt(5, "1", 1));
m.stan.Add(new Produkt(15, "2", 2));
m.stan.Add(new Produkt(10, "3", 3));

m.Produkty();
m.Sort();
m.Produkty();


List<List<int>> l1 = new(); 
for(int i = 0; i < 3; i++)
{
    l1.Add(new());
    for(int j = 0; j < 3; j++)
    {
        l1[i].Add(i+j);
    }
}

Macierz matrix = new(l1);

for (int i = 0; i < l1.Count; i++)
{
    for (int j = 0; j < l1[i].Count; j++)
    {
        Console.Write(l1[i][j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

matrix.Show();

matrix.matrix = matrix + matrix;

matrix.Show();

matrix++;

matrix.Show();

matrix--;

matrix.Show();

matrix.matrix = matrix * matrix;

matrix.Show();

matrix.matrix = matrix - matrix;

matrix.Show();