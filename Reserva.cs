/*
*	<copyright file="Fase1.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>João Barbosa</author>
*   <date>06/11/2024 16:00:13</date>
*	<description></description>
**/
using System;

namespace Fase1
{
    /// <summary>
    /// Purpose:
    /// Created by: João Barbosa
    /// Created on: 06/11/2024 16:00:13
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    /// <summary>
    /// Representa uma reserva de quartos em um alojamento feita por um cliente.
    /// </summary>
    public class Reserva
    {
        #region Attributes
        /// <summary>
        /// Cliente que realizou a reserva.
        /// </summary>
        Cliente cliente;

        /// <summary>
        /// Alojamento onde a reserva será realizada.
        /// </summary>
        Alojamento alojamento;

        /// <summary>
        /// Data de entrada na reserva.
        /// </summary>
        DateTime dataEntrada;

        /// <summary>
        /// Data de saída na reserva.
        /// </summary>
        DateTime dataSaida;

        /// <summary>
        /// Quantidade de quartos reservados.
        /// </summary>
        int quantidadeQuartos;

        /// <summary>
        /// Indica se a reserva foi realizada.
        /// </summary>
        bool realizada;

        /// <summary>
        /// Data e hora do check-in, se realizado.
        /// </summary>
        DateTime? dataHoraCheckIn;

        #endregion

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Reserva"/>.
        /// </summary>
        /// <param name="cliente">Cliente que fez a reserva.</param>
        /// <param name="alojamento">Alojamento onde será feita a reserva.</param>
        /// <param name="dataEntrada">Data de entrada na reserva.</param>
        /// <param name="dataSaida">Data de saída na reserva.</param>
        /// <param name="quantidadeQuartos">Quantidade de quartos a serem reservados.</param>
        public Reserva(Cliente cliente, Alojamento alojamento, DateTime dataEntrada, DateTime dataSaida, int quantidadeQuartos)
        {
            Cliente = cliente;
            Alojamento = alojamento;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
            QuantidadeQuartos = quantidadeQuartos;
            Realizada = false;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Obtém ou define o cliente que fez a reserva.
        /// </summary>
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        /// <summary>
        /// Obtém ou define o alojamento da reserva.
        /// </summary>
        public Alojamento Alojamento
        {
            get { return alojamento; }
            set { alojamento = value; }
        }

        /// <summary>
        /// Obtém ou define a data de entrada na reserva.
        /// </summary>
        public DateTime DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
        }

        /// <summary>
        /// Obtém ou define a data de saída na reserva.
        /// </summary>
        public DateTime DataSaida
        {
            get { return dataSaida; }
            set { dataSaida = value; }
        }

        /// <summary>
        /// Obtém ou define a quantidade de quartos reservados.
        /// </summary>
        public int QuantidadeQuartos
        {
            get { return quantidadeQuartos; }
            set { quantidadeQuartos = value; }
        }

        /// <summary>
        /// Obtém ou define um valor indicando se a reserva foi realizada.
        /// </summary>
        public bool Realizada
        {
            get { return realizada; }
            set { realizada = value; }
        }

        /// <summary>
        /// Obtém ou define a data e hora do check-in, se realizado.
        /// </summary>
        public DateTime? DataHoraCheckIn  
        {
            get { return dataHoraCheckIn; }
            set { dataHoraCheckIn = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Realiza a reserva no alojamento e marca como realizada.
        /// </summary>
        /// <returns>Retorna <c>true</c> se a reserva foi bem-sucedida; caso contrário, <c>false</c>.</returns>
        public bool RealizarReserva()
        {
            Realizada = true;
            return Alojamento.ReservarQuartos(DataEntrada, DataSaida, QuantidadeQuartos);
        }

        /// <summary>
        /// Cancela a reserva no alojamento.
        /// </summary>
        public void CancelarReserva()
        {
            Alojamento.CancelarReserva(DataEntrada, DataSaida, QuantidadeQuartos);
        }
        }

    }

    #endregion




