// See https://aka.ms/new-console-template for more information
Console.WriteLine("2025105756 - José Antonio Guides Mequelin");
Console.WriteLine("2025106239 - Thais Carvalheiro\n");
Console.WriteLine("2025105388 - Bianca Michoski Cabral");
Console.WriteLine("2025106086 - Gabriel Marczal dos Santos");

void SorteiaPalavra()
{
    String[] palavras = { "casa", "carro", "avião", "navio", "bicicleta", "moto", "ônibus", "trem", "metrô", "barco" };

    Random random = new Random();

    int indiceDoArray = random.Next(palavras.Length);

    String palavraEscolhida = palavras[indiceDoArray];

    ComecarJogo(palavraEscolhida);
}

SorteiaPalavra();

void ComecarJogo(String palavraEscolhida)
    {
    int tentativas = 0;
    int numeroCaracteres = palavraEscolhida.Length;


    for (int i = 0; i < palavraEscolhida.Length; i++)
    {
          tentativas++;
    }
    tentativas *= 2;

    Console.WriteLine("\n\nBem vindo ao jogo da forca!");
    Console.WriteLine("Tente advinhar a palavra sorteada letra por letra.");
    Console.WriteLine($"voce tem {tentativas} tentativas");
    Console.WriteLine("Boa sorte!\n");

    foreach (char letra in palavraEscolhida)
    {
        Console.WriteLine("_ ");
        

    }
    String[] palavraSecreta = new string[numeroCaracteres];


    VerificaLetra(palavraEscolhida, tentativas, palavraSecreta);
}

void VerificaLetra(String palavraEscolhida,int  tentativas, String []palavraSecreta)
{
    while(tentativas > 0)
    {
        Console.WriteLine($"\n\nVoce tem {tentativas} tentativas");
        Console.Write("Digite uma letra: ");
        char letraDigitada = Console.ReadLine()[0];


        for (int i = 0; i < palavraEscolhida.Length; i++)
        {
            if (letraDigitada == palavraEscolhida[i])
            {
                //Console.Write(letraDigitada + " ");
                palavraSecreta[i] = letraDigitada.ToString();

                foreach (string letra in palavraSecreta)
                {
                    if (letra != null)
                    {
                        Console.Write(letra + " ");
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }

            }
            else
            {
               // Console.Write("_ ");
            }

        }
        tentativas--;



    }

}