using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Mapeamentos;
using Microsoft.EntityFrameworkCore;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados
{
    public class ClinicaVeterinariaContexto : DbContext
    {
        public DbSet<Raca> Racas { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }

        public ClinicaVeterinariaContexto(DbContextOptions<ClinicaVeterinariaContexto> 
            options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            * Documentação: https://docs.microsoft.com/pt-br/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
            * 1º etapa - Criar a Entidade
            * 2º etapa - Criar o Mapeamento da Entidade para tabela
            * 3º etapa - Registrar o Mapeamento
            * 4º etapa - Gerar a Migration
            *      dotnet ef migrations add NomeMigration
            * 5º etapa - A Migration poderá ser aplicada de duas formas:
            *      - Executar comando para aplicar a migration sem a necessidade de executar a aplicação
            *          dotnet ef database update
            *      - Executar a aplicação irá aplicar a migration */
            
            modelBuilder.ApplyConfiguration(new RacaMapeamento());
            modelBuilder.ApplyConfiguration(new VeterinarioMapeamento());
        }
    }
}