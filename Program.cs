using dio_exemplo_POO.Interfaces;
using dio_exemplo_POO.models;

ICalculadora calc = new Calculadora();
Console.WriteLine($"Multiplicação: {calc.Multiplicar(9, 3)}");
Console.WriteLine($"Divisão: {calc.Dividir(9, 3)}");
Console.WriteLine($"Subtração: {calc.Subtrair(9, 3)}");
Console.WriteLine($"Soma: {calc.Somar(9, 3)}");


//--------------------------------------
// Computador c = new Computador();
// Console.WriteLine(c.ToString());

//--------------------------------------
// Pessoa p1 = new Pessoa("Tiago");
// Aluno a1 = new Aluno("Leonardo");

// Professor prof = new Professor();

//--------------------------------------
// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();

//--------------------------------------
// Aluno a1 = new Aluno();
// a1.Nome = "Tiago";
// a1.Idade = 29;
// a1.Email = "teste@teste.com";
// a1.Nota = 9.5;
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "Marcelo";
// p1.Idade = 39;
// p1.Salario = 1000;
// p1.Apresentar();

//--------------------------------------
// ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();

//--------------------------------------
// Pessoa p1 = new Pessoa();
// p1.Nome = "Tiago";
// p1.Idade = 29;
// p1.Apresentar();