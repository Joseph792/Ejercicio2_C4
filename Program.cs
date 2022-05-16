// See https://aka.ms/new-console-template for more information
int n, pot, acum = 1;


Console.WriteLine("Introdzca el Numero a elevar: ");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduzca la potencia: ");
pot = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<=pot; i++){
    acum = acum * n;
}

Console.WriteLine("El resultado es {0}: ", acum);

return acum;