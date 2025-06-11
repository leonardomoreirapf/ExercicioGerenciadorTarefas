using ExercicioGerenciadorTarefas.Application.Repository;
using ExercicioGerenciadorTarefas.Communication.Responses;

namespace ExercicioGerenciadorTarefas.Application.UseCases.Tarefa.GetById;

public class GetTarefaByIdUseCase
{
	public ResponseTarefaJson? Execute(int id) =>  TarefasRepository.ObterTarefa(id);
	
}
