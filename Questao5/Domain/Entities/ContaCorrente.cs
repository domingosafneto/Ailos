﻿namespace Questao5.Domain.Entities
{
    public class ContaCorrente
    {
        public ContaCorrente() 
        {
            IdContaCorrente = "";            
            Nome = "";         
        }

        public string IdContaCorrente  { get; set; } 

        public int Numero { get; set; }

        public string Nome { get; set; }

        public int Ativo { get; set; } = 0;
    }
}
