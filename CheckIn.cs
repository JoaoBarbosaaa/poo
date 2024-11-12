/*
*	<copyright file="Fase1.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>João Barbosa</author>
*   <date>12/11/2024 15:38:05</date>
*	<description></description>
**/
using System;
namespace Fase1
{
    /// <summary>
    /// Purpose:
    /// Created by: João Barbosa
    /// Created on: 12/11/2024 15:20:05
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    /// <summary>
    /// Classe abstrata que representa o processo de check-in para uma reserva.
    /// </summary>    
    public abstract class CheckIn
        {

        /// <summary>
        /// Reserva associada ao check-in.
        /// </summary>
        protected Reserva reserva;

        /// <summary>
        /// Data e hora do check-in realizado.
        /// </summary>
        DateTime? dataHoraCheckIn;



        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="CheckIn"/> com a reserva especificada.
        /// </summary>
        /// <param name="reserva">A reserva associada ao check-in.</param>
        protected CheckIn(Reserva reserva)
            {
                this.reserva = reserva;
            }

        /// <summary>
        /// Realiza o check-in para a reserva.
        /// Este método deve ser implementado pelas classes derivadas.
        /// </summary>
        public abstract bool RealizarCheckIn();

        /// <summary>
        /// Verifica se o check-in foi realizado.
        /// </summary>
        /// <returns>Retorna <c>true</c> se o check-in foi realizado; caso contrário, <c>false</c>.</returns>
        public bool CheckInRealizado()
        {
            return dataHoraCheckIn.HasValue;
        }
    }
}

