using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        string _descricao = "";
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao 
        { 
            get => _descricao;
            set
            {
                if (value != null)
                {
                    throw new Exception("Informe o nome do produto");
                    _descricao = value;
                }
            }
        }
        public double Quantidade { get; set; }
        public double Preço { get; set; }
        public double Total { get => Quantidade * Preço; }
    }
}
