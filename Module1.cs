// Decompiled with JetBrains decompiler
// Type: sms.Module1
// Assembly: sms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FE7413C-F4EA-405E-B2B2-9E574872504B
// Assembly location: C:\Users\Desarrollo 5\AppData\Local\Temp\Migemad\a3777d5204\sms.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Text;

//nullable disable
namespace sms
{
  [StandardModule]
  internal sealed class Module1
  {
    [AccessedThroughProperty("miSerialPort")]
    private static SerialPort _miSerialPort;

    private static SerialPort miSerialPort
    {
      [DebuggerNonUserCode] get => Module1._miSerialPort;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        Module1._miSerialPort = value;
      }
    }

    [STAThread]
    public static void Main()
    {
      try
      {
        string[] commandLineArgs = Environment.GetCommandLineArgs();
        string portName = commandLineArgs[1];
        string str1 = commandLineArgs[2];
        string str2 = (string) null;
        int num = checked (commandLineArgs.Length - 1);
        int index = 3;
        while (index <= num)
        {
          str2 = str2 + " " + commandLineArgs[index];
          checked { ++index; }
        }
        string str3 = str2.Trim();
        Module1.miSerialPort = new SerialPort(portName, 460800, Parity.None, 8, StopBits.One);
        Module1.miSerialPort.Handshake = Handshake.None;
        Module1.miSerialPort.NewLine = "\r\n";
        Module1.miSerialPort.Encoding = Encoding.Default;
        Module1.miSerialPort.Open();
        string str4 = "+503" + str1;
        Module1.miSerialPort.WriteLine("AT");
        Module1.miSerialPort.WriteLine("AT+CMGF=1\r\n");
        Module1.miSerialPort.WriteLine("AT+CMGS=\"" + str4 + "\"\r\n");
        Module1.miSerialPort.WriteLine(str3 + "\r\n\u001A");
        Module1.miSerialPort.Close();
        Console.Write("OK: " + str1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Console.Write(ex.Message);
        ProjectData.ClearProjectError();
      } 

    }
  }
}

//execute the following command
//sms.exe COM3 12345678 "Hello World" 
