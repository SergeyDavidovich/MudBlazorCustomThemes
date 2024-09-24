using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MudBlazor;

namespace MudBlazorCustomThemes.BootswatchThemes
{
    public class ThemeFlatly
    {
        MudTheme theme;
        public MudTheme Get => theme;
        public ThemeFlatly()
        {
            {
                theme = new MudTheme()
                {
                    PaletteLight = new PaletteLight()
                    {
                        Primary = Colors.Blue.Default,
                        Secondary = Colors.Green.Accent4,
                        AppbarBackground = Colors.Green.Default
                    },
                    PaletteDark = new PaletteDark()
                    {
                        Primary = Colors.Blue.Lighten1,
                        AppbarBackground = Colors.BlueGray.Darken3
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
