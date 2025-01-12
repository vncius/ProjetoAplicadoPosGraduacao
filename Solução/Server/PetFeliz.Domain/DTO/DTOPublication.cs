﻿using PetFeliz.Domain.Model.Publication;
using System;

namespace PetFeliz.Domain.DTO
{
    public class DTOPublication
    {
        public DTOPublication() { }

        public DTOPublication(PublicationModel model)
        {
            Id = model.Id;
            UserId = model.UserId;
            Nome = model.Nome;
            CidadeId = model.CidadeId;
            Sexo = model.Sexo;
            Idade = model.Idade;
            Descricao = model.Descricao;
            IsAdotado = model.IsAdotado;
            NameImagem = model.NameImagem;
            EstadoId = model.EstadoId;
            PublicationCanceled = model.PublicationCanceled;
        }

        public long Id { get; set; }
        public long UserId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public long CidadeId { get; set; }
        public long EstadoId { get; set; }
        public string Setor { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public bool IsAdotado { get; set; }
        public string NameImagem { get; set; }
        public bool PublicationCanceled { get; set; }
    }
}
