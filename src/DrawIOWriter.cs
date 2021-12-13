using System;
using System.Xml;

namespace DrawIOFromCode;

public class DrawIOWriter
{
    public DrawIOWriter()
    {
    }

    public XmlWriter WriteHeader(string fileName)
    {
        var settings = new XmlWriterSettings() { Indent = true };
        var xw = XmlWriter.Create(fileName, settings);
        WriteStartFile(xw);
        WriteStartDiagram(xw);
        WriteStartGraphModel(xw);

        xw.WriteStartElement("root");

        xw.WriteStartElement("mxCell");
        xw.WriteAttributeString("id", "0");
        xw.WriteEndElement();

        xw.WriteStartElement("mxCell");
        xw.WriteAttributeString("id", "1");
        xw.WriteAttributeString("parent", "0");
        xw.WriteEndElement();
        return xw;
    }

    public void WriteFooter(XmlWriter xw)
    {
        xw.WriteEndElement();
        xw.WriteEndElement();
        xw.WriteEndElement();
        xw.WriteEndElement();
        xw.Flush();
    }

    public void WriteStartFile(XmlWriter xw)
    {
        xw.WriteStartElement("mxfile");
        xw.WriteAttributeString("host", "65bd71144e");
    }

    public void WriteStartDiagram(XmlWriter xw)
    {
        xw.WriteStartElement("diagram");
        xw.WriteAttributeString("id", "WBtnvRxhtW3SN2imph_D");
        xw.WriteAttributeString("name", "Page1");
    }

    public void WriteStartGraphModel(XmlWriter xw)
    {
        xw.WriteStartElement("mxGraphModel");
        xw.WriteAttributeString("dx", "684");
        xw.WriteAttributeString("dy", "424");
        xw.WriteAttributeString("grid", "1");
        xw.WriteAttributeString("gridSize", "10");
        xw.WriteAttributeString("guides", "1");
        xw.WriteAttributeString("tooltips", "1");
        xw.WriteAttributeString("connect", "1");
        xw.WriteAttributeString("arrows", "1");
        xw.WriteAttributeString("fold", "1");
        xw.WriteAttributeString("page", "1");
        xw.WriteAttributeString("pageScale", "1");
        xw.WriteAttributeString("pageWidth", "827");
        xw.WriteAttributeString("pageHeight", "1169");
        xw.WriteAttributeString("math", "0");
        xw.WriteAttributeString("shadow", "0");
    }

    public void AddClass(XmlWriter xw, int id, string name, int x, int y)
    {
        xw.WriteStartElement("mxCell");
        xw.WriteAttributeString("id", id.ToString());
        xw.WriteAttributeString("value", $@"<p style=""margin:0px;margin-top:4px;text-align:center;""><b>{name}</b></p><hr size=""1""/><lt><div style=""height:2px;""></div>");
        xw.WriteAttributeString("style", "verticalAlign=top;align=left;overflow=fill;fontSize=12;fontFamily=Helvetica;html=1;");
        xw.WriteAttributeString("vertex", "1");
        xw.WriteAttributeString("parent", "1");
        xw.WriteStartElement("mxGeometry");
        //xw.WriteAttributeString("x", x.ToString());
        //xw.WriteAttributeString("y", y.ToString());
        xw.WriteAttributeString("width", "140");
        xw.WriteAttributeString("height", "60");
        xw.WriteAttributeString("as", "geometry");
        xw.WriteEndElement();
        xw.WriteEndElement();
    }

    public void AddLine(XmlWriter xw, int id, int source, int target)
    {
        xw.WriteStartElement("mxCell");
        xw.WriteAttributeString("id", id.ToString());
        //xw.WriteAttributeString("style", "edgeStyle=none;html=1;exitX=0.5;exitY=0;exitDx=0;exitDy=0;entryX=0.5;entryY=1;entryDx=0;entryDy=0;");
        xw.WriteAttributeString("style", "edgeStyle=none;html=1;");//endArrow=block;endFill=0;
        xw.WriteAttributeString("edge", "1");
        xw.WriteAttributeString("parent", "1");
        xw.WriteAttributeString("source", source.ToString());
        xw.WriteAttributeString("target", target.ToString());
        xw.WriteStartElement("mxGeometry");
        xw.WriteAttributeString("relative", "1");
        xw.WriteAttributeString("as", "geometry");
        xw.WriteEndElement();
        xw.WriteEndElement();
    }

    public void Inherits(XmlWriter xw, int id, int source, int inheritsFrom)
    {
        xw.WriteStartElement("mxCell");
        xw.WriteAttributeString("id", id.ToString());
        //xw.WriteAttributeString("style", "edgeStyle=none;html=1;exitX=0.5;exitY=0;exitDx=0;exitDy=0;entryX=0.5;entryY=1;entryDx=0;entryDy=0;");
        xw.WriteAttributeString("style", "edgeStyle=orthogonalEdgeStyle;html=1;entryX=0.5;entryY=1;entryDx=0;entryDy=0;");
        xw.WriteAttributeString("edge", "1");
        xw.WriteAttributeString("parent", "1");
        xw.WriteAttributeString("source", source.ToString());
        xw.WriteAttributeString("target", inheritsFrom.ToString());
        xw.WriteStartElement("mxGeometry");
        xw.WriteAttributeString("relative", "1");
        xw.WriteAttributeString("as", "geometry");
        xw.WriteEndElement();
        xw.WriteEndElement();
    }
}
