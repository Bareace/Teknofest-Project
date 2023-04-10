using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class kayıt : MonoBehaviour
{

private string filePath;

    // Update is called once per frame
    void Update()
    {
        
    }
    

public void Start()
{
    

}
public void SaveToTexta()
{
    filePath = @"C:\Users\baris\OneDrive\Masaüstü\choices.txt";

    // FileStream nesnesi oluşturuluyor.
    using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
    {
        // StreamWriter nesnesi oluşturuluyor.
        using (StreamWriter sw = new StreamWriter(fs))
        {
            // Veri dosyaya yazılıyor.
            sw.Write("a,");
            sw.Close();
        }

    }
    
}
public void SaveToTextb()
{
    // Seçim text dosyasına b yazılıyor.
    filePath = @"C:\Users\baris\OneDrive\Masaüstü\choices.txt";

    // FileStream nesnesi oluşturuluyor.
    using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
    {
        // StreamWriter nesnesi oluşturuluyor.
        using (StreamWriter sw = new StreamWriter(fs))
        {
            // Veri dosyaya yazılıyor.
            sw.Write("b,");
            sw.Close();
        }

    }
    
    
}
}
