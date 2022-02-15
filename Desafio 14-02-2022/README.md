## Exercício

***Contexto:*** 

*Um desenvolvedor com mais de 2 anos de experiência, claramente um Sênior aos olhos do RH, criou um P.O.C. na qual o código do jogo abaixo foi desenvolvido, para ser  adicionado ao projeto "Gaming experience", aonde o usuário poderá  gerenciar seus documentos fiscais e jogar jogos ao mesmo tempo, uma revolução no mercado!* 

*Depois de apresentado ao P.O. da equipe e aprovado, seu trabalho agora é refatorar o código para torná-lo escalável e reutilizável. Você tem liberdade total para refatorar o código baseado no seu entendimento do problema!*    

------

```c#
class MainClass {
    public static void Main (string[] args) {
        /*
            "Jogo do chute", o usuário tem que acertar o número
            aleatório escolhido pelo computador, ao acertar o computador 
            imprime na tela o número de chutes que foram necessários.
        */

        int qtd_chutes = 1;
    
        while(true){
            Console.Write("Digite um numero (entre 0-100): ");
            int chute = int.Parse(Console.ReadLine());

            if(chute > 45){
                Console.WriteLine("Seu chute foi muito alto...");
            }else if(chute < 45){
                Console.WriteLine("Seu chute foi muito baixo...");
            }else{
                break;
            }
            qtd_chutes += 1;
        }
        Console.WriteLine($"Você acertou o numero em {qtd_chutes} tentativas!");
    }
}
```



Torne esse programa reutilizável... Deixando-o flexível, aleatório e com funcionalidades!



Exemplos:

*Deixar o numero aleatório...*

*Mostrar o nome da pessoa...*

*Mudar o range...*

*E por ai vai!*
