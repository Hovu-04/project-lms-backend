﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_LMS.Data;
using Project_LMS.DTOs.Request;
using Project_LMS.DTOs.Response;
using Project_LMS.Interfaces.Services;

namespace Project_LMS.Controllers;

[Authorize(Policy = "DATA-MNG-VIEW")]
[Route("api/[controller]")]
[ApiController]
public class SubjectGroupController : ControllerBase
{
    private readonly ISubjectGroupService _subjectGroupService;

    public SubjectGroupController(ISubjectGroupService subjectGroupService)
    {
        _subjectGroupService = subjectGroupService;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllDisciplinesAsync(int? pageNumber,
        int? pageSize,
        string? sortDirection)
    {
        var response = await _subjectGroupService.GetAllSubjectGroupAsync(pageNumber, pageSize, sortDirection);

        if (response.Status == 1)
        {
            return BadRequest(
                new ApiResponse<PaginatedResponse<SubjectGroupResponse>>(response.Status, response.Message, response.Data));
        }

        return Ok(new ApiResponse<PaginatedResponse<SubjectGroupResponse>>(response.Status, response.Message, response.Data));
    }

    [Authorize(Policy = "DATA-MNG-INSERT")]
    [HttpPost]
    public async Task<IActionResult> CreateDepartment([FromBody] CreateSubjectGroupRequest createSubjectGroupRequest)
    {
        var response = await _subjectGroupService.CreateSubjectGroupAsync(createSubjectGroupRequest);

        if (response.Status == 1)
        {
            return BadRequest(
                new ApiResponse<SubjectGroupResponse>(response.Status, response.Message, response.Data));
        }

        return Ok(new ApiResponse<SubjectGroupResponse>(response.Status, response.Message, response.Data));
    }

    [HttpGet("{id?}")]
    public async Task<IActionResult> UpdateDiscipline(int id)
    {
        var response = await _subjectGroupService.GetSubjectGroupById(id);

        if (response.Status == 1)
        {
            return BadRequest(new ApiResponse<SubjectGroupResponse>(response.Status, response.Message, response.Data));
        }

        return Ok(new ApiResponse<SubjectGroupResponse>(response.Status, response.Message, response.Data));
    }


    [HttpPut]
    public async Task<IActionResult> UpdateDepartment([FromBody] UpdateSubjectGroupRequest updateSubjectGroupRequest)
    {
        var response = await _subjectGroupService.UpdateSubjectGroupAsync(updateSubjectGroupRequest);
        if (response.Status == 1)
        {
            return BadRequest(new ApiResponse<SubjectGroupResponse>(response.Status, response.Message, response.Data));
        }

        return Ok(new ApiResponse<SubjectGroupResponse>(response.Status, response.Message, response.Data));
    }

    [Authorize(Policy = "DATA-MNG-DELETE")]
    [HttpDelete("{id?}")]
    public async Task<IActionResult> DeleteDepartment(int id)
    {
        var response = await _subjectGroupService.DeleteSubjectGroupAsync(id);
        if (response.Status == 1)
        {
            return BadRequest(new ApiResponse<SubjectGroupResponse>(response.Status, response.Message, response.Data));
        }

        return Ok(new ApiResponse<SubjectGroupResponse>(response.Status, response.Message, response.Data));
    }

    [Authorize(Policy = "DATA-MNG-DELETE")]
    [HttpDelete]
    public async Task<IActionResult> DeleteListSubject([FromBody] DeleteRequest deleteRequest)
    {
        var response = await _subjectGroupService.DeleteSubjectGroupSubject(deleteRequest);

        if (response.Status == 1)
        {
            return BadRequest(new ApiResponse<SubjectGroupResponse>(response.Status, response.Message, response.Data));
        }

        return Ok(new ApiResponse<SubjectGroupResponse>(response.Status, response.Message, response.Data));
    }

    [HttpGet("get-all-subject-groups")]
    public async Task<IActionResult> GetSubjectGroupDropdown()
    {
        var response = await _subjectGroupService.GetSubjectGroupDropdownAsync();

        if (response.Status == 1)
        {
            return BadRequest(new ApiResponse<List<SubjectGroupDropdownResponse>>(response.Status, response.Message, response.Data));
        }

        return Ok(new ApiResponse<List<SubjectGroupDropdownResponse>>(response.Status, response.Message, response.Data));
    }

}