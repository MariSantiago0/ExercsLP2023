# ExercsLP2023
EXERCÍCIOS DO C# PASSADOS EM SALA DE AULA


#EXERCÍCIO 1 - Gasolina

// criação do form2
    criação das caixas de texto txtcod, txtquant e txtvalorp e dos botões btncalcular, btnvoltar e btnlimpar
    configuração do botão btnvoltar para voltar ao menu casoo usuário clique nele
    configuração do botão btncalcular
    definição da variável cod do tipo char e conversão para toChar e definição das variáveis quant1 e quant2 do tipo double e conversão para toDouble
    comando "if" verificando se o combustível é álcool
    comando "if" verificando se serão abastecidos menos de 20 litros
    caso seja verdadeira, cálculos serão feitos para descobrir o valor a ser pago com um desconto de 3%
    exibição do resultado na caixa de texto txtvalorp
    caso a segunda condição seja falsa, cálculos para descobrir o valor a ser pago com 5% de desconto seram feitos
    exibição do resultado na caixa de texto txtvalorp
    caso ambas as condições sejam falsas, comando "if" verifica se o combustível é gasolina
    comando "if" verificando se serão abastecidos menos de 20 litros
    caso ambas as condições forem verdadeiras, cálculos serão feitos oara descobrir qual o valor será pago com um desconto de 4%
    exibição do resultado na caixa de texto txtvalorp
    caso apenas a segunda condição seja falsa, serão feitos cálculos para descobrir qual valor será pago com 6% de desconto
    exibição do resultado na caixa de texto txtvalorp
    configuração do botão limpar para limpar as caixas de texto txtcod, txtquant e txtvalorp e focar na caixa de texto txtcod caso o usuário clique no botão
finalização do form2 //



#EXERCÍCIO 2 - Votação

// criação do form6
    criação das labels lblvoto, lblvencedor, lblvt, lblporcent e lbltotal
    criação das caixas de texto txtvoto, txtvencedor, txtvt, txtporcent e txttotal
    criação dos botões btncalcular, btnlimpar e btnvoltar
    configuração do botão btncalcular
    definição da variável voto do tipo string, definição das variáveis vtjs, vtmj, vtjt, pjs, pmj, pjt e total do tipo double e definição da variável i do tipo int
    definição dos valores das variáveis vtjs, vtmj e vtjt para 0 e da variável i para 1
    comando "while" definindo looping a partir da variável i
    comando "if" para verificar se José da Silva foi votado
    caso seja verdadeira, a variável vtjt recebe mais um voto
    comando "else if" verifica se Maria Juruma recebeu o voto
    caso seja verdadeira a condição, a variável vtmj recebe mais um voto
    comando "else if" verifica se João da Tapioca recebeu o voto
    caso seja verdade, a variável vtjt recebe mais um voto
    variável total recebe o valor da soma das variáveis vtjs, vtmj e vtjt
    variável pjs recebe a porcentagem dos votos de José da Silva
    variável pmj recebe a porcentagem dos votos de Maria Juruma
    variável pmj recebe a porcentagem dos votos de Maria Juruma
    comando "if" verifica se José da Silva recebeu a maioria dos votos
    se sim, exibe nas caixas de texto txtvencedor, txtvt, txtporcent e txttotal seus resultados
    comando "if" verifica se Maria Juruma recebeu a maioria dos votos
    se sim, exibe nas caixas de texto txtvencedor, txtvt, txtporcent e txttotal seus resultados
    comando "if" verifica se João da Tapioca recebeu a maioria dos votos
    se sim, exibe nas caixas de texto txtvencedor, txtvt, txtporcent e txttotal seus resultados
    caso nenhuma dessas condições forem verdadeiras, exibe na caixa de texto txtvencedor "Votação Inválida (Empate)" e na caixa de texto txttotal os votos totais
    configuração do botão btnlimpar para limpar as caixas de texto txtvoto, txtvencedor, txtvt, txtporcent e txttotal e focar na cauxa de texto txtvoto caso o usuário clique no botão
    configuração do botão btnvoltar para voltar para o menu caso o usuário clique no botão
finalização do form6 //


-TABUADA-

#EXERCÍCIO 3.1 - Looping while

// criação do form3
    definição da variável num do tipo double para receber o número da tabuada desejada, da variável i do tipo int para realizar o looping e da variável tabwhile do tipo string para armazenar os resultados
    definição do valor da variável i para 1
    comando "while" define um looping a partir da variável i até chegar no número 10
    definição de variável tabwhileresult do tipo double para fazer a conta da tabuada
    variável tabwhile armazena a tabuada
    i soma mais 1
    exibição tabwhile na caixa de texto txttabwhileresult
finalização do form3 //


#EXERCÍCIO 3.2 - Looping do..while

// criação do form4
    definição da variável num do tipo double para receber o número da tabuada desejada, da variável i do tipo int para realizar o looping e da variável tabdowhile do tipo string para armazenar os resultados
    definição do valor da variável i para 1
    comando "do" inicia um looping a partir da variável i até chegar no número 10
    definição de variável tabdowhileresult do tipo double para fazer a conta da tabuada
    variável tabdowhile armazena a tabuada
    i soma mais 1
    exibição tabdowhile na caixa de texto txttabdowhileresult
finalização do form4 //


#EXERCÍCIO 3.3 - Looping for

// criação do form5
    definição da variável num do tipo double para receber o número da tabuada desejada, da variável i do tipo int para realizar o looping e da variável tabfor do tipo string para armazenar os resultados
    definição do valor da variável i para 1
    comando "for" inicia um looping a partir da variável i até chegar no número 10
    definição de variável tabforresult do tipo double para fazer a conta da tabuada
    variável tabfor armazena a tabuada
    i soma mais 1
    exibição tabfor na caixa de texto txttabforresult
finalização do form5 //
