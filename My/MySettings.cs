// Decompiled with JetBrains decompiler
// Type: sms.My.MySettings
// Assembly: sms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FE7413C-F4EA-405E-B2B2-9E574872504B
// Assembly location: C:\Users\Desarrollo 5\AppData\Local\Temp\Migemad\a3777d5204\sms.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace sms.My
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

    [DebuggerNonUserCode]
    public MySettings()
    {
    }

    public static MySettings Default => MySettings.defaultInstance;
  }
}
