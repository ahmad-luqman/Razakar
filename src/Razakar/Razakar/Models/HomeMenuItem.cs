using System;
using System.Collections.Generic;
using System.Text;

namespace Razakar.Models
{
    public enum MenuItemType
    {
        Authentication,
        SignUpOrganization,
        SignUpRazakar,
        RequestRazakar,
        Browse,
        About,
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
