using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios- Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},

                //Estruturas de controle
                {"Estrutura IF -  Estruturas de controle", EstruturaIF.Executar},
                {"Estrutura If/Else - Estruturas de controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de controle", EstruturaIFElseIf.Executar},
                {"Estrutura Switch- Estruturas de controle", EstruturaSwitch.Executar},
                {"Estrutura While- Estruturas de controle", EstruturaWhile.Executar},
                {"Estrutura Do While- Estruturas de controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de controle", UsandoContinue.Executar},
               
                //Classes e métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Metodo com retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Metodo Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"GetSet - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", ReadOnly.Executar},
                {"Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor Vs Referencia - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro com valor Padrão - Classes e Métodos", ParametrosPadrao.Executar},
                
                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar}, //aqui colocamos dessa maneira pois ja existe uma classe array no System.Array.
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade (Equals e GetHashCode) - Coleções", Igualdade.Executar},
                {"Stack - Coleções", CoelecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                //OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Classe Abstrata - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                //Métodos e Funcões
                {"Exemplo Lambda - Métodos e Funcões", ExemploLambda.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}