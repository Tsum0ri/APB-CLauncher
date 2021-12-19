using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Launcher
{
    public class GameLauncher
    {
        public static string SelectedINI;

        [DebuggerNonUserCode]
        public GameLauncher()
        {
        }

        [DllImport("kernel32", EntryPoint = "GetPrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetPrivateProfileString(
          [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName,
          [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName,
          [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault,
          [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnedString,
          int nSize,
          [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

        [DllImport("kernel32", EntryPoint = "WritePrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int WritePrivateProfileString(
          [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName,
          [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName,
          [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString,
          [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

        [DllImport("kernel32", EntryPoint = "WritePrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int DeletePrivateProfileSection(
          [MarshalAs(UnmanagedType.VBByRefStr)] ref string Section,
          int NoKey,
          int NoSetting,
          [MarshalAs(UnmanagedType.VBByRefStr)] ref string FileName);

        public static void GetINI(string INI)
        {
            GameLauncher.SelectedINI = INI;
        }

        public static string ReadFromINI(string Section, string Key, string Standfile = "", int BufferSize = 1024)
        {
            try
            {
                if (Operators.CompareString(GameLauncher.SelectedINI, "", false) == 0)
                    return (string)null;
                if (!File.Exists(GameLauncher.SelectedINI))
                    return (string)null;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.OkOnly, (object)null);
                ProjectData.ClearProjectError();
            }
            string lpReturnedString = Strings.Space(BufferSize);
            int privateProfileString = GameLauncher.GetPrivateProfileString(ref Section, ref Key, ref Standfile, ref lpReturnedString, BufferSize, ref GameLauncher.SelectedINI);
            return Strings.Left(lpReturnedString, privateProfileString);
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public static void SaveToINI(string Section, string Key, string KeyValue)
        {
            try
            {
                if (File.Exists(GameLauncher.SelectedINI))
                    ;
                short num = checked((short)FileSystem.FreeFile());
                FileSystem.FileOpen((int)num, GameLauncher.SelectedINI, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.LockReadWrite, -1);
                FileSystem.FileClose((int)num);
                if (Operators.CompareString(GameLauncher.SelectedINI, "", false) == 0 || !Directory.Exists(Path.GetDirectoryName(GameLauncher.SelectedINI)))
                    return;
                GameLauncher.WritePrivateProfileString(ref Section, ref Key, ref KeyValue, ref GameLauncher.SelectedINI);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.OkOnly, (object)null);
                ProjectData.ClearProjectError();
            }
        }

        public static void DeleteKey(string Section, string Key)
        {
            try
            {
                if (Operators.CompareString(GameLauncher.SelectedINI, "", false) == 0 || !Directory.Exists(Path.GetDirectoryName(GameLauncher.SelectedINI)))
                    return;
                ref string local1 = ref Section;
                ref string local2 = ref Key;
                string str = (string)null;
                ref string local3 = ref str;
                ref string local4 = ref GameLauncher.SelectedINI;
                GameLauncher.WritePrivateProfileString(ref local1, ref local2, ref local3, ref local4);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.OkOnly, (object)null);
                ProjectData.ClearProjectError();
            }
        }

        public static void DeleteSection(string Section)
        {
            try
            {
                if (Operators.CompareString(GameLauncher.SelectedINI, "", false) == 0)
                {
                    int num = (int)Interaction.MsgBox((object)string.Format("Section Error : Couldnt Delete Section {0} In File '{1}'", (object)Section, (object)GameLauncher.SelectedINI), MsgBoxStyle.Critical, (object)"ERROR");
                }
                else
                {
                    if (!File.Exists(GameLauncher.SelectedINI))
                        return;
                    GameLauncher.DeletePrivateProfileSection(ref Section, 0, 0, ref GameLauncher.SelectedINI);
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.OkOnly, (object)null);
                ProjectData.ClearProjectError();
            }
        }

        public static void CreateBackup(string BackupLocation, bool ShowErrors = false)
        {
            try
            {
                if (Operators.CompareString(GameLauncher.SelectedINI, "", false) == 0)
                {
                    if (ShowErrors)
                        ;
                }
                else if (!Directory.Exists(Path.GetDirectoryName(GameLauncher.SelectedINI)))
                {
                    if (!ShowErrors)
                        return;
                    int num = (int)Interaction.MsgBox((object)string.Format("Create INI Backup Error : Couldnt Find Folder '{0}'", (object)BackupLocation), MsgBoxStyle.Critical, (object)"");
                }
                else
                    File.Copy(GameLauncher.SelectedINI, BackupLocation);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.OkOnly, (object)null);
                ProjectData.ClearProjectError();
            }
        }

        public void DeleteINI(bool ShowErrors = false)
        {
            if (Operators.CompareString(GameLauncher.SelectedINI, "", false) == 0)
            {
                if (!ShowErrors)
                    return;
                int num = (int)Interaction.MsgBox((object)"INI File Could Not Be Deleted.", MsgBoxStyle.Exclamation, (object)"ERROR");
            }
            else
            {
                try
                {
                    if (!File.Exists(GameLauncher.SelectedINI))
                    {
                        if (!ShowErrors)
                            return;
                        int num = (int)Interaction.MsgBox((object)string.Format("Error On DeleteINI , Failed to find '{0}'", (object)GameLauncher.SelectedINI), MsgBoxStyle.Critical, (object)"ERROR");
                    }
                    else
                        File.Delete(GameLauncher.SelectedINI);
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    int num = (int)Interaction.MsgBox((object)ex.Message, MsgBoxStyle.OkOnly, (object)null);
                    ProjectData.ClearProjectError();
                }
            }
        }
    }
}
