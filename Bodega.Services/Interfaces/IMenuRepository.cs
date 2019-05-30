using Bodega.Dal.Dtos;
using Bodega.Dal.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bodega.Services.Interfaces
{
    public interface IMenuRepository
    {
        ResponseMessageViewModel AddMenu(AddMenuDto addMenuDto);
    }
}
