// See https://aka.ms/new-console-template for more information

int var1 = 1;
int var2 = 2;

string str1 = "hola ";
string str2 = "si";


Console.WriteLine(calculo(var1,var2));

Console.WriteLine(calculo(str1, str2));


dynamic calculo(dynamic d1, dynamic d2) {
    return d1+d2;
}

