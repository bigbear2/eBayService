// Decompiled with JetBrains decompiler
// Type: eBay.Service.Util.AttributeHelper
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Soap;
using System.Collections;


namespace eBay.Service.Util
{
  /// <summary>Helper class for attributes.</summary>
  public abstract class AttributeHelper
  {
    /// <summary>Find an attribute node.</summary>
    /// <param name="ast"></param>
    /// <param name="attributeID"></param>
    /// <returns></returns>
    public static AttributeType FindAttribute(AttributeSetType ast, int attributeID)
    {
      foreach (AttributeType attribute in (CollectionBase) ast.Attribute)
      {
        if (attribute.attributeID == attributeID)
          return attribute;
      }
      return (AttributeType) null;
    }

    /// <summary>
    /// Insert an attribute node to AttributeSetType or update the existing attribute node.
    /// </summary>
    /// <param name="ast"></param>
    /// <param name="attributeID"></param>
    /// <param name="valueID"></param>
    /// <param name="valStr"></param>
    public static void InsertToAttributeSet(
      AttributeSetType ast,
      int attributeID,
      int valueID,
      string valStr)
    {
      AttributeType attributeType = AttributeHelper.FindAttribute(ast, attributeID);
      if (attributeType == null)
      {
        attributeType = new AttributeType();
        attributeType.attributeID = attributeID;
        ast.Attribute.Add(attributeType);
      }
      ValType valType = new ValType();
      valType.ValueID = valueID;
      valType.ValueLiteral = valStr;
      attributeType.Value = new ValTypeCollection();
      attributeType.Value.Add(valType);
    }

    /// <summary>Get the first ValueLiteral of an attribute node.</summary>
    /// <param name="ast"></param>
    /// <param name="attributeID"></param>
    /// <returns></returns>
    public static string GetValueLiteral(AttributeSetType ast, int attributeID)
    {
      AttributeType attribute = AttributeHelper.FindAttribute(ast, attributeID);
      return attribute != null && attribute.Value != null && attribute.Value.Count > 0 ? attribute.Value[0].ValueLiteral : (string) null;
    }

    /// <summary>Get the first ValueID of an attribute node.</summary>
    /// <param name="ast"></param>
    /// <param name="attributeID"></param>
    /// <returns></returns>
    public static int GetValueID(AttributeSetType ast, int attributeID)
    {
      AttributeType attribute = AttributeHelper.FindAttribute(ast, attributeID);
      return attribute != null && attribute.Value != null && attribute.Value.Count > 0 ? attribute.Value[0].ValueID : 0;
    }

    /// <summary>Remove an attribute from the AttributeSetType object.</summary>
    /// <param name="ast"></param>
    /// <param name="attributeID"></param>
    /// <returns>True means the attribute has been found and removed.</returns>
    public static bool RemoveAttribute(AttributeSetType ast, int attributeID)
    {
      AttributeType attribute = AttributeHelper.FindAttribute(ast, attributeID);
      if (attribute == null)
        return false;
      ast.Attribute.Remove(attribute);
      return true;
    }
  }
}
