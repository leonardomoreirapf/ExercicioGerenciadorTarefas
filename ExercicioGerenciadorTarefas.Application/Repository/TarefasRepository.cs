using ExercicioGerenciadorTarefas.Communication.Requests;
using ExercicioGerenciadorTarefas.Communication.Responses;

namespace ExercicioGerenciadorTarefas.Application.Repository;

public static class TarefasRepository
{
	public static List<ResponseTarefaJson> _tarefas = [];
	private static int _id = 0;

	public static int RetornarNovoId()
	{
		_id++;
		return _id;
	}

	public static void AdicionarRegistro(ResponseTarefaJson response) => _tarefas.Add(response);
	public static ResponseTarefaJson? ObterTarefa(int id) => _tarefas.FirstOrDefault(tarefa => tarefa.Id.Equals(id));
	public static List<ResponseTarefaJson> ObterTodasTarefas() => _tarefas;
	public static void AtualizarRegistro(int id, RequestTarefaJson request)
	{
		var tarefa = _tarefas.First(tarefa => tarefa.Id.Equals(id)); ;

		tarefa.Nome = request.Nome;
		tarefa.Descricao = request.Descricao;
		tarefa.Prioridade = request.Prioridade;
		tarefa.DataRealizacao = request.DataRealizacao;
		tarefa.Status = request.Status;
	}
	public static void DeletarRegistro(ResponseTarefaJson tarefaJson) => _tarefas.Remove(tarefaJson);
}
