using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace Config_Save
{
    
    public class SystemConfig
    {
        private static readonly Lazy<SystemConfig> instance =
            new Lazy<SystemConfig>(() => new SystemConfig());

        public static SystemConfig Instance => instance.Value;

        public const string STR_csvPath = "csvPath";
        public const string STR_pythonExe = "pythonExe";
        public const string STR_pythonScript = "pythonScript";
        public const string STR_saveLocation = "saveLocation";
        public const string STR_db = "DB";

        public const string STR_ip = "ip";
        public const string STR_port = "port";
        public const string STR_id = "id";
        public const string STR_pw = "pw";
        public const string STR_database = "database";
        public const string STR_table = "table";

        private const string FILENAME = "config.json";

        private string csvPath;
        private string pythonExe;
        private string pythonScript;
        private string saveLocation;
        private string ip;
        private string port;
        private string id;
        private string pw;
        private string database;
        private string table;
       
        public string CsvPath { get => csvPath; set => csvPath = value; }
        public string PythonExe { get => pythonExe; set => pythonExe = value; }
        public string PythonScript { get => pythonScript; set => pythonScript = value; }
        public string SaveLocation { get => saveLocation; set => saveLocation = value; }
        public string Ip { get => ip; set => ip = value; }
        public string Port { get => port; set => port = value; }
        public string Id { get => id; set => id = value; }
        public string Pw { get => pw; set => pw = value; }
        public string Database { get => database; set => database = value; }
        public string Table { get => table; set => table = value; }

        string filePath;

        private SystemConfig()
        {
            // relative path
            var dllPath = new Uri(typeof(SystemConfig).Assembly.CodeBase).LocalPath; //경로가져옴
            var dllDir = Path.GetDirectoryName(dllPath); //디렉토리까지가져옴
            DirectoryInfo di = new DirectoryInfo(dllDir);

            if (!di.Exists)
                di.Create();

            filePath = di.FullName + @"\" + FILENAME;

            FileInfo fileInfo = new FileInfo(filePath); //파일경로등록

            if (!fileInfo.Exists)
            {
                fileInfo.Create();
                return;
            }

            Load();
        }

        public void Load()
        {
            try
            {
                string json = File.ReadAllText(filePath); //json string으로 읽어오기
                JToken jToken = JToken.Parse(json); //jToken변환
                FromJson(jToken); 
            }catch(Exception e)
            {
                return;
            }
        }
        public void Save()
        {
            JToken jToken = ToJson();

            File.WriteAllText(filePath, jToken.ToString());
            File.WriteAllText(saveLocation + @"\" + FILENAME, jToken.ToString());          
        }

        public void FromJson(JToken jToken)
        {
            JObject json = jToken as JObject;
            csvPath = json[STR_csvPath].ToString();
            pythonExe = json[STR_pythonExe].ToString();
            pythonScript = json[STR_pythonScript].ToString();
            saveLocation = json[STR_saveLocation].ToString();
            
            JToken dbJsonToken = json[STR_db];
            JObject dbJson = (JObject)dbJsonToken;


            ip = dbJson[STR_ip].ToString();
            port = dbJson[STR_port].ToString();
            id = dbJson[STR_id].ToString();
            pw = dbJson[STR_pw].ToString();
            database = dbJson[STR_database].ToString();
            table = dbJson[STR_table].ToString();
        }

        public JToken ToJson()
        {
            JObject jDb = new JObject();
            jDb.Add(STR_ip, ip);
            jDb.Add(STR_port, port);
            jDb.Add(STR_id, id);
            jDb.Add(STR_pw, pw);
            jDb.Add(STR_database, database);
            jDb.Add(STR_table, table);

            JObject jObject = new JObject();
            jObject.Add(STR_csvPath, csvPath);
            jObject.Add(STR_pythonExe, pythonExe);
            jObject.Add(STR_pythonScript, pythonScript);
            jObject.Add(STR_saveLocation, saveLocation);
            jObject.Add(STR_db, jDb);
            return jObject;
        }




    }
}
