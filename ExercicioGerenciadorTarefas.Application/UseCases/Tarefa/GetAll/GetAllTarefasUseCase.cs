using ExercicioGerenciadorTarefas.Application.Repository;
using ExercicioGerenciadorTarefas.Communication.Responses;

namespace ExercicioGerenciadorTarefas.Application.UseCases.Tarefa.GetAll;

public class GetAllTarefasUseCase
{
	public ResponseAllTarefasJson Execute()
	{
		var response = new ResponseAllTarefasJson();
		response.TarefasJson = TarefasRepository.ObterTodasTarefas();
		return response;
	}
}
