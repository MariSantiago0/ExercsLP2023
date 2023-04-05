algoritmo "Voto"
// Função :
// Autor : Mariana Santiago e Yuri Telis
// Data : 22/03/2023
// Seção de Declarações 
var
   porcentjs, porcentmj, porcentjt, votototal, votojs, votomj, votojt : real
   voto : caracter
   i : inteiro
inicio
// Seção de Comandos
   i:=0
   enquanto (i>=0) faca
            escreval ("Digite o seu voto:")
            leia (voto)
            se (voto="Jose da Silva") ou (voto="js") entao
               votojs:=1
               enquanto (votojs>=1) faca
               votojs:=votojs+1
            fimse
            se (voto="Maria Juruma") ou (voto="mj") entao
               votomj:=1
               enquanto (votomj>=1) faca
               votomj:=votomj+1
            fimse
            se (voto="Joao da Tapioca") ou (voto="jt") entao
               votojt:=1
               enquanto (votojt>=1) faca
               votojt:=votojt+1
            fimse
votototal:=votomj+votojs+votojt
            porcentjs:=(votojs/votototal)*1/100
            porcentmj:=(votomj/votototal)*1/100
            porcentjt:=(votojt/votototal)*1/100
            se (votojs>votomj) e (votojs>votojt) entao
               escreva ("O vencedor e: Jose da Silva, com", votojs, "votos totais e", porcentjs, "porcento dos votos. O total de pessoas que votaram foi:", votototal)
            senao
                 se (votomj>votojs) e (votomj>votojt) entao
                    escreva ("O vencedor e: Maria Juruma, com", votomj, "votos totais e", porcentmj, "porcento dos votos. O total de pessoas que votaram foi:", votototal)
                 senao
                    se (votojt>votojs) e (votojt>votomj) entao
                       escreva ("O vencedor e: Joao da Tapioca, com", votojt, "votos totais e", porcentjt, "porcento dos votos. O total de pessoas que votaram foi:", votototal)
                    senao
                         escreva ("Votacao Invalida")
                    fimse
                 fimse
            fimse
   fimenquanto
   fimenquanto
   fimenquanto
   fimenquanto
fimalgoritmo
