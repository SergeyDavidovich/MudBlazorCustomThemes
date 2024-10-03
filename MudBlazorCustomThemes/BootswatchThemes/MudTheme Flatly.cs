using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MudBlazor;
using MudBlazor.Utilities;
using static MudBlazor.Colors;

// public MudTheme()
// {
//    PaletteLight = new PaletteLight();
//    PaletteDark = new PaletteDark();
//    Shadows = new Shadow();
//    Typography = new Typography();
//    LayoutProperties = new LayoutProperties();
//    ZIndex = new ZIndex();
//    PseudoCss = new PseudoCss();
// }

namespace MudBlazorCustomThemes.BootswatchThemes
{
    //https://bootswatch.com/flatly/
    public class ThemeFlatly 
    {
        MudTheme theme;
        public MudTheme Get => theme;
        public ThemeFlatly()
        {
            {
                // rgb(44, 62, 80)
                theme = new MudTheme()
                {
                    PaletteLight = new PaletteLight()
                    {
                        AppbarBackground = Colors.BlueGray.Lighten1,
                        DrawerBackground = Colors.BlueGray.Darken4,
                        DrawerText = Colors.BlueGray.Lighten5,

                    },
                    PaletteDark = new PaletteDark()
                    {
                        AppbarBackground = "#2c3e50",
                        Background = "002948",
                        DrawerBackground = Colors.BlueGray.Darken4,
                        DrawerText = Colors.BlueGray.Lighten5,
                        TextPrimary = "#dee2e6",

                    },

                    LayoutProperties = new LayoutProperties()
                    {
                        DrawerWidthLeft = "260px",
                        DrawerWidthRight = "300px",
                    }
                };
            }
        }
    }
}
