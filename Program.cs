using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Alessandra");
Pessoa p2 = new Pessoa(nome: "Viktor s2");
Pessoa p3 = new Pessoa(nome: "Felícia");
Pessoa p4 = new Pessoa(nome: "Leona");
Pessoa p5 = new Pessoa(nome: "Shiro");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);
hospedes.Add(p5);

// Cria a suíte
Suite suite1 = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 100);
Suite suite2 = new Suite(tipoSuite: "Boa, mas não premium", capacidade: 5, valorDiaria: 70);
Suite suite3 = new Suite(tipoSuite: "OK", capacidade: 10, valorDiaria: 50 );


// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);

reserva.CadastrarSuite(suite2);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");