﻿// Decompiled with JetBrains decompiler
// Type: JuicyChicken.YieldInstruction
// Assembly: Chicken2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A3CF9AB0-735E-4893-A3F9-5337EA664FC9
// Assembly location: C:\Users\Admin\Desktop\RE\ChickWinx64\Chicken2.dll

#nullable disable
namespace JuicyChicken
{
  public abstract class YieldInstruction
  {
    public bool IsDone { get; protected set; }

    public virtual void Start() => this.IsDone = false;

    public virtual void Update()
    {
    }
  }
}