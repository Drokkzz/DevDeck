using MudBlazor;

namespace DevDeck.App.Theme;

public static class ThemeConfiguration
{
    private static readonly Typography DefaultTypography = new Typography
    {
        Default = new DefaultTypography
        {
            FontFamily = new[] { "Inter", "Helvetica", "Arial", "sans-serif" }
        }
    };

    public static MudTheme DarkTheme => new MudTheme
    {
        Typography = DefaultTypography,
        PaletteDark = new PaletteDark
        {
            Primary = "#7267ef",
            Secondary = "#ff4081",
            AppbarBackground = "#1E1E2D",
            Background = "#1A1A27",
            DrawerBackground = "#1E1E2D",
            DrawerText = "rgba(255,255,255,0.50)",
            Surface = "#1E1E2D",
            TextPrimary = "rgba(255,255,255,0.70)",
            TextSecondary = "rgba(255,255,255,0.50)",
            AppbarText = "rgba(255,255,255,0.70)",
            ActionDefault = "#74718E",
            Success = "#00c853"
        }
    };

    public static MudTheme LightTheme => new MudTheme
    {
        Typography = DefaultTypography,
        PaletteDark = new PaletteDark
        {
            Primary = "#594AE2",
            Secondary = "#ff4081",
            AppbarBackground = "#594AE2",
            Background = "#F2F3F9",
            DrawerBackground = "#FFF",
            DrawerText = "rgba(0,0,0,0.7)",
            Surface = "#FFF",
            TextPrimary = "rgba(0,0,0,0.70)",
            TextSecondary = "rgba(0,0,0,0.50)",
            AppbarText = "#FFF",
            Success = "#007E33"
        }
    };
}