using ExercicioGerenciadorTarefas.Communication.Enums;

namespace ExercicioGerenciadorTarefas.Communication.Requests;

public class RequestTarefaJson
{
	public string Nome { get; set; } = string.Empty;
	public string Descricao { get; set; } = string.Empty;
	public Prioridade Prioridade { get; set; }
	public DateOnly DataRealizacao { get; set; }
	public Status Status { get; set; }
}
