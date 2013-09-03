using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JDCB_CodeGen
{
    public class SimpleXmlRequestHelper
    {
        public SimpleXmlRequestHelper()
        {
        }

        private string Tabs()
        {
            return new string('\t', tabRepeatCount);
        }

        public static string FixName(string name)
        {

            var tmp = name.Split(new char[] { '_' })
                .Where(s => s.Length > 0)
                .Select(s =>
                {
                    var c = Char.ToUpper(s.First());
                    return c + s.Remove(0, 1);
                }
                )
                .ToArray();

            return string.Join("", tmp);
        }
        Dictionary<string, int> propertyNameCount = new Dictionary<string, int>();
        private int tabRepeatCount = 1;

        public string GetRequestContractsCode(string filePath, string className, String ns)
        {
            IEnumerable<XElement> _allParamsQuery;
            XDocument _core;
            string _className;
            string _baseClassName;

            _core = XDocument.Load(filePath);
            _className = FixName(className);
            _baseClassName = _core.Root.Elements().First().Name.LocalName;
            _allParamsQuery = _core.Root.Descendants()
               .Where(e => e.Name.LocalName == "param");
            var cele = _core.Root.Elements().First().Elements().Where(e => e.Name.LocalName == "Comment").FirstOrDefault();
            string comment = cele == null ? "" : cele.Value;


            var sb = new StringBuilder().AppendLine();
            sb
                .Append(Tabs()).Append("namespace ").AppendLine(ns); ;
            sb
                .Append(Tabs()).AppendLine("{");
            tabRepeatCount++;
            WriteComment(comment, sb);
            sb
                .Append(Tabs()).Append("public class ").Append(_className).Append(" : ").Append(_baseClassName).Append(", INotifyPropertyChanged").AppendLine()
                .Append(Tabs()).AppendLine("{");
            tabRepeatCount++;
            sb
                .Append(Tabs()).Append("public ").Append(_className).Append("()").AppendLine()
                .Append(Tabs()).Append("{").AppendLine();



            sb
                .Append(Tabs()).Append("}").AppendLine().AppendLine();

            sb
                .Append(Tabs()).Append("public event PropertyChangedEventHandler  PropertyChanged ;").AppendLine()
                .AppendLine();

            tabRepeatCount--;


            var result = _allParamsQuery
                .Select(e =>
                    new
                    {
                        Element = e,
                        DataPart = (DataPart)Enum.Parse(typeof(DataPart), e.Parent.Name.LocalName, true),
                        PropertyType = (PropertyType)Enum.Parse(typeof(PropertyType), e.Attribute("type").Value, true),
                        Name = e.Attribute("key").Value,
                        CommentElement = e.Elements().Where(el => el.Name.LocalName == "Comment").FirstOrDefault()

                    })
                .ToList();

            result.ForEach(
                    itm =>
                    {
                        string cmt = "";
                        if (itm.CommentElement != null)
                        {
                            cmt = itm.CommentElement.Value;
                        }
                        WriteProperty(itm.Name, itm.PropertyType, itm.DataPart, sb, cmt);
                    }
                );

            sb
                .Append(Tabs()).AppendLine("}");

            tabRepeatCount--;
            sb
                .Append(Tabs()).AppendLine("}");
            return sb.ToString();
        }




        static Dictionary<DataPart, string> pathDic = new Dictionary<DataPart, string> 
	{ 
		{ DataPart.Query,"RequestData.QueryStringValues" },
		{ DataPart.Post,"RequestData.PostFieldValues" },
		{ DataPart.Header,"RequestData.HeaderValues" },
		{ DataPart.File,"RequestData.UploadFiles" },
		{ DataPart.URLTemplate,"RequestData.UrlTemplateValues" }
		};
        private void WriteComment(string comment, StringBuilder sb)
        {
            sb
            .Append(Tabs())
                .Append("/// <summary>1").AppendLine();

            comment.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(
                    line =>
                    sb
                    .Append(Tabs())
                        .Append("/// ").Append(line.Trim()).AppendLine()

                );
            sb
                .Append(Tabs())
                    .Append("/// </summary>").AppendLine();

        }
        private void WriteProperty(string name, PropertyType type, DataPart part, StringBuilder sb, string comment)
        {
            int count = 0;
            var propertyName = FixName(name);
            propertyNameCount.TryGetValue(propertyName, out count);
            count++;
            propertyNameCount[propertyName] = count;

            if (count > 1)
            {
                propertyName = propertyName + "_" + (count - 1).ToString();
            }

            var forceSingle = (part == DataPart.File) || (part == DataPart.URLTemplate);
            tabRepeatCount++;
            var pathString = pathDic[part];
            var typeString = part == DataPart.File ? "FileUploadInfo" : "string";

            WriteComment(comment, sb);
            sb
               .Append(Tabs())
                   .Append("public ")
                   .Append(type == PropertyType.List && (!forceSingle) ? "List<" : "")
                   .Append(typeString)
                   .Append(type == PropertyType.List && (!forceSingle) ? ">" : "")
                   .Append(" ")
                   .Append(propertyName)
                   .AppendLine()
               .Append(Tabs())
                   .Append("{ ")
                   .AppendLine();
            tabRepeatCount++;
            sb
               .Append(Tabs())
                   .Append("get { return ")
                   .Append(pathString)
                   .Append(".ContainsKey(\"").Append(name).Append("\")")
                   .Append(" ? ")
                   .Append(pathString)
                   .Append("[\"").Append(name).Append("\"]")
                   .Append((type == PropertyType.List) || (forceSingle) ? "" : ".FirstOrDefault()")
                   .Append(" : ")
                   .Append("null;")
                   .Append(" }")
                   .AppendLine();
            sb
                .Append(Tabs())
                   .Append("set")
                   .AppendLine()
                .Append(Tabs())
                    .Append("{")
                    .AppendLine();

            tabRepeatCount++;

            if (type == PropertyType.Single && !forceSingle)
            {

                sb
                    .Append(Tabs())
                        .Append("var oldv=")
                        .Append(propertyName)
                        .Append(";")
                        .AppendLine()
                    .Append(Tabs())
                        .Append("var target = ")
                        .Append(pathString)
                        .Append(".ContainsKey(\"").Append(name).Append("\")")
                        .Append(" ? ")
                        .Append(pathString)
                        .Append("[\"").Append(name).Append("\"]")
                        .Append(" : ")
                        .Append("new List<string> ()")
                        .Append(" ;")
                        .AppendLine()
                    .Append(Tabs())
                        .Append("target.Clear();")
                        .AppendLine()
                    .Append(Tabs())
                        .Append("target.Add(value);")
                        .AppendLine()
                    .Append(Tabs())
                        .Append(pathString)
                        .Append("[\"").Append(name).Append("\"]")
                        .Append(" = target;")
                        .AppendLine()
                    .Append(Tabs())
                        .Append("if")
                        .Append("(").Append(" PropertyChanged !=null && oldv!=value").Append(")")
                        .Append("PropertyChanged(this , new PropertyChangedEventArgs(\"")
                        .Append(propertyName)
                        .Append("\"));")
                        .AppendLine();


            }
            else
            {

                sb
                  .Append(Tabs())
                      .Append(pathString)
                      .Append("[\"").Append(name).Append("\"]")
                      .Append(" = value;")
                      .AppendLine()
                  .Append(Tabs())
                        .Append("if")
                        .Append("(").Append(" PropertyChanged !=null ").Append(")")
                        .Append("PropertyChanged(this , new PropertyChangedEventArgs(\"")
                        .Append(propertyName)
                        .Append("\"));")
                        .AppendLine();
            }
            tabRepeatCount--;
            sb
                .Append(Tabs())
                    .Append("}")
                    .AppendLine();
            tabRepeatCount--;
            sb
           .Append(Tabs())
               .Append("}")
               .AppendLine();



            tabRepeatCount--;
        }



    }
    enum PropertyType
    {
        Single,
        List
    }

    enum DataPart
    {
        Header,
        Query,
        Post,
        File,
        URLTemplate

    }
}
