using System;
using System.Reactive;
using AvaSandBox.Models;
using ReactiveUI;
namespace AvaSandBox.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    /// <summary>
    /// モデルクラスのインスタンス
    /// </summary>
    private DataManage _dataManage = new DataManage();

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public MainWindowViewModel()
    {
        ClickCommand = ReactiveCommand.Create(Click); // コマンド設定
    }

    
    // ===============================================================================
    #region バインド用コマンド
    // ===============================================================================
    // -------------------------------------------------------------------------------
    #region +Click : 入力している値の符号を反転させるコマンド
    // -------------------------------------------------------------------------------
    private void Click()
    {
        _dataManage.MakeXmlFile();
        Console.WriteLine("Button Click");
    }
    public ReactiveCommand<Unit, Unit> ClickCommand { get; }
    #endregion (Click)
    
    #endregion (バインド用コマンド)
    
    /// <summary>
    /// テスト用変更用通知プロパティ
    /// </summary>
    public string Greeting
    {
        get => _greeting;
        set => this.RaiseAndSetIfChanged(ref _greeting, value);
    }
    private string _greeting = "Hello World";
}