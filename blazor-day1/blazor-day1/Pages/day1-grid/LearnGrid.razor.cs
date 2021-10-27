using Models.User;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_day1.Pages.day1_grid
{
    public partial class LearnGrid
    {
        private bool _hover = true;
        private HashSet<VmUser> _selectedItems = new HashSet<VmUser>();
        private IEnumerable<VmUser> _v_users = new List<VmUser>();

        private MudTable<VmUser> _refTable;


        protected override Task OnInitializedAsync()
        {
            _v_users = new List<VmUser>()
            {
                new VmUser("id1", "pw1", "name1", "phone1", "address1"),
            };
            return base.OnInitializedAsync();
        }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            if(firstRender == true)
            {
                _refTable.ReloadServerData();
            }
            return base.OnAfterRenderAsync(firstRender);
        }
    }
}
