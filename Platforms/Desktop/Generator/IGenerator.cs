using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.Generator {
    interface IGenerator {
        string[] Imports {
            get;
        }

        string FileName {
            get;
        }

        string Namespace {
            get;
        }

        void Generate(XmlDocument document, StringBuilder code, List<string> errors);
    }
}
