using System;

class Program {
    public static void Main (string[] args) {
        string nome;
        string nivel = "desconhecido";
        double xp;

        Console.WriteLine("Insira o nome do seu heroi");
        nome = Console.ReadLine();
        
        Console.WriteLine("Digite a quantidade de xp do seu herói");
        xp = Convert.ToDouble(Console.ReadLine());
        
        if(xp < 1000)
        {
            Console.WriteLine("Somente xp igual ou maior que 1000 são aceitos");
        }
        
        if (xp < 1000){
                nivel = "Ferro";
        
            } else if(xp >= 1001 && xp <= 2000) {
                nivel = "Bronze";
        
            } else if (xp >= 2001 && xp <= 5000){
                nivel = "Prata";
        
            } else if (xp >= 5001 && xp <= 7000) {
                nivel = "Ouro";
        
            } else if (xp >= 7001 && xp <= 8000) {
                nivel = "Platina";
        
            } else if (xp >= 8001 && xp <= 9000) {
                nivel = "Ascendente";
        
            } else if (xp >= 9001 && xp <= 10000){
                nivel = "Imortal";
        
            } else if (xp >= 10001){
                nivel = "Radiante";
            }
    
        Console.WriteLine("O Herói de nome {0} está no nível {1}", nome, nivel);
    }
}