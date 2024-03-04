using System.Drawing;

namespace Blazr.ColorPicker;

public class ColorHelper
{
    private static List<string>? _colors;
    public static IEnumerable<string> DefaultPalette => _colors ?? GetDefaultPalette();

    public static bool IsColor(string? htmlColor, out Color color)
    {
        color = new();

        if (htmlColor is null)
            return false;

        try
        {
            var obj = new ColorConverter().ConvertFromString(htmlColor);
            color = (Color)obj!;
            return obj is Color;
        }
        catch
        {
            return false;
        }
    }

    public static bool IsColor(string? htmlColor)
    {
        if (htmlColor is null)
            return false;

        var obj = new ColorConverter().ConvertFromString(htmlColor);
        return obj is Color;
    }

    private static IEnumerable<string> GetDefaultPalette()
    {
        _colors = new();
        //The default _colors
        // Red
        _colors.Add("#FFE4E9");
        _colors.Add("#FFCDD2");
        _colors.Add("#EE9A9A");
        _colors.Add("#E57373");
        _colors.Add("#EE534F");
        _colors.Add("#F44236");
        _colors.Add("#E53935");
        _colors.Add("#C9342D");
        _colors.Add("#C62827");
        _colors.Add("#B61C1C");
        // Rose
        _colors.Add("#FFD2E7");
        _colors.Add("#F9BBD0");
        _colors.Add("#F48FB1");
        _colors.Add("#F06292");
        _colors.Add("#EC407A");
        _colors.Add("#EA1E63");
        _colors.Add("#D81A60");
        _colors.Add("#C2175B");
        _colors.Add("#AD1457");
        _colors.Add("#890E4F");
        //Mauve
        _colors.Add("#F8D5FF");
        _colors.Add("#E1BEE8");
        _colors.Add("#CF93D9");
        _colors.Add("#B968C7");
        _colors.Add("#AA47BC");
        _colors.Add("#9C28B1");
        _colors.Add("#8E24AA");
        _colors.Add("#7A1FA2");
        _colors.Add("#6A1B9A");
        _colors.Add("#4A148C");
        //Violet
        _colors.Add("#E7DBFF");
        _colors.Add("#D0C4E8");
        _colors.Add("#B39DDB");
        _colors.Add("#9675CE");
        _colors.Add("#7E57C2");
        _colors.Add("#673BB7");
        _colors.Add("#5D35B0");
        _colors.Add("#512DA7");
        _colors.Add("#45289F");
        _colors.Add("#301B92");
        //Bleu foncé
        _colors.Add("#DCE1FF");
        _colors.Add("#C5CAE8");
        _colors.Add("#9EA8DB");
        _colors.Add("#7986CC");
        _colors.Add("#5C6BC0");
        _colors.Add("#3F51B5");
        _colors.Add("#3949AB");
        _colors.Add("#303E9F");
        _colors.Add("#283593");
        _colors.Add("#1A237E");
        //Bleu
        _colors.Add("#D2F5FF");
        _colors.Add("#BBDEFA");
        _colors.Add("#90CAF8");
        _colors.Add("#64B5F6");
        _colors.Add("#42A5F6");
        _colors.Add("#2196F3");
        _colors.Add("#1D89E4");
        _colors.Add("#1976D3");
        _colors.Add("#1564C0");
        _colors.Add("#0E47A1");
        //Cyan
        _colors.Add("#CAFCFF");
        _colors.Add("#B3E5FC");
        _colors.Add("#81D5FA");
        _colors.Add("#4FC2F8");
        _colors.Add("#28B6F6");
        _colors.Add("#03A9F5");
        _colors.Add("#039BE6");
        _colors.Add("#0288D1");
        _colors.Add("#0277BD");
        _colors.Add("#00579C");
        // Bleu-Vert
        _colors.Add("#C9FFFF");
        _colors.Add("#B2EBF2");
        _colors.Add("#80DEEA");
        _colors.Add("#4DD0E2");
        _colors.Add("#25C6DA");
        _colors.Add("#00BCD5");
        _colors.Add("#00ACC2");
        _colors.Add("#0098A6");
        _colors.Add("#00828F");
        _colors.Add("#016064");
        //Bleu-vert foncé
        _colors.Add("#C9F6F3");
        _colors.Add("#B2DFDC");
        _colors.Add("#80CBC4");
        _colors.Add("#4CB6AC");
        _colors.Add("#26A59A");
        _colors.Add("#009788");
        _colors.Add("#00887A");
        _colors.Add("#00796A");
        _colors.Add("#00695B");
        _colors.Add("#004C3F");
        //Vert
        _colors.Add("#DFFDE1");
        _colors.Add("#C8E6CA");
        _colors.Add("#A5D6A7");
        _colors.Add("#80C783");
        _colors.Add("#66BB6A");
        _colors.Add("#4CB050");
        _colors.Add("#43A047");
        _colors.Add("#398E3D");
        _colors.Add("#2F7D32");
        _colors.Add("#1C5E20");
        //Green-Yellow
        _colors.Add("#F4FFDF");
        _colors.Add("#DDEDC8");
        _colors.Add("#C5E1A6");
        _colors.Add("#AED582");
        _colors.Add("#9CCC66");
        _colors.Add("#8BC24A");
        _colors.Add("#7DB343");
        _colors.Add("#689F39");
        _colors.Add("#548B2E");
        _colors.Add("#33691E");
        //Green-Yellow-Light
        _colors.Add("#FFFFD9");
        _colors.Add("#F0F4C2");
        _colors.Add("#E6EE9B");
        _colors.Add("#DDE776");
        _colors.Add("#D4E056");
        _colors.Add("#CDDC39");
        _colors.Add("#C0CA33");
        _colors.Add("#B0B42B");
        _colors.Add("#9E9E24");
        _colors.Add("#817716");
        //Yellow
        _colors.Add("#FFFFDA");
        _colors.Add("#FFFAC3");
        _colors.Add("#FFF59C");
        _colors.Add("#FFF176");
        _colors.Add("#FFEE58");
        _colors.Add("#FFEB3C");
        _colors.Add("#FDD734");
        _colors.Add("#FAC02E");
        _colors.Add("#F9A825");
        _colors.Add("#F47F16");
        //Yellow-Orange
        _colors.Add("#FFFFC9");
        _colors.Add("#FFECB2");
        _colors.Add("#FFE083");
        _colors.Add("#FFD54F");
        _colors.Add("#FFC928");
        _colors.Add("#FEC107");
        _colors.Add("#FFB200");
        _colors.Add("#FF9F00");
        _colors.Add("#FF8E01");
        _colors.Add("#FF6F00");
        // Orange
        _colors.Add("#FFF7C9");
        _colors.Add("#FFE0B2");
        _colors.Add("#FFCC80");
        _colors.Add("#FFB64D");
        _colors.Add("#FFA827");
        _colors.Add("#FF9700");
        _colors.Add("#FB8C00");
        _colors.Add("#F67C01");
        _colors.Add("#EF6C00");
        _colors.Add("#E65100");
        //Orange Dark
        _colors.Add("#FFE3D2");
        _colors.Add("#FFCCBB");
        _colors.Add("#FFAB91");
        _colors.Add("#FF8A66");
        _colors.Add("#FF7143");
        _colors.Add("#FE5722");
        _colors.Add("#F5511E");
        _colors.Add("#E64A19");
        _colors.Add("#D74315");
        _colors.Add("#BF360C");
        //Marron
        _colors.Add("#EEE3DF");
        _colors.Add("#D7CCC8");
        _colors.Add("#BCABA4");
        _colors.Add("#A0887E");
        _colors.Add("#8C6E63");
        _colors.Add("#7B5347");
        _colors.Add("#6D4D42");
        _colors.Add("#5D4038");
        _colors.Add("#4D342F");
        _colors.Add("#3E2622");
        //Grey
        _colors.Add("#FFFFFF");
        _colors.Add("#F5F5F5");
        _colors.Add("#EEEEEE");
        _colors.Add("#E0E0E0");
        _colors.Add("#BDBDBD");
        _colors.Add("#9E9E9E");
        _colors.Add("#757575");
        _colors.Add("#616161");
        _colors.Add("#424242");
        _colors.Add("#212121");
        //Bleu gris
        _colors.Add("#E5F0F4");
        _colors.Add("#CED9DD");
        _colors.Add("#B0BFC6");
        _colors.Add("#90A4AD");
        _colors.Add("#798F9A");
        _colors.Add("#607D8B");
        _colors.Add("#546F7A");
        _colors.Add("#465A65");
        _colors.Add("#36474F");
        _colors.Add("#273238");

        return _colors.AsEnumerable();
    }
}
