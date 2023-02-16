double mediaTotal;
string nomeAluno;
int quantNotas;

Console.WriteLine(" Bem vindo! Infome o nome do aluno(a): ");
nomeAluno = Console.ReadLine();
Console.WriteLine("Informe a quantidade de notas: ");
quantNotas = int.Parse(Console.ReadLine());

double[] notas = new double[quantNotas];
for(int i = 0; i < quantNotas; i++){
   Console.WriteLine($"Digite a nota {i + 1}: ");
   notas[i] = double.Parse(Console.ReadLine());
   }
   double somaNotas = notas[0];
   for(int i = 1; i < quantNotas; i++){
  somaNotas = somaNotas + notas[i];
 }
 mediaTotal = somaNotas/quantNotas;

  Console.WriteLine($"Aluno(a): {nomeAluno}.");
  for(int i = 0; i < quantNotas; i++){
    Console.WriteLine($"Nota {i+1}: {notas[i]}");
  }

   if(mediaTotal >= 6) {
    Console.WriteLine($"Parabéns {nomeAluno}! Você está aprovado(a) com média {mediaTotal}.");
}
   else if(mediaTotal >= 5 && mediaTotal < 6 ) {
    Console.WriteLine($"O aluno(a) {nomeAluno} está em recuperação com média {mediaTotal}.");
}
   else {
    Console.WriteLine($"Com a média {mediaTotal}, o aluno(a) {nomeAluno} está reprovado!");
  }
