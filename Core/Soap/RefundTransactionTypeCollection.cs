﻿// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.RefundTransactionTypeCollection
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.Collections;


namespace eBay.Service.Core.Soap
{
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  public sealed class RefundTransactionTypeCollection : CollectionBase
  {
    /// <summary>
    /// 
    /// </summary>
    public RefundTransactionTypeCollection()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    public RefundTransactionTypeCollection(RefundTransactionType[] items) => this.AddRange(items);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    public RefundTransactionTypeCollection(RefundTransactionTypeCollection items)
    {
      this.AddRange(items);
    }

    /// <summary>
    /// 
    /// </summary>
    public RefundTransactionType this[int index]
    {
      get => (RefundTransactionType) this.InnerList[index];
      set => this.InnerList[index] = (object) value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool IsFixedSize => this.InnerList.IsFixedSize;

    /// <summary>
    /// 
    /// </summary>
    public bool IsReadOnly => this.InnerList.IsReadOnly;

    /// <summary>
    /// 
    /// </summary>
    public bool IsSynchronized => this.InnerList.IsSynchronized;

    /// <summary>
    /// 
    /// </summary>
    public object SyncRoot => this.InnerList.SyncRoot;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public int Add(RefundTransactionType item) => this.InnerList.Add((object) item);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    public void AddRange(RefundTransactionType[] items)
    {
      this.InnerList.AddRange((ICollection) items);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    public void AddRange(RefundTransactionTypeCollection items)
    {
      this.InnerList.AddRange((ICollection) items);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public bool Contains(RefundTransactionType item) => this.InnerList.Contains((object) item);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    /// <param name="index"></param>
    public void CopyTo(RefundTransactionType[] items, int index)
    {
      this.InnerList.CopyTo((Array) items, index);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public int IndexOf(RefundTransactionType item) => this.InnerList.IndexOf((object) item);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    /// <param name="item"></param>
    public void Insert(int index, RefundTransactionType item)
    {
      this.InnerList.Insert(index, (object) item);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public RefundTransactionType ItemAt(int index) => (RefundTransactionType) this.InnerList[index];

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    public void Remove(RefundTransactionType item) => this.InnerList.Remove((object) item);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public RefundTransactionType[] ToArray()
    {
      return (RefundTransactionType[]) this.InnerList.ToArray(typeof (RefundTransactionType));
    }
  }
}