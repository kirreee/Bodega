using Bodega.Dal.Dtos;
using Bodega.Dal.Models;
using Bodega.Dal.ViewModels;
using Bodega.Services.Interfaces;
using Bodega.Web.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bodega.Services.Services
{
    public class MenuRepository : IMenuRepository
    {
        private readonly ApplicationDbContext _ctx;

        public MenuRepository(ApplicationDbContext context)
        {
            _ctx = context;
        }

        public ResponseMessageViewModel AddMenu(AddMenuDto addMenuDto)
        {
            var model = new Menu()
            {
                Title = addMenuDto.Title,
                Description = addMenuDto.Description,
                Price = addMenuDto.Price,
                Posted = DateTime.Now
            };

            try
            {
                _ctx.Menus.Add(model);
                _ctx.SaveChanges();

                ResponseMessageViewModel responseViewModel = new ResponseMessageViewModel()
                {
                    Message = "Success",
                    Code = "200"
                };

                return responseViewModel;
            }
            catch (Exception ex)
            {
                ResponseMessageViewModel responseViewModel = new ResponseMessageViewModel()
                {
                    Message = "Failed",
                    Code = "500"
                };

                return responseViewModel;
            }
        }
    }
}
