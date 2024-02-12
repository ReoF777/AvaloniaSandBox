using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
namespace AvaSandBox.Models;

public class DataManage
{
    // ===============================================================================
    #region 定数
    // ===============================================================================
    /// <summary>ユーザーデータを保存するファイル名です。</summary>
    private const string DataFilePath = "//Data.xml";
    #endregion (定数)
    
    // ===============================================================================
    #region メンバ変数
    // ===============================================================================
    /// <summary>ユーザー情報を記録する固定長ファイルをデスクトップに保存するためのフォルダのパスを設定します。</summary>
    private readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + DataFilePath;
    /// <summary>ファイルに書き込む文字コードを格納します。</summary>
    private readonly Encoding _enc = Encoding.GetEncoding("utf-8");
    #endregion (メンバ変数)

    public void MakeXmlFile()
    {
        // ファイルの有無確認
        if (!File.Exists(_path))
        {
            using (var fs = File.Create(_path))
            {
            }
        }

        // デモデータクラスでのxmlファイルの書き込み、読み込み
        DemoData demo = new()
        {
            Place = "tokyo",
            Value = 100
        };
        var serializer = new XmlSerializer(typeof(DemoData));
        // 書き込み処理
        // var sw = new StreamWriter(_path, true, new UTF8Encoding());
        // serializer.Serialize(sw, demo);
        // sw.Close();
        // 読み込み処理
        var sr = new StreamReader(_path, new UTF8Encoding());
        DemoData? readDemo = (DemoData)serializer.Deserialize(sr)!;
        sr.Close();
        Console.WriteLine($"{readDemo.Place} and {readDemo.Value}");
        
        
        // // データ作成
        // IBirthData birthData = new UserData(5, 10, 5, "text", "test", 
        //     "string second", "string third");
        // // IFood food = new UserData(5, 10, 5, "text", "test", 
        // //     "string second", "string third");
        // Console.WriteLine($"{birthData.Year} {birthData.Month}");
        //
        // // xmlファイル作成
        // var serializer = new XmlSerializer(typeof(IBirthData));
        // var sw = new StreamWriter(_path, false, Encoding.GetEncoding("utf-8"));
        // serializer.Serialize(sw, birthData);
        // sw.Close();
        
    }
}