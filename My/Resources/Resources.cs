// Decompiled with JetBrains decompiler
// Type: sms.My.Resources.Resources
// Assembly: sms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FE7413C-F4EA-405E-B2B2-9E574872504B
// Assembly location: C:\Users\Desarrollo 5\AppData\Local\Temp\Migemad\a3777d5204\sms.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace sms.My.Resources
{
  [StandardModule]
  [HideModuleName]
  [CompilerGenerated]
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) sms.My.Resources.Resources.resourceMan, (object) null))
          sms.My.Resources.Resources.resourceMan = new ResourceManager("sms.Resources", typeof (sms.My.Resources.Resources).Assembly);
        return sms.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => sms.My.Resources.Resources.resourceCulture;
      set => sms.My.Resources.Resources.resourceCulture = value;
    }
  }
}
