string parola, parolaUpper = "";
Console.WriteLine("Inserire la parola con caratteri minuscoli da trasformare in maiuscolo");
parola = Console.ReadLine();
for(int i = 0; i < parola.Length; i++)
{
    int ascii = (int)parola[i];
    if (ascii >= 97 && ascii <= 122)
    {
        ascii = ascii - 32;
    }
    parolaUpper = parolaUpper + (char)ascii;
}
Console.WriteLine(parolaUpper);
