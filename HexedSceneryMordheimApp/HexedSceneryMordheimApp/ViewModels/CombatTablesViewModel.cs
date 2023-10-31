using CommunityToolkit.Mvvm.ComponentModel;
using HexedSceneryMordheimApp.Models;
using HexedSceneryMordheimApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexedSceneryMordheimApp.ViewModels
{
    public partial class CombatTablesViewModel : ObservableObject
    {
        private readonly ITableService _tableService;

        [ObservableProperty]
        private SelectListItem _table;

        public List<SelectListItem> Tables { get; set; }

        public CombatTablesViewModel(ITableService tableService) { 
            _tableService = tableService;
            Tables = _tableService.GetTablesByCategory(Models.Enums.TableCategory.MiscCombatTables);
            Table = Tables.First();
        }

    }
}
