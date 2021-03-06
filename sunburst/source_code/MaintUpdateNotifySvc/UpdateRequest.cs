﻿// Decompiled with JetBrains decompiler
// Type: SolarWinds.Orion.Core.BusinessLayer.MaintUpdateNotifySvc.UpdateRequest
// Assembly: SolarWinds.Orion.Core.BusinessLayer, Version=2020.2.5300.12432, Culture=neutral, PublicKeyToken=null
// MVID: 8A00C947-7FE8-4638-AFC6-F6694E5CE56E
// Assembly location: Z:\samples\new\4572807326629888\sunburst.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SolarWinds.Orion.Core.BusinessLayer.MaintUpdateNotifySvc
{
  [GeneratedCode("System.Xml", "4.8.3761.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.solarwinds.com/contracts/IMaintUpdateNotifySvc/2009/09")]
  [Serializable]
  public class UpdateRequest : INotifyPropertyChanged
  {
    private string contractVersionField;
    private CustomerEnvironmentInfoPack customerInfoField;

    [XmlElement(Order = 0)]
    public string ContractVersion
    {
      get
      {
        return this.contractVersionField;
      }
      set
      {
        this.contractVersionField = value;
        this.RaisePropertyChanged(nameof (ContractVersion));
      }
    }

    [XmlElement(Order = 1)]
    public CustomerEnvironmentInfoPack CustomerInfo
    {
      get
      {
        return this.customerInfoField;
      }
      set
      {
        this.customerInfoField = value;
        this.RaisePropertyChanged(nameof (CustomerInfo));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
    {
      PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      if (propertyChanged == null)
        return;
      propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
