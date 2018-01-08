using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Morning_Planning
{
    class SaveProject
    {
        private string _file_path, _Dir_path;
        public SaveProject(string file_name)
        {
            this._file_path = Environment.CurrentDirectory + "\\save\\" + DateTime.Now.ToString("yyyy") +"\\"+file_name;
            this._Dir_path = Path.GetDirectoryName(this._file_path);
            if (!Directory.Exists(_Dir_path))
            {
                Directory.CreateDirectory(_Dir_path);
            }
            if (!File.Exists(_file_path))
            {
                var _file =  File.Create(_file_path);
                _file.Close();
            }
        }
        public SaveProject()
        {

        }
        public void YearProject_Record(string []file_data)
        {
            string _file_name = DateTime.Now.ToString("yyyy") + "\\Year_Project.txt";
            string file_path = Environment.CurrentDirectory + "\\save\\" + _file_name;
            File.WriteAllLines(file_path, file_data); 
        }
        public void Project_Record(string[] file_data)
        {
            File.WriteAllLines(this._file_path, file_data);
        }
        
        public string[] Read_YearProject ()
        {
            string _file_name = DateTime.Now.ToString("yyyy") + "\\Year_Project.txt";
            string file_path = Environment.CurrentDirectory + "\\save\\" + _file_name;
            string [] file_data = File.ReadAllLines(file_path);
            return file_data;
        }
        public string[] Read_Project ()
        {
            string []file_data = File.ReadAllLines(this._file_path);
            return file_data;
        }
    }
}
