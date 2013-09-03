using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Json;
using System.Linq;
using System.Text;

namespace JDCB_CodeGen
{
    public class SimpleJsonToDataContractHelper
    {

        public class ClassDefiniation
        {
            public ClassDefiniation(string propertyName, JsonValue jValue, StringBuilder sb, string classHeadser)
            {
                PropertyName = propertyName;
                JValue = jValue;
                StringBuilder = sb;
                ClassHeader = classHeadser;
            }
            public string PropertyName { get; set; }
            public JsonValue JValue { get; set; }
            public StringBuilder StringBuilder { get; set; }
            public string ClassHeader { get; set; }
        }

        private int tabRepeatCount = 1;
        private string Tabs()
        {
            return new string('\t', tabRepeatCount);
        }
        public string GetDataContract(Stream jsonStream, string classHeader , string namespaceString)
        {

            var value = System.Json.JsonObject.Load(jsonStream);
            var sb = new StringBuilder();

            sb
            .Append(Tabs())
            .Append("namespace ")
            .Append(namespaceString)
            .AppendLine();
            sb
              .Append(Tabs())
              .AppendLine("{")
              .AppendLine();
            tabRepeatCount++;

            var lst = VisitJsonValue("", value, sb, classHeader).ToList();

            foreach (var item in lst)
            {
                DefineObject(item.PropertyName, item.JValue, item.StringBuilder, item.ClassHeader);
            }
            tabRepeatCount--;

            sb
             .Append(Tabs())
             .AppendLine("}")
             .AppendLine();

            return sb.ToString();
        }
        Dictionary<JsonType, string> typedic
            = new Dictionary<JsonType, string>()
			{
				{ JsonType.Number, "double"},
				{ JsonType.String, "string"},
				{ JsonType.Boolean,"bool"}
			};
        IEnumerable<ClassDefiniation> VisitJsonValue(string propertyName, JsonValue jvalue, StringBuilder sb, string classHeader)
        {
            if (jvalue == null)
            {

                DefineProperty(propertyName, sb, "object");
                return Enumerable.Empty<ClassDefiniation>();
            }



            switch (jvalue.JsonType)
            {
                case JsonType.Array:
                    return VisitArray(propertyName, jvalue, sb, classHeader);


                case JsonType.Object:
                    return VisitObject(propertyName, jvalue, sb, classHeader);


                default:
                    return VisitDefault(propertyName, jvalue, sb);

            }



        }

        private IEnumerable<ClassDefiniation> VisitDefault(string propertyName, JsonValue jvalue, StringBuilder sb)
        {

            var tpname = typedic[jvalue.JsonType];
            DefineProperty(propertyName, sb, tpname);
            return Enumerable.Empty<ClassDefiniation>();
        }

        private IEnumerable<ClassDefiniation> VisitObject(string propertyName, JsonValue jvalue, StringBuilder sb, string classHeader)
        {

            var typeName = classHeader;
            if (!string.IsNullOrEmpty(propertyName))
            {
                typeName = propertyName+"Type";
                DefineProperty(propertyName, sb, propertyName+"Type");
                yield return new ClassDefiniation(propertyName, jvalue, sb, typeName);
            }
            else
            {

                propertyName = typeName;
                yield return new ClassDefiniation(propertyName, jvalue, sb, propertyName);
            }
            //DefineObject(propertyName, jvalue, sb, typeName);
            

        }

        private IEnumerable<ClassDefiniation> VisitArray(string propertyName, JsonValue jvalue, StringBuilder sb, string classHeader)
        {
            var j = jvalue as JsonArray;
            if (j.Count > 0)
            {
                var fv = j.First();
                var fbak = fv;
                string subTypeName;

                int arraymarks = 1;

                while (fbak.JsonType == JsonType.Array)
                {
                    arraymarks++;
                    var va = (fbak as JsonArray);
                    fbak = va.FirstOrDefault();
                    if (fbak == null) break;
                }

                var marks = string.Join("", string.Concat(Enumerable.Repeat("[]", arraymarks).ToArray()));
                if (fbak == null)
                {
                    subTypeName = "object";
                }
                else if (fbak.JsonType == JsonType.Object)
                {



                    if (string.IsNullOrEmpty(propertyName))
                    {
                        subTypeName = classHeader + "_" + propertyName + "_ArrayItem";
                        yield return new ClassDefiniation("", fbak, sb, subTypeName);
                        //DefineObject("", null, sb, classHeader + "_" + propertyName + " : List<" + subTypeName + ">");
                        yield return new ClassDefiniation("", null, sb, classHeader + "_" + propertyName + " : ObservableCollection<" + subTypeName + ">");
                    }
                    else
                    {
                        subTypeName = propertyName + "_ArrayItem";
                        yield return new ClassDefiniation("", fbak, sb, subTypeName);
                        DefineProperty(propertyName, sb, subTypeName + marks);
                    }

                }
                else
                {
                    subTypeName = typedic[fbak.JsonType];
                    if (string.IsNullOrEmpty(propertyName))
                    {
                        //DefineObject("", null, sb, classHeader + "_" + propertyName + " : List<" + subTypeName + ">");
                        yield return new ClassDefiniation("", null, sb, classHeader + "_" + propertyName + " : ObservableCollection<" + subTypeName + ">");
                    }
                    else
                    {

                        DefineProperty(propertyName, sb, subTypeName + marks);
                    }
                }
            }
            else
            {
                DefineProperty(propertyName, sb, "object[]");
            }
        }


        private void DefineObject(string propertyName, JsonValue jvalue, StringBuilder sb, string typeName)
        {
            var lst = new List<ClassDefiniation>();
            var isCollection = typeName.Contains("ObservableCollection<");
            if (isCollection)
            {
                sb
                    .Append(Tabs()).Append("[CollectionDataContract]").AppendLine();
            }
            else
            {
                sb
                    .Append(Tabs()).Append("[DataContract]").AppendLine();

            }
            sb
                .Append(Tabs()).Append("public class ").Append(FixName(typeName)).Append(isCollection ? "" : ": INotifyPropertyChanged").AppendLine(); ;
            sb
                .Append(Tabs()).Append("{").AppendLine();

            tabRepeatCount++;
            if (!isCollection)
            {
                sb
                    .Append(Tabs()).Append("public event PropertyChangedEventHandler  PropertyChanged ;").AppendLine()
                    .AppendLine();
                var jvo = (jvalue as JsonObject);
                if (jvo != null)
                {
                    lst.AddRange(jvo
                        .SelectMany
                       (jv => VisitJsonValue(jv.Key, jv.Value, sb, typeName)));
                }
                foreach (var item in lst)
                {
                    DefineObject(item.PropertyName, item.JValue, item.StringBuilder, item.ClassHeader);
                }
            }

            tabRepeatCount--;
            sb
                .Append(Tabs()).Append("}").AppendLine();


        }

        private void DefineProperty(string propertyName, StringBuilder sb, string typeName)
        {
            sb
                .Append(Tabs()).Append(FixName(typeName)).Append(" _").Append(propertyName).AppendLine(";")
                .Append(Tabs()).Append("[DataMember(Name = \"").Append(propertyName).Append("\")]").AppendLine()
                .Append(Tabs()).Append("public ").Append(FixName(typeName)).Append(" ").Append(FixName(propertyName)).AppendLine()
                .Append(Tabs()).Append("{ ").AppendLine()
                .Append(Tabs()).Append("\tget { return").Append(" _").Append(propertyName).Append(";} ").AppendLine()
                .Append(Tabs()).Append("\tset ").AppendLine()
                .Append(Tabs()).Append("\t{ ").AppendLine()
                .Append(Tabs()).Append("\t\t_").Append(propertyName).AppendLine(" = value;")
                .Append(Tabs()).Append("\t\tif ( this.PropertyChanged != null )").AppendLine()
                .Append(Tabs()).Append("\t\t\tthis.PropertyChanged (this,new PropertyChangedEventArgs (\"").Append(FixName(propertyName)).Append("\"));").AppendLine()
                .Append(Tabs()).AppendLine("\t}")
                .Append(Tabs()).Append("}").AppendLine()
                .AppendLine();
        }
        public string FixName(string propertyName)
        {
            if (typedic.Values.Contains(propertyName)) return propertyName;
            var tmp = propertyName.Split(new char[] { '_' })
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
    }
}