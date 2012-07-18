using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Media.Imaging;

namespace SDN.Programs.App_Code
{
    class ProgramInfo
    {
        private DataSet settings = new DataSet();
        
        public string StartStoreLocation
        {
            get { return settings.Tables["StartStoreLocation"].Rows[0]["StartLocation"].ToString(); }
            
            set { settings.Tables["StartStoreLocation"].Rows[0]["StartLocation"] = value; }
        }

        public string LookInFolder
        {
            get { return settings.Tables["LookAtFolder"].Rows[0]["LookAtLocation"].ToString(); }

            set { settings.Tables["LookAtFolder"].Rows[0]["LookAtLocation"] = value; }
        }

        public DataTable MoveToFolders
        {
            get { return settings.Tables["MoveToLocation"]; }
        }

        public ProgramInfo()
        {

            if (!File.Exists(Directory.GetCurrentDirectory() + "\\ProgramSettings.xml"))
            {
                CreateLookAtFoler();

                CreateMoveToLovation();

                CreateStartStoreLocation();

                SaveData(settings);

            }
            else
            {
                settings.ReadXml(Directory.GetCurrentDirectory() + "\\ProgramSettings.xml");

                if (!settings.Tables.Contains("StartStoreLocation"))
                    CreateStartStoreLocation();
                if (!settings.Tables.Contains("MoveToLocation"))
                    CreateMoveToLovation();
                if (!settings.Tables.Contains("LookAtFolder"))
                    CreateLookAtFoler();


            }
        }

        private void CreateStartStoreLocation()
        {
            DataTable dt;
            DataColumn dc;
            DataRow dr;

            dt = settings.Tables.Add("StartStoreLocation");
            dc = new DataColumn();
            dc.ColumnName = "StartLocation";
            dt.Columns.Add(dc);
            dr = dt.NewRow();
            dr["StartLocation"] = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            dt.Rows.Add(dr);

        }

        private void CreateMoveToLovation()
        {
            DataTable dt;
            DataColumn dc;
            DataRow dr;

            dt = settings.Tables.Add("MoveToLocation");
            dc = new DataColumn();
            dc.ColumnName = "LookAtLocation";
            dt.Columns.Add(dc);
            dr = dt.NewRow();
            dr["LookAtLocation"] = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            dt.Rows.Add(dr);

        }
       
        private void CreateLookAtFoler()
        {
            DataTable dt;
            DataColumn dc;
            DataRow dr;

            dt = settings.Tables.Add("LookAtFolder");
            dc = new DataColumn();
            dc.ColumnName = "LookAtLocation";
            dt.Columns.Add(dc);
            dr = dt.NewRow();
            dr["LookAtLocation"] = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            dt.Rows.Add(dr);

        }

        public void SaveData()
        {
            settings.WriteXml(Directory.GetCurrentDirectory() + "\\ProgramSettings.xml");
        }

        public void SaveData(DataSet ds)
        {
            ds.WriteXml(Directory.GetCurrentDirectory() + "\\ProgramSettings.xml");
        }

        public DataSet GetData()
        {
            settings.ReadXml(Directory.GetCurrentDirectory() + "\\ProgramSettings.xml");

            return settings;
        }

        public void AddMoveToFolders(string folder)
        {   
            DataRow dr;

            dr = settings.Tables["MoveToLocation"].NewRow();
            dr["LookAtLocation"] = folder;
            settings.Tables["MoveToLocation"].Rows.Add(dr);

        }

        public void DeleteMoveToFolders(string folder)
        {

            foreach (DataRow dr in settings.Tables["MoveToLocation"].Rows)
            {
                if (dr["LookAtLocation"].ToString().IndexOf(folder) >= 0)
                {
                    settings.Tables["MoveToLocation"].Rows.Remove(dr);
                    break;
                }

            }
            
            

        }




    }
}
