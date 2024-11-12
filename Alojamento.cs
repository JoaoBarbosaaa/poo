/*
*	<copyright file="Fase1.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>João Barbosa</author>
*   <date>06/11/2024 13:49:24</date>
*	<description></description>
**/

namespace Fase1
{

    using System;
    using System.Collections.Generic;
    using System.Globalization;

    /// <summary>
    /// Purpose:
    /// Created by: João Barbosa
    /// Created on: 06/11/2024 13:49:24
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    /// <summary>
    /// Representa um alojamento com capacidade para reserva de quartos.
    /// </summary>
    public class Alojamento : IAlojamento
    {
        #region Attributes
        /// <summary>
        /// Nome do alojamento.
        /// </summary>
        string nome;
        /// <summary>
        /// Preço por noite do alojamento.
        /// </summary>
        decimal precoPorNoite;
        /// <summary>
        /// Capacidade total de quartos do alojamento.
        /// </summary>
        int capacidadeQuartos;  // Atributo que controla o número de quartos disponíveis
        /// <summary>
        /// Array que armazena o número de reservas para cada dia do ano.
        /// </summary>
        int[] reservasPorData;
        /// <summary>
        /// Data inicial para o controle das reservas.
        /// </summary>
        DateTime dataInicial;
        #endregion

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Alojamento"/>.
        /// </summary>
        /// <param name="nome">Nome do alojamento.</param>
        /// <param name="precoPorNoite">Preço por noite do alojamento.</param>
        /// <param name="capacidadeQuartos">Capacidade total de quartos.</param>
        /// <param name="dataInicial">Data inicial de controle das reservas.</param>
        public Alojamento(string nome, decimal precoPorNoite, int capacidadeQuartos, DateTime dataInicial)
        {
            Nome = nome;
            PrecoPorNoite = precoPorNoite;
            CapacidadeQuartos = capacidadeQuartos;
            this.dataInicial = dataInicial;

            // Supõe que o intervalo de datas é de até 365 dias (1 ano)
            reservasPorData = new int[365];  // Número de dias no ano
        }
        #endregion

        #region Properties
        /// <summary>
        /// Obtém ou define o nome do alojamento.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém ou define o preço por noite.
        /// </summary>
        public decimal PrecoPorNoite
        {
            get { return precoPorNoite; }
            set { precoPorNoite = value; }
        }

        /// <summary>
        /// Obtém ou define a capacidade de quartos do alojamento.
        /// </summary>
        public int CapacidadeQuartos
        {
            get { return capacidadeQuartos; }
            set { capacidadeQuartos = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calcula o índice do array <see cref="reservasPorData"/> com base na data fornecida.
        /// </summary>
        /// <param name="data">Data para cálculo do índice.</param>
        /// <returns>Índice correspondente no array de reservas.</returns>
        private int CalcularIndice(DateTime data)
        {
            // A diferença de dias entre a data inicial e a data fornecida
            return (data - dataInicial).Days;
        }

        /// <summary>
        /// Exibe detalhes da disponibilidade de quartos entre as datas especificadas.
        /// </summary>
        /// <param name="dataEntrada">Data de início.</param>
        /// <param name="dataSaida">Data de término.</param>
        public void MostrarDetalhes(DateTime dataEntrada, DateTime dataSaida)
        {
            Console.WriteLine($"Disponibilidade para {Nome} entre: {dataEntrada.ToShortDateString()} e {dataSaida.ToShortDateString()}");
            for (DateTime data = dataEntrada; data <= dataSaida; data = data.AddDays(1))
            {
                int indice = CalcularIndice(data);
                int quartosDisponiveis = CapacidadeQuartos - reservasPorData[indice];
                Console.WriteLine($"Data: {data.ToShortDateString()} - Quartos disponíveis: {quartosDisponiveis}");
            }
        }
        /// <summary>
        /// Reserva uma quantidade de quartos para o intervalo de datas especificado.
        /// </summary>
        /// <param name="dataEntrada">Data de início da reserva.</param>
        /// <param name="dataSaida">Data de término da reserva.</param>
        /// <param name="quantidadeQuartos">Quantidade de quartos a reservar.</param>
        /// <returns>Retorna <c>true</c> se a reserva foi bem-sucedida; caso contrário, <c>false</c>.</returns>
        public bool ReservarQuartos(DateTime dataEntrada, DateTime dataSaida, int quantidadeQuartos)
        {
            for (DateTime data = dataEntrada; data <= dataSaida; data = data.AddDays(1))
            {
                int indice = CalcularIndice(data);

                // Verificar se há quartos suficientes para essa data
                if (reservasPorData[indice] + quantidadeQuartos > CapacidadeQuartos)
                {
                    return false; // Não há quartos suficientes
                }
            }

            // Se possível, reservar os quartos
            for (DateTime data = dataEntrada; data <= dataSaida; data = data.AddDays(1))
            {
                int indice = CalcularIndice(data);
                reservasPorData[indice] += quantidadeQuartos;  // Incrementa os quartos reservados
            }
            return true; // Reserva bem-sucedida
        }

        /// <summary>
        /// Cancela uma quantidade de quartos reservados para o intervalo de datas especificado.
        /// </summary>
        /// <param name="dataEntrada">Data de início do cancelamento.</param>
        /// <param name="dataSaida">Data de término do cancelamento.</param>
        /// <param name="quantidadeQuartos">Quantidade de quartos a cancelar.</param>
        /// <returns>Retorna <c>true</c> se o cancelamento foi bem-sucedido; caso contrário, <c>false</c>.</returns>
        public bool CancelarReserva(DateTime dataEntrada, DateTime dataSaida, int quantidadeQuartos)
        {

            for (DateTime data = dataEntrada; data <= dataSaida; data = data.AddDays(1))
            {
                int indice = CalcularIndice(data);

                // Verificar se o número de quartos a cancelar não excede o número de quartos reservados
                if (reservasPorData[indice] < quantidadeQuartos)
                {
                    return false; // Se não houver quartos suficientes para cancelar, falha
                }

                // Cancelar a reserva, ou seja, diminuir o número de quartos reservados
                reservasPorData[indice] -= quantidadeQuartos;  // Liberta os quartos

                // Garantir que o número de quartos não seja negativo
                if (reservasPorData[indice] < 0)
                {
                    reservasPorData[indice] = 0;
                }
            }

            return true; 
        }
    }


        #endregion
    }

