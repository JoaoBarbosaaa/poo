/*
*	<copyright file="Fase1.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>João Barbosa</author>
*   <date>06/11/2024 14:36:00</date>
*	<description></description>
**/
using System;
namespace Fase1
{
    /// <summary>
    /// Purpose:
    /// Created by: João Barbosa
    /// Created on: 06/11/2024 14:36:00
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    /// <summary>
    /// Classe que representa um cliente.
    /// </summary>
    public class Cliente
    {
        #region Attributes
        /// <summary>
        /// Nome do cliente.
        /// </summary>
        string nome;
        /// <summary>
        /// Número de identificação do cliente.
        /// </summary>
        string numIdentificacao;
        #endregion

        #region Constructors
        /// <summary>
        /// Construtor padrão da classe Cliente.
        /// Inicializa o nome como uma string vazia e o número de identificação como "0".
        /// </summary>
        public Cliente()
        {
            nome = "";
            numIdentificacao = "0";
        }
        /// <summary>
        /// Construtor com parâmetros da classe Cliente.
        /// </summary>
        /// <param name="nome">Nome do cliente.</param>
        /// <param name="numIdentificacao">Número de identificação do cliente.</param>
        public Cliente(string nome, string numIdentificacao)
        {
            Nome = nome;
            NumIdentificacao = numIdentificacao;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Obtém ou define o nome do cliente.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém ou define o número de identificação do cliente.
        /// </summary>
        public string NumIdentificacao
        {
            get { return numIdentificacao; }
            set { numIdentificacao = value; }
        }

        #endregion

    }

}
