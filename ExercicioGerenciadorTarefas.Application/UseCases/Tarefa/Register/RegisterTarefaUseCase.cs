using ExercicioGerenciadorTarefas.Application.Repository;
using ExercicioGerenciadorTarefas.Communication.Requests;
using ExercicioGerenciadorTarefas.Communication.Responses;

namespace ExercicioGerenciadorTarefas.Application.UseCases.Tarefa.Register;

public class RegisterTarefaUseCase
{
	public ResponseRegisteredTarefaJson Execute(RequestTarefaJson request)
	{
		var registro = new ResponseTarefaJson()
		{
			Id = TarefasRepository.RetornarNovoId(),
			Nome = request.Nome,
			Descricao = request.Descricao,
			DataRealizacao = request.DataRealizacao,
			Prioridade = request.Prioridade,
			Status = request.Status
		};

		TarefasRepository.AdicionarRegistro(registro);

		return new ResponseRegisteredTarefaJson()
		{
			Id = registro.Id,
			Nome = registro.Nome
		};
	}
}
