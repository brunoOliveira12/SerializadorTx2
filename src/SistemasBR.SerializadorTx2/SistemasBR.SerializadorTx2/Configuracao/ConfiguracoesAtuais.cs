﻿namespace SistemasBR.SerializadorTx2.Configuracao
{
    internal static class ConfiguracoesAtuais
    {
        internal static bool NomeDaClasseNoCabecalhoNaoInformadoOuVazio { get; private set; }
        internal static bool SerializarPropriedadesSemAtributo { get; private set; }
        internal static bool NomeDaPropriedadeQuandoNomeCampoVazio { get; private set; }
        internal static bool NaoDispararExceptionPropriedadesObrigatoriasVazias { get; private set; }
        internal static bool NaoDispararExceptionPropriedadesMaioresPermitido { get; private set; }

        internal static void AtualizarConfiguracoesGerais(ComportamentoFlags configuracoes)
        {
            NomeDaClasseNoCabecalhoNaoInformadoOuVazio =
                configuracoes.HasFlag(ComportamentoFlags.NomeDaClasseNoCabecalhoNaoInformadoOuVazio);

            SerializarPropriedadesSemAtributo =
                configuracoes.HasFlag(ComportamentoFlags.SerializarPropriedadesSemAtributo);

            NomeDaPropriedadeQuandoNomeCampoVazio =
                configuracoes.HasFlag(ComportamentoFlags.NomeDaPropriedadeQuandoNomeCampoVazio);

            NaoDispararExceptionPropriedadesObrigatoriasVazias =
                configuracoes.HasFlag(ComportamentoFlags.NaoDispararExceptionPropriedadesObrigatoriasVazias);

            NaoDispararExceptionPropriedadesMaioresPermitido =
                configuracoes.HasFlag(ComportamentoFlags.NaoDispararExceptionPropriedadesMaioresPermitido);
        }

        internal static ComportamentoFlags DevolverConfiguracoesAtuais()
        {
            ComportamentoFlags comportamentoAtual = 0;

            if (NomeDaClasseNoCabecalhoNaoInformadoOuVazio)
                comportamentoAtual = ComportamentoFlags.NomeDaClasseNoCabecalhoNaoInformadoOuVazio;

            if (SerializarPropriedadesSemAtributo)
                comportamentoAtual = comportamentoAtual == 0
                    ? ComportamentoFlags.SerializarPropriedadesSemAtributo
                    : comportamentoAtual | ComportamentoFlags.SerializarPropriedadesSemAtributo;

            if (NomeDaPropriedadeQuandoNomeCampoVazio)
                comportamentoAtual = comportamentoAtual == 0
                    ? ComportamentoFlags.NomeDaPropriedadeQuandoNomeCampoVazio
                    : comportamentoAtual | ComportamentoFlags.NomeDaPropriedadeQuandoNomeCampoVazio;

            if (NaoDispararExceptionPropriedadesObrigatoriasVazias)
                comportamentoAtual = comportamentoAtual == 0
                    ? ComportamentoFlags.NaoDispararExceptionPropriedadesObrigatoriasVazias
                    : comportamentoAtual | ComportamentoFlags.NaoDispararExceptionPropriedadesObrigatoriasVazias;

            if (NaoDispararExceptionPropriedadesMaioresPermitido)
                comportamentoAtual = comportamentoAtual == 0
                    ? ComportamentoFlags.NaoDispararExceptionPropriedadesMaioresPermitido
                    : comportamentoAtual | ComportamentoFlags.NaoDispararExceptionPropriedadesMaioresPermitido;

            return comportamentoAtual;
        }
    }
}
