using ExercicioGerenciadorTarefas.Communication.Enums;

namespace ExercicioGerenciadorTarefas.Communication.Responses;

public class ResponseTarefaJson
{
	public int Id { get; set; }
	public string Nome { get; set; } = string.Empty;
	public string Descricao { get; set; } = string.Empty;
	public Prioridade Prioridade { get; set; }
	public DateOnly DataRealizacao { get; set; }
	public Status Status { get; set; }
}
