using Microsoft.AspNetCore.Mvc;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using UI.Models;
using System;

namespace UI.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        ICategoryService _categoryService;

        public ICategoryService CategoryService { get => _categoryService; set => _categoryService = value; }

        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListVM
            {
                Categories = _categoryService.GetAll()
                CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["category"])
            };

            return View(model);
        }
    }
}
