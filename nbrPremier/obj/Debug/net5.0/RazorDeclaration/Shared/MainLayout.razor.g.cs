// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace nbrPremier.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/admindsm/Prgs_PO/nbrPremier-master/nbrPremier/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admindsm/Prgs_PO/nbrPremier-master/nbrPremier/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/admindsm/Prgs_PO/nbrPremier-master/nbrPremier/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/admindsm/Prgs_PO/nbrPremier-master/nbrPremier/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/admindsm/Prgs_PO/nbrPremier-master/nbrPremier/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/admindsm/Prgs_PO/nbrPremier-master/nbrPremier/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/admindsm/Prgs_PO/nbrPremier-master/nbrPremier/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/admindsm/Prgs_PO/nbrPremier-master/nbrPremier/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/admindsm/Prgs_PO/nbrPremier-master/nbrPremier/_Imports.razor"
using nbrPremier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/admindsm/Prgs_PO/nbrPremier-master/nbrPremier/_Imports.razor"
using nbrPremier.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/admindsm/Prgs_PO/nbrPremier-master/nbrPremier/Shared/MainLayout.razor"
using nbrPremier.Outils;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "/Users/admindsm/Prgs_PO/nbrPremier-master/nbrPremier/Shared/MainLayout.razor"
      
    private string footerTitre = "@Prem's Copyright 2021";
    private bool premier = false;
    private bool noPremier = false;


    private void onInputPrems(ChangeEventArgs args)
    {
      if (args.Value.ToString() != "")
      {
        int nombre = 0;
        try
        {
          nombre = int.Parse(args.Value.ToString());
        }catch(Exception ex)
        {
          nombre = 4;
        }
        //int nombre = int.Parse(args.Value.ToString());


        int result = NombrePremier.nbrPremier(nombre);
        if (result == 0)
        {
          noPremier = true;
          premier = false;
        }
        if (result == 1)
        {
          noPremier = false;
          premier = true;
        }

      }
      else
      {
        noPremier = false;
        premier = false;
      }
      //registerValidationForm.mail = args.Value.ToString();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
