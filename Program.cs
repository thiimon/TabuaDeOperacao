int numero, hor, ver, res;
string operacao;

Console.Write("Digite o número do conjunto de classe de restos para gerar a tábua: ");
numero = Convert.ToInt32(Console.ReadLine());
int[,] matriz = new int[numero, numero];

do {
    Console.Write("Adição ou multiplicação? (A/M): ");
    operacao = Console.ReadLine().ToUpper();
} while(operacao != "A" && operacao != "M");


// preenchendo a tábua
for (int x = 0; x < numero; x++) {
    matriz[0, x] = x;
}

for (int y = 0; y < numero; y++) {
    matriz[y, 0] = y;
}


// cálculo do espaçamento para alinhar os números
int largura = (numero - 1).ToString().Length;


// distribuição dos números na tábua
Console.Write("+  ");
for (hor = 0; hor < numero; hor++) {
    Console.Write(matriz[0, hor].ToString("D" + largura) + " ");
}
Console.WriteLine();

for (ver = 0; ver < numero; ver++) {
    Console.Write(matriz[ver, 0].ToString("D" + largura) + " | ");
    for (hor = 0; hor < numero; hor++) {
        if (operacao == "A") {
            res = matriz[ver, 0] + matriz[0, hor];
            if (res >= numero){
            	matriz[ver, hor] = res % numero;
        	} else {
            	matriz[ver, hor] = res;
        	}
        } else {
            res = (ver * hor) % numero;
            matriz[ver, hor] = res;
        }
        
        Console.Write(matriz[ver, hor].ToString("D" + largura) + " ");
    }
    Console.WriteLine();
}
