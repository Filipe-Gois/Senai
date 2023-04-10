int contador;

char sexo;
char opiniao;

int totalsim = 0;
int totalnao = 0;

int mulherestotal = 0;
int mulherestotalsim = 0;

int homenstotal = 0;
int homensnao = 0;

double porcentagemhomem = 0;

for (contador = 1; contador <= 3; contador++)
{
    Console.WriteLine(@$"
    Olá, informe o sexo do funcionário: 
    (m) - masculino
    (f) - feminino");

    sexo = char.Parse(Console.ReadLine()!.ToLower());

    if (sexo == 'f')
    {
        mulherestotal++;
    }

    else
    {
        homenstotal++;
    }

    Console.WriteLine(@$"
    Você gostou do produto ?
    (s) - sim
    (n) - não");

    opiniao = char.Parse(Console.ReadLine()!.ToLower());

    if (opiniao == 's')
    {
        totalsim++;
        
        if (sexo == 'f')
        {
            mulherestotalsim++;
        }

    }
    else
    {
        totalnao++;

        if (sexo == 'm')
        {
            homensnao++;
        }
    }

}

porcentagemhomem = Math.Round(((double)homensnao /(double)homenstotal)*100, 2);

Console.WriteLine($"O total de pessoas que responderam sim foi de: {totalsim}");
Console.WriteLine($"O total de pessoas que responderam não foi de: {totalnao}");

Console.WriteLine($"[O total de mulheres que responderam sim foi de: {mulherestotalsim}]");

Console.WriteLine($"A porcentagem de homens que não gostaram do produto foi de {porcentagemhomem} %");



