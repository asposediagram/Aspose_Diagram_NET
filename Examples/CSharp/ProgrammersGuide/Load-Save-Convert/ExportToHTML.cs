using System.IO;
using Aspose.Diagram;

namespace Aspose.Diagram.Examples.CSharp.Diagrams
{
    public class ExportToHTML
    {
        public static void Run()
        {
            // ExStart:ExportToHTML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadSaveConvert();
            // load diagram
            Diagram diagram = new Diagram(dataDir + "ExportToHTML.vsd");
            // save diagram
            diagram.Save(dataDir + "outputVSDtoHTML.html", SaveFileFormat.HTML);
            // ExEnd:ExportToHTML
        }
    }
}