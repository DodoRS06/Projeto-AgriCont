﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgriCont.Models;

namespace AgriCont.Models
{
    public class ApplicationDbContext : DbContext
    {
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        {
            Database.EnsureCreated();
        }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Informatica> Informaticas { get; set; }

        public DbSet<Ferramenta> Ferramentas { get; set; }

        public DbSet<Maquinario> Maquinarios { get; set; }

        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet<AgriCont.Models.FormFaleConosco> FormFaleConosco { get; set; }
    }
}