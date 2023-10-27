using System;

class Program {
    public static void Main (string[] args) 
    {
        string nivel = "desconhecido";
        
        static int calculadoraRank (int vitorias, int derrotas)
        {
            return vitorias - derrotas;
        }

        var saldo = calculadoraRank(103,0);

        if(saldo <= 10){
                nivel= "Ferro";
            }
            else if (saldo >= 11 && saldo<= 20){
                nivel = "Bronze";
            }
            else if (saldo >= 21 && saldo <=50 ){
                nivel = "Prata";
            }
            else if (saldo >= 51 && saldo <=80 ){
                nivel = "Ouro";
            }
            else if (saldo >= 81 && saldo <=90 ){
                nivel = "Diamante";
            }
            else if (saldo >= 91 && saldo <=100 ){
                nivel = "Lendário";
            }
            else{
                nivel = "imortal";
            }

        Console.WriteLine("O herói tem saldo de " + saldo + " vitórias e está no nível " + nivel);  
    }
}