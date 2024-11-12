/*
*	<copyright file="Fase1.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>João Barbosa</author>
*   <date>06/11/2024 14:34:00</date>
*	<description></description>
**/
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1
{
    /// <summary>
    /// Purpose:
    /// Created by: João Barbosa
    /// Created on: 06/11/2024 14:34:00
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    /// <summary>
    /// Classe principal do programa para fazer a gestão de alojamentos turisticos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de clientes
            Cliente cliente1 = new Cliente("João Silva", "123456789");
            Cliente cliente2 = new Cliente("Maria Santos", "987654321");
            Cliente cliente3 = new Cliente("Rui Costa", "987554321");
            Cliente cliente4 = new Cliente("Miro Oliveira", "999988844");

            // Criação alojamento com 10 quartos e começa com 01/01/2024 como data inicial
            DateTime dataInicial = new DateTime(2024, 1, 1);
            Alojamento alojamento1 = new Alojamento("Hotel XYZ", 100.00m, 10, dataInicial);

            // Tentar realizar uma reserva
            DateTime dataEntrada1 = new DateTime(2024, 11, 12);
            DateTime dataSaida1 = new DateTime(2024, 11, 12);
            Reserva reserva1 = new Reserva(cliente1, alojamento1, dataEntrada1, dataSaida1, 3);
            Console.WriteLine($"\nTentando realizar a reserva para {cliente1.Nome} no {alojamento1.Nome}...");
            if (reserva1.RealizarReserva())
            {
                Console.WriteLine("Reserva realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Falha na reserva!");
            }

            alojamento1.MostrarDetalhes(dataEntrada1, dataSaida1);



            DateTime dataEntrada2 = new DateTime(2024, 11, 12);
            DateTime dataSaida2 = new DateTime(2024, 11, 12);
            Reserva reserva2 = new Reserva(cliente2, alojamento1, dataEntrada2, dataSaida2, 5); 
            Console.WriteLine($"\nTentando realizar a reserva para {cliente2.Nome} no {alojamento1.Nome}...");
            if (reserva2.RealizarReserva())
            {
                Console.WriteLine("Reserva realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Falha na reserva! Quartos indisponíveis.");
            }

            
            alojamento1.MostrarDetalhes(dataEntrada2, dataSaida2);



            DateTime dataEntrada3 = new DateTime(2024, 11, 12);
            DateTime dataSaida3 = new DateTime(2024, 11, 12);
            Reserva reserva3 = new Reserva(cliente3, alojamento1, dataEntrada3, dataSaida3, 4);
            Console.WriteLine($"\nTentando realizar a reserva para {cliente3.Nome} no {alojamento1.Nome}...");
            if (reserva3.RealizarReserva())
            {
                Console.WriteLine("Reserva realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Falha na reserva! Quartos indisponíveis.");
            }

            alojamento1.MostrarDetalhes(dataEntrada3, dataSaida3);





            DateTime dataEntrada4 = new DateTime(2024, 01, 07);
            DateTime dataSaida4 = new DateTime(2024, 01, 07);
            Reserva reserva4 = new Reserva(cliente4, alojamento1, dataEntrada4, dataSaida4, 3);  
            Console.WriteLine($"\nTentando realizar a reserva para {cliente4.Nome} no {alojamento1.Nome}...");
            if (reserva4.RealizarReserva())
            {
                Console.WriteLine("Reserva realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Falha na reserva! Quartos indisponíveis.");
            }

  
            alojamento1.MostrarDetalhes(dataEntrada4, dataSaida4);




            // Cancelar uma reserva
            Console.WriteLine($"\nCancelando a reserva de {cliente1.Nome}...");
            reserva1.CancelarReserva();
            alojamento1.MostrarDetalhes(dataEntrada1, dataSaida1);



            //tentativa de fazer check in
            CheckInReserva checkIn1 = new CheckInReserva(reserva1);
            CheckInReserva checkIn2 = new CheckInReserva(reserva2);
            CheckInReserva checkIn4 = new CheckInReserva(reserva4);


            //Executa check-in para os clientes com base em suas reservas
            checkIn1.ExecutarCheckIn();
            checkIn2.ExecutarCheckIn();
            checkIn4.ExecutarCheckIn();

        }
    }
}