using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
namespace Bouwa.Helper.Class
{   
    public class RFVersionInfo
    {
        public static string GetSystemVersion()
        {
            Assembly assembly = null;
            AssemblyName name = new AssemblyName();
            name.Version = new System.Version("0.0.0");

            // Try obtaining assembly version
            string sPath = GetCurrentDirectory() + @"\" + "Bouwa.ITSP2V31.Win.exe";
            try
            {
                if (File.Exists(sPath))
                {
                    assembly = Assembly.LoadFrom(sPath);
                    name = assembly.GetName();
                }
            }
            catch (Exception ex)
            {
               Log.WriterLine(ELevel.error,"��ȡϵͳ�汾" , ex.ToString());
            }
            assembly = null;
            
            return name.Version.Major + "." + name.Version.Minor + "." + name.Version.Build + "." + name.Version.Revision;        
            
        }
        /// <summary>
        /// ��ñ�����·��
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
        }

        /// <summary>
        /// ɾ���ļ�
        /// </summary>
        /// <param name="dir">Ŀ¼·��</param>
        /// <param name="delname">��ɾ���ļ����ļ�������</param>
        public void DeleteFolder(string dir, string delname)
        {
            if (Directory.Exists(dir))
            {
                foreach (string d in Directory.GetFileSystemEntries(dir))
                {
                    string tmpd = d.Substring(0, d.LastIndexOf("\\")) + "\\" + delname;
                    if (Directory.Exists(d))
                    {
                        if (d == tmpd)
                            Directory.Delete(d, true);
                        else
                            DeleteFolder(d, delname);//�ݹ�ɾ�����ļ���   
                    }
                    else if (File.Exists(d))
                    {
                        if (d == tmpd)
                            File.Delete(d);
                    }
                }
            }
        }
 
        public void FindFile(string path,string file)
        {
            //string str=null;
            //    DirectoryInfo dir = new DirectoryInfo(@path); //·��  
            //    foreach(DirectoryInfo dChild in dir.GetFiles(file))//�ļ�
            //    {
                    //str=dChild.Name;
                    //�����GetFiles("*.txt"),��ôȫ��txt�ļ��ᱻ��ʾ
                    //Response.Write(dChild.Name + "<BR>");//��ӡ�ļ���
                    //Response.Write(dChild.FullName + "<BR>");//��ӡ·�����ļ���
                //}

        }

����  }



    
}
