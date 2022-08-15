﻿using System.ComponentModel.DataAnnotations.Schema;

namespace TarefasAPISQL.Data
{
    [Table("Tarefas")]
    public record Tarefa(int Id, string Atividade, string Status);
}
