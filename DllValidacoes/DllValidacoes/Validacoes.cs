using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Validacoes
{
    public class Validar
    {
        public static bool ValidarCPF(string CPF)
        {
            CPF = CPF.Replace(".", "").Replace("_", "").Replace("-", "");//Remove a máscara

            if (CPF.Length != 11)//Verifica se o CPF contém todos os 11 digitos
                return false;

            for (int i = 1; i < CPF.Length; i++)//For para verificar se os digitos são todos iguais
            {
                if (CPF[i - 1] != CPF[i])
                    break;
                else if (i == CPF.Length - 1)
                    return false;
            }

            char[] numFinal = new char[2];//Vetor para o calculo dos 2 números final
            int[] vetCPF = new int[10];//Vetor para o calculo dos 9 primeiros números
            for (int i = 0; i < 9; i++)//Carrega o vetCPF com os 9 primeiros números do CPF
                vetCPF[i] = CPF[i] - '0';
            int soma = 0;
            for (int i = 0; i < 9; i++)//Soma os 9 primeiros números do CPF
                soma += (10 - i) * vetCPF[i];
            int modSoma = soma % 11;
            numFinal[0] = modSoma < 2 ? '0' : (char)('0' + 11 - modSoma);

            //--------Segundo Número--------

            soma = 0;
            vetCPF[9] = numFinal[0] - '0';
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * vetCPF[i];
            modSoma = soma % 11;
            numFinal[1] = modSoma < 2 ? '0' : (char)('0' + 11 - modSoma);
            return CPF.EndsWith(numFinal[0].ToString() + numFinal[1].ToString());
        }

        public static bool ValidarCNPJ(string CNPJ)
        {
            CNPJ = CNPJ.Replace(".", "").Replace("_", "").Replace("/", "").Replace("-", "");

            if (CNPJ.Length != 14)
                return false;

            for (int i = 1; i < CNPJ.Length; i++)//For para verificar se os digitos são todos iguais
            {
                if (CNPJ[i - 1] != CNPJ[i])
                    break;
                else if (i == CNPJ.Length - 1)
                    return false;
            }

            char[] numFinal = new char[2];
            int[] vetCNPJ = new int[13];
            for (int i = 0; i < 12; i++)
                vetCNPJ[i] = CNPJ[i] - '0';
            int soma = 0;
            int[] multiplicador = new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            for (int i = 0; i < 12; i++)
                soma += multiplicador[i + 1] * vetCNPJ[i];
            int modSoma = soma % 11;
            numFinal[0] = modSoma < 2 ? '0' : (char)('0' + 11 - modSoma);

            //--------Segundo Número--------

            soma = 0;
            vetCNPJ[12] = numFinal[0] - '0';
            for (int i = 0; i < 13; i++)
                soma += multiplicador[i] * vetCNPJ[i];
            modSoma = soma % 11;
            numFinal[1] = modSoma < 2 ? '0' : (char)('0' + 11 - modSoma);
            return CNPJ.EndsWith(numFinal[0].ToString() + numFinal[1].ToString());
        }
    }
}
