# Neogrid
 
DESAFIO TÉCNICO .NET – SISTEMAS INTERNOS
O desafio consiste em você criar duas APIs na linguagem .NET, uma com dois endpoints e outra
com um endpoint:

API 1
1) Retornar taxa de juros
Responde pelo path relativo "/taxaJuros"
Retorna os juros de 1% ou 0,01 (fixo no código)
Exemplo: /taxaJuros Resultado esperado: 0,01

API 2
1) Calcula Juros
Responde pelo path relativo "/calculajuros"
Ela faz um cálculo em memória, de juros compostos, conforme abaixo:
Valor Final = Valor Inicial * (1 + juros) ^ Tempo
Valor inicial é um decimal recebido como parâmetro.
Valor do Juros deve ser consultado na API 1.
Tempo é um inteiro, que representa meses, também recebido como parâmetro.
^ representa a operação de potência.
Valor Final deve ser truncado (sem arredondamento) em duas casas decimais.
Exemplo: /calculajuros?valorinicial=100&meses=5 Resultado esperado: 105,10

2) Show me the code
Este responde pelo path relativo /showmethecode Deverá retornar a url de onde
encontra-se o fonte no github
Esperamos que a entrega tenha

=============================================================================

1. Código fonte em .NET no github
2. Publicar as APIs em um endereço Web (ESTA ENTREGA É OPCIONAL)
3. Testes unitários (ESTA ENTREGA É OPCIONAL)
