namespace Atividade{
    class Pessoa_Juridica:Clientes{
        public string cnpj{ get; set; }
        public string ie{ get; set;}
        public override void Pagar_Imposto(float v)
        {
            valor = v;
            valor_imposto = valor*20/100;
            total =valor+valor_imposto;
        }
    }
}