using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudblazorCustomThemes.MyCustomThemes
{
    public class MyCustomTheme1
    {
        MudTheme theme;
        public MyCustomTheme1()
        {
            {
                theme = new MudTheme()
                {
                    PaletteLight = new PaletteLight()
                    {
                        Primary = Colors.Blue.Default,
                        Secondary = Colors.Green.Accent4,
                        AppbarBackground = Colors.Red.Default,
                    },
                    PaletteDark = new PaletteDark()
                    {
                        Primary = Colors.Blue.Lighten1
                    },

                    LayoutProperties = new LayoutProperties()
                    {
                        DrawerWidthLeft = "260px",
                        DrawerWidthRight = "300px"
                    }
                };
            }
        }
        public MudTheme Get
        {
            get
            {
                return theme;
            }
        }

    }
}

