using ExercicioGerenciadorTarefas.Application.Repository;
using ExercicioGerenciadorTarefas.Communication.Responses;

namespace ExercicioGerenciadorTarefas.Application.UseCases.Tarefa.Delete;

public class DeleteTarefaByIdUseCase
{
	public void Execute(ResponseTarefaJson tarefa) => TarefasRepository.DeletarRegistro(tarefa);
}
