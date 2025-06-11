using ExercicioGerenciadorTarefas.Application.UseCases.Tarefa.Delete;
using ExercicioGerenciadorTarefas.Application.UseCases.Tarefa.GetAll;
using ExercicioGerenciadorTarefas.Application.UseCases.Tarefa.GetById;
using ExercicioGerenciadorTarefas.Application.UseCases.Tarefa.Register;
using ExercicioGerenciadorTarefas.Application.UseCases.Tarefa.Update;
using ExercicioGerenciadorTarefas.Communication.Requests;
using ExercicioGerenciadorTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ExercicioGerenciadorTarefas.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GerenciadorTarefaController : ControllerBase
{
	[HttpPost]
	[ProducesResponseType(typeof(ResponseRegisteredTarefaJson), StatusCodes.Status200OK)]
	[ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
	public IActionResult Register([FromBody] RequestTarefaJson request)
	{
		var response = new RegisterTarefaUseCase().Execute(request);
		
		return Created(string.Empty, response);
	}

	[HttpGet]
	[Route("{id}")]
	[ProducesResponseType(typeof(ResponseTarefaJson), StatusCodes.Status200OK)]
	[ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
	public IActionResult Get(int id)
	{
		var response = new GetTarefaByIdUseCase().Execute(id);

		if (response is null)
			return NotFound();

		return Ok(response);
	}

	[HttpGet]
	[ProducesResponseType(typeof(ResponseAllTarefasJson), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	public IActionResult GetAll()
	{
		var response = new GetAllTarefasUseCase().Execute();

		if (response.TarefasJson.Any())
			return Ok(response);

		return NoContent();
	}

	[HttpPut]
	[Route("{id}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public IActionResult Update([FromRoute]int id, [FromBody] RequestTarefaJson request)
	{
		var tarefa = new GetTarefaByIdUseCase().Execute(id);

		if (tarefa is null)
			return NotFound();

		new UpdateTarefaUseCase().Execute(id, request);

		return NoContent();
	}

	[HttpDelete]
	[Route("{id}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
	public IActionResult Delete(int id)
	{
		var tarefa = new GetTarefaByIdUseCase().Execute(id);

		if (tarefa is null)
			return NotFound();

		new DeleteTarefaByIdUseCase().Execute(tarefa);

		return NoContent();
	}
}
