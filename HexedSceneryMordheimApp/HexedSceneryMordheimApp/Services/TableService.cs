using HexedSceneryMordheimApp.Models;
using HexedSceneryMordheimApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexedSceneryMordheimApp.Services
{
    public interface ITableService
    {
        List<SelectListItem> GetTablesByCategory(TableCategory category);
    }

    public class TableService : ITableService
    {

        public List<SelectListItem> GetTablesByCategory(TableCategory category)
        {
            if (category == TableCategory.MiscCombatTables)
            {
                return new List<SelectListItem>
                {
                    new SelectListItem(0, "Blackpowder Misfires"),
                    new SelectListItem(1, "Stupidity"),
                    new SelectListItem(2, "Animosity")
                };
            } 
            else
            {
                return new List<SelectListItem>();
            }
        }
    }
}
