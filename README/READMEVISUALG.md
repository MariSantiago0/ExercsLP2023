EXERCÍCIOS DO VISUALG PASSADOS EM SALA DE AULA


##EXERCÍCIO 1 - Gasolina

// criação do arquivo Gasolina.alg
definição da variável comb do tipo caracter e das variáveis pre, val, lit e desc do tipo real
início do algoritmo
    comando "escreva" pedindo para o usuário digitar o tipo de combustível usado pelo veículo e definição do uso da variável "comb"
    comando "escreva" pedindo para o usuário digitar quantos litros abastecerá e definição do uso da variável "lit"
    comando "se" verificando se é gasolina
    comando "se" verificando se serão menos de 20 litros para abastecer
    caso ambas as condições forem verdadeiras, cálculos para ver qual vai ser o valor a pagar com um desconto de 3% são feitos
    caso apenas a segunda condição for falsa, serão realizados cálculos para saber o valor a pagar com um desconto de 5%
    fim do comando se para verificar quantos litros serão abastecidos
    caso o combustível for gasolina, o programa fará a verificação para checar se serão abastecidos menos de 20 litros
    se a condição for verdadeira, cálculos serão feitos oara descobrir qual valor terá de ser pago com um desconto de 6%
    se a condição for falsa, serão realizados cálculos para descobrir qual valor será pago com 6% de desconto
    finalização de três condições
    comando "escreva" exibindo o resultado
finalização do algoritmo //



#EXERCÍCIO 2 - Votação

// criação do arquivo Voto.alg
declaração das variáveis porcentjs, porcentmj, porcentjt, votototal, votojs, votomj e votojt do tipo inteiro, declaração fa variável voto do tipo caracter e declaração da variável i do tipo inteiro
início do algoritmo
    variável i recebe o valor 0
    comando "enquanto" definindo um looping a partir da variável i
    comando "escreva" pedindo para o usuário escrever o nome do candidato que deseja votar e definição da variável voto
    comando "se" verificando se o candidato José da Silva que recebeu o voto
    caso a condição seja verdadeira, a variável vtjs recebe o valor 1
    comando "enquanto" definindo um looping a partir da variável vtjs
    variável vtjs recebe mais 1 voto a cada vez que for votado
    fim do comando "se"
    comando "se" verificando se o candidato Maria Juruma que recebeu o voto
    caso a condição seja verdadeira, a variável vtmj recebe o valor 1
    comando "enquanto" definindo um looping a partir da variável vtmj
    variável vtmj recebe mais 1 voto a cada vez que for votada
    fim do comando "se"
    comando "se" verificando se o candidato João da Tapioca que recebeu o voto
    caso a condição seja verdadeira, a variável vtjt recebe o valor 1
    comando "enquanto" definindo um looping a partir da variável vtjt
    variável vtjt recebe mais 1 voto a cada vez que for votado
    fim do comando "se"
    variável votototal recebe a soma de votojs, votomj e votojt
    porcentjs recebe a porcentagem de votos do candidato José da Silva
    porcentmj recebe a porcentagem de votos da candidata Maria Juruma
    porcentjt recebe a porcentagem de votos do candidato João da Tapioca
    comando "se" verificando se José da Silva foi o vencedor
    caso verdadeira, comando "escreva" exibe os resultados dele
    caso seja falsa, comando "se" verifica se Maria Juruma ganhou
    caso a condição seja verdadeira, comando "escreva" exibe seus resultados
    caso seja falsa, comando "se" verifica se João da Tapioca venceu
    caso seja verdadeira, comando "escreva" exibe seus resultados
    caso nenhuma das condições sejam verdadeiras, comando "escreva" exibe que a votação foi inválida por empate
    finalização de três condições e de quatro looping
finalização do algoritmo //


-TABUADAS-

#EXERCÍCIO 3.1 - Looping enquanto

// criação do arquivo TABENQUANTO.ALG
declaração das variáveis num e tab do tipo real e variável i de tipo inteiro
início do algoritmo
    comando "escreval" pedindo ao usuário para digitar o número da tabuada desejada e definição do uso da variável num
    variável i recebe o valor 1
    comando "enquanto" define um looping a partir da variável i até cehgar no número 10
    variável tab recebe num multiplicado por i
    comando "escreva" exibe os resultados da tabuada
    i recebe a soma de i mais 1
    finalização do looping 
finalização do algoritmo //

#EXERCÍCIO 3.2 - Looping repita

// criação do arquivo tabrepita.ALG
definição das variáveis num e tab do tipo real e variável i do tipo inteiro
inicio do algoritmo
    comando "escreval" pedindo ao usuário para digitar o número da tabuada desejada e definição do uso da variável num
    variável i recebe o valor 1
    comando "repita" inicia o looping utilizando a variável i até chegar no número 10
    variável tab recebe num multiplicado por i
    comando "escreva" exibe os resultados da tabuada
    i recebe soma de i mais 1
    finalização do looping
finalização do algoritmo //

#EXERCÍCIO 3.3 - Looping para

// criação do arquivo tabpara.ALG
definição das variáveis num e tab do tipo real e variável i do tipo inteiro
inicio do algoritmo
    comando "escreval" pedindo ao usuário para digitar o número da tabuada desejada e definição do uso da variável num
    variável i recebe o valor 1
    comando "para" define um looping a partir de i até chegar em 10
    variável tab recebe num multiplicado por i
    comando "escreva" exibe os resultados da tabuada
    i recebe soma de i mais 1
    finalização do looping
finalização do algoritmo //
