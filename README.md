# Neogrid - DESAFIO TÉCNICO .NET – SISTEMAS INTERNOS

A APIOne é equivalente a API 1 responsável pela consulta da taxa de Juros que é retornado fixo 0.01
<br>Endereço: http://localhost:5001
<br>Para fazer a consulta de juros deve-se utilizar http://localhost:5001/taxaJuros e será retornado o JSON com o valor do juros

A APITwo é equivalente a API 2 que realiza a consulta na API 1 referente ao valor de juros e depois realiza o Calculo do Juros compostos com base nas informações de valor inicial e da quantidade de meses através da Requisição REST. 
<br>Também retorna a URL de onde encontra-se o código fonte do GitHub.
<br>Endereço: http://localhost:5002/
<br>Para fazer a consulta de juros deve-se utilizar http://localhost:5002/calculajuros?valorinicial=100&meses=5 e será retornado o valor final no JSON
<br>Para fazer a consulta da URL onde encontra-se o fonte deve-se utilizar http://localhost:5002/showmethecode
