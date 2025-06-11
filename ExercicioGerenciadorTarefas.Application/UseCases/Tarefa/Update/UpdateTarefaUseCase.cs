using ExercicioGerenciadorTarefas.Application.Repository;
using ExercicioGerenciadorTarefas.Communication.Requests;

namespace ExercicioGerenciadorTarefas.Application.UseCases.Tarefa.Update
{
	public class UpdateTarefaUseCase
	{
		public void Execute(int id, RequestTarefaJson request) => TarefasRepository.AtualizarRegistro(id, request);
	}
}
