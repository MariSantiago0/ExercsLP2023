algoritmo "Gasolina"
// Função :
// Autor : Mariana Santiago e Yuri Telis
// Data : 22/03/2023
// Seção de Declarações 
var
   comb : caracter
   pre, val, lit, desc : real
inicio
// Seção de Comandos
   escreva ("Digite o tipo de combustível (A- álcool; G- gasolina):")
   leia(comb)
   escreva ("Digite quantos litros vai abastecer: ")
   leia (lit)
   se (comb="A") entao
   se (lit<=20) entao
      pre:=4,90*lit
      desc:=(3/100)*pre
      val:=pre-desc
   senao
      pre:=4,90*lit
      desc:=(5/100)*pre
      val:=pre-desc
   fimse
   senao
        se (comb="G") entao
        se (lit<=20) entao
           pre:=5,50*lit
           desc:=(4/100)*pre
           val:=pre-desc
        senao
             pre:=5,50*lit
             desc:=(4/100)*pre
             val:=pre-desc
        fimse
        fimse
   fimse
   escreva ("O valor a pagar é:", val)
fimalgoritmo
