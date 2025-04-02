using System.Collections.Generic;

public class CsharpPractice
{
    public int Add(int a , int b)
    {
        return a + b;
    }

    private Dictionary<string , string> localizationTexts = new Dictionary<string , string>()
    {
        { "Apple" , "蘋果" } , { "Banana" , "香蕉" } ,
    };

    public string GetLocalizationText(string key)
    {
        // if (language == "中文")
        // {
        //     if (key == "Apple")
        //     {
        //         return "蘋果";
        //     }
        // }
        var value = localizationTexts[key];
        return value;
        // return "";
    }
}