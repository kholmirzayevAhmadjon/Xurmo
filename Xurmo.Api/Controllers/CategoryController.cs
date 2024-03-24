using Microsoft.AspNetCore.Mvc;
using Xurmo.Models.Categories;
using Xurmo.Service.Interfaces;

namespace Xurmo.Api.Controllers;

public class CategoryController : ControllerBase
{
    private readonly ICategoryService categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        this.categoryService = categoryService;
    }

    [HttpGet("get-all")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(new
        {
            StatusCode = 200,
            Message = "Success",
            Data = categoryService.GetAllAsync()
        });
    }

    [HttpGet("get-by-id")]
    public async Task<IActionResult> GetById(long id)
    {
        return Ok(new
        {
            StatusCode = 200,
            Message = "Success",
            Data = categoryService.GetByIdAsync(id)
        });
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateAsync(CategoryCreateModel model)
    {
        return Ok(new
        {
            StatusCode = 200,
            Message = "Success",
            Data = categoryService.CreateAsync(model)
        });
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> DeleteAsync(long id)
    {
        return Ok(new
        {
            StatusCode = 200,
            Message = "Success",
            Data = categoryService.DeleteAsync(id)
        });
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateAsync(long id, CategoryUpdateModel model, bool isDelete = false)
    {
        return Ok(new
        {
            StatusCode = 200,
            Message = "Success",
            Data = categoryService.UpdateAsync(id,model, isDelete)
        });
    }
}
