/*
*	<copyright file="Fase1.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>João Barbosa</author>
*   <date>06/11/2024 14:19:30</date>
*	<description></description>
**/
using System;

namespace Fase1
{
    /// <summary>
    /// Purpose:
    /// Created by: João Barbosa
    /// Created on: 06/11/2024 14:19:30
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    /// <summary>
    /// Interface que define as operações básicas para gerenciamento de um alojamento.
    /// </summary>
    public interface IAlojamento
    {

        #region metodos
        /// <summary>
        /// Exibe detalhes da disponibilidade de quartos no alojamento entre as datas especificadas.
        /// </summary>
        /// <param name="dataEntrada">Data de início para verificar disponibilidade.</param>
        /// <param name="dataSaida">Data de término para verificar disponibilidade.</param>
        void MostrarDetalhes(DateTime dataEntrada, DateTime dataSaida);

        /// <summary>
        /// Realiza a reserva de uma quantidade de quartos no alojamento para o intervalo de datas especificado.
        /// </summary>
        /// <param name="dataEntrada">Data de início da reserva.</param>
        /// <param name="dataSaida">Data de término da reserva.</param>
        /// <param name="quantidadeQuartos">Número de quartos a serem reservados.</param>
        /// <returns>Retorna <c>true</c> se a reserva foi realizada com sucesso; caso contrário, <c>false</c>.</returns>
        bool ReservarQuartos(DateTime dataEntrada, DateTime dataSaida, int quantidadeQuartos);

        /// <summary>
        /// Cancela uma quantidade de quartos reservados no alojamento para o intervalo de datas especificado.
        /// </summary>
        /// <param name="dataEntrada">Data de início do cancelamento.</param>
        /// <param name="dataSaida">Data de término do cancelamento.</param>
        /// <param name="quantidadeQuartos">Número de quartos a serem cancelados.</param>
        /// <returns>Retorna <c>true</c> se o cancelamento foi realizado com sucesso; caso contrário, <c>false</c>.</returns>
        bool CancelarReserva(DateTime dataEntrada, DateTime dataSaida, int quantidadeQuartos);

        #endregion
    }

}

