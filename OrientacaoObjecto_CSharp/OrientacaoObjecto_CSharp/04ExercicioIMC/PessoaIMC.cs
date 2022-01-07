using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjecto_CSharp.ExercicioIMC
{
    public class PessoaIMC
    {
        //Atributos

        public double peso;
        public double altura1;
        public double altura2;

        //Metodos

        public double IMC()
        {
            return peso / (altura1 * altura2);
        }

        //Situação
        public string situacaoIMC(double IMC)
        {
            string retorno;

            if (IMC < 18.5 )
            {
               retorno = "Abaixo do Peso";
            }
            if (IMC < 25)
            {
                retorno= "Peso normal";
            }
            if (IMC < 30)
            {
                retorno= "Acima do peso";
            }
            if (IMC < 35)
            {
                retorno= "Obesidade I";
            }
            if (IMC < 40)
            {
                retorno = "Obesidade II";
            }
            else 
            {
                retorno= "Obesidade III";
            }

            return retorno;
        }
       
        
        //Mensagem
        
        public void mensagee()
        {
            double obterIMC = IMC();

            string obterSituacao = situacaoIMC(obterIMC);
            Console.WriteLine("O IMC é de: " +obterIMC);
            Console.WriteLine("A sua situação é: " + obterSituacao);
            Console.ReadKey();
        }
    }
}
