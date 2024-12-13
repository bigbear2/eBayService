// Decompiled with JetBrains decompiler
// Type: eBay.Service.Util.XmlUtility
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using System.Xml.XPath;


namespace eBay.Service.Util
{
  /// <summary>
  /// 
  /// </summary>
  [ComVisible(false)]
  public class XmlUtility
  {
    internal static IFormatProvider DateFormatProvider = (IFormatProvider) new CultureInfo("en-US");
    internal const string EBAY_TIME_FORMAT = "yyyy'-'MM'-'dd HH':'mm':'ss";
    internal const string EBAY_DATE_FORMAT = "yyyy'-'MM'-'dd";

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Document"></param>
    /// <param name="Parent"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static XmlNode AddChild(XmlDocument Document, XmlNode Parent, string NodeName)
    {
      XmlNode element = (XmlNode) Document.CreateElement(NodeName);
      Parent.AppendChild(element);
      return element;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Document"></param>
    /// <param name="Parent"></param>
    /// <param name="NodeName"></param>
    /// <param name="Data"></param>
    /// <returns></returns>
    public static XmlNode AddChild(
      XmlDocument Document,
      XmlNode Parent,
      string NodeName,
      string Data)
    {
      XmlNode element = (XmlNode) Document.CreateElement(NodeName);
      element.InnerText = Data;
      Parent.AppendChild(element);
      return element;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Document"></param>
    /// <param name="Parent"></param>
    /// <param name="NodeName"></param>
    /// <param name="Data"></param>
    /// <param name="UseCData"></param>
    /// <returns></returns>
    public static XmlNode AddChild(
      XmlDocument Document,
      XmlNode Parent,
      string NodeName,
      string Data,
      bool UseCData)
    {
      XmlNode newChild;
      if (!UseCData)
      {
        newChild = XmlUtility.AddChild(Document, Parent, NodeName, Data);
      }
      else
      {
        newChild = (XmlNode) Document.CreateElement(NodeName);
        XmlNode cdataSection = (XmlNode) Document.CreateCDataSection(Data);
        newChild.AppendChild(cdataSection);
        Parent.AppendChild(newChild);
      }
      return newChild;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Document"></param>
    /// <param name="Parent"></param>
    /// <param name="NodeName"></param>
    /// <param name="Data"></param>
    /// <returns></returns>
    public static XmlNode AddChild(
      XmlDocument Document,
      XmlNode Parent,
      string NodeName,
      bool Data)
    {
      return XmlUtility.AddChild(Document, Parent, NodeName, Data ? "1" : "0");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Document"></param>
    /// <param name="Parent"></param>
    /// <param name="NodeName"></param>
    /// <param name="Data"></param>
    /// <param name="UseDateOnly"></param>
    /// <returns></returns>
    public static XmlNode AddChild(
      XmlDocument Document,
      XmlNode Parent,
      string NodeName,
      DateTime Data,
      bool UseDateOnly)
    {
      return UseDateOnly ? XmlUtility.AddChild(Document, Parent, NodeName, XmlUtility.ToEBayDate(Data)) : XmlUtility.AddChild(Document, Parent, NodeName, XmlUtility.ToEBayTime(Data));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Document"></param>
    /// <param name="Parent"></param>
    /// <param name="NodeName"></param>
    /// <param name="Data"></param>
    /// <returns></returns>
    public static XmlNode AddChild(
      XmlDocument Document,
      XmlNode Parent,
      string NodeName,
      Decimal Data)
    {
      return XmlUtility.AddChild(Document, Parent, NodeName, Data.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Document"></param>
    /// <param name="Parent"></param>
    /// <param name="NodeName"></param>
    /// <param name="Data"></param>
    /// <returns></returns>
    public static XmlNode AddChild(
      XmlDocument Document,
      XmlNode Parent,
      string NodeName,
      double Data)
    {
      return XmlUtility.AddChild(Document, Parent, NodeName, Data.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Document"></param>
    /// <param name="Parent"></param>
    /// <param name="NodeName"></param>
    /// <param name="Data"></param>
    /// <returns></returns>
    public static XmlNode AddChild(
      XmlDocument Document,
      XmlNode Parent,
      string NodeName,
      long Data)
    {
      return XmlUtility.AddChild(Document, Parent, NodeName, Data.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Document"></param>
    /// <param name="Parent"></param>
    /// <param name="AttributeName"></param>
    /// <param name="AttributeValue"></param>
    /// <returns></returns>
    public static XmlNode AddAttributeNode(
      XmlDocument Document,
      XmlNode Parent,
      string AttributeName,
      object AttributeValue)
    {
      XmlAttribute attribute = Document.CreateAttribute(AttributeName);
      attribute.Value = AttributeValue.ToString();
      Parent.Attributes.Append(attribute);
      return (XmlNode) attribute;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static bool GetBoolean(XPathNavigator Navigator, string NodeName)
    {
      string upper = XmlUtility.GetString(Navigator, NodeName).Trim().ToUpper(CultureInfo.InvariantCulture);
      return upper == "1" || upper == "YES" || upper == "TRUE";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="XPath"></param>
    /// <returns></returns>
    public static bool GetBoolean(XPathNavigator Navigator, XPathExpression XPath)
    {
      string upper = XmlUtility.GetString(Navigator, XPath).Trim().ToUpper(CultureInfo.InvariantCulture);
      return upper == "1" || upper == "YES" || upper == "TRUE";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Node"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static bool GetBoolean(XmlNode Node, string NodeName)
    {
      string upper = XmlUtility.GetString(Node, NodeName).Trim().ToUpper(CultureInfo.InvariantCulture);
      return upper == "1" || upper == "YES";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static DateTime GetDateTime(XPathNavigator Navigator, string NodeName)
    {
      DateTime dateTime = new DateTime(0L);
      string Time = XmlUtility.GetString(Navigator, NodeName).Trim();
      if (Time.Length > 0)
      {
        try
        {
          dateTime = XmlUtility.ParseEBayTime(Time);
        }
        catch (ArgumentNullException ex)
        {
        }
        catch (FormatException ex)
        {
        }
      }
      return dateTime;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="XPath"></param>
    /// <returns></returns>
    public static DateTime GetDateTime(XPathNavigator Navigator, XPathExpression XPath)
    {
      DateTime dateTime = new DateTime(0L);
      string Time = XmlUtility.GetString(Navigator, XPath).Trim();
      if (Time.Length > 0)
      {
        try
        {
          dateTime = XmlUtility.ParseEBayTime(Time);
        }
        catch (ArgumentNullException ex)
        {
        }
        catch (FormatException ex)
        {
        }
      }
      return dateTime;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Node"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static DateTime GetDateTime(XmlNode Node, string NodeName)
    {
      DateTime dateTime = new DateTime(0L);
      string Time = XmlUtility.GetString(Node, NodeName).Trim();
      if (Time.Length > 0)
      {
        try
        {
          dateTime = XmlUtility.ParseEBayTime(Time);
        }
        catch (ArgumentNullException ex)
        {
        }
        catch (FormatException ex)
        {
        }
      }
      return dateTime;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static Decimal GetDecimal(XPathNavigator Navigator, string NodeName)
    {
      Decimal num = -1.0M;
      string s = XmlUtility.GetString(Navigator, NodeName).Trim();
      if (s.Length > 0)
      {
        try
        {
          num = Decimal.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        catch (ArgumentNullException ex)
        {
        }
        catch (FormatException ex)
        {
        }
        catch (OverflowException ex)
        {
        }
      }
      return num;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="XPath"></param>
    /// <returns></returns>
    public static Decimal GetDecimal(XPathNavigator Navigator, XPathExpression XPath)
    {
      Decimal num = -1.0M;
      string s = XmlUtility.GetString(Navigator, XPath).Trim();
      if (s.Length > 0)
      {
        try
        {
          num = Decimal.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        catch (ArgumentNullException ex)
        {
        }
        catch (FormatException ex)
        {
        }
        catch (OverflowException ex)
        {
        }
      }
      return num;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Node"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static Decimal GetDecimal(XmlNode Node, string NodeName)
    {
      Decimal num = -1.0M;
      string s = XmlUtility.GetString(Node, NodeName).Trim();
      if (s.Length > 0)
      {
        try
        {
          num = Decimal.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        catch (ArgumentNullException ex)
        {
        }
        catch (FormatException ex)
        {
        }
        catch (OverflowException ex)
        {
        }
      }
      return num;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static double GetDouble(XPathNavigator Navigator, string NodeName)
    {
      double num = -1.0;
      string s = XmlUtility.GetString(Navigator, NodeName).Trim();
      if (s.Length > 0)
      {
        try
        {
          num = double.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        catch (ArgumentNullException ex)
        {
        }
        catch (FormatException ex)
        {
        }
        catch (OverflowException ex)
        {
        }
      }
      return num;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="XPath"></param>
    /// <returns></returns>
    public static double GetDouble(XPathNavigator Navigator, XPathExpression XPath)
    {
      double num = -1.0;
      string s = XmlUtility.GetString(Navigator, XPath).Trim();
      if (s.Length > 0)
      {
        try
        {
          num = double.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        catch (ArgumentNullException ex)
        {
        }
        catch (FormatException ex)
        {
        }
        catch (OverflowException ex)
        {
        }
      }
      return num;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Node"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static double GetDouble(XmlNode Node, string NodeName)
    {
      double num = -1.0;
      string s = XmlUtility.GetString(Node, NodeName).Trim();
      if (s.Length > 0)
      {
        try
        {
          num = double.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        catch (ArgumentNullException ex)
        {
        }
        catch (FormatException ex)
        {
        }
        catch (OverflowException ex)
        {
        }
      }
      return num;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static int GetInteger(XPathNavigator Navigator, string NodeName)
    {
      int integer = -1;
      string s = XmlUtility.GetString(Navigator, NodeName).Trim();
      if (s.Length != 0)
      {
        try
        {
          integer = int.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        catch (ArgumentNullException ex)
        {
        }
        catch (OverflowException ex)
        {
        }
      }
      return integer;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="XPath"></param>
    /// <returns></returns>
    public static int GetInteger(XPathNavigator Navigator, XPathExpression XPath)
    {
      int integer = -1;
      string s = XmlUtility.GetString(Navigator, XPath).Trim();
      if (s.Length != 0)
      {
        try
        {
          integer = int.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        catch (ArgumentNullException ex)
        {
        }
        catch (OverflowException ex)
        {
        }
      }
      return integer;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Node"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static int GetInteger(XmlNode Node, string NodeName)
    {
      int integer = -1;
      string s = XmlUtility.GetString(Node, NodeName).Trim();
      if (s.Length > 0)
      {
        try
        {
          integer = int.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        catch (ArgumentNullException ex)
        {
        }
        catch (OverflowException ex)
        {
        }
      }
      return integer;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static string GetString(XPathNavigator Navigator, string NodeName)
    {
      XPathNodeIterator xpathNodeIterator = Navigator.Select(NodeName);
      return xpathNodeIterator.MoveNext() ? xpathNodeIterator.Current.Value : "";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="XPath"></param>
    /// <returns></returns>
    public static string GetString(XPathNavigator Navigator, XPathExpression XPath)
    {
      XPathNodeIterator xpathNodeIterator = Navigator.Select(XPath);
      return xpathNodeIterator.MoveNext() ? xpathNodeIterator.Current.Value : "";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Node"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static string GetString(XmlNode Node, string NodeName)
    {
      XmlNode xmlNode = Node.SelectSingleNode(NodeName);
      return xmlNode != null ? xmlNode.InnerText : "";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static XmlNode GetChildNode(XPathNavigator Navigator, string NodeName)
    {
      try
      {
        XPathNodeIterator xpathNodeIterator = Navigator.Select(NodeName);
        return xpathNodeIterator.MoveNext() ? ((IHasXmlNode) xpathNodeIterator.Current).GetNode() : (XmlNode) null;
      }
      catch (ArgumentException ex)
      {
        return (XmlNode) null;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="XPath"></param>
    /// <returns></returns>
    public static XmlNode GetChildNode(XPathNavigator Navigator, XPathExpression XPath)
    {
      try
      {
        XPathNodeIterator xpathNodeIterator = Navigator.Select(XPath);
        return xpathNodeIterator.MoveNext() ? ((IHasXmlNode) xpathNodeIterator.Current).GetNode() : (XmlNode) null;
      }
      catch (ArgumentException ex)
      {
        return (XmlNode) null;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Node"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static XmlNode GetChildNode(XmlNode Node, string NodeName)
    {
      return Node.SelectSingleNode(NodeName);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static bool NodeExists(XPathNavigator Navigator, string NodeName)
    {
      return Navigator.Select(NodeName).MoveNext();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Navigator"></param>
    /// <param name="XPath"></param>
    /// <returns></returns>
    public static bool NodeExists(XPathNavigator Navigator, XPathExpression XPath)
    {
      return Navigator.Select(XPath).MoveNext();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Node"></param>
    /// <param name="NodeName"></param>
    /// <returns></returns>
    public static bool NodeExists(XmlNode Node, string NodeName)
    {
      return Node.SelectSingleNode(NodeName) != null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Time"></param>
    /// <returns></returns>
    public static DateTime ParseEBayTime(string Time)
    {
      return DateTime.ParseExact(Time, "yyyy'-'MM'-'dd HH':'mm':'ss", XmlUtility.DateFormatProvider);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Time"></param>
    /// <returns></returns>
    public static string ToEBayTime(DateTime Time)
    {
      return Time.ToString("yyyy'-'MM'-'dd HH':'mm':'ss", XmlUtility.DateFormatProvider);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Date"></param>
    /// <returns></returns>
    public static DateTime ParseEBayDate(string Date)
    {
      return DateTime.ParseExact(Date, "yyyy'-'MM'-'dd", XmlUtility.DateFormatProvider);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Date"></param>
    /// <returns></returns>
    public static string ToEBayDate(DateTime Date)
    {
      return Date.ToString("yyyy'-'MM'-'dd", XmlUtility.DateFormatProvider);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Document"></param>
    /// <param name="writer"></param>
    public static void Display(XmlDocument Document, TextWriter writer)
    {
      MemoryStream w1 = new MemoryStream();
      XmlTextWriter w2 = new XmlTextWriter((Stream) w1, Encoding.GetEncoding(((XmlDeclaration) Document.FirstChild).Encoding));
      w2.Formatting = Formatting.Indented;
      w2.Indentation = 2;
      Document.Save((XmlWriter) w2);
      w2.Flush();
      w1.Position = 0L;
      StreamReader streamReader = new StreamReader((Stream) w1);
      writer.Write(streamReader.ReadToEnd());
    }

    /// <summary>
    /// Returns formatted xml string (indent and newlines) from unformatted XML
    /// </summary>
    /// <param name="sUnformattedXml">Unformatted xml string.</param>
    /// <returns>Formatted xml string and any exceptions that occur.</returns>
    public static string FormatXml(string sUnformattedXml)
    {
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.LoadXml(sUnformattedXml);
      StringBuilder sb = new StringBuilder();
      StringWriter w1 = new StringWriter(sb);
      XmlTextWriter w2 = (XmlTextWriter) null;
      try
      {
        w2 = new XmlTextWriter((TextWriter) w1);
        w2.Formatting = Formatting.Indented;
        xmlDocument.WriteTo((XmlWriter) w2);
      }
      finally
      {
        w2?.Close();
      }
      return sb.ToString();
    }
  }
}
