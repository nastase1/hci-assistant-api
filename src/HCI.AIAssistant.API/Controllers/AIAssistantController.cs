using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HCI.AIAssistant.API.Models.DTOs.AIAssistanController;
using Microsoft.AspNetCore.Mvc;

namespace HCI.AIAssistant.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AIAssistantController : ControllerBase
{
    [HttpPost("/message")]
    public async Task<ActionResult<AIAssistantControllerPostMessageResponseDTO>> PostMessageAsync([FromBody] AIAssistantControllerPostMessageRequestDTO request)
    {
        AIAssistantControllerPostMessageResponseDTO response = new AIAssistantControllerPostMessageResponseDTO
        {
            TextMessage = $"Received: {request.TextMessage}"
        };

        return Ok(response);
    }
}
