﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TravelManagement.Shared.Abbstraction.Commands;
using TravelManagement.Shared.Abbstraction.Queries;
using TravelManagemnet.Application.Commands;
using TravelManagemnet.Application.DTO;
using TravelManagemnet.Application.Queries;

namespace TravelManagement.Api.Controllers
{
   
    public class TravelerCheckListController : BaseController
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;

        public TravelerCheckListController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<TravelCheckListDto>> Get([FromRoute] GetTravelerCheckList query)
        {
            var result = await _queryDispatcher.QueryAsync(query);
            return OkOrNotFound(result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TravelCheckListDto>>> Get([FromQuery] SearchTravelerCheckList query)
        {
            var result = await _queryDispatcher.QueryAsync(query);
           if(result==null )
                return NotFound();
           return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateTravelerCheckListWithItems command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return CreatedAtAction(nameof(Get), new { id = command.Id }, null);
        }

        [HttpPut("{TravelerCheckListId}/items")]
        public async Task<IActionResult> Put([FromBody] AddTravelerItem command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }

        [HttpPut("{TravelerCheckListId:guid}/items/{name}/Take")]
        public async Task<IActionResult> Put([FromBody] TakeItem command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }

        [HttpDelete("{TravelerCheckListId:guid}/items/{name}")]
        public async Task<IActionResult> Delete([FromBody] RemoveTravelerItem command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete([FromBody] RemoveTravelerCheckList command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }
    }
}
