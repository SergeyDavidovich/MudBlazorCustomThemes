using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MudBlazor;

namespace MudBlazorCustomThemes.BootswatchThemes
{
    public class MudThemeFMudTheme 
    {
        MudTheme Flatly = new MudTheme()
        {
            PaletteLight = new PaletteLight()
            {
                Primary = Colors.Blue.Default,
                Secondary = Colors.Green.Accent4,

                AppbarBackground = new MudBlazor.Utilities.MudColor("rgb(123, 138, 139)"),

            },
            PaletteDark = new PaletteDark()
            {
                Primary = Colors.Blue.Lighten1,
                AppbarBackground = new MudBlazor.Utilities.MudColor("rgb(44, 62, 80)"),
                Background = new MudBlazor.Utilities.MudColor("rgb(33, 37, 41)"),
                TextPrimary = new MudBlazor.Utilities.MudColor("rgb(173, 217, 230)"),
            },

            LayoutProperties = new LayoutProperties()
            {
                DrawerWidthLeft = "260px",
                DrawerWidthRight = "300px"
            }

        };
    }
}
