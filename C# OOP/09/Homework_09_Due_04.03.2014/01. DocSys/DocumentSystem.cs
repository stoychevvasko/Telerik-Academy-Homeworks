using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public interface IDocument
{
    string Name { get; }
    string Content { get; }
    void LoadProperty(string key, string value);
    void SaveAllProperties(IList<KeyValuePair<string, object>> output);
    string ToString();
}

public interface IEditable
{
    void ChangeContent(string newContent);
}

public interface IEncryptable
{
    bool IsEncrypted { get; }
    void Encrypt();
    void Decrypt();
}

public class DocumentSystemConsole
{
    static DocumentSystem system;
    static void Main()
    {
        system =  new DocumentSystem();
        IList<string> allCommands = ReadAllCommands();
        ExecuteCommands(allCommands);
    }

    private static IList<string> ReadAllCommands()
    {
        List<string> commands = new List<string>();
        while (true)
        {
            string commandLine = Console.ReadLine();
            if (commandLine == String.Empty)
            {
                // End of commands
                break;
            }
            commands.Add(commandLine);
        }
        return commands;
    }

    private static void ExecuteCommands(IList<string> commands)
    {
        foreach (var commandLine in commands)
        {
            int paramsStartIndex = commandLine.IndexOf("[");
            string cmd = commandLine.Substring(0, paramsStartIndex);
            int paramsEndIndex = commandLine.IndexOf("]");
            string parameters = commandLine.Substring(
                paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
            ExecuteCommand(cmd, parameters);
        }
    }

    private static void ExecuteCommand(string cmd, string parameters)
    {        
        string[] cmdAttributes = parameters.Split(
            new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        if (cmd == "AddTextDocument")
        {
            Console.WriteLine(system.AddTextDocument(cmdAttributes));
        }
        else if (cmd == "AddPDFDocument")
        {
            Console.WriteLine(system.AddPdfDocument(cmdAttributes));

        }
        else if (cmd == "AddWordDocument")
        {
            Console.WriteLine(system.AddWordDocument(cmdAttributes));
        }
        else if (cmd == "AddExcelDocument")
        {
            Console.WriteLine(system.AddExcelDocument(cmdAttributes));
        }
        else if (cmd == "AddAudioDocument")
        {
            Console.WriteLine(system.AddAudioDocument(cmdAttributes));
        }
        else if (cmd == "AddVideoDocument")
        {
            Console.WriteLine(system.AddVideoDocument(cmdAttributes));
        }
        else if (cmd == "ListDocuments")
        {
            Console.WriteLine(system.ListDocuments());
        }
        else if (cmd == "EncryptDocument")
        {
            Console.WriteLine(system.EncryptDocument(parameters));
        }
        else if (cmd == "DecryptDocument")
        {
            Console.WriteLine(system.DecryptDocument(parameters));
        }
        else if (cmd == "EncryptAllDocuments")
        {
            Console.WriteLine(system.EncryptAllDocuments());
        }
        else if (cmd == "ChangeContent")
        {
            Console.WriteLine(system.ChangeContent(cmdAttributes[0], cmdAttributes[1]));
        }
        else
        {
            throw new InvalidOperationException("Invalid command: " + cmd);
        }
    }
}


public class DocumentSystem
{
    #region fields

    private IList<IDocument> documents;

    #endregion

    #region constructors

    public DocumentSystem()
    {
        this.documents = new List<IDocument>();
    }

    #endregion

    #region methods

    private KeyValuePair<string, string> ParseAttribute(string attribute)
    {
        var keyValue = new KeyValuePair<string, string>();
        var parts = attribute.Split('=');
        return new KeyValuePair<string, string>(parts[0], parts[1]);
    }

    private string AddDocument(IDocument document, string[] attributes)
    {
        foreach (var attribute in attributes)
        {
            var keyValue = this.ParseAttribute(attribute);
            document.LoadProperty(keyValue.Key, keyValue.Value);
        }

        this.documents.Add(document);

        if (document.Name == null)
        {
            return "Document has no name";
        }
        else
        {
            return string.Format("Document added: {0}", document.Name);
        }
    }

    public string AddTextDocument(string[] attributes)
    {
        var document = new TextDocument();
        return this.AddDocument(document, attributes);
    }

    public string AddPdfDocument(string[] attributes)
    {
        var document = new PDFDocument();
        return this.AddDocument(document, attributes);
    }

    public string AddWordDocument(string[] attributes)
    {
        var document = new WordDocument();
        return this.AddDocument(document, attributes);
    }

    public string AddExcelDocument(string[] attributes)
    {
        var document = new ExcelDocument();
        return this.AddDocument(document, attributes);
    }

    public string AddAudioDocument(string[] attributes)
    {
        var document = new AudioDocument();
        return this.AddDocument(document, attributes);
    }

    public string AddVideoDocument(string[] attributes)
    {
        var document = new VideoDocument();
        return this.AddDocument(document, attributes);
    }

    public string ListDocuments()
    {
        var sb = new StringBuilder();

        foreach (var doc in this.documents)
        {
            sb.AppendLine(doc.ToString());
        }

        if (sb.Length == 0)
        {
            return "No document found";
        }

        return sb.ToString().Trim();
    }

    public string EncryptDocument(string name)
    {
        var sb = new StringBuilder();

        foreach (var document in this.documents)
        {
            if (document.Name == name)
            {
                if (document is EncryptableDocument)
                {
                    (document as EncryptableDocument).Encrypt();

                    sb.AppendLine(string.Format("Document encrypted: {0}", document.Name));
                }
                else
                {
                    sb.AppendLine(string.Format("Document does not support encryption: {0}", document.Name));
                }
            }
        }

        if (sb.Length == 0)
        {
            sb.AppendLine(string.Format("Document not found: {0}", name));
        }

        return sb.ToString().Trim();
    }

    public string DecryptDocument(string name)
    {
        var sb = new StringBuilder();

        foreach (var document in this.documents)
        {
            if (document.Name == name)
            {
                if (document is EncryptableDocument)
                {
                    (document as EncryptableDocument).Decrypt();

                    sb.AppendLine(string.Format("Document decrypted: {0}", document.Name));
                }
                else
                {
                    sb.AppendLine(string.Format("Document does not support decryption: {0}", document.Name));
                }
            }
        }

        if (sb.Length == 0)
        {
            sb.AppendLine(string.Format("Document not found: {0}", name));
        }

        return sb.ToString().Trim();
    }

    public string EncryptAllDocuments()
    {

        bool atLeastOneDocumentEncrypted = false;


        foreach (var document in this.documents)
        {
            if (document is EncryptableDocument)
            {
                (document as EncryptableDocument).Encrypt();
                atLeastOneDocumentEncrypted = true; ;


            }
        }

        if (atLeastOneDocumentEncrypted)
        {
            return "All documents encrypted";
        }
        else
        {
            return "No encryptable documents found";
        }
    }

    public string ChangeContent(string name, string content)
    {
        var sb = new StringBuilder();

        foreach (var document in this.documents)
        {
            if (document.Name == name)
            {
                if (document is IEditable)
                {
                    (document as IEditable).ChangeContent(content);

                    sb.AppendLine(string.Format("Document content changed: {0}", document.Name));
                }
                else
                {
                    sb.AppendLine(string.Format("Document is not editable: {0}", document.Name));
                }
            }
        }

        if (sb.Length == 0)
        {
            sb.AppendLine(string.Format("Document not found: {0}", name));
        }

        return sb.ToString().Trim();
    }

    #endregion
}

public abstract class Document
    : IDocument
{
    #region fields

    protected readonly Dictionary<string, object> properties;

    #endregion

    #region properties

    public string Name
    {
        get 
        {
            return this.GetProperty("Name") as string; 
        }

        protected set { this.LoadProperty("Name", value.ToString()); }
    }

    public string Content
    {
        get { return this.GetProperty("Content").ToString(); }
        protected set { this.LoadProperty("Content", value.ToString()); }
    }

    #endregion

    #region constructors

    public Document()
    {
        this.properties = new Dictionary<string, object>();
    }

    #endregion

    #region IDocument implementation
    public void LoadProperty(string key, string value)
    {
        string loweredKey = key.ToLower();

        if (this.properties.ContainsKey(loweredKey))
        {
            this.properties[loweredKey] = value;
        }
        else
        {
            this.properties.Add(loweredKey, value);
        }
    }

    public void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output = this.properties.ToList();
        output = output.OrderBy(x => x.Key).ToList();
    }

    protected object GetProperty(string key)
    {
        string loweredKey = key.ToLower();

        if (this.properties.ContainsKey(loweredKey))
        {
            return properties[loweredKey];
        }
        else
        {
            return null;
        }
    }

    #endregion

    #region overrides

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(this.GetType().Name);
        sb.Append('[');

        var list = this.properties.ToList();
        list = list.OrderBy(x => x.Key).ToList();

        foreach (var item in list)
        {
            if (item.Value != null)
            {
                sb.AppendFormat("{0}={1};", item.Key.ToLower(), item.Value);
            }
        }

        string result = sb.ToString().Trim(';') + ']';
        return result;
    }

    #endregion
}

public abstract class BinaryDocument
    : Document
{
    #region properties

    public ulong Size
    {
        get { return this.GetProperty("Size").ToULong(); }
        set { this.LoadProperty("Size", value.ToString()); }
    }

    #endregion
}

public class TextDocument
    : Document, IEditable
{
    #region properties

    public string Charset
    {
        get { return this.GetProperty("chars").ToString(); }
        set { this.LoadProperty("chars", value.ToString()); }
    }

    #endregion

    #region IEditable implementation
    public void ChangeContent(string newContent)
    {
        this.Content = newContent;
    }

    #endregion
}

public class PDFDocument
    : EncryptableDocument
{
    #region properties

    public uint NumberOfPages
    {
        get { return this.GetProperty("pages").ToUInteger(); }
        set { this.LoadProperty("pages", value.ToString()); }
    }
    #endregion
}

public abstract class OfficeDocument
    : EncryptableDocument
{
    #region properties

    public string Version
    {
        get { return this.GetProperty("Version").ToString(); }
        set { this.LoadProperty("Version", value.ToString()); }
    }
    #endregion
}

public class WordDocument
    : OfficeDocument, IEditable
{
    #region properties

    public ulong NumberOfCharacters
    {
        get { return this.GetProperty("chars").ToULong(); }
        set { this.LoadProperty("chars", value.ToString()); }
    }
    #endregion


    #region IEditable implementation

    public void ChangeContent(string newContent)
    {
        this.Content = newContent;
    }

    #endregion
}

public class ExcelDocument
    : OfficeDocument
{
    #region properties

    public ulong NumberOfRows
    {
        get { return this.GetProperty("rows").ToULong(); }
        set { this.LoadProperty("rows", value.ToString()); }
    }
    public ulong NumberOfColumns
    {
        get { return this.GetProperty("cols").ToULong(); }
        set { this.LoadProperty("cols", value.ToString()); }
    }
    #endregion
}

public abstract class MultimediaDocument
    : BinaryDocument
{
    #region properties

    public ulong Length
    {
        get { return this.GetProperty("Length").ToULong(); }
        set { this.LoadProperty("Length", value.ToString()); }
    }

    #endregion
}

public class AudioDocument
    : MultimediaDocument
{
    #region properties

    public uint SampleRate
    {
        get { return this.GetProperty("SampleRate").ToUInteger(); }
        set { this.LoadProperty("SampleRate", value.ToString()); }
    }

    #endregion

    #region constructors



    #endregion
}

public class VideoDocument
    : MultimediaDocument
{
    #region properties

    public uint FrameRate
    {
        get { return this.GetProperty("framerate").ToUInteger(); }
        set { this.LoadProperty("framerate", value.ToString()); }
    }

    #endregion
}

public abstract class EncryptableDocument
    : BinaryDocument, IEncryptable
{
    #region fields

    private bool isEncrypted = false;

    #endregion

    #region properties

    public bool IsEncrypted
    {
        get { return this.isEncrypted; }
    }

    #endregion

    #region IEncryptable implementation

    public void Encrypt()
    {
        this.isEncrypted = true;
    }

    public void Decrypt()
    {
        this.isEncrypted = false;
    }

    #endregion

    #region overrides

    public override string ToString()
    {
        if (this.isEncrypted)
        {
            return string.Format("{0}[encrypted]", this.GetType().Name);
        }
        else
        {
            return base.ToString();
        }
    }

    #endregion
}

public static class ExtensionMethods
{
    public static uint ToUInteger(this object obj)
    {
        uint result = 0;
        uint.TryParse(obj.ToString(), out result);
        return result;
    }

    public static ulong ToULong(this object obj)
    {
        ulong result = 0;
        ulong.TryParse(obj.ToString(), out result);
        return result;
    }
}