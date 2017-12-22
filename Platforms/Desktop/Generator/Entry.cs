using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.Generator {
    static class Entry {
        static readonly IGenerator[] Generators = {
            new EnumGenerator(),
            new InterfaceGenerator(),
            new ImplementationGenerator()
        };

        static void Main(string[] args) {
            XmlDocument doc = new XmlDocument();
            using (HttpClient client = new HttpClient()) {
                Task<Stream> t = client.GetStreamAsync("https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml");
                t.Wait();
                using (t.Result) {
                    doc.Load(t.Result);
                }
            }
            List<string> errors = new List<string>();
            foreach (IGrouping<string, IGenerator> file in Generators.GroupBy(g => g.FileName)) {
                StringBuilder code = new StringBuilder();
                foreach (string import in file.SelectMany(g => g.Imports).GroupBy(o => o).Select(g => g.Key).OrderBy(o => o)) {
                    code.AppendFormat("using {0};", import);
                    code.AppendLine();
                }
                code.AppendLine();
                foreach (IGrouping<string, IGenerator> @namespace in file.GroupBy(g => g.Namespace)) {
                    code.AppendFormat("namespace {0} {1}", @namespace.Key, '{');
                    code.AppendLine();
                    foreach (IGenerator generator in @namespace) {
                        generator.Generate(doc, code, errors);
                    }
                    if (code[code.Length - 1] == '\n') {
                        code.Remove(code.Length - 1, 1);
                    }
                    code.AppendLine("}");
                }
                Directory.CreateDirectory(Path.GetDirectoryName(file.Key));
                File.WriteAllText(file.Key, code.ToString());
            }
            foreach (string error in errors) {
                Console.Error.WriteLine(error);
            }
        }
    }
}
