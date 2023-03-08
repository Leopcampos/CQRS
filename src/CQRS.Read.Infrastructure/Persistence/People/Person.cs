﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CQRS.Read.Infrastructure.Persistence.People
{
    [Flags]
    public enum PersonClass
    {
        Comun,
        Admin
    }

    public class Person
    {
        public int Id { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PersonClass Class { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Person(int id, PersonClass personClass, string nome, int idade)
        {
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("nome");

            this.Id = id;
            this.Class = personClass;
            this.Nome = nome;
            this.Idade = idade;
        }

        public Person(PersonClass personClass, string nome, int idade)
        {
            this.Id = -1;
            this.Class = personClass;
            this.Nome = nome;
            this.Idade = idade;
        }

        public override string ToString()
        {
            return $"{this.Class}:[Class]{this.Class}, [Nome]{this.Nome}, [Idade]{this.Idade}";
        }
    }
}