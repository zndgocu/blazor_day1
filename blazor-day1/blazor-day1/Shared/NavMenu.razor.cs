using ClassExtension.Nav;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_day1.Shared
{
    public partial class NavMenu
    {
        private List<NavMenuItem> _menus;

        protected override Task OnInitializedAsync()
        {
            _menus = new List<NavMenuItem>();
            _menus.Add(NavMenuItem.CreateNavItem("day1-grid", "/day1-grid/learn-grid"));
            return base.OnInitializedAsync();
        }


        // <MudNavGroup Title="Settings" Expanded="true">
        //     <MudNavLink Href="/users">Users</MudNavLink>
        //     <MudNavLink Href="/security">Security</MudNavLink>
        // </MudNavGroup>
        // <MudNavLink Href="/about">About</MudNavLink>
    }
}
