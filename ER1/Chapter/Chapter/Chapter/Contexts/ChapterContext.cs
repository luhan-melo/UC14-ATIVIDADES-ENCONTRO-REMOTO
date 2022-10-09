using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext: DbContext
    {
        public ChapterContext()
        {

        }
        public ChapterContext(DbContextOptions<ChapterContext> options):base(options)
        {

        }

        //vamos utilziar esse método para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                //cada provedor tem sua sintaxe para especificação (trocou de provedor, tem que mudar)
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-L8SLKHA\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
        }
        //dbset representa as entidades que serão utilziadas nas operações de leitura, criação, atualização,e exclusão
        public DbSet<Livro> Livros { get; set; }

    }
}
