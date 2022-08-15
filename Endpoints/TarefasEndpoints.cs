using Dapper.Contrib.Extensions;
using TarefasAPISQL.Data;
using static TarefasAPISQL.Data.TarefaContext;

namespace TarefasAPISQL.Endpoints
{
    public static class TarefasEndpoints
    {
        public static void MapTarefasEndpoints(this WebApplication app)
        {
            app.MapGet("/", () => $"Bem vindo a API Tarefas {DateTime.Now}");

            app.MapGet("/tarefas", async (GetConnection connectionGetter) =>
            {
                using var con = await connectionGetter();
                var tarefas = con.GetAll<Tarefa>().ToList();
                if (tarefas is null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(tarefas);
            });
        }
    }
}
