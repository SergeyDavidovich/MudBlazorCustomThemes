using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MudBlazor;
using MudBlazor.Utilities;

namespace MudBlazorCustomThemes.BootswatchThemes
{
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
                        Primary = Colors.Blue.Default,
                        Secondary = Colors.Green.Accent4,
                        AppbarBackground = "#7b8a8b"
                    },
                    PaletteDark = new PaletteDark()
                    {
                        Primary = Colors.Blue.Lighten1,
                        AppbarBackground =  "#2c3e50",
                        Background = "#212529",
                        TextPrimary= "#dee2e6"

                    },

                    LayoutProperties = new LayoutProperties()
                    {
                        DrawerWidthLeft = "260px",
                        DrawerWidthRight = "300px"
                    }
                };
            }
        }
    }
}
