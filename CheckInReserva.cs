/*
*	<copyright file="Fase1.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>João Barbosa</author>
*   <date>12/11/2024 15:39:15</date>
*	<description></description>
**/
using System;
namespace Fase1
{
    /// <summary>
    /// Purpose:
    /// Created by: João Barbosa
    /// Created on: 12/11/2024 15:39:15
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    /// <summary>
    /// Classe concreta que representa o check-in de uma reserva específica.
    /// Herda da classe abstrata <see cref="CheckIn"/>.
    /// </summary>
    public class CheckInReserva : CheckIn
    {

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="CheckInReserva"/> com a reserva especificada.
        /// </summary>
        /// <param name="reserva">A reserva associada ao check-in.</param>
        public CheckInReserva(Reserva reserva) : base(reserva)
        {
        }


        /// <summary>
        /// Tenta realizar o check-in para a reserva e retorna um valor indicando o sucesso.
        /// </summary>
        /// <returns>Retorna <c>true</c> se o check-in for realizado com sucesso; caso contrário, <c>false</c>.</returns>
        public override bool RealizarCheckIn()
        {
            DateTime dataAtual = DateTime.Now;

            // Verifica se a data de hoje é a mesma que a data de entrada da reserva
            if (dataAtual.Date == reserva.DataEntrada.Date)
            {
                // Realiza o check-in
                reserva.DataHoraCheckIn = dataAtual;
                return true; // Check-in realizado com sucesso
            }
            else
            {
                return false; // Check-in não realizado, data incorreta
            }
        }

        /// <summary>
        /// Executa o check-in e exibe mensagens apropriadas com base no resultado do check-in.
        /// </summary>
        public void ExecutarCheckIn()
        {
            if (RealizarCheckIn())
            {
                Console.WriteLine($"Check-in realizado com sucesso para {reserva.Cliente.Nome} em {reserva.DataHoraCheckIn}");
            }
            else
            {
                Console.WriteLine($"Não é possível realizar o check-in para {reserva.Cliente.Nome} hoje. O check-in só pode ser feito em {reserva.DataEntrada.ToShortDateString()}.");
            }


        }
    }

}

