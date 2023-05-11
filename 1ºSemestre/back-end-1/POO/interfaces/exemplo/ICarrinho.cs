using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo
{
    public interface ICarrinho
    {
        // regras do "contrato" (métodos que deverão apenas serem declarados)

        // crud: create, read, update, delete

        // create
        void Adicionar(Produto _produto);

        // read
        void Listar();

        // update
        void Atualizar(int _codigo, Produto _produto);

        // delete
        void Remover(Produto _produto);
    }
}